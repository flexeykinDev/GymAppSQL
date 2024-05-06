namespace GymAppSQL
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.pnlMainRegister = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeaderRegister = new System.Windows.Forms.Panel();
            this.lblCloseApp = new System.Windows.Forms.Label();
            this.lblHeaderRegister = new System.Windows.Forms.Label();
            this.pnlMainRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeaderRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainRegister
            // 
            this.pnlMainRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.pnlMainRegister.Controls.Add(this.lblLogin);
            this.pnlMainRegister.Controls.Add(this.userNameField);
            this.pnlMainRegister.Controls.Add(this.userSurnameField);
            this.pnlMainRegister.Controls.Add(this.btnRegister);
            this.pnlMainRegister.Controls.Add(this.passField);
            this.pnlMainRegister.Controls.Add(this.pictureBox2);
            this.pnlMainRegister.Controls.Add(this.loginField);
            this.pnlMainRegister.Controls.Add(this.pictureBox1);
            this.pnlMainRegister.Controls.Add(this.pnlHeaderRegister);
            this.pnlMainRegister.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlMainRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainRegister.Location = new System.Drawing.Point(0, 0);
            this.pnlMainRegister.Name = "pnlMainRegister";
            this.pnlMainRegister.Size = new System.Drawing.Size(800, 450);
            this.pnlMainRegister.TabIndex = 1;
            this.pnlMainRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMainRegister_MouseDown);
            this.pnlMainRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMainRegister_MouseMove);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(304, 401);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(158, 27);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Авторизуватись";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            this.lblLogin.MouseEnter += new System.EventHandler(this.lblLogin_MouseEnter);
            this.lblLogin.MouseLeave += new System.EventHandler(this.lblLogin_MouseLeave);
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.Location = new System.Drawing.Point(119, 169);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(196, 33);
            this.userNameField.TabIndex = 7;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // userSurnameField
            // 
            this.userSurnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userSurnameField.Location = new System.Drawing.Point(119, 232);
            this.userSurnameField.Multiline = true;
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(196, 33);
            this.userSurnameField.TabIndex = 6;
            this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
            this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnRegister.Location = new System.Drawing.Point(285, 336);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(196, 53);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Зареєструватися";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(493, 236);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(196, 29);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GymAppSQL.Properties.Resources.icon_password64;
            this.pictureBox2.Location = new System.Drawing.Point(417, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(493, 169);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(196, 33);
            this.loginField.TabIndex = 2;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GymAppSQL.Properties.Resources.icon_male64;
            this.pictureBox1.Location = new System.Drawing.Point(34, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHeaderRegister
            // 
            this.pnlHeaderRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.pnlHeaderRegister.Controls.Add(this.lblCloseApp);
            this.pnlHeaderRegister.Controls.Add(this.lblHeaderRegister);
            this.pnlHeaderRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderRegister.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderRegister.Name = "pnlHeaderRegister";
            this.pnlHeaderRegister.Size = new System.Drawing.Size(800, 56);
            this.pnlHeaderRegister.TabIndex = 0;
            // 
            // lblCloseApp
            // 
            this.lblCloseApp.AutoSize = true;
            this.lblCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCloseApp.ForeColor = System.Drawing.Color.White;
            this.lblCloseApp.Location = new System.Drawing.Point(786, 0);
            this.lblCloseApp.Name = "lblCloseApp";
            this.lblCloseApp.Size = new System.Drawing.Size(14, 13);
            this.lblCloseApp.TabIndex = 6;
            this.lblCloseApp.Text = "X";
            this.lblCloseApp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCloseApp.Click += new System.EventHandler(this.lblCloseApp_Click);
            this.lblCloseApp.MouseEnter += new System.EventHandler(this.lblCloseApp_MouseEnter_1);
            this.lblCloseApp.MouseLeave += new System.EventHandler(this.lblCloseApp_MouseLeave_1);
            // 
            // lblHeaderRegister
            // 
            this.lblHeaderRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderRegister.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeaderRegister.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeaderRegister.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderRegister.Name = "lblHeaderRegister";
            this.lblHeaderRegister.Size = new System.Drawing.Size(800, 56);
            this.lblHeaderRegister.TabIndex = 0;
            this.lblHeaderRegister.Text = "Реєстрація";
            this.lblHeaderRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMainRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація";
            this.pnlMainRegister.ResumeLayout(false);
            this.pnlMainRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeaderRegister.ResumeLayout(false);
            this.pnlHeaderRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHeaderRegister;
        private System.Windows.Forms.Label lblCloseApp;
        private System.Windows.Forms.Label lblHeaderRegister;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.Label lblLogin;
    }
}