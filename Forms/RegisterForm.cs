using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAppSQL
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Введіть ім'я";
            userNameField.ForeColor = Color.Gray;

            userSurnameField.Text = "Введіть прізвище";
            userSurnameField.ForeColor = Color.Gray;

            loginField.Text = "Введіть логін";
            loginField.ForeColor = Color.Gray;

            passField.Text = "******";
            passField.ForeColor = Color.Gray;

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 33);
        }

        private void lblCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lblCloseApp_MouseEnter_1(object sender, EventArgs e)
        {
            lblCloseApp.ForeColor = Color.Red;
        }

        private void lblCloseApp_MouseLeave_1(object sender, EventArgs e)
        {
            lblCloseApp.ForeColor = Color.White;
        }

        Point lastPoint;

        private void pnlMainRegister_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }
        private void pnlMainRegister_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введіть ім'я")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }
        
        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введіть ім'я";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введіть прізвище")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введіть прізвище";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введіть логін")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введіть логін";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "******")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "******";
                passField.ForeColor = Color.Gray;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введіть ім'я") 
            {
                MessageBox.Show("Введіть ім'я");
                return;
            }
            if (userSurnameField.Text == "Введіть прізвище")
            {
                MessageBox.Show("Введіть прізвище");
                return;
            }
            if(loginField.Text == "Введіть логін" || loginField.Text.Length < 3)
            {
                MessageBox.Show("Логін повинен бути не менше 3 символів");
                return;
            }
            if (passField.Text == "******" || passField.Text.Length < 4)
            {
                MessageBox.Show("Пароль повинен бути не менше 4 символів");
                return;
            }
            if (isUserExists())
            {
                return;
            }
            

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`log`, `pass`, `name`, `surname`, `group`) VALUES (@uL, @uP, @uName, @uSurName, 3);", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@uName", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@uSurname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Акаунт було створено");
            else
                MessageBox.Show("Акаунт не був створений");

            db.closeConnection();
            
        }
        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `log` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такий логін уже є, введіть інший.");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void lblLogin_MouseEnter(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.Aquamarine;
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.White;
        }
    }
}
