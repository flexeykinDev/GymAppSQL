namespace GymAppSQL
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.pnlMainLogin = new System.Windows.Forms.Panel();
            this.lblConfirmHint = new System.Windows.Forms.Label();
            this.lblNewHint = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.pictureBoxEye = new System.Windows.Forms.PictureBox();
            this.oldPass = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.confirmNewPass = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlHeaderLogin = new System.Windows.Forms.Panel();
            this.lblCloseApp = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlMainLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlHeaderLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainLogin
            // 
            this.pnlMainLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.pnlMainLogin.Controls.Add(this.lblConfirmHint);
            this.pnlMainLogin.Controls.Add(this.lblNewHint);
            this.pnlMainLogin.Controls.Add(this.lblHint);
            this.pnlMainLogin.Controls.Add(this.pictureBoxEye);
            this.pnlMainLogin.Controls.Add(this.oldPass);
            this.pnlMainLogin.Controls.Add(this.newPass);
            this.pnlMainLogin.Controls.Add(this.btnChangePass);
            this.pnlMainLogin.Controls.Add(this.confirmNewPass);
            this.pnlMainLogin.Controls.Add(this.pictureBox2);
            this.pnlMainLogin.Controls.Add(this.pnlHeaderLogin);
            this.pnlMainLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlMainLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlMainLogin.Name = "pnlMainLogin";
            this.pnlMainLogin.Size = new System.Drawing.Size(487, 450);
            this.pnlMainLogin.TabIndex = 1;
            this.pnlMainLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMainLogin_MouseDown);
            this.pnlMainLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMainLogin_MouseMove);
            // 
            // lblConfirmHint
            // 
            this.lblConfirmHint.AutoSize = true;
            this.lblConfirmHint.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConfirmHint.ForeColor = System.Drawing.Color.White;
            this.lblConfirmHint.Location = new System.Drawing.Point(149, 229);
            this.lblConfirmHint.Name = "lblConfirmHint";
            this.lblConfirmHint.Size = new System.Drawing.Size(199, 23);
            this.lblConfirmHint.TabIndex = 11;
            this.lblConfirmHint.Text = "Повторіть новий пароль";
            this.lblConfirmHint.Visible = false;
            // 
            // lblNewHint
            // 
            this.lblNewHint.AutoSize = true;
            this.lblNewHint.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewHint.ForeColor = System.Drawing.Color.White;
            this.lblNewHint.Location = new System.Drawing.Point(147, 162);
            this.lblNewHint.Name = "lblNewHint";
            this.lblNewHint.Size = new System.Drawing.Size(118, 23);
            this.lblNewHint.TabIndex = 10;
            this.lblNewHint.Text = "Новий пароль";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHint.ForeColor = System.Drawing.Color.White;
            this.lblHint.Location = new System.Drawing.Point(149, 110);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(125, 23);
            this.lblHint.TabIndex = 9;
            this.lblHint.Text = "Старий пороль";
            // 
            // pictureBoxEye
            // 
            this.pictureBoxEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEye.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEye.Image")));
            this.pictureBoxEye.Location = new System.Drawing.Point(384, 174);
            this.pictureBoxEye.Name = "pictureBoxEye";
            this.pictureBoxEye.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEye.TabIndex = 8;
            this.pictureBoxEye.TabStop = false;
            this.pictureBoxEye.Click += new System.EventHandler(this.PictureBoxEye_Click);
            // 
            // oldPass
            // 
            this.oldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPass.Location = new System.Drawing.Point(150, 134);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(196, 29);
            this.oldPass.TabIndex = 7;
            // 
            // newPass
            // 
            this.newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPass.Location = new System.Drawing.Point(150, 186);
            this.newPass.Name = "newPass";
            this.newPass.ShortcutsEnabled = false;
            this.newPass.Size = new System.Drawing.Size(196, 29);
            this.newPass.TabIndex = 6;
            this.newPass.Enter += new System.EventHandler(this.newPass_Enter);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnChangePass.Location = new System.Drawing.Point(150, 301);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(196, 53);
            this.btnChangePass.TabIndex = 5;
            this.btnChangePass.Text = "Поміняти Пароль";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // confirmNewPass
            // 
            this.confirmNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmNewPass.Location = new System.Drawing.Point(150, 252);
            this.confirmNewPass.Name = "confirmNewPass";
            this.confirmNewPass.ShortcutsEnabled = false;
            this.confirmNewPass.Size = new System.Drawing.Size(196, 29);
            this.confirmNewPass.TabIndex = 4;
            this.confirmNewPass.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GymAppSQL.Properties.Resources.icon_password64;
            this.pictureBox2.Location = new System.Drawing.Point(55, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pnlHeaderLogin
            // 
            this.pnlHeaderLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.pnlHeaderLogin.Controls.Add(this.lblCloseApp);
            this.pnlHeaderLogin.Controls.Add(this.lblHeader);
            this.pnlHeaderLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderLogin.Name = "pnlHeaderLogin";
            this.pnlHeaderLogin.Size = new System.Drawing.Size(487, 56);
            this.pnlHeaderLogin.TabIndex = 0;
            // 
            // lblCloseApp
            // 
            this.lblCloseApp.AutoSize = true;
            this.lblCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCloseApp.ForeColor = System.Drawing.Color.White;
            this.lblCloseApp.Location = new System.Drawing.Point(473, 0);
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
            this.lblHeader.Size = new System.Drawing.Size(487, 56);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Зміна пароля";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.pnlMainLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зміна пароля";
            this.Load += new System.EventHandler(this.ChangePass_Load);
            this.pnlMainLogin.ResumeLayout(false);
            this.pnlMainLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlHeaderLogin.ResumeLayout(false);
            this.pnlHeaderLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainLogin;
        private System.Windows.Forms.TextBox oldPass;
        private System.Windows.Forms.TextBox newPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.TextBox confirmNewPass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlHeaderLogin;
        private System.Windows.Forms.Label lblCloseApp;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBoxEye;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblConfirmHint;
        private System.Windows.Forms.Label lblNewHint;
    }
}