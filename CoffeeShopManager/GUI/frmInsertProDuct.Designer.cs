﻿namespace GUI
{
    partial class frmInsertProDuct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertProDuct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCopyPrice = new System.Windows.Forms.TextBox();
            this.rtxDetail = new System.Windows.Forms.RichTextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNameDeleted = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNameDeleted)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtCopyPrice);
            this.panel1.Controls.Add(this.rtxDetail);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.cbxType);
            this.panel1.Controls.Add(this.txtName1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblDetails);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblName);
            this.errNameDeleted.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorProvider2.SetError(this.panel1, resources.GetString("panel1.Error1"));
            this.errorProvider1.SetError(this.panel1, resources.GetString("panel1.Error2"));
            this.errorProvider1.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errNameDeleted.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment1"))));
            this.errorProvider2.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment2"))));
            this.errNameDeleted.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding2"))));
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(67)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnExit);
            this.errNameDeleted.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.errorProvider2.SetError(this.panel2, resources.GetString("panel2.Error1"));
            this.errorProvider1.SetError(this.panel2, resources.GetString("panel2.Error2"));
            this.errorProvider1.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.errNameDeleted.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment1"))));
            this.errorProvider2.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment2"))));
            this.errNameDeleted.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding2"))));
            this.panel2.Name = "panel2";
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errNameDeleted.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider2.SetError(this.label1, resources.GetString("label1.Error1"));
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error2"));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.errorProvider2.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment2"))));
            this.errNameDeleted.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding2"))));
            this.label1.Name = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.errNameDeleted.SetError(this.btnExit, resources.GetString("btnExit.Error"));
            this.errorProvider1.SetError(this.btnExit, resources.GetString("btnExit.Error1"));
            this.errorProvider2.SetError(this.btnExit, resources.GetString("btnExit.Error2"));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.errorProvider2.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment2"))));
            this.errNameDeleted.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding2"))));
            this.btnExit.Image = global::GUI.Properties.Resources.close_window_24px1;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCopyPrice
            // 
            resources.ApplyResources(this.txtCopyPrice, "txtCopyPrice");
            this.errorProvider1.SetError(this.txtCopyPrice, resources.GetString("txtCopyPrice.Error"));
            this.errorProvider2.SetError(this.txtCopyPrice, resources.GetString("txtCopyPrice.Error1"));
            this.errNameDeleted.SetError(this.txtCopyPrice, resources.GetString("txtCopyPrice.Error2"));
            this.errorProvider2.SetIconAlignment(this.txtCopyPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCopyPrice.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtCopyPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCopyPrice.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.txtCopyPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCopyPrice.IconAlignment2"))));
            this.errorProvider2.SetIconPadding(this.txtCopyPrice, ((int)(resources.GetObject("txtCopyPrice.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtCopyPrice, ((int)(resources.GetObject("txtCopyPrice.IconPadding1"))));
            this.errNameDeleted.SetIconPadding(this.txtCopyPrice, ((int)(resources.GetObject("txtCopyPrice.IconPadding2"))));
            this.txtCopyPrice.Name = "txtCopyPrice";
            // 
            // rtxDetail
            // 
            resources.ApplyResources(this.rtxDetail, "rtxDetail");
            this.errNameDeleted.SetError(this.rtxDetail, resources.GetString("rtxDetail.Error"));
            this.errorProvider1.SetError(this.rtxDetail, resources.GetString("rtxDetail.Error1"));
            this.errorProvider2.SetError(this.rtxDetail, resources.GetString("rtxDetail.Error2"));
            this.errorProvider2.SetIconAlignment(this.rtxDetail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("rtxDetail.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.rtxDetail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("rtxDetail.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.rtxDetail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("rtxDetail.IconAlignment2"))));
            this.errNameDeleted.SetIconPadding(this.rtxDetail, ((int)(resources.GetObject("rtxDetail.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.rtxDetail, ((int)(resources.GetObject("rtxDetail.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.rtxDetail, ((int)(resources.GetObject("rtxDetail.IconPadding2"))));
            this.rtxDetail.Name = "rtxDetail";
            // 
            // txtPrice
            // 
            resources.ApplyResources(this.txtPrice, "txtPrice");
            this.errorProvider1.SetError(this.txtPrice, resources.GetString("txtPrice.Error"));
            this.errorProvider2.SetError(this.txtPrice, resources.GetString("txtPrice.Error1"));
            this.errNameDeleted.SetError(this.txtPrice, resources.GetString("txtPrice.Error2"));
            this.errorProvider2.SetIconAlignment(this.txtPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPrice.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPrice.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.txtPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPrice.IconAlignment2"))));
            this.errorProvider2.SetIconPadding(this.txtPrice, ((int)(resources.GetObject("txtPrice.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtPrice, ((int)(resources.GetObject("txtPrice.IconPadding1"))));
            this.errNameDeleted.SetIconPadding(this.txtPrice, ((int)(resources.GetObject("txtPrice.IconPadding2"))));
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // cbxType
            // 
            resources.ApplyResources(this.cbxType, "cbxType");
            this.errNameDeleted.SetError(this.cbxType, resources.GetString("cbxType.Error"));
            this.errorProvider1.SetError(this.cbxType, resources.GetString("cbxType.Error1"));
            this.errorProvider2.SetError(this.cbxType, resources.GetString("cbxType.Error2"));
            this.cbxType.FormattingEnabled = true;
            this.errorProvider2.SetIconAlignment(this.cbxType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbxType.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.cbxType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbxType.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.cbxType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbxType.IconAlignment2"))));
            this.errorProvider2.SetIconPadding(this.cbxType, ((int)(resources.GetObject("cbxType.IconPadding"))));
            this.errNameDeleted.SetIconPadding(this.cbxType, ((int)(resources.GetObject("cbxType.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.cbxType, ((int)(resources.GetObject("cbxType.IconPadding2"))));
            this.cbxType.Items.AddRange(new object[] {
            resources.GetString("cbxType.Items"),
            resources.GetString("cbxType.Items1"),
            resources.GetString("cbxType.Items2")});
            this.cbxType.Name = "cbxType";
            this.cbxType.TextChanged += new System.EventHandler(this.cbxType_TextChanged);
            // 
            // txtName1
            // 
            resources.ApplyResources(this.txtName1, "txtName1");
            this.errorProvider1.SetError(this.txtName1, resources.GetString("txtName1.Error"));
            this.errorProvider2.SetError(this.txtName1, resources.GetString("txtName1.Error1"));
            this.errNameDeleted.SetError(this.txtName1, resources.GetString("txtName1.Error2"));
            this.errorProvider2.SetIconAlignment(this.txtName1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtName1.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtName1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtName1.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.txtName1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtName1.IconAlignment2"))));
            this.errorProvider2.SetIconPadding(this.txtName1, ((int)(resources.GetObject("txtName1.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtName1, ((int)(resources.GetObject("txtName1.IconPadding1"))));
            this.errNameDeleted.SetIconPadding(this.txtName1, ((int)(resources.GetObject("txtName1.IconPadding2"))));
            this.txtName1.Name = "txtName1";
            this.txtName1.TextChanged += new System.EventHandler(this.txtName1_TextChanged);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errNameDeleted.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.errorProvider1.SetError(this.btnCancel, resources.GetString("btnCancel.Error1"));
            this.errorProvider2.SetError(this.btnCancel, resources.GetString("btnCancel.Error2"));
            this.errorProvider2.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment2"))));
            this.errNameDeleted.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding2"))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errNameDeleted.SetError(this.btnAdd, resources.GetString("btnAdd.Error"));
            this.errorProvider1.SetError(this.btnAdd, resources.GetString("btnAdd.Error1"));
            this.errorProvider2.SetError(this.btnAdd, resources.GetString("btnAdd.Error2"));
            this.errorProvider2.SetIconAlignment(this.btnAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAdd.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAdd.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.btnAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAdd.IconAlignment2"))));
            this.errNameDeleted.SetIconPadding(this.btnAdd, ((int)(resources.GetObject("btnAdd.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.btnAdd, ((int)(resources.GetObject("btnAdd.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.btnAdd, ((int)(resources.GetObject("btnAdd.IconPadding2"))));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errNameDeleted.SetError(this.btnBrowse, resources.GetString("btnBrowse.Error"));
            this.errorProvider1.SetError(this.btnBrowse, resources.GetString("btnBrowse.Error1"));
            this.errorProvider2.SetError(this.btnBrowse, resources.GetString("btnBrowse.Error2"));
            this.errorProvider2.SetIconAlignment(this.btnBrowse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBrowse.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnBrowse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBrowse.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.btnBrowse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBrowse.IconAlignment2"))));
            this.errNameDeleted.SetIconPadding(this.btnBrowse, ((int)(resources.GetObject("btnBrowse.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.btnBrowse, ((int)(resources.GetObject("btnBrowse.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.btnBrowse, ((int)(resources.GetObject("btnBrowse.IconPadding2"))));
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errNameDeleted.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.errorProvider1.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error1"));
            this.errorProvider2.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error2"));
            this.errorProvider1.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.errNameDeleted.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment1"))));
            this.errorProvider2.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment2"))));
            this.errorProvider2.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.errNameDeleted.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding2"))));
            this.pictureBox1.Image = global::GUI.Properties.Resources.select_none_80px;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblDetails
            // 
            resources.ApplyResources(this.lblDetails, "lblDetails");
            this.errNameDeleted.SetError(this.lblDetails, resources.GetString("lblDetails.Error"));
            this.errorProvider2.SetError(this.lblDetails, resources.GetString("lblDetails.Error1"));
            this.errorProvider1.SetError(this.lblDetails, resources.GetString("lblDetails.Error2"));
            this.errorProvider2.SetIconAlignment(this.lblDetails, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDetails.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblDetails, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDetails.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.lblDetails, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDetails.IconAlignment2"))));
            this.errNameDeleted.SetIconPadding(this.lblDetails, ((int)(resources.GetObject("lblDetails.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblDetails, ((int)(resources.GetObject("lblDetails.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.lblDetails, ((int)(resources.GetObject("lblDetails.IconPadding2"))));
            this.lblDetails.Name = "lblDetails";
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.errNameDeleted.SetError(this.lblType, resources.GetString("lblType.Error"));
            this.errorProvider2.SetError(this.lblType, resources.GetString("lblType.Error1"));
            this.errorProvider1.SetError(this.lblType, resources.GetString("lblType.Error2"));
            this.errorProvider2.SetIconAlignment(this.lblType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblType.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblType.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.lblType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblType.IconAlignment2"))));
            this.errNameDeleted.SetIconPadding(this.lblType, ((int)(resources.GetObject("lblType.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblType, ((int)(resources.GetObject("lblType.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.lblType, ((int)(resources.GetObject("lblType.IconPadding2"))));
            this.lblType.Name = "lblType";
            // 
            // lblPrice
            // 
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.errNameDeleted.SetError(this.lblPrice, resources.GetString("lblPrice.Error"));
            this.errorProvider2.SetError(this.lblPrice, resources.GetString("lblPrice.Error1"));
            this.errorProvider1.SetError(this.lblPrice, resources.GetString("lblPrice.Error2"));
            this.errorProvider2.SetIconAlignment(this.lblPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPrice.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPrice.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.lblPrice, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPrice.IconAlignment2"))));
            this.errNameDeleted.SetIconPadding(this.lblPrice, ((int)(resources.GetObject("lblPrice.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblPrice, ((int)(resources.GetObject("lblPrice.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.lblPrice, ((int)(resources.GetObject("lblPrice.IconPadding2"))));
            this.lblPrice.Name = "lblPrice";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.errNameDeleted.SetError(this.lblName, resources.GetString("lblName.Error"));
            this.errorProvider2.SetError(this.lblName, resources.GetString("lblName.Error1"));
            this.errorProvider1.SetError(this.lblName, resources.GetString("lblName.Error2"));
            this.errorProvider2.SetIconAlignment(this.lblName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblName.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.lblName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblName.IconAlignment1"))));
            this.errNameDeleted.SetIconAlignment(this.lblName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblName.IconAlignment2"))));
            this.errNameDeleted.SetIconPadding(this.lblName, ((int)(resources.GetObject("lblName.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblName, ((int)(resources.GetObject("lblName.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.lblName, ((int)(resources.GetObject("lblName.IconPadding2"))));
            this.lblName.Name = "lblName";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkRate = 300;
            this.errorProvider2.ContainerControl = this;
            resources.ApplyResources(this.errorProvider2, "errorProvider2");
            // 
            // errNameDeleted
            // 
            this.errNameDeleted.ContainerControl = this;
            resources.ApplyResources(this.errNameDeleted, "errNameDeleted");
            // 
            // frmInsertProDuct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(67)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInsertProDuct";
            this.Load += new System.EventHandler(this.frmInsertProDuct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNameDeleted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RichTextBox rtxDetail;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txtCopyPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errNameDeleted;
    }
}