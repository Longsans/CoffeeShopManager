﻿namespace GUI
{
    partial class frmEditEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditEmployees));
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCopyemail = new System.Windows.Forms.TextBox();
            this.datJoin = new System.Windows.Forms.DateTimePicker();
            this.datBirth = new System.Windows.Forms.DateTimePicker();
            this.picboxEmpImg = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.txtManagerID = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmpImg)).BeginInit();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // radFemale
            // 
            resources.ApplyResources(this.radFemale, "radFemale");
            this.errorProvider1.SetError(this.radFemale, resources.GetString("radFemale.Error"));
            this.errEmail.SetError(this.radFemale, resources.GetString("radFemale.Error1"));
            this.errEmail.SetIconAlignment(this.radFemale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radFemale.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.radFemale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radFemale.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.radFemale, ((int)(resources.GetObject("radFemale.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.radFemale, ((int)(resources.GetObject("radFemale.IconPadding1"))));
            this.radFemale.Name = "radFemale";
            this.radFemale.TabStop = true;
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            resources.ApplyResources(this.radMale, "radMale");
            this.errorProvider1.SetError(this.radMale, resources.GetString("radMale.Error"));
            this.errEmail.SetError(this.radMale, resources.GetString("radMale.Error1"));
            this.errEmail.SetIconAlignment(this.radMale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radMale.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.radMale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radMale.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.radMale, ((int)(resources.GetObject("radMale.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.radMale, ((int)(resources.GetObject("radMale.IconPadding1"))));
            this.radMale.Name = "radMale";
            this.radMale.TabStop = true;
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // btnSaveChange
            // 
            resources.ApplyResources(this.btnSaveChange, "btnSaveChange");
            this.btnSaveChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSaveChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errEmail.SetError(this.btnSaveChange, resources.GetString("btnSaveChange.Error"));
            this.errorProvider1.SetError(this.btnSaveChange, resources.GetString("btnSaveChange.Error1"));
            this.btnSaveChange.FlatAppearance.BorderSize = 0;
            this.btnSaveChange.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errorProvider1.SetIconAlignment(this.btnSaveChange, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSaveChange.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.btnSaveChange, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSaveChange.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.btnSaveChange, ((int)(resources.GetObject("btnSaveChange.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnSaveChange, ((int)(resources.GetObject("btnSaveChange.IconPadding1"))));
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.UseVisualStyleBackColor = false;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.errEmail.SetError(this.txtPhone, resources.GetString("txtPhone.Error"));
            this.errorProvider1.SetError(this.txtPhone, resources.GetString("txtPhone.Error1"));
            this.errEmail.SetIconAlignment(this.txtPhone, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhone.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtPhone, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhone.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.txtPhone, ((int)(resources.GetObject("txtPhone.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtPhone, ((int)(resources.GetObject("txtPhone.IconPadding1"))));
            this.txtPhone.Name = "txtPhone";
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.errEmail.SetError(this.txtAddress, resources.GetString("txtAddress.Error"));
            this.errorProvider1.SetError(this.txtAddress, resources.GetString("txtAddress.Error1"));
            this.errEmail.SetIconAlignment(this.txtAddress, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAddress.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtAddress, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAddress.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.txtAddress, ((int)(resources.GetObject("txtAddress.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtAddress, ((int)(resources.GetObject("txtAddress.IconPadding1"))));
            this.txtAddress.Name = "txtAddress";
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.errEmail.SetError(this.txtLastName, resources.GetString("txtLastName.Error"));
            this.errorProvider1.SetError(this.txtLastName, resources.GetString("txtLastName.Error1"));
            this.errEmail.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding1"))));
            this.txtLastName.Name = "txtLastName";
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.errEmail.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error"));
            this.errorProvider1.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error1"));
            this.errEmail.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding1"))));
            this.txtFirstName.Name = "txtFirstName";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(134)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.txtCopyemail);
            this.panel2.Controls.Add(this.datJoin);
            this.panel2.Controls.Add(this.datBirth);
            this.panel2.Controls.Add(this.picboxEmpImg);
            this.panel2.Controls.Add(this.btnChooseImage);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.cboPosition);
            this.panel2.Controls.Add(this.radFemale);
            this.panel2.Controls.Add(this.radMale);
            this.panel2.Controls.Add(this.btnSaveChange);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.txtManagerID);
            this.panel2.Controls.Add(this.txtSalary);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.errEmail.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.errorProvider1.SetError(this.panel2, resources.GetString("panel2.Error1"));
            this.errEmail.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.errEmail.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding1"))));
            this.panel2.Name = "panel2";
            // 
            // txtCopyemail
            // 
            resources.ApplyResources(this.txtCopyemail, "txtCopyemail");
            this.errEmail.SetError(this.txtCopyemail, resources.GetString("txtCopyemail.Error"));
            this.errorProvider1.SetError(this.txtCopyemail, resources.GetString("txtCopyemail.Error1"));
            this.errEmail.SetIconAlignment(this.txtCopyemail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCopyemail.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtCopyemail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCopyemail.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.txtCopyemail, ((int)(resources.GetObject("txtCopyemail.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtCopyemail, ((int)(resources.GetObject("txtCopyemail.IconPadding1"))));
            this.txtCopyemail.Name = "txtCopyemail";
            // 
            // datJoin
            // 
            resources.ApplyResources(this.datJoin, "datJoin");
            this.errEmail.SetError(this.datJoin, resources.GetString("datJoin.Error"));
            this.errorProvider1.SetError(this.datJoin, resources.GetString("datJoin.Error1"));
            this.errEmail.SetIconAlignment(this.datJoin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datJoin.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.datJoin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datJoin.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.datJoin, ((int)(resources.GetObject("datJoin.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.datJoin, ((int)(resources.GetObject("datJoin.IconPadding1"))));
            this.datJoin.Name = "datJoin";
            this.datJoin.ValueChanged += new System.EventHandler(this.datJoin_ValueChanged);
            // 
            // datBirth
            // 
            resources.ApplyResources(this.datBirth, "datBirth");
            this.errEmail.SetError(this.datBirth, resources.GetString("datBirth.Error"));
            this.errorProvider1.SetError(this.datBirth, resources.GetString("datBirth.Error1"));
            this.errEmail.SetIconAlignment(this.datBirth, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirth.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.datBirth, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirth.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.datBirth, ((int)(resources.GetObject("datBirth.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.datBirth, ((int)(resources.GetObject("datBirth.IconPadding1"))));
            this.datBirth.Name = "datBirth";
            this.datBirth.ValueChanged += new System.EventHandler(this.datBirth_ValueChanged);
            // 
            // picboxEmpImg
            // 
            resources.ApplyResources(this.picboxEmpImg, "picboxEmpImg");
            this.picboxEmpImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errEmail.SetError(this.picboxEmpImg, resources.GetString("picboxEmpImg.Error"));
            this.errorProvider1.SetError(this.picboxEmpImg, resources.GetString("picboxEmpImg.Error1"));
            this.errEmail.SetIconAlignment(this.picboxEmpImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picboxEmpImg.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.picboxEmpImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picboxEmpImg.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.picboxEmpImg, ((int)(resources.GetObject("picboxEmpImg.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.picboxEmpImg, ((int)(resources.GetObject("picboxEmpImg.IconPadding1"))));
            this.picboxEmpImg.Name = "picboxEmpImg";
            this.picboxEmpImg.TabStop = false;
            // 
            // btnChooseImage
            // 
            resources.ApplyResources(this.btnChooseImage, "btnChooseImage");
            this.btnChooseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.errEmail.SetError(this.btnChooseImage, resources.GetString("btnChooseImage.Error"));
            this.errorProvider1.SetError(this.btnChooseImage, resources.GetString("btnChooseImage.Error1"));
            this.btnChooseImage.FlatAppearance.BorderSize = 0;
            this.btnChooseImage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errorProvider1.SetIconAlignment(this.btnChooseImage, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnChooseImage.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.btnChooseImage, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnChooseImage.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.btnChooseImage, ((int)(resources.GetObject("btnChooseImage.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnChooseImage, ((int)(resources.GetObject("btnChooseImage.IconPadding1"))));
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errEmail.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.errorProvider1.SetError(this.btnCancel, resources.GetString("btnCancel.Error1"));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errorProvider1.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding1"))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboPosition
            // 
            resources.ApplyResources(this.cboPosition, "cboPosition");
            this.errEmail.SetError(this.cboPosition, resources.GetString("cboPosition.Error"));
            this.errorProvider1.SetError(this.cboPosition, resources.GetString("cboPosition.Error1"));
            this.cboPosition.FormattingEnabled = true;
            this.errEmail.SetIconAlignment(this.cboPosition, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cboPosition.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.cboPosition, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cboPosition.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.cboPosition, ((int)(resources.GetObject("cboPosition.IconPadding"))));
            this.errEmail.SetIconPadding(this.cboPosition, ((int)(resources.GetObject("cboPosition.IconPadding1"))));
            this.cboPosition.Items.AddRange(new object[] {
            resources.GetString("cboPosition.Items"),
            resources.GetString("cboPosition.Items1"),
            resources.GetString("cboPosition.Items2"),
            resources.GetString("cboPosition.Items3"),
            resources.GetString("cboPosition.Items4"),
            resources.GetString("cboPosition.Items5"),
            resources.GetString("cboPosition.Items6")});
            this.cboPosition.Name = "cboPosition";
            // 
            // txtManagerID
            // 
            resources.ApplyResources(this.txtManagerID, "txtManagerID");
            this.errEmail.SetError(this.txtManagerID, resources.GetString("txtManagerID.Error"));
            this.errorProvider1.SetError(this.txtManagerID, resources.GetString("txtManagerID.Error1"));
            this.errEmail.SetIconAlignment(this.txtManagerID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtManagerID.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtManagerID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtManagerID.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.txtManagerID, ((int)(resources.GetObject("txtManagerID.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtManagerID, ((int)(resources.GetObject("txtManagerID.IconPadding1"))));
            this.txtManagerID.Name = "txtManagerID";
            this.txtManagerID.TextChanged += new System.EventHandler(this.txtManagerID_TextChanged);
            // 
            // txtSalary
            // 
            resources.ApplyResources(this.txtSalary, "txtSalary");
            this.errEmail.SetError(this.txtSalary, resources.GetString("txtSalary.Error"));
            this.errorProvider1.SetError(this.txtSalary, resources.GetString("txtSalary.Error1"));
            this.errEmail.SetIconAlignment(this.txtSalary, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSalary.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtSalary, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSalary.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.txtSalary, ((int)(resources.GetObject("txtSalary.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtSalary, ((int)(resources.GetObject("txtSalary.IconPadding1"))));
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.errEmail.SetError(this.txtEmail, resources.GetString("txtEmail.Error"));
            this.errorProvider1.SetError(this.txtEmail, resources.GetString("txtEmail.Error1"));
            this.errEmail.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding1"))));
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Cursor = System.Windows.Forms.Cursors.No;
            this.errEmail.SetError(this.txtID, resources.GetString("txtID.Error"));
            this.errorProvider1.SetError(this.txtID, resources.GetString("txtID.Error1"));
            this.errEmail.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding1"))));
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.errEmail.SetError(this.label9, resources.GetString("label9.Error"));
            this.errorProvider1.SetError(this.label9, resources.GetString("label9.Error1"));
            this.errEmail.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.errEmail.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding1"))));
            this.label9.Name = "label9";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.errEmail.SetError(this.label11, resources.GetString("label11.Error"));
            this.errorProvider1.SetError(this.label11, resources.GetString("label11.Error1"));
            this.errEmail.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding"))));
            this.errEmail.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding1"))));
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.errEmail.SetError(this.label10, resources.GetString("label10.Error"));
            this.errorProvider1.SetError(this.label10, resources.GetString("label10.Error1"));
            this.errEmail.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.errEmail.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding1"))));
            this.label10.Name = "label10";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errEmail.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error1"));
            this.errEmail.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.errEmail.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding1"))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errEmail.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error1"));
            this.errEmail.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.errEmail.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding1"))));
            this.label1.Name = "label1";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.errEmail.SetError(this.label14, resources.GetString("label14.Error"));
            this.errorProvider1.SetError(this.label14, resources.GetString("label14.Error1"));
            this.errEmail.SetIconAlignment(this.label14, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label14.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label14, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label14.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.label14, ((int)(resources.GetObject("label14.IconPadding"))));
            this.errEmail.SetIconPadding(this.label14, ((int)(resources.GetObject("label14.IconPadding1"))));
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.errEmail.SetError(this.label15, resources.GetString("label15.Error"));
            this.errorProvider1.SetError(this.label15, resources.GetString("label15.Error1"));
            this.errEmail.SetIconAlignment(this.label15, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label15.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label15, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label15.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.label15, ((int)(resources.GetObject("label15.IconPadding"))));
            this.errEmail.SetIconPadding(this.label15, ((int)(resources.GetObject("label15.IconPadding1"))));
            this.label15.Name = "label15";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errEmail.SetError(this.label7, resources.GetString("label7.Error"));
            this.errorProvider1.SetError(this.label7, resources.GetString("label7.Error1"));
            this.errEmail.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.errEmail.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding1"))));
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errEmail.SetError(this.label6, resources.GetString("label6.Error"));
            this.errorProvider1.SetError(this.label6, resources.GetString("label6.Error1"));
            this.errEmail.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.errEmail.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding1"))));
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errEmail.SetError(this.label5, resources.GetString("label5.Error"));
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error1"));
            this.errEmail.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.errEmail.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding1"))));
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errEmail.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error1"));
            this.errEmail.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.errEmail.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding1"))));
            this.label4.Name = "label4";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.errEmail.SetError(this.label8, resources.GetString("label8.Error"));
            this.errorProvider1.SetError(this.label8, resources.GetString("label8.Error1"));
            this.errEmail.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.errEmail.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding1"))));
            this.label8.Name = "label8";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errEmail.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error1"));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.errEmail.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.errEmail.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding1"))));
            this.label3.Name = "label3";
            // 
            // TitleBar
            // 
            resources.ApplyResources(this.TitleBar, "TitleBar");
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(67)))), ((int)(((byte)(58)))));
            this.TitleBar.Controls.Add(this.btnExit);
            this.TitleBar.Controls.Add(this.label3);
            this.errEmail.SetError(this.TitleBar, resources.GetString("TitleBar.Error"));
            this.errorProvider1.SetError(this.TitleBar, resources.GetString("TitleBar.Error1"));
            this.errEmail.SetIconAlignment(this.TitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TitleBar.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.TitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TitleBar.IconAlignment1"))));
            this.errorProvider1.SetIconPadding(this.TitleBar, ((int)(resources.GetObject("TitleBar.IconPadding"))));
            this.errEmail.SetIconPadding(this.TitleBar, ((int)(resources.GetObject("TitleBar.IconPadding1"))));
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.errEmail.SetError(this.btnExit, resources.GetString("btnExit.Error"));
            this.errorProvider1.SetError(this.btnExit, resources.GetString("btnExit.Error1"));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.errorProvider1.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment1"))));
            this.errEmail.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding1"))));
            this.btnExit.Image = global::GUI.Properties.Resources.close_window_24px1;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            resources.ApplyResources(this.errEmail, "errEmail");
            // 
            // frmEditEmployees
            // 
            this.AcceptButton = this.btnSaveChange;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditEmployees";
            this.Load += new System.EventHandler(this.frmEditEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmpImg)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picboxEmpImg;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtManagerID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.DateTimePicker datBirth;
        private System.Windows.Forms.DateTimePicker datJoin;
        private System.Windows.Forms.TextBox txtCopyemail;
    }
}