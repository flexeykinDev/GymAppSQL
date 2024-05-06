using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GymAppSQL
{
    public partial class MainForm : Form
    {
        private string loggedInUser;

        public MainForm(string loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            MessageBox.Show("Вітаємо, " + loggedInUser + "!");
            LoadUserData(loggedInUser);
        }

        private void LoadUserData(string loggedInUser)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `name`, `surname`, `group`, `subscription_end_date` FROM `users` WHERE `log` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loggedInUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string groupName = "";
                int group = Convert.ToInt32(table.Rows[0]["group"]);

                switch (group)
                {
                    case 0:
                        lblGroup.ForeColor = Color.Red;
                        groupName = "Root";
                        btnBuyVip.Hide();
                        break;
                    case 1:
                        lblGroup.ForeColor = Color.Red;
                        groupName = "Адміністратор";
                        btnBuyVip.Hide();
                        break;
                    case 2:
                        lblGroup.ForeColor = Color.Gold;
                        groupName = "VIP";
                        btnAdmin.Hide();
                        btnBuyVip.Hide();
                        break;
                    case 3:
                        lblGroup.ForeColor = Color.White;
                        groupName = "Звичайний користувач";
                        btnAdmin.Hide();
                        break;
                    default:
                        lblGroup.ForeColor = Color.Black;
                        groupName = "Невідомо";
                        btnAdmin.Hide();
                        break;
                }

                lblName.Text = "Ім'я: " + table.Rows[0]["name"].ToString();
                lblSurName.Text = "Прізвище: " + table.Rows[0]["surname"].ToString();
                lblGroup.Text = "Група: " + groupName;

                if (table.Rows[0]["subscription_end_date"] != DBNull.Value)
                {
                    DateTime subscriptionEndDate = Convert.ToDateTime(table.Rows[0]["subscription_end_date"]);
                    TimeSpan remainingTime = subscriptionEndDate - DateTime.Now;
                    int remainingDays = (int)Math.Floor(remainingTime.TotalDays);

                    if (remainingDays > 21)
                    {
                        lblSubscription.ForeColor = Color.Green;
                        lblSubscription.Text = $"Залишилося {remainingDays} днів підписки";
                    }
                    else if (remainingDays > 10)
                    {
                        lblSubscription.ForeColor = Color.Yellow;
                        lblSubscription.Text = $"Залишилося {remainingDays} днів підписки";
                    }
                    else if (remainingDays > 3)
                    {
                        lblSubscription.ForeColor = Color.LightCoral;
                        lblSubscription.Text = $"Залишилося {remainingDays} дні підписки";
                    }
                    else if (remainingDays > 1)
                    {
                        lblSubscription.ForeColor = Color.Red;
                        lblSubscription.Text = $"Залишився {remainingDays} день підписки";
                        btnExpiredSubscription.Show();
                    }
                    else
                    {
                        lblSubscription.ForeColor = Color.Red;
                        lblSubscription.Text = "Закінчився абонемент! Подовжте підписку";
                        btnExpiredSubscription.Show();
                    }
                }
                else
                {
                    lblSubscription.ForeColor = Color.Red;
                    lblSubscription.Text = "Інформація про підписку недоступна";
                    btnExpiredSubscription.Show();
                }

            }
        }

        private void lblCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void lblMain_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void lblMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm(loggedInUser);
            adminForm.Show();
        }

        private void btnExpiredSubscription_Click(object sender, EventArgs e)
        {
            bool isVIP = CheckVIPStatus(loggedInUser);
            BuyDialog buyDialog = new BuyDialog(loggedInUser, isVIP);
            buyDialog.SubscriptionUpdated += BuyDialog_SubscriptionUpdated;
            buyDialog.Show();
        }

        private bool CheckVIPStatus(string loggedInUser)
        {
            bool isVIP = false;

            // Виконуємо запит до бази даних, щоб отримати інформацію про групу користувача
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `group` FROM `users` WHERE `log` = @uL", db.getConnection());
            command.Parameters.AddWithValue("@uL", loggedInUser);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                int group = Convert.ToInt32(table.Rows[0]["group"]);
                // Перевіряємо, чи є група користувача VIP (група 2)
                isVIP = (group == 2);
            }

            return isVIP;
        }
    

        private void BuyDialog_SubscriptionUpdated(object sender, EventArgs e)
        {
            LoadUserData(loggedInUser);
        }

        private void btnBuyVip_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете придбати ВІП абонемент?", "Купівля ВІП", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UpdateUserGroup(loggedInUser, 2);
            }
        }

        private void UpdateUserGroup(string loggedInUser, int newGroup)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `group` = @newGroup WHERE `log` = @loggedInUser", db.getConnection());
            command.Parameters.AddWithValue("@newGroup", newGroup);
            command.Parameters.AddWithValue("@loggedInUser", loggedInUser);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Групу користувача успішно оновлено.");
                LoadUserData(loggedInUser);
            }
            else
            {
                MessageBox.Show("Помилка під час оновлення групи користувача.");
            }

            db.closeConnection();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loggedInUser))
            {
                this.Close();
                ChangePass changePass = new ChangePass(loggedInUser);
                changePass.Show();
            }
            else
            {
                MessageBox.Show("Помилка: не вдалося отримати ім'я користувача.");
            }
        }
    }
}