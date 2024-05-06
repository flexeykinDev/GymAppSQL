namespace GymAppSQL
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.pnlMainLogin = new System.Windows.Forms.Panel();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.lblTools = new System.Windows.Forms.Label();
            this.btnTruncateTable = new System.Windows.Forms.Button();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.textBox_EndDataTime = new System.Windows.Forms.TextBox();
            this.textBox_Group = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_SurName = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblSurName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.pnlHeaderAdmin = new System.Windows.Forms.Panel();
            this.lblCloseApp = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlMainLogin.SuspendLayout();
            this.pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.panelAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.pnlHeaderAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainLogin
            // 
            this.pnlMainLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.pnlMainLogin.Controls.Add(this.pnlTools);
            this.pnlMainLogin.Controls.Add(this.panelAbout);
            this.pnlMainLogin.Controls.Add(this.dataGridViewMain);
            this.pnlMainLogin.Controls.Add(this.pnlHeaderAdmin);
            this.pnlMainLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlMainLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlMainLogin.Name = "pnlMainLogin";
            this.pnlMainLogin.Size = new System.Drawing.Size(853, 589);
            this.pnlMainLogin.TabIndex = 1;
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.btnClear);
            this.pnlTools.Controls.Add(this.btnEdit);
            this.pnlTools.Controls.Add(this.btnSave);
            this.pnlTools.Controls.Add(this.btnDelete);
            this.pnlTools.Controls.Add(this.btnSearch);
            this.pnlTools.Controls.Add(this.textBox_search);
            this.pnlTools.Controls.Add(this.btnRefresh);
            this.pnlTools.Controls.Add(this.lblTools);
            this.pnlTools.Controls.Add(this.btnTruncateTable);
            this.pnlTools.Location = new System.Drawing.Point(319, 232);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(522, 345);
            this.pnlTools.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Image = global::GymAppSQL.Properties.Resources.clear;
            this.btnClear.Location = new System.Drawing.Point(13, 34);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 64);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClear.TabIndex = 22;
            this.btnClear.TabStop = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnEdit.Location = new System.Drawing.Point(13, 123);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(264, 61);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnSave.Location = new System.Drawing.Point(13, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(264, 61);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.btnDelete.Location = new System.Drawing.Point(305, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 61);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = global::GymAppSQL.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(213, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 64);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSearch.TabIndex = 18;
            this.btnSearch.TabStop = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_search.Location = new System.Drawing.Point(305, 61);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(200, 37);
            this.textBox_search.TabIndex = 17;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Image = global::GymAppSQL.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(111, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 64);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTools
            // 
            this.lblTools.AutoSize = true;
            this.lblTools.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTools.ForeColor = System.Drawing.Color.White;
            this.lblTools.Location = new System.Drawing.Point(209, 0);
            this.lblTools.Name = "lblTools";
            this.lblTools.Size = new System.Drawing.Size(96, 23);
            this.lblTools.TabIndex = 15;
            this.lblTools.Text = "Управління";
            // 
            // btnTruncateTable
            // 
            this.btnTruncateTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTruncateTable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTruncateTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTruncateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTruncateTable.ForeColor = System.Drawing.Color.Red;
            this.btnTruncateTable.Location = new System.Drawing.Point(305, 214);
            this.btnTruncateTable.Name = "btnTruncateTable";
            this.btnTruncateTable.Size = new System.Drawing.Size(200, 58);
            this.btnTruncateTable.TabIndex = 5;
            this.btnTruncateTable.Text = "Зробити вайп БД";
            this.btnTruncateTable.UseVisualStyleBackColor = true;
            this.btnTruncateTable.Click += new System.EventHandler(this.btnTruncateTable_Click);
            // 
            // panelAbout
            // 
            this.panelAbout.Controls.Add(this.textBox_Id);
            this.panelAbout.Controls.Add(this.lblID);
            this.panelAbout.Controls.Add(this.textBox_EndDataTime);
            this.panelAbout.Controls.Add(this.textBox_Group);
            this.panelAbout.Controls.Add(this.textBox_Password);
            this.panelAbout.Controls.Add(this.textBox_Login);
            this.panelAbout.Controls.Add(this.textBox_SurName);
            this.panelAbout.Controls.Add(this.textBox_Name);
            this.panelAbout.Controls.Add(this.lblEndTime);
            this.panelAbout.Controls.Add(this.lblGroup);
            this.panelAbout.Controls.Add(this.lblSurName);
            this.panelAbout.Controls.Add(this.lblName);
            this.panelAbout.Controls.Add(this.lblPass);
            this.panelAbout.Controls.Add(this.lblLogin);
            this.panelAbout.Controls.Add(this.lblInfo);
            this.panelAbout.Location = new System.Drawing.Point(12, 232);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(301, 345);
            this.panelAbout.TabIndex = 7;
            // 
            // textBox_Id
            // 
            this.textBox_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.textBox_Id.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Id.ForeColor = System.Drawing.Color.White;
            this.textBox_Id.Location = new System.Drawing.Point(93, 44);
            this.textBox_Id.MaxLength = 255;
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(184, 30);
            this.textBox_Id.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(3, 40);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 23);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID:";
            // 
            // textBox_EndDataTime
            // 
            this.textBox_EndDataTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.textBox_EndDataTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_EndDataTime.ForeColor = System.Drawing.Color.White;
            this.textBox_EndDataTime.Location = new System.Drawing.Point(126, 276);
            this.textBox_EndDataTime.MaxLength = 255;
            this.textBox_EndDataTime.Name = "textBox_EndDataTime";
            this.textBox_EndDataTime.Size = new System.Drawing.Size(151, 30);
            this.textBox_EndDataTime.TabIndex = 12;
            // 
            // textBox_Group
            // 
            this.textBox_Group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.textBox_Group.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Group.ForeColor = System.Drawing.Color.White;
            this.textBox_Group.Location = new System.Drawing.Point(93, 214);
            this.textBox_Group.MaxLength = 255;
            this.textBox_Group.Name = "textBox_Group";
            this.textBox_Group.Size = new System.Drawing.Size(184, 30);
            this.textBox_Group.TabIndex = 11;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.textBox_Password.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.ForeColor = System.Drawing.Color.White;
            this.textBox_Password.Location = new System.Drawing.Point(93, 178);
            this.textBox_Password.MaxLength = 255;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(184, 30);
            this.textBox_Password.TabIndex = 10;
            // 
            // textBox_Login
            // 
            this.textBox_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.textBox_Login.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login.ForeColor = System.Drawing.Color.White;
            this.textBox_Login.Location = new System.Drawing.Point(93, 146);
            this.textBox_Login.MaxLength = 255;
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(184, 30);
            this.textBox_Login.TabIndex = 9;
            // 
            // textBox_SurName
            // 
            this.textBox_SurName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.textBox_SurName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SurName.ForeColor = System.Drawing.Color.White;
            this.textBox_SurName.Location = new System.Drawing.Point(93, 114);
            this.textBox_SurName.MaxLength = 255;
            this.textBox_SurName.Name = "textBox_SurName";
            this.textBox_SurName.Size = new System.Drawing.Size(184, 30);
            this.textBox_SurName.TabIndex = 8;
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.textBox_Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Name.ForeColor = System.Drawing.Color.White;
            this.textBox_Name.Location = new System.Drawing.Point(93, 79);
            this.textBox_Name.MaxLength = 255;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(184, 30);
            this.textBox_Name.TabIndex = 7;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEndTime.ForeColor = System.Drawing.Color.White;
            this.lblEndTime.Location = new System.Drawing.Point(3, 250);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(136, 46);
            this.lblEndTime.TabIndex = 6;
            this.lblEndTime.Text = "Дата закінчення \r\nпідписки:";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGroup.ForeColor = System.Drawing.Color.White;
            this.lblGroup.Location = new System.Drawing.Point(3, 211);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(61, 23);
            this.lblGroup.TabIndex = 5;
            this.lblGroup.Text = "Група:";
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurName.ForeColor = System.Drawing.Color.White;
            this.lblSurName.Location = new System.Drawing.Point(3, 110);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(90, 23);
            this.lblSurName.TabIndex = 4;
            this.lblSurName.Text = "Прізвище:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(3, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Ім\'я:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(3, 174);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(74, 23);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Пароль:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(3, 142);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(58, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Логін:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(122, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(50, 23);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Інфо";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.Size = new System.Drawing.Size(829, 150);
            this.dataGridViewMain.TabIndex = 6;
            this.dataGridViewMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellClick);
            // 
            // pnlHeaderAdmin
            // 
            this.pnlHeaderAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(133)))), ((int)(((byte)(130)))));
            this.pnlHeaderAdmin.Controls.Add(this.lblCloseApp);
            this.pnlHeaderAdmin.Controls.Add(this.lblHeader);
            this.pnlHeaderAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderAdmin.Name = "pnlHeaderAdmin";
            this.pnlHeaderAdmin.Size = new System.Drawing.Size(853, 56);
            this.pnlHeaderAdmin.TabIndex = 0;
            this.pnlHeaderAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeaderAdmin_MouseDown);
            this.pnlHeaderAdmin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeaderAdmin_MouseMove);
            // 
            // lblCloseApp
            // 
            this.lblCloseApp.AutoSize = true;
            this.lblCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCloseApp.ForeColor = System.Drawing.Color.White;
            this.lblCloseApp.Location = new System.Drawing.Point(839, 0);
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
            this.lblHeader.Size = new System.Drawing.Size(853, 56);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Панель Адміністратора";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHeader_MouseDown);
            this.lblHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHeader_MouseMove);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 589);
            this.Controls.Add(this.pnlMainLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель Адміністратора";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnlMainLogin.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.pnlHeaderAdmin.ResumeLayout(false);
            this.pnlHeaderAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainLogin;
        private System.Windows.Forms.Button btnTruncateTable;
        private System.Windows.Forms.Panel pnlHeaderAdmin;
        private System.Windows.Forms.Label lblCloseApp;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox textBox_EndDataTime;
        private System.Windows.Forms.TextBox textBox_Group;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_SurName;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Label lblTools;
        private System.Windows.Forms.PictureBox btnRefresh;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox btnClear;
    }
}