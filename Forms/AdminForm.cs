using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GymAppSQL
{
    public partial class AdminForm : Form
    {
        private string loggedInUser;
        private DB db = new DB();
        public AdminForm(string loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            CreateColumns();
            RefreshDataGrid(dataGridViewMain);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }

        private void lblCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm(loggedInUser);
            mainForm.ShowDialog();
        }

        private void btnTruncateTable_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити всі записи, окрім користувачів з групами 0 і 1?", "Попередження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DeleteRecords();
            }
        }

        private void DeleteRecords()
        {
            try
            {
                using (var db = new DB())
                {
                    db.openConnection();

                    string deleteQuery = "DELETE FROM `users` WHERE `group` NOT IN (0, 1)";
                    MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, db.getConnection());
                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    MessageBox.Show($"Успішно видалено {rowsAffected} записів, крім користувачів із групами 0 і 1.");

                    string alterQuery = "ALTER TABLE users AUTO_INCREMENT = 3";
                    MySqlCommand alterCommand = new MySqlCommand(alterQuery, db.getConnection());
                    alterCommand.ExecuteNonQuery();

                    db.closeConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час видалення записів: {ex.Message}");
            }
        }

        private void CreateColumns()
        {
            dataGridViewMain.Columns.AddRange(
                new DataGridViewTextBoxColumn { Name = "id", HeaderText = "ID" },
                new DataGridViewTextBoxColumn { Name = "log", HeaderText = "Логін" },
                new DataGridViewTextBoxColumn { Name = "pass", HeaderText = "Пароль" },
                new DataGridViewTextBoxColumn { Name = "name", HeaderText = "Ім'я" },
                new DataGridViewTextBoxColumn { Name = "surname", HeaderText = "Прізвище" },
                new DataGridViewTextBoxColumn { Name = "group", HeaderText = "Група" },
                new DataGridViewTextBoxColumn { Name = "subscription_end_date", HeaderText = "Дата закінчення підписки" },
                new DataGridViewTextBoxColumn { Name = "row_state", HeaderText = "Стан рядка", Visible = false } // Скрытый столбец для состояния строки
            );
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            try
            {
                db.openConnection();

                string queryString = "SELECT id, log, pass, name, surname, `group`, IFNULL(subscription_end_date, 'Нет подписки') AS subscription_end_date FROM users";
                MySqlCommand command = new MySqlCommand(queryString, db.getConnection());
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string subscriptionEndDate = reader.GetString("subscription_end_date");
                        if (subscriptionEndDate == "Немає підписки")
                        {
                            subscriptionEndDate = string.Empty; // Перетворення «Немає підписки» на порожній рядок
                        }

                        dgw.Rows.Add(
                            reader.GetInt32("id"),
                            reader.GetString("log"),
                            reader.GetString("pass"),
                            reader.GetString("name"),
                            reader.GetString("surname"),
                            reader.GetInt32("group"), // Група зчитується як ціле число
                            subscriptionEndDate,
                            DBNull.Value // Не встановлюємо початковий стан рядка
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час завантаження користувачів: {ex.Message}");
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMain.Rows[e.RowIndex];

                textBox_Id.Text = row.Cells[0].Value.ToString();
                textBox_Login.Text = row.Cells[1].Value.ToString();
                textBox_Password.Text = row.Cells[2].Value.ToString();
                textBox_Name.Text = row.Cells[3].Value.ToString();
                textBox_SurName.Text = row.Cells[4].Value.ToString();
                textBox_Group.Text = row.Cells[5].Value.ToString();
                textBox_EndDataTime.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewMain);
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void deleteRow()
        {
            int index = dataGridViewMain.CurrentCell.RowIndex;

            dataGridViewMain.Rows[index].Visible = false;
            if (dataGridViewMain.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridViewMain.Rows[index].Cells[5].Value = DBNull.Value; // Скидаємо значення групи до DBNull
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridViewMain.CurrentCell.RowIndex;

            var id = textBox_Id.Text;
            var login = textBox_Login.Text;
            var password = textBox_Password.Text;
            var name = textBox_Name.Text;
            var surName = textBox_SurName.Text;
            var endData = textBox_EndDataTime.Text;
            var group = textBox_Group.Text; // Приймаємо групу як рядок

            dataGridViewMain.Rows[selectedRowIndex].SetValues(id, login, password, name, surName, group, endData);
        }

        private void ClearFields()
        {
            textBox_Id.Text = "";
            textBox_Login.Text = "";
            textBox_Password.Text = "";
            textBox_Name.Text = "";
            textBox_SurName.Text = "";
            textBox_Group.Text = "";
            textBox_EndDataTime.Text = "";
        }

        private void UpdateData()
        {
            db.openConnection();

            for (int index = 0; index < dataGridViewMain.Rows.Count; index++)
            {
                var id = dataGridViewMain.Rows[index].Cells[0].Value.ToString();
                var login = dataGridViewMain.Rows[index].Cells[1].Value.ToString();
                var password = dataGridViewMain.Rows[index].Cells[2].Value.ToString();
                var name = dataGridViewMain.Rows[index].Cells[3].Value.ToString();
                var surName = dataGridViewMain.Rows[index].Cells[4].Value.ToString();
                var group = dataGridViewMain.Rows[index].Cells[5].Value.ToString();
                var EndData = dataGridViewMain.Rows[index].Cells[6].Value.ToString();

                // Перевірка, чи є EndData рядком «Немає підписки» EndData
                if (EndData == "Нет подписки")
                {
                    EndData = null; // Встановлення EndData в NULL для зазначення відсутності дати закінчення підписки
                }

                var changeQuery = $"UPDATE users SET log = @login, pass = @password, name = @name, surname = @surName, `group` = @group, subscription_end_date = @EndData WHERE id = @id";

                var command = new MySqlCommand(changeQuery, db.getConnection());
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@surName", surName);
                command.Parameters.AddWithValue("@group", group);
                command.Parameters.AddWithValue("@EndData", EndData);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }

            db.closeConnection();
        }





        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridViewMain);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            try
            {
                db.openConnection();

                string searchString = $"SELECT id, log, pass, name, surname, `group`, IFNULL(subscription_end_date, 'Нет подписки') AS subscription_end_date FROM users WHERE CONCAT(id, log, pass, name, surname, `group`, IFNULL(subscription_end_date, 'Нет подписки')) LIKE '%{textBox_search.Text}%'";
                MySqlCommand command = new MySqlCommand(searchString, db.getConnection());
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgw.Rows.Add(
                            reader.GetInt32("id"),
                            reader.GetString("log"),
                            reader.GetString("pass"),
                            reader.GetString("name"),
                            reader.GetString("surname"),
                            reader.GetInt32("group").ToString(), // Перетворіть значення group у рядок перед додаванням у DataGridView
                            reader.GetString("subscription_end_date")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении поиска: {ex.Message}");
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void lblCloseApp_MouseEnter(object sender, EventArgs e)
        {
            lblCloseApp.ForeColor = Color.Red;
        }

        private void lblCloseApp_MouseLeave(object sender, EventArgs e)
        {
            lblCloseApp.ForeColor = Color.White;
        }
        Point lastPoint;


        private void pnlHeaderAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pnlHeaderAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void lblHeader_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void lblHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        
    }
}
