namespace GUI
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.imgListMenuButton = new System.Windows.Forms.ImageList(this.components);
            this.btnNoti = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnOrderhistory = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.imgListWindowButton = new System.Windows.Forms.ImageList(this.components);
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picStatistics = new System.Windows.Forms.PictureBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.picEmployees = new System.Windows.Forms.PictureBox();
            this.ucProductTab = new GUI.UserControlProductTab();
            this.ucOrderHistorycs1 = new GUI.ucOrderHistorycs();
            this.ucEmployeeTab = new GUI.UserControlEmployeesTab();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.pnlMenu.Controls.Add(this.btnUser);
            this.pnlMenu.Controls.Add(this.btnNoti);
            this.pnlMenu.Controls.Add(this.btnEvent);
            this.pnlMenu.Controls.Add(this.btnStatistic);
            this.pnlMenu.Controls.Add(this.btnCustomer);
            this.pnlMenu.Controls.Add(this.btnOrderhistory);
            this.pnlMenu.Controls.Add(this.btnSupplier);
            this.pnlMenu.Controls.Add(this.btnStock);
            this.pnlMenu.Controls.Add(this.btnProduct);
            this.pnlMenu.Controls.Add(this.btnEmployee);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 37);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(221, 592);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.ImageIndex = 9;
            this.btnUser.ImageList = this.imgListMenuButton;
            this.btnUser.Location = new System.Drawing.Point(1, 521);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(217, 50);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // imgListMenuButton
            // 
            this.imgListMenuButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListMenuButton.ImageStream")));
            this.imgListMenuButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListMenuButton.Images.SetKeyName(0, "Employee.png");
            this.imgListMenuButton.Images.SetKeyName(1, "Coffee.png");
            this.imgListMenuButton.Images.SetKeyName(2, "Stockpng.png");
            this.imgListMenuButton.Images.SetKeyName(3, "supplier.png");
            this.imgListMenuButton.Images.SetKeyName(4, "order_history.png");
            this.imgListMenuButton.Images.SetKeyName(5, "customer.png");
            this.imgListMenuButton.Images.SetKeyName(6, "statistics.png");
            this.imgListMenuButton.Images.SetKeyName(7, "event.png");
            this.imgListMenuButton.Images.SetKeyName(8, "notification_50px.png");
            this.imgListMenuButton.Images.SetKeyName(9, "user_account_50px.png");
            // 
            // btnNoti
            // 
            this.btnNoti.FlatAppearance.BorderSize = 0;
            this.btnNoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoti.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoti.ImageIndex = 8;
            this.btnNoti.ImageList = this.imgListMenuButton;
            this.btnNoti.Location = new System.Drawing.Point(1, 465);
            this.btnNoti.Name = "btnNoti";
            this.btnNoti.Size = new System.Drawing.Size(217, 50);
            this.btnNoti.TabIndex = 0;
            this.btnNoti.Text = "Notifications";
            this.btnNoti.UseVisualStyleBackColor = true;
            // 
            // btnEvent
            // 
            this.btnEvent.FlatAppearance.BorderSize = 0;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvent.ImageIndex = 7;
            this.btnEvent.ImageList = this.imgListMenuButton;
            this.btnEvent.Location = new System.Drawing.Point(1, 409);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(217, 50);
            this.btnEvent.TabIndex = 0;
            this.btnEvent.Text = "Events";
            this.btnEvent.UseVisualStyleBackColor = true;
            // 
            // btnStatistic
            // 
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.ImageIndex = 6;
            this.btnStatistic.ImageList = this.imgListMenuButton;
            this.btnStatistic.Location = new System.Drawing.Point(1, 344);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(217, 50);
            this.btnStatistic.TabIndex = 0;
            this.btnStatistic.Text = "Statistics";
            this.btnStatistic.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.ImageIndex = 5;
            this.btnCustomer.ImageList = this.imgListMenuButton;
            this.btnCustomer.Location = new System.Drawing.Point(1, 288);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(217, 50);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnOrderhistory
            // 
            this.btnOrderhistory.FlatAppearance.BorderSize = 0;
            this.btnOrderhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderhistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderhistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderhistory.ImageIndex = 4;
            this.btnOrderhistory.ImageList = this.imgListMenuButton;
            this.btnOrderhistory.Location = new System.Drawing.Point(1, 222);
            this.btnOrderhistory.Name = "btnOrderhistory";
            this.btnOrderhistory.Size = new System.Drawing.Size(217, 50);
            this.btnOrderhistory.TabIndex = 0;
            this.btnOrderhistory.Text = "Order history";
            this.btnOrderhistory.UseVisualStyleBackColor = true;
            this.btnOrderhistory.Click += new System.EventHandler(this.btnOrderhistory_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.ImageIndex = 3;
            this.btnSupplier.ImageList = this.imgListMenuButton;
            this.btnSupplier.Location = new System.Drawing.Point(1, 166);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(217, 50);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.Text = "Suppliers";
            this.btnSupplier.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.ImageIndex = 2;
            this.btnStock.ImageList = this.imgListMenuButton;
            this.btnStock.Location = new System.Drawing.Point(1, 110);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(217, 50);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.ImageIndex = 1;
            this.btnProduct.ImageList = this.imgListMenuButton;
            this.btnProduct.Location = new System.Drawing.Point(1, 54);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(217, 50);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Products";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.ImageIndex = 0;
            this.btnEmployee.ImageList = this.imgListMenuButton;
            this.btnEmployee.Location = new System.Drawing.Point(1, -2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(217, 50);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.pnlTitleBar.Controls.Add(this.btnMenu);
            this.pnlTitleBar.Controls.Add(this.lblLogo);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnCancel);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(984, 37);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.pnlTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ImageIndex = 4;
            this.btnMenu.ImageList = this.imgListWindowButton;
            this.btnMenu.Location = new System.Drawing.Point(221, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(37, 37);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // imgListWindowButton
            // 
            this.imgListWindowButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListWindowButton.ImageStream")));
            this.imgListWindowButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListWindowButton.Images.SetKeyName(0, "close_window.png");
            this.imgListWindowButton.Images.SetKeyName(1, "maximize.png");
            this.imgListWindowButton.Images.SetKeyName(2, "minimize.png");
            this.imgListWindowButton.Images.SetKeyName(3, "restore.png");
            this.imgListWindowButton.Images.SetKeyName(4, "menu_50px.png");
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLogo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(221, 37);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "CoffeeShopManager";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ImageIndex = 2;
            this.btnMinimize.ImageList = this.imgListWindowButton;
            this.btnMinimize.Location = new System.Drawing.Point(861, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(41, 37);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ImageIndex = 1;
            this.btnMaximize.ImageList = this.imgListWindowButton;
            this.btnMaximize.Location = new System.Drawing.Point(902, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(41, 37);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ImageIndex = 0;
            this.btnCancel.ImageList = this.imgListWindowButton;
            this.btnCancel.Location = new System.Drawing.Point(943, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(41, 37);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlShow
            // 
            this.pnlShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlShow.Controls.Add(this.ucProductTab);
            this.pnlShow.Controls.Add(this.ucOrderHistorycs1);
            this.pnlShow.Controls.Add(this.button1);
            this.pnlShow.Controls.Add(this.ucEmployeeTab);
            this.pnlShow.Controls.Add(this.picStatistics);
            this.pnlShow.Controls.Add(this.picEmployees);
            this.pnlShow.Controls.Add(this.picCustomer);
            this.pnlShow.Controls.Add(this.label2);
            this.pnlShow.Controls.Add(this.label3);
            this.pnlShow.Controls.Add(this.label4);
            this.pnlShow.Controls.Add(this.panel1);
            this.pnlShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShow.Location = new System.Drawing.Point(221, 37);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(763, 592);
            this.pnlShow.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(582, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Statistics";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employees";
            // 
            // picStatistics
            // 
            this.picStatistics.BackgroundImage = global::GUI.Properties.Resources.FreeVector_3D_Charts_Graphics;
            this.picStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStatistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStatistics.Location = new System.Drawing.Point(284, 341);
            this.picStatistics.Name = "picStatistics";
            this.picStatistics.Size = new System.Drawing.Size(192, 145);
            this.picStatistics.TabIndex = 4;
            this.picStatistics.TabStop = false;
            // 
            // picCustomer
            // 
            this.picCustomer.BackgroundImage = global::GUI.Properties.Resources.GuysDrinkingBeer_Preview_02;
            this.picCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCustomer.Location = new System.Drawing.Point(526, 142);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(183, 145);
            this.picCustomer.TabIndex = 5;
            this.picCustomer.TabStop = false;
            // 
            // picEmployees
            // 
            this.picEmployees.BackgroundImage = global::GUI.Properties.Resources.Coffee_Shop;
            this.picEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployees.Location = new System.Drawing.Point(113, 142);
            this.picEmployees.Name = "picEmployees";
            this.picEmployees.Size = new System.Drawing.Size(194, 145);
            this.picEmployees.TabIndex = 6;
            this.picEmployees.TabStop = false;
            this.picEmployees.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // ucProductTab
            // 
            this.ucProductTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProductTab.Location = new System.Drawing.Point(0, 34);
            this.ucProductTab.Name = "ucProductTab";
            this.ucProductTab.Size = new System.Drawing.Size(763, 558);
            this.ucProductTab.TabIndex = 1;
            this.ucProductTab.Visible = false;
            // 
            // ucOrderHistorycs1
            // 
            this.ucOrderHistorycs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOrderHistorycs1.Location = new System.Drawing.Point(0, 34);
            this.ucOrderHistorycs1.Name = "ucOrderHistorycs1";
            this.ucOrderHistorycs1.Size = new System.Drawing.Size(763, 558);
            this.ucOrderHistorycs1.TabIndex = 0;
            this.ucOrderHistorycs1.Visible = false;
            // 
            // ucEmployeeTab
            // 
            this.ucEmployeeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEmployeeTab.Location = new System.Drawing.Point(0, 34);
            this.ucEmployeeTab.Name = "ucEmployeeTab";
            this.ucEmployeeTab.Size = new System.Drawing.Size(763, 558);
            this.ucEmployeeTab.TabIndex = 0;
            this.ucEmployeeTab.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 34);
            this.panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(610, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 32);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Admin";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 629);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlShow.ResumeLayout(false);
            this.pnlShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.ImageList imgListMenuButton;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnNoti;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnOrderhistory;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ImageList imgListWindowButton;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblLogo;
        private ucOrderHistorycs ucOrderHistorycs1;
        private UserControlEmployeesTab ucEmployeeTab;
        private UserControlProductTab ucProductTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picStatistics;
        private System.Windows.Forms.PictureBox picCustomer;
        private System.Windows.Forms.PictureBox picEmployees;
        // private ucOrderHistorycs ucOrderHistorycs1;
    }
}