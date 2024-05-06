namespace GymAppSQL
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnBuyVip = new System.Windows.Forms.Button();
            this.btnExpiredSubscription = new System.Windows.Forms.Button();
            this.lblSubscription = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblSurName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pnlHeaderLogin = new System.Windows.Forms.Panel();
            this.lblCloseApp = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlHeaderLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.pnlMain.Controls.Add(this.btnChangePass);
            this.pnlMain.Controls.Add(this.btnBuyVip);
            this.pnlMain.Controls.Add(this.btnExpiredSubscription);
            this.pnlMain.Controls.Add(this.lblSubscription);
            this.pnlMain.Controls.Add(this.lblGroup);
            this.pnlMain.Controls.Add(this.lblSurName);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.btnAdmin);
            this.pnlMain.Controls.Add(this.pnlHeaderLogin);
            this.pnlMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 450);
            this.pnlMain.TabIndex = 1;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnChangePass.Location = new System.Drawing.Point(539, 367);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(196, 61);
            this.btnChangePass.TabIndex = 12;
            this.btnChangePass.Text = "Редагувати пароль\r\n";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnBuyVip
            // 
            this.btnBuyVip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyVip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuyVip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuyVip.ForeColor = System.Drawing.Color.Yellow;
            this.btnBuyVip.Location = new System.Drawing.Point(300, 300);
            this.btnBuyVip.Name = "btnBuyVip";
            this.btnBuyVip.Size = new System.Drawing.Size(196, 61);
            this.btnBuyVip.TabIndex = 11;
            this.btnBuyVip.Text = "Купити VIP абонімент";
            this.btnBuyVip.UseVisualStyleBackColor = true;
            this.btnBuyVip.Click += new System.EventHandler(this.btnBuyVip_Click);
            // 
            // btnExpiredSubscription
            // 
            this.btnExpiredSubscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpiredSubscription.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnExpiredSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpiredSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExpiredSubscription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnExpiredSubscription.Location = new System.Drawing.Point(300, 367);
            this.btnExpiredSubscription.Name = "btnExpiredSubscription";
            this.btnExpiredSubscription.Size = new System.Drawing.Size(196, 61);
            this.btnExpiredSubscription.TabIndex = 10;
            this.btnExpiredSubscription.Text = "Придбати абонімент";
            this.btnExpiredSubscription.UseVisualStyleBackColor = true;
            this.btnExpiredSubscription.Click += new System.EventHandler(this.btnExpiredSubscription_Click);
            // 
            // lblSubscription
            // 
            this.lblSubscription.AutoSize = true;
            this.lblSubscription.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubscription.ForeColor = System.Drawing.Color.White;
            this.lblSubscription.Location = new System.Drawing.Point(36, 186);
            this.lblSubscription.Name = "lblSubscription";
            this.lblSubscription.Size = new System.Drawing.Size(62, 26);
            this.lblSubscription.TabIndex = 9;
            this.lblSubscription.Text = "label1";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroup.ForeColor = System.Drawing.Color.White;
            this.lblGroup.Location = new System.Drawing.Point(36, 151);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(62, 26);
            this.lblGroup.TabIndex = 8;
            this.lblGroup.Text = "label1";
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurName.ForeColor = System.Drawing.Color.White;
            this.lblSurName.Location = new System.Drawing.Point(36, 116);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(62, 26);
            this.lblSurName.TabIndex = 7;
            this.lblSurName.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(36, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 26);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "label1";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnAdmin.Location = new System.Drawing.Point(52, 367);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(196, 61);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Редагувати користувачів";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pnlHeaderLogin
            // 
            this.pnlHeaderLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.pnlHeaderLogin.Controls.Add(this.lblCloseApp);
            this.pnlHeaderLogin.Controls.Add(this.lblMain);
            this.pnlHeaderLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderLogin.Name = "pnlHeaderLogin";
            this.pnlHeaderLogin.Size = new System.Drawing.Size(800, 56);
            this.pnlHeaderLogin.TabIndex = 0;
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
            this.lblCloseApp.MouseEnter += new System.EventHandler(this.lblCloseApp_MouseEnter);
            this.lblCloseApp.MouseLeave += new System.EventHandler(this.lblCloseApp_MouseLeave);
            // 
            // lblMain
            // 
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMain.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMain.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMain.Location = new System.Drawing.Point(0, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(800, 56);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Головне Меню";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMain_MouseDown);
            this.lblMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMain_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlHeaderLogin.ResumeLayout(false);
            this.pnlHeaderLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnlHeaderLogin;
        private System.Windows.Forms.Label lblCloseApp;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSubscription;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Button btnExpiredSubscription;
        private System.Windows.Forms.Button btnBuyVip;
        private System.Windows.Forms.Button btnChangePass;
    }
}