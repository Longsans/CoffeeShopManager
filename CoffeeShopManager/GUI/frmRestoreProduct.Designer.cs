namespace GUI
{
    partial class frmRestoreProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestoreProduct));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdItems = new System.Windows.Forms.DataGridView();
            this.btnRestore = new System.Windows.Forms.Button();
            this.rtxDetail = new System.Windows.Forms.RichTextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblListCaption = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtType = new System.Windows.Forms.TextBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(67)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.lblTitle);
            this.errorProvider2.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.errorProvider1.SetError(this.panel2, resources.GetString("panel2.Error1"));
            this.errorProvider2.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding1"))));
            this.panel2.Name = "panel2";
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.errorProvider2.SetError(this.btnExit, resources.GetString("btnExit.Error"));
            this.errorProvider1.SetError(this.btnExit, resources.GetString("btnExit.Error1"));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.errorProvider1.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding1"))));
            this.btnExit.Image = global::GUI.Properties.Resources.close_window_24px1;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.errorProvider2.SetError(this.lblTitle, resources.GetString("lblTitle.Error"));
            this.errorProvider1.SetError(this.lblTitle, resources.GetString("lblTitle.Error1"));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.errorProvider2.SetIconAlignment(this.lblTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTitle.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTitle.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.lblTitle, ((int)(resources.GetObject("lblTitle.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblTitle, ((int)(resources.GetObject("lblTitle.IconPadding1"))));
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // grdItems
            // 
            resources.ApplyResources(this.grdItems, "grdItems");
            this.grdItems.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdItems.BackgroundColor = System.Drawing.Color.White;
            this.grdItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(171)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdItems.EnableHeadersVisualStyles = false;
            this.errorProvider2.SetError(this.grdItems, resources.GetString("grdItems.Error"));
            this.errorProvider1.SetError(this.grdItems, resources.GetString("grdItems.Error1"));
            this.errorProvider2.SetIconAlignment(this.grdItems, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grdItems.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.grdItems, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grdItems.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.grdItems, ((int)(resources.GetObject("grdItems.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.grdItems, ((int)(resources.GetObject("grdItems.IconPadding1"))));
            this.grdItems.Name = "grdItems";
            this.grdItems.ReadOnly = true;
            this.grdItems.RowHeadersVisible = false;
            this.grdItems.RowTemplate.Height = 24;
            this.grdItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnRestore
            // 
            resources.ApplyResources(this.btnRestore, "btnRestore");
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider2.SetError(this.btnRestore, resources.GetString("btnRestore.Error"));
            this.errorProvider1.SetError(this.btnRestore, resources.GetString("btnRestore.Error1"));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.errorProvider1.SetIconAlignment(this.btnRestore, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnRestore.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.btnRestore, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnRestore.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.btnRestore, ((int)(resources.GetObject("btnRestore.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnRestore, ((int)(resources.GetObject("btnRestore.IconPadding1"))));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // rtxDetail
            // 
            resources.ApplyResources(this.rtxDetail, "rtxDetail");
            this.errorProvider2.SetError(this.rtxDetail, resources.GetString("rtxDetail.Error"));
            this.errorProvider1.SetError(this.rtxDetail, resources.GetString("rtxDetail.Error1"));
            this.errorProvider2.SetIconAlignment(this.rtxDetail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("rtxDetail.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.rtxDetail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("rtxDetail.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.rtxDetail, ((int)(resources.GetObject("rtxDetail.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.rtxDetail, ((int)(resources.GetObject("rtxDetail.IconPadding1"))));
            this.rtxDetail.Name = "rtxDetail";
            this.rtxDetail.ReadOnly = true;
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorProvider2.SetError(this.txtPrice, resources.GetString("txtPrice.Error"));
            this.errorProvider1.SetError(this.txtPrice, resources.GetString("txtPrice.Error1"));
            this.errorProvider2.SetIconAlignment(this.txtPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPrice.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPrice.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.txtPrice, ((int)(resources.GetObject("txtPrice.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtPrice, ((int)(resources.GetObject("txtPrice.IconPadding1"))));
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorProvider2.SetError(this.txtName, resources.GetString("txtName.Error"));
            this.errorProvider1.SetError(this.txtName, resources.GetString("txtName.Error1"));
            this.errorProvider2.SetIconAlignment(this.txtName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtName.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtName.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.txtName, ((int)(resources.GetObject("txtName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtName, ((int)(resources.GetObject("txtName.IconPadding1"))));
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorProvider2.SetError(this.txtID, resources.GetString("txtID.Error"));
            this.errorProvider1.SetError(this.txtID, resources.GetString("txtID.Error1"));
            this.errorProvider2.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding1"))));
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider2.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.errorProvider1.SetError(this.btnCancel, resources.GetString("btnCancel.Error1"));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.errorProvider1.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding1"))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseUp);
            // 
            // picProduct
            // 
            resources.ApplyResources(this.picProduct, "picProduct");
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorProvider2.SetError(this.picProduct, resources.GetString("picProduct.Error"));
            this.errorProvider1.SetError(this.picProduct, resources.GetString("picProduct.Error1"));
            this.errorProvider2.SetIconAlignment(this.picProduct, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picProduct.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.picProduct, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picProduct.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.picProduct, ((int)(resources.GetObject("picProduct.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.picProduct, ((int)(resources.GetObject("picProduct.IconPadding1"))));
            this.picProduct.Name = "picProduct";
            this.picProduct.TabStop = false;
            // 
            // lblDetails
            // 
            resources.ApplyResources(this.lblDetails, "lblDetails");
            this.errorProvider2.SetError(this.lblDetails, resources.GetString("lblDetails.Error"));
            this.errorProvider1.SetError(this.lblDetails, resources.GetString("lblDetails.Error1"));
            this.errorProvider2.SetIconAlignment(this.lblDetails, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDetails.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblDetails, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDetails.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.lblDetails, ((int)(resources.GetObject("lblDetails.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblDetails, ((int)(resources.GetObject("lblDetails.IconPadding1"))));
            this.lblDetails.Name = "lblDetails";
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.errorProvider2.SetError(this.lblType, resources.GetString("lblType.Error"));
            this.errorProvider1.SetError(this.lblType, resources.GetString("lblType.Error1"));
            this.errorProvider2.SetIconAlignment(this.lblType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblType.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblType.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.lblType, ((int)(resources.GetObject("lblType.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblType, ((int)(resources.GetObject("lblType.IconPadding1"))));
            this.lblType.Name = "lblType";
            // 
            // lblListCaption
            // 
            resources.ApplyResources(this.lblListCaption, "lblListCaption");
            this.errorProvider2.SetError(this.lblListCaption, resources.GetString("lblListCaption.Error"));
            this.errorProvider1.SetError(this.lblListCaption, resources.GetString("lblListCaption.Error1"));
            this.errorProvider2.SetIconAlignment(this.lblListCaption, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblListCaption.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblListCaption, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblListCaption.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.lblListCaption, ((int)(resources.GetObject("lblListCaption.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblListCaption, ((int)(resources.GetObject("lblListCaption.IconPadding1"))));
            this.lblListCaption.Name = "lblListCaption";
            // 
            // lblPrice
            // 
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.errorProvider2.SetError(this.lblPrice, resources.GetString("lblPrice.Error"));
            this.errorProvider1.SetError(this.lblPrice, resources.GetString("lblPrice.Error1"));
            this.errorProvider2.SetIconAlignment(this.lblPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPrice.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPrice.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.lblPrice, ((int)(resources.GetObject("lblPrice.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblPrice, ((int)(resources.GetObject("lblPrice.IconPadding1"))));
            this.lblPrice.Name = "lblPrice";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.errorProvider2.SetError(this.lblName, resources.GetString("lblName.Error"));
            this.errorProvider1.SetError(this.lblName, resources.GetString("lblName.Error1"));
            this.errorProvider2.SetIconAlignment(this.lblName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblName.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblName.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.lblName, ((int)(resources.GetObject("lblName.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblName, ((int)(resources.GetObject("lblName.IconPadding1"))));
            this.lblName.Name = "lblName";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.errorProvider2.SetError(this.lblID, resources.GetString("lblID.Error"));
            this.errorProvider1.SetError(this.lblID, resources.GetString("lblID.Error1"));
            this.errorProvider2.SetIconAlignment(this.lblID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblID.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblID.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.lblID, ((int)(resources.GetObject("lblID.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblID, ((int)(resources.GetObject("lblID.IconPadding1"))));
            this.lblID.Name = "lblID";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grdItems);
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.rtxDetail);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.picProduct);
            this.panel1.Controls.Add(this.lblDetails);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblListCaption);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblID);
            this.errorProvider2.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorProvider1.SetError(this.panel1, resources.GetString("panel1.Error1"));
            this.errorProvider2.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding1"))));
            this.panel1.Name = "panel1";
            // 
            // txtType
            // 
            resources.ApplyResources(this.txtType, "txtType");
            this.txtType.BackColor = System.Drawing.Color.White;
            this.txtType.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorProvider2.SetError(this.txtType, resources.GetString("txtType.Error"));
            this.errorProvider1.SetError(this.txtType, resources.GetString("txtType.Error1"));
            this.errorProvider2.SetIconAlignment(this.txtType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtType.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtType.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.txtType, ((int)(resources.GetObject("txtType.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtType, ((int)(resources.GetObject("txtType.IconPadding1"))));
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            resources.ApplyResources(this.errorProvider2, "errorProvider2");
            // 
            // frmRestoreProduct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRestoreProduct";
            this.Load += new System.EventHandler(this.frmRestoreProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView grdItems;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.RichTextBox rtxDetail;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblListCaption;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txtType;
    }
}