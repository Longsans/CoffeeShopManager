namespace CoffeeShopManager
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.imgListMenuButton = new System.Windows.Forms.ImageList(this.components);
            this.imgListWindowButton = new System.Windows.Forms.ImageList(this.components);
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnNoti = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnOrderhistory = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ucOrderHistorycs1 = new CoffeeShopManager.ucOrderHistorycs();
            this.pnlMenu.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(105)))));
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
            // pnlShow
            // 
            this.pnlShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.pnlShow.Controls.Add(this.ucOrderHistorycs1);
            this.pnlShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShow.Location = new System.Drawing.Point(221, 37);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(763, 592);
            this.pnlShow.TabIndex = 2;
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
            // ucOrderHistorycs1
            // 
            this.ucOrderHistorycs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOrderHistorycs1.Location = new System.Drawing.Point(0, 0);
            this.ucOrderHistorycs1.Name = "ucOrderHistorycs1";
            this.ucOrderHistorycs1.Size = new System.Drawing.Size(763, 592);
            this.ucOrderHistorycs1.TabIndex = 0;
            this.ucOrderHistorycs1.Visible = false;
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
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlShow.ResumeLayout(false);
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
    }
}