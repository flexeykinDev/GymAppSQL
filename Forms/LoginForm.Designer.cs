namespace GymAppSQL
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlMainLogin = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeaderLogin = new System.Windows.Forms.Panel();
            this.lblCloseApp = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlMainLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeaderLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainLogin
            // 
            this.pnlMainLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.pnlMainLogin.Controls.Add(this.lblRegister);
            this.pnlMainLogin.Controls.Add(this.btnLogin);
            this.pnlMainLogin.Controls.Add(this.passField);
            this.pnlMainLogin.Controls.Add(this.pictureBox2);
            this.pnlMainLogin.Controls.Add(this.loginField);
            this.pnlMainLogin.Controls.Add(this.pictureBox1);
            this.pnlMainLogin.Controls.Add(this.pnlHeaderLogin);
            this.pnlMainLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlMainLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlMainLogin.Name = "pnlMainLogin";
            this.pnlMainLogin.Size = new System.Drawing.Size(401, 394);
            this.pnlMainLogin.TabIndex = 0;
            this.pnlMainLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMainLogin_MouseDown);
            this.pnlMainLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMainLogin_MouseMove);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(132, 356);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(179, 19);
            this.lblRegister.TabIndex = 6;
            this.lblRegister.Text = "немає облікового запису?";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            this.lblRegister.MouseEnter += new System.EventHandler(this.lblRegister_MouseEnter);
            this.lblRegister.MouseLeave += new System.EventHandler(this.lblRegister_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnLogin.Location = new System.Drawing.Point(124, 289);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(196, 53);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Увійти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(124, 240);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(196, 29);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GymAppSQL.Properties.Resources.icon_password64;
            this.pictureBox2.Location = new System.Drawing.Point(38, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(124, 157);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(196, 33);
            this.loginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GymAppSQL.Properties.Resources.icon_male64;
            this.pictureBox1.Location = new System.Drawing.Point(38, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHeaderLogin
            // 
            this.pnlHeaderLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.pnlHeaderLogin.Controls.Add(this.lblCloseApp);
            this.pnlHeaderLogin.Controls.Add(this.lblHeader);
            this.pnlHeaderLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderLogin.Name = "pnlHeaderLogin";
            this.pnlHeaderLogin.Size = new System.Drawing.Size(401, 56);
            this.pnlHeaderLogin.TabIndex = 0;
            // 
            // lblCloseApp
            // 
            this.lblCloseApp.AutoSize = true;
            this.lblCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCloseApp.ForeColor = System.Drawing.Color.White;
            this.lblCloseApp.Location = new System.Drawing.Point(387, 0);
            this.lblCloseApp.Name = "lblCloseApp";
            this.lblCloseApp.Size = new System.Drawing.Size(14, 13);
            this.lblCloseApp.TabIndex = 6;
            this.lblCloseApp.Text = "X";
            this.lblCloseApp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCloseApp.Click += new System.EventHandler(this.lblCloseApp_Click);
            this.lblCloseApp.MouseEnter += new System.EventHandler(this.lblCloseApp_MouseEnter);
            this.lblCloseApp.MouseLeave += new System.EventHandler(this.lblCloseApp_MouseLeave);
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(401, 56);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Авторизація";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHeader_MouseDown);
            this.lblHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHeader_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 394);
            this.Controls.Add(this.pnlMainLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Логін";
            this.pnlMainLogin.ResumeLayout(false);
            this.pnlMainLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHeaderLogin.ResumeLayout(false);
            this.pnlHeaderLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainLogin;
        private System.Windows.Forms.Panel pnlHeaderLogin;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblCloseApp;
        private System.Windows.Forms.Label lblRegister;
    }
}

