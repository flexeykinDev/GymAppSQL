using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymAppSQL
{
    public partial class ChangePass : Form
    {
        private string loggedInUser;
        private DB db;
        private bool showPasswords = false;

        public ChangePass(string loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            db = new DB();


        }
        
        private void PictureBoxEye_Click(object sender, EventArgs e)
        {

            // Інвертуємо значення змінної showPasswords при кожному кліці
            showPasswords = !showPasswords;

            // Встановлюємо символ відображення пароля залежно від значення showPasswords
            oldPass.PasswordChar = showPasswords ? '\0' : '•';
            newPass.PasswordChar = showPasswords ? '\0' : '•';
            confirmNewPass.PasswordChar = showPasswords ? '\0' : '•';

            // Встановлюємо зображення для PictureBox залежно від значення showPasswords
            pictureBoxEye.Image = showPasswords ? Properties.Resources.openEyeImage : Properties.Resources.closedEyeImage;
        }

        private void lblCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm(loggedInUser);
            mainForm.ShowDialog();
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

        private void pnlMainLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pnlMainLogin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPass.Text;
            string newPassword = newPass.Text;
            string confirmPassword = confirmNewPass.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Новий пароль і підтвердження пароля не збігаються.");
                return;
            }

            if (newPassword.Length < 4)
            {
                MessageBox.Show("Новий пароль має містити щонайменше 4 символи.");
                return;
            }

            if (!CheckOldPassword(oldPassword))
            {
                MessageBox.Show("Старий пароль введений неправильно.");
                return;
            }

            if (UpdatePassword(newPassword))
            {
                MessageBox.Show("Пароль успішно змінений.");
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Помилка під час зміни пароля.");
            }
        }

        private bool CheckOldPassword(string oldPassword)
        {
            try
            {
                db.openConnection();
                string query = "SELECT COUNT(*) FROM users WHERE log = @loggedInUser AND pass = @oldPassword";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                command.Parameters.AddWithValue("@loggedInUser", loggedInUser);
                command.Parameters.AddWithValue("@oldPassword", oldPassword);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час перевірки старого пароля: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
            return false;
        }

        private bool UpdatePassword(string newPassword)
        {
            try
            {
                db.openConnection();
                string query = "UPDATE users SET pass = @newPassword WHERE log = @loggedInUser";
                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                command.Parameters.AddWithValue("@newPassword", newPassword);
                command.Parameters.AddWithValue("@loggedInUser", loggedInUser);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час оновлення пароля: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
            return false;
        }

        private void newPass_Enter(object sender, EventArgs e)
        {
            if(newPass.Text != null)
            {
                confirmNewPass.Show();
                lblConfirmHint.Show();
            }
            else
            {
                confirmNewPass.Hide();
                lblConfirmHint.Hide();
            }
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            // Встановлюємо символ відображення пароля залежно від значення showPasswords
            oldPass.PasswordChar = showPasswords ? '\0' : '•';
            newPass.PasswordChar = showPasswords ? '\0' : '•';
            confirmNewPass.PasswordChar = showPasswords ? '\0' : '•';

            // Встановлюємо зображення для PictureBox залежно від значення showPasswords 
            pictureBoxEye.Image = showPasswords ? Properties.Resources.openEyeImage : Properties.Resources.closedEyeImage;
        }
    }
}

