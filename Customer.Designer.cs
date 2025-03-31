namespace WindowsFormsApp1
{
    partial class Functions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Functions));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cbSelect = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UserData = new System.Windows.Forms.DataGridView();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.pbGameRoom = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbFoodImage = new System.Windows.Forms.PictureBox();
            this.pbDashboard = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pbSetting = new System.Windows.Forms.PictureBox();
            this.pbDesktopComputer = new System.Windows.Forms.PictureBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnServer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbCustomerImage = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameRoom)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesktopComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerImage)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1016, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customer";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(668, 105);
            this.txtUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(358, 32);
            this.txtUser.TabIndex = 8;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // cbSelect
            // 
            this.cbSelect.BackColor = System.Drawing.Color.Transparent;
            this.cbSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelect.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSelect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSelect.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSelect.ItemHeight = 30;
            this.cbSelect.Items.AddRange(new object[] {
            "Username",
            "Phone"});
            this.cbSelect.Location = new System.Drawing.Point(457, 100);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(140, 36);
            this.cbSelect.TabIndex = 9;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(681, 228);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 41);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(900, 228);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 41);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(668, 159);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(358, 32);
            this.txtMoney.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(457, 230);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 41);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Account_Image.png");
            this.imageList1.Images.SetKeyName(1, "tải xuống.jpeg");
            // 
            // UserData
            // 
            this.UserData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserData.Location = new System.Drawing.Point(385, 320);
            this.UserData.Name = "UserData";
            this.UserData.RowHeadersWidth = 51;
            this.UserData.RowTemplate.Height = 24;
            this.UserData.Size = new System.Drawing.Size(959, 366);
            this.UserData.TabIndex = 15;
            this.UserData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserData_CellEndEdit);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.LightGray;
            this.btnCreateAcc.FlatAppearance.BorderSize = 0;
            this.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAcc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAcc.ForeColor = System.Drawing.Color.Black;
            this.btnCreateAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAcc.ImageIndex = 1;
            this.btnCreateAcc.ImageList = this.imageList1;
            this.btnCreateAcc.Location = new System.Drawing.Point(1112, 228);
            this.btnCreateAcc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(180, 50);
            this.btnCreateAcc.TabIndex = 7;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // pbGameRoom
            // 
            this.pbGameRoom.Image = ((System.Drawing.Image)(resources.GetObject("pbGameRoom.Image")));
            this.pbGameRoom.Location = new System.Drawing.Point(10, 5);
            this.pbGameRoom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pbGameRoom.Name = "pbGameRoom";
            this.pbGameRoom.Size = new System.Drawing.Size(70, 48);
            this.pbGameRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGameRoom.TabIndex = 8;
            this.pbGameRoom.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(94, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(387, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "Internet Gaming Manage System 2.0";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.pbGameRoom);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(213, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1287, 55);
            this.panel8.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkCyan;
            this.panel7.Controls.Add(this.btnLogout);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Location = new System.Drawing.Point(0, 614);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(213, 89);
            this.panel7.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(80, 30);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 41);
            this.btnLogout.TabIndex = 31;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pbFoodImage
            // 
            this.pbFoodImage.Image = ((System.Drawing.Image)(resources.GetObject("pbFoodImage.Image")));
            this.pbFoodImage.Location = new System.Drawing.Point(16, 319);
            this.pbFoodImage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pbFoodImage.Name = "pbFoodImage";
            this.pbFoodImage.Size = new System.Drawing.Size(55, 50);
            this.pbFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoodImage.TabIndex = 18;
            this.pbFoodImage.TabStop = false;
            // 
            // pbDashboard
            // 
            this.pbDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pbDashboard.Image")));
            this.pbDashboard.Location = new System.Drawing.Point(15, 406);
            this.pbDashboard.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pbDashboard.Name = "pbDashboard";
            this.pbDashboard.Size = new System.Drawing.Size(55, 50);
            this.pbDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDashboard.TabIndex = 20;
            this.pbDashboard.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WindowsFormsApp1.Properties.Resources.Contact_Icon1;
            this.pictureBox8.Location = new System.Drawing.Point(15, 509);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(55, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            // 
            // pbSetting
            // 
            this.pbSetting.Image = global::WindowsFormsApp1.Properties.Resources.Server_Icon;
            this.pbSetting.Location = new System.Drawing.Point(15, 230);
            this.pbSetting.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pbSetting.Name = "pbSetting";
            this.pbSetting.Size = new System.Drawing.Size(55, 50);
            this.pbSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSetting.TabIndex = 24;
            this.pbSetting.TabStop = false;
            // 
            // pbDesktopComputer
            // 
            this.pbDesktopComputer.BackColor = System.Drawing.Color.Teal;
            this.pbDesktopComputer.Image = ((System.Drawing.Image)(resources.GetObject("pbDesktopComputer.Image")));
            this.pbDesktopComputer.Location = new System.Drawing.Point(10, 0);
            this.pbDesktopComputer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pbDesktopComputer.Name = "pbDesktopComputer";
            this.pbDesktopComputer.Size = new System.Drawing.Size(193, 123);
            this.pbDesktopComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDesktopComputer.TabIndex = 25;
            this.pbDesktopComputer.TabStop = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(76, 159);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(124, 34);
            this.btnCustomer.TabIndex = 15;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.Teal;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.White;
            this.btnFood.Location = new System.Drawing.Point(76, 327);
            this.btnFood.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(114, 34);
            this.btnFood.TabIndex = 26;
            this.btnFood.Text = "Food";
            this.btnFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Teal;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(68, 417);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(133, 34);
            this.btnDashboard.TabIndex = 27;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.Color.Teal;
            this.btnServer.FlatAppearance.BorderSize = 0;
            this.btnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.ForeColor = System.Drawing.Color.White;
            this.btnServer.Location = new System.Drawing.Point(76, 241);
            this.btnServer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(115, 34);
            this.btnServer.TabIndex = 28;
            this.btnServer.Text = "Server";
            this.btnServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(72, 516);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 29;
            this.button1.Text = "Contact";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // pbCustomerImage
            // 
            this.pbCustomerImage.Image = global::WindowsFormsApp1.Properties.Resources.Customer_Icon;
            this.pbCustomerImage.Location = new System.Drawing.Point(15, 148);
            this.pbCustomerImage.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pbCustomerImage.Name = "pbCustomerImage";
            this.pbCustomerImage.Size = new System.Drawing.Size(55, 50);
            this.pbCustomerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCustomerImage.TabIndex = 30;
            this.pbCustomerImage.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.pbCustomerImage);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.btnServer);
            this.panel5.Controls.Add(this.btnDashboard);
            this.panel5.Controls.Add(this.btnFood);
            this.panel5.Controls.Add(this.btnCustomer);
            this.panel5.Controls.Add(this.pbDesktopComputer);
            this.panel5.Controls.Add(this.pbSetting);
            this.panel5.Controls.Add(this.pictureBox8);
            this.panel5.Controls.Add(this.pbDashboard);
            this.panel5.Controls.Add(this.pbFoodImage);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 759);
            this.panel5.TabIndex = 19;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DarkBlue;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(791, 711);
            this.btnPay.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(156, 41);
            this.btnPay.TabIndex = 21;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Functions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 759);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.UserData);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Functions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Functions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Functions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameRoom)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesktopComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerImage)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private Guna.UI2.WinForms.Guna2ComboBox cbSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.DataGridView UserData;
        private System.Windows.Forms.PictureBox pbGameRoom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbFoodImage;
        private System.Windows.Forms.PictureBox pbDashboard;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pbSetting;
        private System.Windows.Forms.PictureBox pbDesktopComputer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbCustomerImage;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnPay;
    }
}