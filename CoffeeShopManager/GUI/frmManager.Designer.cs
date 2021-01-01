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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.pnlMenu.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlShow.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
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
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Name = "pnlMenu";
            // 
            // pnlChangeTab
            // 
            this.pnlChangeTab.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.pnlChangeTab, "pnlChangeTab");
            this.pnlChangeTab.Name = "pnlChangeTab";
            // 
            // btnTable
            // 
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnTable, "btnTable");
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
            this.btnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShop.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnShop, "btnShop");
            this.err.SetIconPadding(this.btnShop, ((int)(resources.GetObject("btnShop.IconPadding"))));
            this.btnShop.ImageList = this.imgListMenuButton;
            this.btnShop.Name = "btnShop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnUser, "btnUser");
            this.btnUser.ImageList = this.imgListMenuButton;
            this.btnUser.Name = "btnUser";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnStatistic, "btnStatistic");
            this.btnStatistic.ImageList = this.imgListMenuButton;
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCustomer, "btnCustomer");
            this.btnCustomer.ImageList = this.imgListMenuButton;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnReceipts
            // 
            this.btnReceipts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceipts.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnReceipts, "btnReceipts");
            this.btnReceipts.ImageList = this.imgListMenuButton;
            this.btnReceipts.Name = "btnReceipts";
            this.btnReceipts.UseVisualStyleBackColor = true;
            this.btnReceipts.Click += new System.EventHandler(this.btnReceipts_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSupplier, "btnSupplier");
            this.btnSupplier.ImageList = this.imgListMenuButton;
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnStock
            // 
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnStock, "btnStock");
            this.btnStock.ImageList = this.imgListMenuButton;
            this.btnStock.Name = "btnStock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnProduct, "btnProduct");
            this.btnProduct.ImageList = this.imgListMenuButton;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnEmployee, "btnEmployee");
            this.btnEmployee.ImageList = this.imgListMenuButton;
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(138)))), ((int)(((byte)(93)))));
            this.pnlTitleBar.Controls.Add(this.comboBox1);
            this.pnlTitleBar.Controls.Add(this.btnHome);
            this.pnlTitleBar.Controls.Add(this.btnMenu);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnCancel);
            resources.ApplyResources(this.pnlTitleBar, "pnlTitleBar");
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.pnlTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnHome, "btnHome");
            this.btnHome.FlatAppearance.BorderSize = 0;
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
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.ImageList = this.imgListWindowButton;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.ImageList = this.imgListWindowButton;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            resources.ApplyResources(this.btnMaximize, "btnMaximize");
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.ImageList = this.imgListWindowButton;
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ImageList = this.imgListWindowButton;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlShow
            // 
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
            resources.ApplyResources(this.pnlShow, "pnlShow");
            this.pnlShow.Name = "pnlShow";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblWelcome);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.Name = "lblWelcome";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            resources.ApplyResources(this.err, "err");
            // 
            // ucHome
            // 
            this.ucHome.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucHome, "ucHome");
            this.ucHome.dtoMan = null;
            this.ucHome.Name = "ucHome";
            this.ucHome.Load += new System.EventHandler(this.ucHome_Load);
            // 
            // ucTable
            // 
            this.ucTable.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucTable, "ucTable");
            this.ucTable.Name = "ucTable";
            // 
            // ucShopInfoTab
            // 
            this.ucShopInfoTab.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucShopInfoTab, "ucShopInfoTab");
            this.ucShopInfoTab.Name = "ucShopInfoTab";
            this.ucShopInfoTab.Load += new System.EventHandler(this.ucShopInfoTab_Load);
            // 
            // ucReceiptDetails
            // 
            this.ucReceiptDetails.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucReceiptDetails, "ucReceiptDetails");
            this.ucReceiptDetails.Name = "ucReceiptDetails";
            this.ucReceiptDetails.UcManReceipt = this.ucReceipts;
            // 
            // ucReceipts
            // 
            this.ucReceipts.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucReceipts, "ucReceipts");
            this.ucReceipts.Name = "ucReceipts";
            this.ucReceipts.ucRecDetails = null;
            // 
            // ucEmployeeTab
            // 
            this.ucEmployeeTab.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucEmployeeTab, "ucEmployeeTab");
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
            this.ucEmployeeTab.Name = "ucEmployeeTab";
            // 
            // ucProductTab
            // 
            this.ucProductTab.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucProductTab.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucProductTab, "ucProductTab");
            this.ucProductTab.Name = "ucProductTab";
            // 
            // ucUserTab
            // 
            this.ucUserTab.BackColor = System.Drawing.Color.White;
            this.ucUserTab.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.ucUserTab, "ucUserTab");
            this.ucUserTab.Name = "ucUserTab";
            // 
            // ucCustomersTab
            // 
            this.ucCustomersTab.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucCustomersTab, "ucCustomersTab");
            this.ucCustomersTab.frmMan = null;
            this.ucCustomersTab.Name = "ucCustomersTab";
            // 
            // ucStatisticsTab
            // 
            this.ucStatisticsTab.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.ucStatisticsTab, "ucStatisticsTab");
            this.ucStatisticsTab.Name = "ucStatisticsTab";
            // 
            // ucStockTab
            // 
            this.ucStockTab.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucStockTab, "ucStockTab");
            this.ucStockTab.frmMan = null;
            this.ucStockTab.Name = "ucStockTab";
            this.ucStockTab.ucSup = null;
            // 
            // ucSuppliersTab
            // 
            this.ucSuppliersTab.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucSuppliersTab, "ucSuppliersTab");
            this.ucSuppliersTab.frmMan = null;
            this.ucSuppliersTab.Name = "ucSuppliersTab";
            this.ucSuppliersTab.UcStock = null;
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