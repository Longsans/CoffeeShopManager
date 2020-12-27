namespace GUI
{
    partial class frmEditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCopyPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdItems = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtxDetail = new System.Windows.Forms.RichTextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblListCaption = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCopyPrice);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grdItems);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.rtxDetail);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.cbxType);
            this.panel1.Controls.Add(this.txtName1);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDetails);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblListCaption);
            this.panel1.Controls.Add(this.lblRemove);
            this.panel1.Controls.Add(this.lblAdd);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorProvider1.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorProvider2.SetError(this.panel1, resources.GetString("panel1.Error1"));
            this.errorProvider1.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding1"))));
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCopyPrice
            // 
            resources.ApplyResources(this.txtCopyPrice, "txtCopyPrice");
            this.errorProvider1.SetError(this.txtCopyPrice, resources.GetString("txtCopyPrice.Error"));
            this.errorProvider2.SetError(this.txtCopyPrice, resources.GetString("txtCopyPrice.Error1"));
            this.errorProvider1.SetIconAlignment(this.txtCopyPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCopyPrice.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.txtCopyPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCopyPrice.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.txtCopyPrice, ((int)(resources.GetObject("txtCopyPrice.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.txtCopyPrice, ((int)(resources.GetObject("txtCopyPrice.IconPadding1"))));
            this.txtCopyPrice.Name = "txtCopyPrice";
            this.txtCopyPrice.TextChanged += new System.EventHandler(this.txtCopyPrice_TextChanged);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(67)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.lblTitle);
            this.errorProvider1.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.errorProvider2.SetError(this.panel2, resources.GetString("panel2.Error1"));
            this.errorProvider1.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding1"))));
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.errorProvider1.SetError(this.btnExit, resources.GetString("btnExit.Error"));
            this.errorProvider2.SetError(this.btnExit, resources.GetString("btnExit.Error1"));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.errorProvider2.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding1"))));
            this.btnExit.Image = global::GUI.Properties.Resources.close_window_24px1;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.errorProvider1.SetError(this.lblTitle, resources.GetString("lblTitle.Error"));
            this.errorProvider2.SetError(this.lblTitle, resources.GetString("lblTitle.Error1"));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.errorProvider1.SetIconAlignment(this.lblTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTitle.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblTitle, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTitle.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblTitle, ((int)(resources.GetObject("lblTitle.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblTitle, ((int)(resources.GetObject("lblTitle.IconPadding1"))));
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
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
            this.errorProvider1.SetError(this.grdItems, resources.GetString("grdItems.Error"));
            this.errorProvider2.SetError(this.grdItems, resources.GetString("grdItems.Error1"));
            this.errorProvider1.SetIconAlignment(this.grdItems, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grdItems.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.grdItems, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grdItems.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.grdItems, ((int)(resources.GetObject("grdItems.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.grdItems, ((int)(resources.GetObject("grdItems.IconPadding1"))));
            this.grdItems.Name = "grdItems";
            this.grdItems.ReadOnly = true;
            this.grdItems.RowHeadersVisible = false;
            this.grdItems.RowTemplate.Height = 24;
            this.grdItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItems_CellContentClick);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.errorProvider2.SetError(this.btnSave, resources.GetString("btnSave.Error1"));
            this.errorProvider2.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding1"))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtxDetail
            // 
            resources.ApplyResources(this.rtxDetail, "rtxDetail");
            this.errorProvider1.SetError(this.rtxDetail, resources.GetString("rtxDetail.Error"));
            this.errorProvider2.SetError(this.rtxDetail, resources.GetString("rtxDetail.Error1"));
            this.errorProvider1.SetIconAlignment(this.rtxDetail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("rtxDetail.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.rtxDetail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("rtxDetail.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.rtxDetail, ((int)(resources.GetObject("rtxDetail.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.rtxDetail, ((int)(resources.GetObject("rtxDetail.IconPadding1"))));
            this.rtxDetail.Name = "rtxDetail";
            this.rtxDetail.TextChanged += new System.EventHandler(this.rtxDetail_TextChanged);
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.errorProvider1.SetError(this.txtPrice, resources.GetString("txtPrice.Error"));
            this.errorProvider2.SetError(this.txtPrice, resources.GetString("txtPrice.Error1"));
            this.errorProvider1.SetIconAlignment(this.txtPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPrice.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.txtPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPrice.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.txtPrice, ((int)(resources.GetObject("txtPrice.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.txtPrice, ((int)(resources.GetObject("txtPrice.IconPadding1"))));
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // cbxType
            // 
            resources.ApplyResources(this.cbxType, "cbxType");
            this.errorProvider1.SetError(this.cbxType, resources.GetString("cbxType.Error"));
            this.errorProvider2.SetError(this.cbxType, resources.GetString("cbxType.Error1"));
            this.cbxType.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.cbxType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbxType.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.cbxType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbxType.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.cbxType, ((int)(resources.GetObject("cbxType.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.cbxType, ((int)(resources.GetObject("cbxType.IconPadding1"))));
            this.cbxType.Items.AddRange(new object[] {
            resources.GetString("cbxType.Items"),
            resources.GetString("cbxType.Items1"),
            resources.GetString("cbxType.Items2")});
            this.cbxType.Name = "cbxType";
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            this.cbxType.TextChanged += new System.EventHandler(this.cbxType_TextChanged);
            // 
            // txtName1
            // 
            resources.ApplyResources(this.txtName1, "txtName1");
            this.errorProvider1.SetError(this.txtName1, resources.GetString("txtName1.Error"));
            this.errorProvider2.SetError(this.txtName1, resources.GetString("txtName1.Error1"));
            this.errorProvider1.SetIconAlignment(this.txtName1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtName1.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.txtName1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtName1.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.txtName1, ((int)(resources.GetObject("txtName1.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.txtName1, ((int)(resources.GetObject("txtName1.IconPadding1"))));
            this.txtName1.Name = "txtName1";
            this.txtName1.TextChanged += new System.EventHandler(this.txtName1_TextChanged);
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.errorProvider1.SetError(this.txtID, resources.GetString("txtID.Error"));
            this.errorProvider2.SetError(this.txtID, resources.GetString("txtID.Error1"));
            this.errorProvider1.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding1"))));
            this.txtID.Name = "txtID";
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.errorProvider2.SetError(this.btnCancel, resources.GetString("btnCancel.Error1"));
            this.errorProvider2.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding1"))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.btnBrowse, resources.GetString("btnBrowse.Error"));
            this.errorProvider2.SetError(this.btnBrowse, resources.GetString("btnBrowse.Error1"));
            this.errorProvider2.SetIconAlignment(this.btnBrowse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBrowse.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnBrowse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBrowse.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.btnBrowse, ((int)(resources.GetObject("btnBrowse.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.btnBrowse, ((int)(resources.GetObject("btnBrowse.IconPadding1"))));
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorProvider1.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.errorProvider2.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error1"));
            this.errorProvider1.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding1"))));
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDetails
            // 
            resources.ApplyResources(this.lblDetails, "lblDetails");
            this.errorProvider1.SetError(this.lblDetails, resources.GetString("lblDetails.Error"));
            this.errorProvider2.SetError(this.lblDetails, resources.GetString("lblDetails.Error1"));
            this.errorProvider1.SetIconAlignment(this.lblDetails, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDetails.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblDetails, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDetails.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblDetails, ((int)(resources.GetObject("lblDetails.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblDetails, ((int)(resources.GetObject("lblDetails.IconPadding1"))));
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Click += new System.EventHandler(this.lblDetails_Click);
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.errorProvider1.SetError(this.lblType, resources.GetString("lblType.Error"));
            this.errorProvider2.SetError(this.lblType, resources.GetString("lblType.Error1"));
            this.errorProvider1.SetIconAlignment(this.lblType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblType.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblType.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblType, ((int)(resources.GetObject("lblType.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblType, ((int)(resources.GetObject("lblType.IconPadding1"))));
            this.lblType.Name = "lblType";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblListCaption
            // 
            resources.ApplyResources(this.lblListCaption, "lblListCaption");
            this.errorProvider1.SetError(this.lblListCaption, resources.GetString("lblListCaption.Error"));
            this.errorProvider2.SetError(this.lblListCaption, resources.GetString("lblListCaption.Error1"));
            this.errorProvider1.SetIconAlignment(this.lblListCaption, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblListCaption.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblListCaption, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblListCaption.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblListCaption, ((int)(resources.GetObject("lblListCaption.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblListCaption, ((int)(resources.GetObject("lblListCaption.IconPadding1"))));
            this.lblListCaption.Name = "lblListCaption";
            this.lblListCaption.Click += new System.EventHandler(this.lblListCaption_Click);
            // 
            // lblRemove
            // 
            resources.ApplyResources(this.lblRemove, "lblRemove");
            this.lblRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.lblRemove, resources.GetString("lblRemove.Error"));
            this.errorProvider2.SetError(this.lblRemove, resources.GetString("lblRemove.Error1"));
            this.errorProvider1.SetIconAlignment(this.lblRemove, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblRemove.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblRemove, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblRemove.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblRemove, ((int)(resources.GetObject("lblRemove.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblRemove, ((int)(resources.GetObject("lblRemove.IconPadding1"))));
            this.lblRemove.Image = global::GUI.Properties.Resources.minus;
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Click += new System.EventHandler(this.lblRemove_Click);
            this.lblRemove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblRemoveFromList_MouseDown);
            this.lblRemove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblRemove_MouseUp);
            // 
            // lblAdd
            // 
            resources.ApplyResources(this.lblAdd, "lblAdd");
            this.lblAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.lblAdd, resources.GetString("lblAdd.Error"));
            this.errorProvider2.SetError(this.lblAdd, resources.GetString("lblAdd.Error1"));
            this.errorProvider1.SetIconAlignment(this.lblAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblAdd.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblAdd.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblAdd, ((int)(resources.GetObject("lblAdd.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblAdd, ((int)(resources.GetObject("lblAdd.IconPadding1"))));
            this.lblAdd.Image = global::GUI.Properties.Resources.plus_not_circle;
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            this.lblAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblRemoveFromList_MouseDown);
            this.lblAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblAdd_MouseUp);
            // 
            // lblPrice
            // 
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.errorProvider1.SetError(this.lblPrice, resources.GetString("lblPrice.Error"));
            this.errorProvider2.SetError(this.lblPrice, resources.GetString("lblPrice.Error1"));
            this.errorProvider1.SetIconAlignment(this.lblPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPrice.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPrice.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblPrice, ((int)(resources.GetObject("lblPrice.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblPrice, ((int)(resources.GetObject("lblPrice.IconPadding1"))));
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.errorProvider1.SetError(this.lblName, resources.GetString("lblName.Error"));
            this.errorProvider2.SetError(this.lblName, resources.GetString("lblName.Error1"));
            this.errorProvider1.SetIconAlignment(this.lblName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblName.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblName.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblName, ((int)(resources.GetObject("lblName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblName, ((int)(resources.GetObject("lblName.IconPadding1"))));
            this.lblName.Name = "lblName";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.errorProvider1.SetError(this.lblID, resources.GetString("lblID.Error"));
            this.errorProvider2.SetError(this.lblID, resources.GetString("lblID.Error1"));
            this.errorProvider1.SetIconAlignment(this.lblID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblID.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblID.IconAlignment1"))));
            this.errorProvider2.SetIconPadding(this.lblID, ((int)(resources.GetObject("lblID.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.lblID, ((int)(resources.GetObject("lblID.IconPadding1"))));
            this.lblID.Name = "lblID";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            resources.ApplyResources(this.errorProvider2, "errorProvider2");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // frmEditProduct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditProduct";
            this.Load += new System.EventHandler(this.frmEditProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rtxDetail;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView grdItems;
        private System.Windows.Forms.Label lblListCaption;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCopyPrice;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}