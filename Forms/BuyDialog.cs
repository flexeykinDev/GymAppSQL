using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GymAppSQL
{
    public partial class BuyDialog : Form
    {
        private string loggedInUser;
        private bool isVIP;


        public BuyDialog(string loggedInUser, bool isVIP)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            this.isVIP = isVIP;
            if (isVIP)
            {
                lblTipInfo.Text = "Вітаємо! Ви вже володієте статусом ВІП \nтому вам надаються знижки на підписки до 50%.";
                lblTipInfo.ForeColor = Color.Gold;
            }
            else
            {
                lblTipInfo.Text = "Для користувачів ВІП знижки до 50%!";
                lblTipInfo.ForeColor = Color.LightGreen;
            }

            UpdateSubscriptionLabels();
        }
        private void UpdateSubscriptionLabels()
        {
            double price7 = 150;
            double price14 = 300;
            double price30 = 610;
            double price365 = 7045;

            if (isVIP)
            {
                price7 *= 0.5;
                price14 *= 0.5;
                price30 *= 0.5;
                price365 *= 0.5;
                lblDiscount7.Text = $"-50%";
                lblDiscount7.ForeColor = Color.Gold;
                lblDiscount7.Visible = true;

                lblDiscount14.Text = $"-50%";
                lblDiscount14.ForeColor = Color.Gold;
                lblDiscount14.Visible = true;

                lblDiscount30.Text = $"-50%";
                lblDiscount30.ForeColor = Color.Gold;

                lblDiscount365.Text = $"-50%";
                lblDiscount365.ForeColor = Color.Gold;
            }

            lbl7Price.Text = $"{price7}₴";
            lbl14Price.Text = $"{price14}₴";
            lbl30Price.Text = $"{price30}₴";
            lbl365Price.Text = $"{price365}₴";

        }


        public event EventHandler SubscriptionUpdated;

        protected virtual void OnSubscriptionUpdated(EventArgs e)
        {
            SubscriptionUpdated?.Invoke(this, e);
        }

        private void lblCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCloseApp_MouseEnter(object sender, EventArgs e)
        {
            lblCloseApp.ForeColor = Color.Red;
        }

        private void lblCloseApp_MouseLeave(object sender, EventArgs e)
        {
            lblCloseApp.ForeColor = Color.White;
        }

        

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int days = Convert.ToInt32(btn.Tag);
            BuySubscription(days);
        }

        private void btnBuy7_Click(object sender, EventArgs e)
        {
            BuySubscription(7);
        }

        private void btnBuy14_Click(object sender, EventArgs e)
        {
            BuySubscription(14);
        }

        private void btnBuy30_Click(object sender, EventArgs e)
        {
            BuySubscription(30);
        }

        private void btnBuy365_Click(object sender, EventArgs e)
        {
            BuySubscription(365);
        }


        private void BuySubscription(int days)
        {
            DateTime currentDate = DateTime.Now;
            DateTime currentSubscriptionEndDate = GetSubscriptionEndDate(loggedInUser);
            DateTime newSubscriptionStartDate = currentDate;

            if (currentSubscriptionEndDate == DateTime.MinValue || currentSubscriptionEndDate < currentDate)
            {
                currentSubscriptionEndDate = currentDate.AddDays(1);
            }

            DateTime newSubscriptionEndDate = currentSubscriptionEndDate.AddDays(days);

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `subscription_end_date` = @newEndDate WHERE `log` = @loggedInUser", db.getConnection());
            command.Parameters.AddWithValue("@newEndDate", newSubscriptionEndDate);
            command.Parameters.AddWithValue("@loggedInUser", loggedInUser);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show($"Підписку успішно продовжено на {days} днів.");
                OnSubscriptionUpdated(EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Помилка під час продовження підписки.");
            }

            db.closeConnection();
        }

        private DateTime GetSubscriptionEndDate(string loggedInUser)
        {
            DateTime subscriptionEndDate = DateTime.MinValue;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `subscription_end_date` FROM `users` WHERE `log` = @uL", db.getConnection());
            command.Parameters.AddWithValue("@uL", loggedInUser);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0 && table.Rows[0]["subscription_end_date"] != DBNull.Value)
            {
                subscriptionEndDate = Convert.ToDateTime(table.Rows[0]["subscription_end_date"]);
            }

            return subscriptionEndDate;
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

    }
}