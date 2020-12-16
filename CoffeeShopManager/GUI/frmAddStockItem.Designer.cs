namespace GUI
{
    partial class frmAddStockItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStockItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEnterSup = new System.Windows.Forms.Label();
            this.lblAddSup = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.txtSupId = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSupName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblEnterSup);
            this.panel1.Controls.Add(this.lblAddSup);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtSupName);
            this.panel1.Controls.Add(this.txtSupId);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lblSupName);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Name = "panel1";
            // 
            // lblEnterSup
            // 
            resources.ApplyResources(this.lblEnterSup, "lblEnterSup");
            this.lblEnterSup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEnterSup.Name = "lblEnterSup";
            this.lblEnterSup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAddSup_MouseDown);
            this.lblEnterSup.MouseEnter += new System.EventHandler(this.lblEnterSup_MouseHover);
            this.lblEnterSup.MouseLeave += new System.EventHandler(this.lblEnterSup_MouseLeave);
            this.lblEnterSup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblEnterSup_MouseUp);
            // 
            // lblAddSup
            // 
            resources.ApplyResources(this.lblAddSup, "lblAddSup");
            this.lblAddSup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddSup.Name = "lblAddSup";
            this.lblAddSup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAddSup_MouseDown);
            this.lblAddSup.MouseEnter += new System.EventHandler(this.lblEnterSup_MouseHover);
            this.lblAddSup.MouseLeave += new System.EventHandler(this.lblEnterSup_MouseLeave);
            this.lblAddSup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAddSup_MouseUp);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.Name = "txtPhone";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtSupName
            // 
            resources.ApplyResources(this.txtSupName, "txtSupName");
            this.txtSupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupName.Name = "txtSupName";
            // 
            // txtSupId
            // 
            resources.ApplyResources(this.txtSupId, "txtSupId");
            this.txtSupId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupId.ForeColor = System.Drawing.Color.DimGray;
            this.txtSupId.Name = "txtSupId";
            this.txtSupId.Size = new System.Drawing.Size(142, 22);
            this.txtSupId.TabIndex = 3;
            this.txtSupId.Text = "Enter existing supplier";
            this.txtSupId.TextChanged += new System.EventHandler(this.txtSupId_TextChanged);
            // 
            // txtItemName
            // 
            resources.ApplyResources(this.txtItemName, "txtItemName");
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Validating += new System.ComponentModel.CancelEventHandler(this.txtItemName_Validating);
            // 
            // lblPhone
            // 
            resources.ApplyResources(this.lblPhone, "lblPhone");
            this.lblPhone.Name = "lblPhone";
            // 
            // lblSupName
            // 
            resources.ApplyResources(this.lblSupName, "lblSupName");
            this.lblSupName.Name = "lblSupName";
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // pnlTitleBar
            // 
            resources.ApplyResources(this.pnlTitleBar, "pnlTitleBar");
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(67)))), ((int)(((byte)(58)))));
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Controls.Add(this.label1);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.pnlTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Image = global::GUI.Properties.Resources.close_window_24px1;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddStockItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddStockItem";
            this.Load += new System.EventHandler(this.frmAddStockItem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSupId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAddSup;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label lblEnterSup;
    }
}