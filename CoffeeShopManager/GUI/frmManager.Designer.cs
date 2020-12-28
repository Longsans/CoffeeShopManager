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
            this.btnTable = new System.Windows.Forms.Button();
            this.imgListMenuButton = new System.Windows.Forms.ImageList(this.components);
            this.btnShop = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnReceipts = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.imgListWindowButton = new System.Windows.Forms.ImageList(this.components);
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.ucHome = new GUI.UserControlHome();
            this.ucTable = new GUI.UserControlTableOfManager();
            this.ucShopInfoTab = new GUI.UserControlManagerShopInfo();
            this.ucReceiptDetails = new GUI.UserControlReceiptsDetail();
            this.ucReceipts = new GUI.UserControlManagerReceiptsTab();
            this.ucEmployeeTab = new GUI.UserControlEmployeesTab();
            this.ucProductTab = new GUI.UserControlProductTab();
            this.ucUserTab = new GUI.UserControlUserTab();
            this.ucCustomersTab = new GUI.UserControlCustomers();
            this.ucStatisticsTab = new GUI.UserControlStatistics();
            this.ucStockTab = new GUI.UserControlStock();
            this.ucSuppliersTab = new GUI.UserControlSuppliers();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlShow.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.pnlMenu.Controls.Add(this.pnlChangeTab);
            this.pnlMenu.Controls.Add(this.btnTable);
            this.pnlMenu.Controls.Add(this.btnShop);
            this.pnlMenu.Controls.Add(this.btnUser);
            this.pnlMenu.Controls.Add(this.btnStatistic);
            this.pnlMenu.Controls.Add(this.btnCustomer);
            this.pnlMenu.Controls.Add(this.btnReceipts);
            this.pnlMenu.Controls.Add(this.btnSupplier);
            this.pnlMenu.Controls.Add(this.btnStock);
            this.pnlMenu.Controls.Add(this.btnProduct);
            this.pnlMenu.Controls.Add(this.btnEmployee);
            this.err.SetError(this.pnlMenu, resources.GetString("pnlMenu.Error"));
            this.err.SetIconAlignment(this.pnlMenu, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pnlMenu.IconAlignment"))));
            this.err.SetIconPadding(this.pnlMenu, ((int)(resources.GetObject("pnlMenu.IconPadding"))));
            this.pnlMenu.Name = "pnlMenu";
            // 
            // pnlChangeTab
            // 
            resources.ApplyResources(this.pnlChangeTab, "pnlChangeTab");
            this.pnlChangeTab.BackColor = System.Drawing.Color.DarkSlateGray;
            this.err.SetError(this.pnlChangeTab, resources.GetString("pnlChangeTab.Error"));
            this.err.SetIconAlignment(this.pnlChangeTab, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pnlChangeTab.IconAlignment"))));
            this.err.SetIconPadding(this.pnlChangeTab, ((int)(resources.GetObject("pnlChangeTab.IconPadding"))));
            this.pnlChangeTab.Name = "pnlChangeTab";
            // 
            // btnTable
            // 
            resources.ApplyResources(this.btnTable, "btnTable");
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err.SetError(this.btnTable, resources.GetString("btnTable.Error"));
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnTable, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnTable.IconAlignment"))));
            this.err.SetIconPadding(this.btnTable, ((int)(resources.GetObject("btnTable.IconPadding"))));
            this.btnTable.ImageList = this.imgListMenuButton;
            this.btnTable.Name = "btnTable";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
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
            this.imgListMenuButton.Images.SetKeyName(10, "shop_32px.png");
            this.imgListMenuButton.Images.SetKeyName(11, "table_32px.png");
            // 
            // btnShop
            // 
            resources.ApplyResources(this.btnShop, "btnShop");
            this.btnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err.SetError(this.btnShop, resources.GetString("btnShop.Error"));
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnShop, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnShop.IconAlignment"))));
            this.err.SetIconPadding(this.btnShop, ((int)(resources.GetObject("btnShop.IconPadding"))));
            this.btnShop.ImageList = this.imgListMenuButton;
            this.btnShop.Name = "btnShop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnUser
            // 
            resources.ApplyResources(this.btnUser, "btnUser");
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err.SetError(this.btnUser, resources.GetString("btnUser.Error"));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnUser, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnUser.IconAlignment"))));
            this.err.SetIconPadding(this.btnUser, ((int)(resources.GetObject("btnUser.IconPadding"))));
            this.btnUser.ImageList = this.imgListMenuButton;
            this.btnUser.Name = "btnUser";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnStatistic
            // 
            resources.ApplyResources(this.btnStatistic, "btnStatistic");
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err.SetError(this.btnStatistic, resources.GetString("btnStatistic.Error"));
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnStatistic, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnStatistic.IconAlignment"))));
            this.err.SetIconPadding(this.btnStatistic, ((int)(resources.GetObject("btnStatistic.IconPadding"))));
            this.btnStatistic.ImageList = this.imgListMenuButton;
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnCustomer
            // 
            resources.ApplyResources(this.btnCustomer, "btnCustomer");
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err.SetError(this.btnCustomer, resources.GetString("btnCustomer.Error"));
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnCustomer, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCustomer.IconAlignment"))));
            this.err.SetIconPadding(this.btnCustomer, ((int)(resources.GetObject("btnCustomer.IconPadding"))));
            this.btnCustomer.ImageList = this.imgListMenuButton;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnReceipts
            // 
            resources.ApplyResources(this.btnReceipts, "btnReceipts");
            this.btnReceipts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err.SetError(this.btnReceipts, resources.GetString("btnReceipts.Error"));
            this.btnReceipts.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnReceipts, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnReceipts.IconAlignment"))));
            this.err.SetIconPadding(this.btnReceipts, ((int)(resources.GetObject("btnReceipts.IconPadding"))));
            this.btnReceipts.ImageList = this.imgListMenuButton;
            this.btnReceipts.Name = "btnReceipts";
            this.btnReceipts.UseVisualStyleBackColor = true;
            this.btnReceipts.Click += new System.EventHandler(this.btnReceipts_Click);
            // 
            // btnSupplier
            // 
            resources.ApplyResources(this.btnSupplier, "btnSupplier");
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err.SetError(this.btnSupplier, resources.GetString("btnSupplier.Error"));
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnSupplier, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSupplier.IconAlignment"))));
            this.err.SetIconPadding(this.btnSupplier, ((int)(resources.GetObject("btnSupplier.IconPadding"))));
            this.btnSupplier.ImageList = this.imgListMenuButton;
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnStock
            // 
            resources.ApplyResources(this.btnStock, "btnStock");
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err.SetError(this.btnStock, resources.GetString("btnStock.Error"));
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnStock, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnStock.IconAlignment"))));
            this.err.SetIconPadding(this.btnStock, ((int)(resources.GetObject("btnStock.IconPadding"))));
            this.btnStock.ImageList = this.imgListMenuButton;
            this.btnStock.Name = "btnStock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnProduct
            // 
            resources.ApplyResources(this.btnProduct, "btnProduct");
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err.SetError(this.btnProduct, resources.GetString("btnProduct.Error"));
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnProduct, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnProduct.IconAlignment"))));
            this.err.SetIconPadding(this.btnProduct, ((int)(resources.GetObject("btnProduct.IconPadding"))));
            this.btnProduct.ImageList = this.imgListMenuButton;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnEmployee
            // 
            resources.ApplyResources(this.btnEmployee, "btnEmployee");
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err.SetError(this.btnEmployee, resources.GetString("btnEmployee.Error"));
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnEmployee, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnEmployee.IconAlignment"))));
            this.err.SetIconPadding(this.btnEmployee, ((int)(resources.GetObject("btnEmployee.IconPadding"))));
            this.btnEmployee.ImageList = this.imgListMenuButton;
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnlTitleBar
            // 
            resources.ApplyResources(this.pnlTitleBar, "pnlTitleBar");
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.pnlTitleBar.Controls.Add(this.comboBox1);
            this.pnlTitleBar.Controls.Add(this.btnHome);
            this.pnlTitleBar.Controls.Add(this.btnMenu);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnCancel);
            this.err.SetError(this.pnlTitleBar, resources.GetString("pnlTitleBar.Error"));
            this.err.SetIconAlignment(this.pnlTitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pnlTitleBar.IconAlignment"))));
            this.err.SetIconPadding(this.pnlTitleBar, ((int)(resources.GetObject("pnlTitleBar.IconPadding"))));
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.pnlTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.err.SetError(this.comboBox1, resources.GetString("comboBox1.Error"));
            this.comboBox1.FormattingEnabled = true;
            this.err.SetIconAlignment(this.comboBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox1.IconAlignment"))));
            this.err.SetIconPadding(this.comboBox1, ((int)(resources.GetObject("comboBox1.IconPadding"))));
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnHome
            // 
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err.SetError(this.btnHome, resources.GetString("btnHome.Error"));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnHome, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnHome.IconAlignment"))));
            this.err.SetIconPadding(this.btnHome, ((int)(resources.GetObject("btnHome.IconPadding"))));
            this.btnHome.ImageList = this.imgListWindowButton;
            this.btnHome.Name = "btnHome";
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
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err.SetError(this.btnMenu, resources.GetString("btnMenu.Error"));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnMenu, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnMenu.IconAlignment"))));
            this.err.SetIconPadding(this.btnMenu, ((int)(resources.GetObject("btnMenu.IconPadding"))));
            this.btnMenu.ImageList = this.imgListWindowButton;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.err.SetError(this.btnMinimize, resources.GetString("btnMinimize.Error"));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnMinimize, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnMinimize.IconAlignment"))));
            this.err.SetIconPadding(this.btnMinimize, ((int)(resources.GetObject("btnMinimize.IconPadding"))));
            this.btnMinimize.ImageList = this.imgListWindowButton;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            resources.ApplyResources(this.btnMaximize, "btnMaximize");
            this.err.SetError(this.btnMaximize, resources.GetString("btnMaximize.Error"));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnMaximize, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnMaximize.IconAlignment"))));
            this.err.SetIconPadding(this.btnMaximize, ((int)(resources.GetObject("btnMaximize.IconPadding"))));
            this.btnMaximize.ImageList = this.imgListWindowButton;
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.err.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.err.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.btnCancel.ImageList = this.imgListWindowButton;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlShow
            // 
            resources.ApplyResources(this.pnlShow, "pnlShow");
            this.pnlShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlShow.Controls.Add(this.ucHome);
            this.pnlShow.Controls.Add(this.ucTable);
            this.pnlShow.Controls.Add(this.ucShopInfoTab);
            this.pnlShow.Controls.Add(this.ucReceiptDetails);
            this.pnlShow.Controls.Add(this.ucEmployeeTab);
            this.pnlShow.Controls.Add(this.ucReceipts);
            this.pnlShow.Controls.Add(this.ucProductTab);
            this.pnlShow.Controls.Add(this.ucUserTab);
            this.pnlShow.Controls.Add(this.ucCustomersTab);
            this.pnlShow.Controls.Add(this.ucStatisticsTab);
            this.pnlShow.Controls.Add(this.ucStockTab);
            this.pnlShow.Controls.Add(this.ucSuppliersTab);
            this.pnlShow.Controls.Add(this.panel1);
            this.err.SetError(this.pnlShow, resources.GetString("pnlShow.Error"));
            this.err.SetIconAlignment(this.pnlShow, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pnlShow.IconAlignment"))));
            this.err.SetIconPadding(this.pnlShow, ((int)(resources.GetObject("pnlShow.IconPadding"))));
            this.pnlShow.Name = "pnlShow";
            // 
            // ucHome
            // 
            resources.ApplyResources(this.ucHome, "ucHome");
            this.ucHome.BackColor = System.Drawing.Color.White;
            this.ucHome.dtoMan = null;
            this.err.SetError(this.ucHome, resources.GetString("ucHome.Error"));
            this.err.SetIconAlignment(this.ucHome, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ucHome.IconAlignment"))));
            this.err.SetIconPadding(this.ucHome, ((int)(resources.GetObject("ucHome.IconPadding"))));
            this.ucHome.Name = "ucHome";
            this.ucHome.Load += new System.EventHandler(this.ucHome_Load);
            // 
            // ucTable
            // 
            resources.ApplyResources(this.ucTable, "ucTable");
            this.ucTable.BackColor = System.Drawing.Color.White;
            this.err.SetError(this.ucTable, resources.GetString("ucTable.Error"));
            this.err.SetIconAlignment(this.ucTable, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ucTable.IconAlignment"))));
            this.err.SetIconPadding(this.ucTable, ((int)(resources.GetObject("ucTable.IconPadding"))));
            this.ucTable.Name = "ucTable";
            // 
            // ucShopInfoTab
            // 
            resources.ApplyResources(this.ucShopInfoTab, "ucShopInfoTab");
            this.ucShopInfoTab.BackColor = System.Drawing.Color.White;
            this.err.SetError(this.ucShopInfoTab, resources.GetString("ucShopInfoTab.Error"));
            this.err.SetIconAlignment(this.ucShopInfoTab, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ucShopInfoTab.IconAlignment"))));
            this.err.SetIconPadding(this.ucShopInfoTab, ((int)(resources.GetObject("ucShopInfoTab.IconPadding"))));
            this.ucShopInfoTab.Name = "ucShopInfoTab";
            this.ucShopInfoTab.Load += new System.EventHandler(this.ucShopInfoTab_Load);
            // 
            // ucReceiptDetails
            // 
            resources.ApplyResources(this.ucReceiptDetails, "ucReceiptDetails");
            this.ucReceiptDetails.BackColor = System.Drawing.Color.White;
            this.err.SetError(this.ucReceiptDetails, resources.GetString("ucReceiptDetails.Error"));
            this.err.SetIconAlignment(this.ucReceiptDetails, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ucReceiptDetails.IconAlignment"))));
            this.err.SetIconPadding(this.ucReceiptDetails, ((int)(resources.GetObject("ucReceiptDetails.IconPadding"))));
            this.ucReceiptDetails.Name = "ucReceiptDetails";
            this.ucReceiptDetails.UcManReceipt = this.ucReceipts;
            // 
            // ucReceipts
            // 
            resources.ApplyResources(this.ucReceipts, "ucReceipts");
            this.ucReceipts.BackColor = System.Drawing.Color.White;
            this.err.SetError(this.ucReceipts, resources.GetString("ucReceipts.Error"));
            this.err.SetIconAlignment(this.ucReceipts, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ucReceipts.IconAlignment"))));
            this.err.SetIconPadding(this.ucReceipts, ((int)(resources.GetObject("ucReceipts.IconPadding"))));
            this.ucReceipts.Name = "ucReceipts";
            this.ucReceipts.ucRecDetails = null;
            // 
            // ucEmployeeTab
            // 
            resources.ApplyResources(this.ucEmployeeTab, "ucEmployeeTab");
            this.ucEmployeeTab.BackColor = System.Drawing.Color.White;
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
            this.err.SetError(this.ucEmployeeTab, resources.GetString("ucEmployeeTab.Error"));
            this.err.SetIconAlignment(this.ucEmployeeTab, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ucEmployeeTab.IconAlignment"))));
            this.err.SetIconPadding(this.ucEmployeeTab, ((int)(resources.GetObject("ucEmployeeTab.IconPadding"))));
            this.ucEmployeeTab.Name = "ucEmployeeTab";
            // 
            // ucProductTab
            // 
            resources.ApplyResources(this.ucProductTab, "ucProductTab");
            this.ucProductTab.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucProductTab.BackColor = System.Drawing.Color.White;
            this.err.SetError(this.ucProductTab, resources.GetString("ucProductTab.Error"));
            this.err.SetIconAlignment(this.ucProductTab, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ucProductTab.IconAlignment"))));
            this.err.SetIconPadding(this.ucProductTab, ((int)(resources.GetObject("ucProductTab.IconPadding"))));
            this.ucProductTab.Name = "ucProductTab";
            // 
            // ucUserTab
            // 
            resources.ApplyResources(this.ucUserTab, "ucUserTab");
            this.ucUserTab.BackColor = System.Drawing.Color.White;
            this.ucUserTab.Cursor = System.Windows.Forms.Cursors.Default;
            this.err.SetError(this.ucUserTab, resources.GetString("ucUserTab.Error"));
            this.err.SetIconAlignment(this.ucUserTab, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ucUserTab.IconAlignment"))));
            this.err.SetIconPadding(this.ucUserTab, ((int)(resources.GetObject("ucUserTab.IconPadding"))));
            this.ucUserTab.Name = "ucUserTab";
            // 
            // ucCustomersTab
            // 
            resources.ApplyResources(this.ucCustomersTab, "ucCustomersTab");
            this.ucCustomersTab.BackColor = System.Drawing.Color.White;
            this.err.SetError(this.ucCustomersTab, resources.GetString("ucCustomersTab.Error"));
            this.ucCustomersTab.frmMan = null;
            this.err.SetIconAlignment(this.ucCustomersTab, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ucCustomersTab.IconAlignment"))));
            this.err.SetIconPadding(this.ucCustomersTab, ((int)(resources.GetObject("ucCustomersTab.IconPadding"))));
            this.ucCustomersTab.Name = "ucCustomersTab";
            // 
            // ucStatisticsTab
            // 
            resources.ApplyResources(this.ucStatisticsTab, "ucStatisticsTab");
            this.ucStatisticsTab.BackColor = System.Drawing.Color.LavenderBlush;
            this.err.SetError(this.ucStatisticsTab, resources.GetString("ucStatisticsTab.Error"));
            this.err.SetIconAlignment(this.ucStatisticsTab, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ucStatisticsTab.IconAlignment"))));
            this.err.SetIconPadding(this.ucStatisticsTab, ((int)(resources.GetObject("ucStatisticsTab.IconPadding"))));
            this.ucStatisticsTab.Name = "ucStatisticsTab";
            // 
            // ucStockTab
            // 
            resources.ApplyResources(this.ucStockTab, "ucStockTab");
            this.ucStockTab.BackColor = System.Drawing.Color.White;
            this.err.SetError(this.ucStockTab, resources.GetString("ucStockTab.Error"));
            this.ucStockTab.frmMan = null;
            this.err.SetIconAlignment(this.ucStockTab, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ucStockTab.IconAlignment"))));
            this.err.SetIconPadding(this.ucStockTab, ((int)(resources.GetObject("ucStockTab.IconPadding"))));
            this.ucStockTab.Name = "ucStockTab";
            // 
            // ucSuppliersTab
            // 
            resources.ApplyResources(this.ucSuppliersTab, "ucSuppliersTab");
            this.ucSuppliersTab.BackColor = System.Drawing.Color.White;
            this.err.SetError(this.ucSuppliersTab, resources.GetString("ucSuppliersTab.Error"));
            this.ucSuppliersTab.frmMan = null;
            this.err.SetIconAlignment(this.ucSuppliersTab, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ucSuppliersTab.IconAlignment"))));
            this.err.SetIconPadding(this.ucSuppliersTab, ((int)(resources.GetObject("ucSuppliersTab.IconPadding"))));
            this.ucSuppliersTab.Name = "ucSuppliersTab";
            this.ucSuppliersTab.UcStock = null;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblWelcome);
            this.err.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.err.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.err.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.panel1.Name = "panel1";
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.err.SetError(this.btnLogout, resources.GetString("btnLogout.Error"));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.err.SetIconAlignment(this.btnLogout, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnLogout.IconAlignment"))));
            this.err.SetIconPadding(this.btnLogout, ((int)(resources.GetObject("btnLogout.IconPadding"))));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.err.SetError(this.lblWelcome, resources.GetString("lblWelcome.Error"));
            this.err.SetIconAlignment(this.lblWelcome, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblWelcome.IconAlignment"))));
            this.err.SetIconPadding(this.lblWelcome, ((int)(resources.GetObject("lblWelcome.IconPadding"))));
            this.lblWelcome.Name = "lblWelcome";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            resources.ApplyResources(this.err, "err");
            // 
            // frmManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlShow.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.ImageList imgListMenuButton;
        private System.Windows.Forms.Button btnUser;
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
        private UserControlHome ucHome;
        private UserControlReceiptsDetail ucReceiptDetails;
        private System.Windows.Forms.Button btnShop;
        private UserControlManagerShopInfo ucShopInfoTab;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnTable;
        private UserControlTableOfManager ucTable;
        private System.Windows.Forms.ErrorProvider err;
    }
}