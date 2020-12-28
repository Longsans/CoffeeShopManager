namespace GUI
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.imgListMenuButton = new System.Windows.Forms.ImageList(this.components);
            this.btnMinimize = new System.Windows.Forms.Button();
            this.imgListWindowButton = new System.Windows.Forms.ImageList(this.components);
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlChangeTab = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnTables = new System.Windows.Forms.Button();
            this.btnReceipts = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.userControlOrderProduct2 = new GUI.UserControlOrderProduct();
            this.ucTable = new GUI.UserControlTable();
            this.ucManagerInfo = new GUI.UserControlManagerAndShopInfo();
            this.ucUserInfo = new GUI.UserControlEmployeeUserTab();
            this.pnlTitleBar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlShow.SuspendLayout();
            this.SuspendLayout();
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
            this.btnHome.Name = "btnHome";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.ImageList = this.imgListMenuButton;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // imgListMenuButton
            // 
            this.imgListMenuButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListMenuButton.ImageStream")));
            this.imgListMenuButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListMenuButton.Images.SetKeyName(0, "order_history_40px.png");
            this.imgListMenuButton.Images.SetKeyName(1, "table_40px.png");
            this.imgListMenuButton.Images.SetKeyName(2, "manager_40px.png");
            this.imgListMenuButton.Images.SetKeyName(3, "user_40px.png");
            this.imgListMenuButton.Images.SetKeyName(4, "menu_50px.png");
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
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.pnlMenu.Controls.Add(this.pnlChangeTab);
            this.pnlMenu.Controls.Add(this.btnUser);
            this.pnlMenu.Controls.Add(this.btnManager);
            this.pnlMenu.Controls.Add(this.btnTables);
            this.pnlMenu.Controls.Add(this.btnReceipts);
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Name = "pnlMenu";
            // 
            // pnlChangeTab
            // 
            this.pnlChangeTab.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.pnlChangeTab, "pnlChangeTab");
            this.pnlChangeTab.Name = "pnlChangeTab";
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
            // btnManager
            // 
            this.btnManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManager.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnManager, "btnManager");
            this.btnManager.ImageList = this.imgListMenuButton;
            this.btnManager.Name = "btnManager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnTables
            // 
            this.btnTables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTables.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnTables, "btnTables");
            this.btnTables.ImageList = this.imgListMenuButton;
            this.btnTables.Name = "btnTables";
            this.btnTables.UseVisualStyleBackColor = true;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
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
            // pnlShow
            // 
            this.pnlShow.Controls.Add(this.userControlOrderProduct2);
            this.pnlShow.Controls.Add(this.ucTable);
            this.pnlShow.Controls.Add(this.ucManagerInfo);
            this.pnlShow.Controls.Add(this.ucUserInfo);
            resources.ApplyResources(this.pnlShow, "pnlShow");
            this.pnlShow.Name = "pnlShow";
            // 
            // userControlOrderProduct2
            // 
            this.userControlOrderProduct2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.userControlOrderProduct2, "userControlOrderProduct2");
            this.userControlOrderProduct2.Name = "userControlOrderProduct2";
            // 
            // ucTable
            // 
            this.ucTable.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.ucTable, "ucTable");
            this.ucTable.Name = "ucTable";
            // 
            // ucManagerInfo
            // 
            resources.ApplyResources(this.ucManagerInfo, "ucManagerInfo");
            this.ucManagerInfo.Name = "ucManagerInfo";
            // 
            // ucUserInfo
            // 
            resources.ApplyResources(this.ucUserInfo, "ucUserInfo");
            this.ucUserInfo.Name = "ucUserInfo";
            // 
            // frmEmployee
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEmployee_FormClosed);
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlChangeTab;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Button btnReceipts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ImageList imgListWindowButton;
        private System.Windows.Forms.ImageList imgListMenuButton;
        private System.Windows.Forms.Panel pnlShow;
        private UserControlTable ucTable;
        private UserControlManagerAndShopInfo ucManagerInfo;
        private UserControlOrderProduct userControlOrderProduct2;
        private UserControlEmployeeUserTab ucUserInfo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}