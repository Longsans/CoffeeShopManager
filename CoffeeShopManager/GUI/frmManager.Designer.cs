namespace GUI
{
    partial class frmManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            DTO.DTO_Manager dtO_Manager1 = new DTO.DTO_Manager();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlChangeTab = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.imgListMenuButton = new System.Windows.Forms.ImageList(this.components);
            this.btnNoti = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnReceipts = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.imgListWindowButton = new System.Windows.Forms.ImageList(this.components);
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.ucHome = new GUI.UserControlHome();
            this.ucSuppliersTab = new GUI.UserControlSuppliers();
            this.ucStockTab = new GUI.UserControlStock();
            this.ucStatisticsTab = new GUI.UserControlStatistics();
            this.ucNotifications = new GUI.UserControlNotifications();
            this.ucEventsTab = new GUI.UserControlEvents();
            this.ucCustomersTab = new GUI.UserControlCustomers();
            this.ucUserTab = new GUI.UserControlUserTab();
            this.ucProductTab = new GUI.UserControlProductTab();
            this.ucReceipts = new GUI.UserControlManagerReceiptsTab();
            this.ucEmployeeTab = new GUI.UserControlEmployeesTab();
            this.ucReceiptDetails = new GUI.UserControlReceiptsDetail();
            this.pnlMenu.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlShow.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.pnlMenu.Controls.Add(this.pnlChangeTab);
            this.pnlMenu.Controls.Add(this.btnUser);
            this.pnlMenu.Controls.Add(this.btnNoti);
            this.pnlMenu.Controls.Add(this.btnEvent);
            this.pnlMenu.Controls.Add(this.btnStatistic);
            this.pnlMenu.Controls.Add(this.btnCustomer);
            this.pnlMenu.Controls.Add(this.btnReceipts);
            this.pnlMenu.Controls.Add(this.btnSupplier);
            this.pnlMenu.Controls.Add(this.btnStock);
            this.pnlMenu.Controls.Add(this.btnProduct);
            this.pnlMenu.Controls.Add(this.btnEmployee);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 37);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(221, 610);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlChangeTab
            // 
            this.pnlChangeTab.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlChangeTab.Location = new System.Drawing.Point(0, 0);
            this.pnlChangeTab.Name = "pnlChangeTab";
            this.pnlChangeTab.Size = new System.Drawing.Size(7, 50);
            this.pnlChangeTab.TabIndex = 4;
            this.pnlChangeTab.Visible = false;
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.ImageIndex = 9;
            this.btnUser.ImageList = this.imgListMenuButton;
            this.btnUser.Location = new System.Drawing.Point(0, 521);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(221, 50);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "   User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
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
            this.btnNoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoti.FlatAppearance.BorderSize = 0;
            this.btnNoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoti.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoti.ImageIndex = 8;
            this.btnNoti.ImageList = this.imgListMenuButton;
            this.btnNoti.Location = new System.Drawing.Point(0, 465);
            this.btnNoti.Name = "btnNoti";
            this.btnNoti.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnNoti.Size = new System.Drawing.Size(221, 50);
            this.btnNoti.TabIndex = 0;
            this.btnNoti.Text = "   Notifications";
            this.btnNoti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNoti.UseVisualStyleBackColor = true;
            this.btnNoti.Click += new System.EventHandler(this.btnNoti_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvent.FlatAppearance.BorderSize = 0;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvent.ImageIndex = 7;
            this.btnEvent.ImageList = this.imgListMenuButton;
            this.btnEvent.Location = new System.Drawing.Point(0, 409);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnEvent.Size = new System.Drawing.Size(221, 50);
            this.btnEvent.TabIndex = 0;
            this.btnEvent.Text = "   Events";
            this.btnEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.ImageIndex = 6;
            this.btnStatistic.ImageList = this.imgListMenuButton;
            this.btnStatistic.Location = new System.Drawing.Point(0, 344);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnStatistic.Size = new System.Drawing.Size(221, 50);
            this.btnStatistic.TabIndex = 0;
            this.btnStatistic.Text = "   Statistics";
            this.btnStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.ImageIndex = 5;
            this.btnCustomer.ImageList = this.imgListMenuButton;
            this.btnCustomer.Location = new System.Drawing.Point(0, 288);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(221, 50);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "   Customers";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnReceipts
            // 
            this.btnReceipts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceipts.FlatAppearance.BorderSize = 0;
            this.btnReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipts.ImageIndex = 4;
            this.btnReceipts.ImageList = this.imgListMenuButton;
            this.btnReceipts.Location = new System.Drawing.Point(0, 222);
            this.btnReceipts.Name = "btnReceipts";
            this.btnReceipts.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnReceipts.Size = new System.Drawing.Size(221, 50);
            this.btnReceipts.TabIndex = 0;
            this.btnReceipts.Text = "   Receipts";
            this.btnReceipts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceipts.UseVisualStyleBackColor = true;
            this.btnReceipts.Click += new System.EventHandler(this.btnReceipts_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.ImageIndex = 3;
            this.btnSupplier.ImageList = this.imgListMenuButton;
            this.btnSupplier.Location = new System.Drawing.Point(0, 166);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnSupplier.Size = new System.Drawing.Size(221, 50);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.Text = "   Suppliers";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnStock
            // 
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.ImageIndex = 2;
            this.btnStock.ImageList = this.imgListMenuButton;
            this.btnStock.Location = new System.Drawing.Point(0, 110);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(221, 50);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "   Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.ImageIndex = 1;
            this.btnProduct.ImageList = this.imgListMenuButton;
            this.btnProduct.Location = new System.Drawing.Point(0, 54);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(221, 50);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "   Products";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.ImageIndex = 0;
            this.btnEmployee.ImageList = this.imgListMenuButton;
            this.btnEmployee.Location = new System.Drawing.Point(0, -2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnEmployee.Size = new System.Drawing.Size(221, 50);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "   Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.pnlTitleBar.Controls.Add(this.btnHome);
            this.pnlTitleBar.Controls.Add(this.btnMenu);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnCancel);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1137, 37);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.pnlTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.ImageIndex = 5;
            this.btnHome.ImageList = this.imgListWindowButton;
            this.btnHome.Location = new System.Drawing.Point(70, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(245, 37);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "CoffeeShopManager";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.imgListWindowButton.Images.SetKeyName(5, "tea_cup_100px.png");
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ImageIndex = 4;
            this.btnMenu.ImageList = this.imgListWindowButton;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(70, 37);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ImageIndex = 2;
            this.btnMinimize.ImageList = this.imgListWindowButton;
            this.btnMinimize.Location = new System.Drawing.Point(1014, 0);
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
            this.btnMaximize.Location = new System.Drawing.Point(1055, 0);
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
            this.btnCancel.Location = new System.Drawing.Point(1096, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(41, 37);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlShow
            // 
            this.pnlShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlShow.Controls.Add(this.panel1);
            this.pnlShow.Controls.Add(this.ucHome);
            this.pnlShow.Controls.Add(this.ucSuppliersTab);
            this.pnlShow.Controls.Add(this.ucStockTab);
            this.pnlShow.Controls.Add(this.ucStatisticsTab);
            this.pnlShow.Controls.Add(this.ucNotifications);
            this.pnlShow.Controls.Add(this.ucEventsTab);
            this.pnlShow.Controls.Add(this.ucCustomersTab);
            this.pnlShow.Controls.Add(this.ucUserTab);
            this.pnlShow.Controls.Add(this.ucProductTab);
            this.pnlShow.Controls.Add(this.ucReceipts);
            this.pnlShow.Controls.Add(this.ucEmployeeTab);
            this.pnlShow.Controls.Add(this.ucReceiptDetails);
            this.pnlShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShow.Location = new System.Drawing.Point(221, 37);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(916, 610);
            this.pnlShow.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 34);
            this.panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(763, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 32);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(608, 8);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(128, 19);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Admin";
            // 
            // ucHome
            // 
            this.ucHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome.dtoMan = null;
            this.ucHome.Location = new System.Drawing.Point(0, 0);
            this.ucHome.Name = "ucHome";
            this.ucHome.Size = new System.Drawing.Size(916, 610);
            this.ucHome.TabIndex = 3;
            this.ucHome.Load += new System.EventHandler(this.ucHome_Load);
            // 
            // ucSuppliersTab
            // 
            this.ucSuppliersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSuppliersTab.Location = new System.Drawing.Point(0, 0);
            this.ucSuppliersTab.Name = "ucSuppliersTab";
            this.ucSuppliersTab.Size = new System.Drawing.Size(916, 610);
            this.ucSuppliersTab.TabIndex = 10;
            this.ucSuppliersTab.Visible = false;
            // 
            // ucStockTab
            // 
            this.ucStockTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStockTab.Location = new System.Drawing.Point(0, 0);
            this.ucStockTab.Name = "ucStockTab";
            this.ucStockTab.Size = new System.Drawing.Size(916, 610);
            this.ucStockTab.TabIndex = 9;
            this.ucStockTab.Visible = false;
            // 
            // ucStatisticsTab
            // 
            this.ucStatisticsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStatisticsTab.Location = new System.Drawing.Point(0, 0);
            this.ucStatisticsTab.Name = "ucStatisticsTab";
            this.ucStatisticsTab.Size = new System.Drawing.Size(916, 610);
            this.ucStatisticsTab.TabIndex = 8;
            this.ucStatisticsTab.Visible = false;
            // 
            // ucNotifications
            // 
            this.ucNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotifications.Location = new System.Drawing.Point(0, 0);
            this.ucNotifications.Name = "ucNotifications";
            this.ucNotifications.Size = new System.Drawing.Size(916, 610);
            this.ucNotifications.TabIndex = 7;
            this.ucNotifications.Visible = false;
            // 
            // ucEventsTab
            // 
            this.ucEventsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEventsTab.Location = new System.Drawing.Point(0, 0);
            this.ucEventsTab.Name = "ucEventsTab";
            this.ucEventsTab.Size = new System.Drawing.Size(916, 610);
            this.ucEventsTab.TabIndex = 6;
            this.ucEventsTab.Visible = false;
            // 
            // ucCustomersTab
            // 
            this.ucCustomersTab.BackColor = System.Drawing.Color.White;
            this.ucCustomersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCustomersTab.frmMan = null;
            this.ucCustomersTab.Location = new System.Drawing.Point(0, 0);
            this.ucCustomersTab.Name = "ucCustomersTab";
            this.ucCustomersTab.Size = new System.Drawing.Size(916, 610);
            this.ucCustomersTab.TabIndex = 5;
            this.ucCustomersTab.Visible = false;
            // 
            // ucUserTab
            // 
            this.ucUserTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucUserTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.ucUserTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUserTab.Location = new System.Drawing.Point(0, 0);
            this.ucUserTab.Name = "ucUserTab";
            this.ucUserTab.Size = new System.Drawing.Size(916, 610);
            this.ucUserTab.TabIndex = 4;
            this.ucUserTab.Visible = false;
            // 
            // ucProductTab
            // 
            this.ucProductTab.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucProductTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProductTab.Location = new System.Drawing.Point(0, 0);
            this.ucProductTab.Name = "ucProductTab";
            this.ucProductTab.Size = new System.Drawing.Size(916, 610);
            this.ucProductTab.TabIndex = 1;
            this.ucProductTab.Visible = false;
            // 
            // ucReceipts
            // 
            this.ucReceipts.BackColor = System.Drawing.Color.White;
            this.ucReceipts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReceipts.Location = new System.Drawing.Point(0, 0);
            this.ucReceipts.Name = "ucReceipts";
            this.ucReceipts.Size = new System.Drawing.Size(916, 610);
            this.ucReceipts.TabIndex = 0;
            this.ucReceipts.ucRecDetails = null;
            this.ucReceipts.Visible = false;
            // 
            // ucEmployeeTab
            // 
            this.ucEmployeeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            dtO_Manager1.Birthdate = new System.DateTime(((long)(0)));
            dtO_Manager1.Email = null;
            dtO_Manager1.Firstname = null;
            dtO_Manager1.Gender = null;
            dtO_Manager1.Id = null;
            dtO_Manager1.Image = null;
            dtO_Manager1.Lastname = null;
            dtO_Manager1.Phone = null;
            dtO_Manager1.Position = null;
            this.ucEmployeeTab.dtoMan = dtO_Manager1;
            this.ucEmployeeTab.Location = new System.Drawing.Point(0, 0);
            this.ucEmployeeTab.Name = "ucEmployeeTab";
            this.ucEmployeeTab.Size = new System.Drawing.Size(916, 610);
            this.ucEmployeeTab.TabIndex = 0;
            this.ucEmployeeTab.Visible = false;
            // 
            // ucReceiptDetails
            // 
            this.ucReceiptDetails.BackColor = System.Drawing.Color.White;
            this.ucReceiptDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucReceiptDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReceiptDetails.Location = new System.Drawing.Point(0, 0);
            this.ucReceiptDetails.Name = "ucReceiptDetails";
            this.ucReceiptDetails.Size = new System.Drawing.Size(916, 610);
            this.ucReceiptDetails.TabIndex = 11;
            this.ucReceiptDetails.UcManReceipt = this.ucReceipts;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1137, 647);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManager";
            this.Text = "frmHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlShow.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnReceipts;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ImageList imgListWindowButton;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMenu;
        private UserControlEmployeesTab ucEmployeeTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlChangeTab;
        private UserControlProductTab ucProductTab;
        private UserControlManagerReceiptsTab ucReceipts;
        private UserControlUserTab ucUserTab;
        private UserControlCustomers ucCustomersTab;
        private UserControlSuppliers ucSuppliersTab;
        private UserControlStock ucStockTab;
        private UserControlStatistics ucStatisticsTab;
        private UserControlNotifications ucNotifications;
        private UserControlEvents ucEventsTab;
        private UserControlHome ucHome;
        private UserControlReceiptsDetail ucReceiptDetails;
    }
}