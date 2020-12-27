namespace GUI
{
    partial class frmAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEmployee));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboString = new System.Windows.Forms.ComboBox();
            this.datJoin = new System.Windows.Forms.DateTimePicker();
            this.datBirth = new System.Windows.Forms.DateTimePicker();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbboxPosition = new System.Windows.Forms.ComboBox();
            this.picboxEmpImg = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errIdDeleted = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmpImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIdDeleted)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(134)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.cboString);
            this.panel2.Controls.Add(this.datJoin);
            this.panel2.Controls.Add(this.datBirth);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.cbboxPosition);
            this.panel2.Controls.Add(this.picboxEmpImg);
            this.panel2.Controls.Add(this.btnChooseImage);
            this.panel2.Controls.Add(this.radFemale);
            this.panel2.Controls.Add(this.radMale);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtSalary);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.errIdDeleted.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.errEmail.SetError(this.panel2, resources.GetString("panel2.Error1"));
            this.errorProvider1.SetError(this.panel2, resources.GetString("panel2.Error2"));
            this.errorProvider1.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.errIdDeleted.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding1"))));
            this.errEmail.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding2"))));
            this.panel2.Name = "panel2";
            // 
            // cboString
            // 
            resources.ApplyResources(this.cboString, "cboString");
            this.errIdDeleted.SetError(this.cboString, resources.GetString("cboString.Error"));
            this.errorProvider1.SetError(this.cboString, resources.GetString("cboString.Error1"));
            this.errEmail.SetError(this.cboString, resources.GetString("cboString.Error2"));
            this.cboString.FormattingEnabled = true;
            this.errEmail.SetIconAlignment(this.cboString, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cboString.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.cboString, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cboString.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.cboString, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cboString.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.cboString, ((int)(resources.GetObject("cboString.IconPadding"))));
            this.errIdDeleted.SetIconPadding(this.cboString, ((int)(resources.GetObject("cboString.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.cboString, ((int)(resources.GetObject("cboString.IconPadding2"))));
            this.cboString.Items.AddRange(new object[] {
            resources.GetString("cboString.Items"),
            resources.GetString("cboString.Items1"),
            resources.GetString("cboString.Items2"),
            resources.GetString("cboString.Items3"),
            resources.GetString("cboString.Items4"),
            resources.GetString("cboString.Items5"),
            resources.GetString("cboString.Items6"),
            resources.GetString("cboString.Items7"),
            resources.GetString("cboString.Items8"),
            resources.GetString("cboString.Items9"),
            resources.GetString("cboString.Items10"),
            resources.GetString("cboString.Items11"),
            resources.GetString("cboString.Items12"),
            resources.GetString("cboString.Items13"),
            resources.GetString("cboString.Items14"),
            resources.GetString("cboString.Items15"),
            resources.GetString("cboString.Items16"),
            resources.GetString("cboString.Items17"),
            resources.GetString("cboString.Items18"),
            resources.GetString("cboString.Items19"),
            resources.GetString("cboString.Items20"),
            resources.GetString("cboString.Items21"),
            resources.GetString("cboString.Items22"),
            resources.GetString("cboString.Items23"),
            resources.GetString("cboString.Items24")});
            this.cboString.Name = "cboString";
            // 
            // datJoin
            // 
            resources.ApplyResources(this.datJoin, "datJoin");
            this.errorProvider1.SetError(this.datJoin, resources.GetString("datJoin.Error"));
            this.errEmail.SetError(this.datJoin, resources.GetString("datJoin.Error1"));
            this.errIdDeleted.SetError(this.datJoin, resources.GetString("datJoin.Error2"));
            this.errIdDeleted.SetIconAlignment(this.datJoin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datJoin.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.datJoin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datJoin.IconAlignment1"))));
            this.errorProvider1.SetIconAlignment(this.datJoin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datJoin.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.datJoin, ((int)(resources.GetObject("datJoin.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.datJoin, ((int)(resources.GetObject("datJoin.IconPadding1"))));
            this.errIdDeleted.SetIconPadding(this.datJoin, ((int)(resources.GetObject("datJoin.IconPadding2"))));
            this.datJoin.Name = "datJoin";
            this.datJoin.ValueChanged += new System.EventHandler(this.datJoin_ValueChanged);
            // 
            // datBirth
            // 
            resources.ApplyResources(this.datBirth, "datBirth");
            this.errorProvider1.SetError(this.datBirth, resources.GetString("datBirth.Error"));
            this.errEmail.SetError(this.datBirth, resources.GetString("datBirth.Error1"));
            this.errIdDeleted.SetError(this.datBirth, resources.GetString("datBirth.Error2"));
            this.errIdDeleted.SetIconAlignment(this.datBirth, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirth.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.datBirth, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirth.IconAlignment1"))));
            this.errorProvider1.SetIconAlignment(this.datBirth, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirth.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.datBirth, ((int)(resources.GetObject("datBirth.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.datBirth, ((int)(resources.GetObject("datBirth.IconPadding1"))));
            this.errIdDeleted.SetIconPadding(this.datBirth, ((int)(resources.GetObject("datBirth.IconPadding2"))));
            this.datBirth.Name = "datBirth";
            this.datBirth.ValueChanged += new System.EventHandler(this.datBirth_ValueChanged);
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.errorProvider1.SetError(this.txtUsername, resources.GetString("txtUsername.Error"));
            this.errEmail.SetError(this.txtUsername, resources.GetString("txtUsername.Error1"));
            this.errIdDeleted.SetError(this.txtUsername, resources.GetString("txtUsername.Error2"));
            this.errEmail.SetIconAlignment(this.txtUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUsername.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUsername.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.txtUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUsername.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtUsername, ((int)(resources.GetObject("txtUsername.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtUsername, ((int)(resources.GetObject("txtUsername.IconPadding1"))));
            this.errIdDeleted.SetIconPadding(this.txtUsername, ((int)(resources.GetObject("txtUsername.IconPadding2"))));
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.errIdDeleted.SetError(this.label18, resources.GetString("label18.Error"));
            this.errEmail.SetError(this.label18, resources.GetString("label18.Error1"));
            this.errorProvider1.SetError(this.label18, resources.GetString("label18.Error2"));
            this.errEmail.SetIconAlignment(this.label18, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label18.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label18, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label18.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label18, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label18.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label18, ((int)(resources.GetObject("label18.IconPadding"))));
            this.errEmail.SetIconPadding(this.label18, ((int)(resources.GetObject("label18.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label18, ((int)(resources.GetObject("label18.IconPadding2"))));
            this.label18.Name = "label18";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errIdDeleted.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.errorProvider1.SetError(this.btnCancel, resources.GetString("btnCancel.Error1"));
            this.errEmail.SetError(this.btnCancel, resources.GetString("btnCancel.Error2"));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errEmail.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.errEmail.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding2"))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbboxPosition
            // 
            resources.ApplyResources(this.cbboxPosition, "cbboxPosition");
            this.errIdDeleted.SetError(this.cbboxPosition, resources.GetString("cbboxPosition.Error"));
            this.errorProvider1.SetError(this.cbboxPosition, resources.GetString("cbboxPosition.Error1"));
            this.errEmail.SetError(this.cbboxPosition, resources.GetString("cbboxPosition.Error2"));
            this.cbboxPosition.FormattingEnabled = true;
            this.errEmail.SetIconAlignment(this.cbboxPosition, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbboxPosition.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.cbboxPosition, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbboxPosition.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.cbboxPosition, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbboxPosition.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.cbboxPosition, ((int)(resources.GetObject("cbboxPosition.IconPadding"))));
            this.errIdDeleted.SetIconPadding(this.cbboxPosition, ((int)(resources.GetObject("cbboxPosition.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.cbboxPosition, ((int)(resources.GetObject("cbboxPosition.IconPadding2"))));
            this.cbboxPosition.Items.AddRange(new object[] {
            resources.GetString("cbboxPosition.Items"),
            resources.GetString("cbboxPosition.Items1"),
            resources.GetString("cbboxPosition.Items2"),
            resources.GetString("cbboxPosition.Items3"),
            resources.GetString("cbboxPosition.Items4"),
            resources.GetString("cbboxPosition.Items5"),
            resources.GetString("cbboxPosition.Items6")});
            this.cbboxPosition.Name = "cbboxPosition";
            this.cbboxPosition.SelectedIndexChanged += new System.EventHandler(this.cbboxPosition_SelectedIndexChanged);
            // 
            // picboxEmpImg
            // 
            resources.ApplyResources(this.picboxEmpImg, "picboxEmpImg");
            this.picboxEmpImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errIdDeleted.SetError(this.picboxEmpImg, resources.GetString("picboxEmpImg.Error"));
            this.errorProvider1.SetError(this.picboxEmpImg, resources.GetString("picboxEmpImg.Error1"));
            this.errEmail.SetError(this.picboxEmpImg, resources.GetString("picboxEmpImg.Error2"));
            this.errorProvider1.SetIconAlignment(this.picboxEmpImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picboxEmpImg.IconAlignment"))));
            this.errIdDeleted.SetIconAlignment(this.picboxEmpImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picboxEmpImg.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.picboxEmpImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picboxEmpImg.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.picboxEmpImg, ((int)(resources.GetObject("picboxEmpImg.IconPadding"))));
            this.errIdDeleted.SetIconPadding(this.picboxEmpImg, ((int)(resources.GetObject("picboxEmpImg.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.picboxEmpImg, ((int)(resources.GetObject("picboxEmpImg.IconPadding2"))));
            this.picboxEmpImg.Image = global::GUI.Properties.Resources.select_none_80px;
            this.picboxEmpImg.Name = "picboxEmpImg";
            this.picboxEmpImg.TabStop = false;
            // 
            // btnChooseImage
            // 
            resources.ApplyResources(this.btnChooseImage, "btnChooseImage");
            this.btnChooseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.errIdDeleted.SetError(this.btnChooseImage, resources.GetString("btnChooseImage.Error"));
            this.errorProvider1.SetError(this.btnChooseImage, resources.GetString("btnChooseImage.Error1"));
            this.errEmail.SetError(this.btnChooseImage, resources.GetString("btnChooseImage.Error2"));
            this.btnChooseImage.FlatAppearance.BorderSize = 0;
            this.btnChooseImage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errEmail.SetIconAlignment(this.btnChooseImage, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnChooseImage.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnChooseImage, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnChooseImage.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.btnChooseImage, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnChooseImage.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.btnChooseImage, ((int)(resources.GetObject("btnChooseImage.IconPadding"))));
            this.errEmail.SetIconPadding(this.btnChooseImage, ((int)(resources.GetObject("btnChooseImage.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.btnChooseImage, ((int)(resources.GetObject("btnChooseImage.IconPadding2"))));
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // radFemale
            // 
            resources.ApplyResources(this.radFemale, "radFemale");
            this.errorProvider1.SetError(this.radFemale, resources.GetString("radFemale.Error"));
            this.errEmail.SetError(this.radFemale, resources.GetString("radFemale.Error1"));
            this.errIdDeleted.SetError(this.radFemale, resources.GetString("radFemale.Error2"));
            this.errIdDeleted.SetIconAlignment(this.radFemale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radFemale.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.radFemale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radFemale.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.radFemale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radFemale.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.radFemale, ((int)(resources.GetObject("radFemale.IconPadding"))));
            this.errEmail.SetIconPadding(this.radFemale, ((int)(resources.GetObject("radFemale.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.radFemale, ((int)(resources.GetObject("radFemale.IconPadding2"))));
            this.radFemale.Name = "radFemale";
            this.radFemale.TabStop = true;
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            resources.ApplyResources(this.radMale, "radMale");
            this.errorProvider1.SetError(this.radMale, resources.GetString("radMale.Error"));
            this.errEmail.SetError(this.radMale, resources.GetString("radMale.Error1"));
            this.errIdDeleted.SetError(this.radMale, resources.GetString("radMale.Error2"));
            this.errIdDeleted.SetIconAlignment(this.radMale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radMale.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.radMale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radMale.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.radMale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radMale.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.radMale, ((int)(resources.GetObject("radMale.IconPadding"))));
            this.errEmail.SetIconPadding(this.radMale, ((int)(resources.GetObject("radMale.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.radMale, ((int)(resources.GetObject("radMale.IconPadding2"))));
            this.radMale.Name = "radMale";
            this.radMale.TabStop = true;
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errIdDeleted.SetError(this.btnAdd, resources.GetString("btnAdd.Error"));
            this.errorProvider1.SetError(this.btnAdd, resources.GetString("btnAdd.Error1"));
            this.errEmail.SetError(this.btnAdd, resources.GetString("btnAdd.Error2"));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errEmail.SetIconAlignment(this.btnAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAdd.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAdd.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.btnAdd, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAdd.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.btnAdd, ((int)(resources.GetObject("btnAdd.IconPadding"))));
            this.errEmail.SetIconPadding(this.btnAdd, ((int)(resources.GetObject("btnAdd.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.btnAdd, ((int)(resources.GetObject("btnAdd.IconPadding2"))));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.errorProvider1.SetError(this.txtPhone, resources.GetString("txtPhone.Error"));
            this.errEmail.SetError(this.txtPhone, resources.GetString("txtPhone.Error1"));
            this.errIdDeleted.SetError(this.txtPhone, resources.GetString("txtPhone.Error2"));
            this.errEmail.SetIconAlignment(this.txtPhone, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhone.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtPhone, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhone.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.txtPhone, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhone.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtPhone, ((int)(resources.GetObject("txtPhone.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtPhone, ((int)(resources.GetObject("txtPhone.IconPadding1"))));
            this.errIdDeleted.SetIconPadding(this.txtPhone, ((int)(resources.GetObject("txtPhone.IconPadding2"))));
            this.txtPhone.Name = "txtPhone";
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.errorProvider1.SetError(this.txtAddress, resources.GetString("txtAddress.Error"));
            this.errEmail.SetError(this.txtAddress, resources.GetString("txtAddress.Error1"));
            this.errIdDeleted.SetError(this.txtAddress, resources.GetString("txtAddress.Error2"));
            this.errEmail.SetIconAlignment(this.txtAddress, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAddress.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtAddress, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAddress.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.txtAddress, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAddress.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtAddress, ((int)(resources.GetObject("txtAddress.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtAddress, ((int)(resources.GetObject("txtAddress.IconPadding1"))));
            this.errIdDeleted.SetIconPadding(this.txtAddress, ((int)(resources.GetObject("txtAddress.IconPadding2"))));
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.errorProvider1.SetError(this.txtLastName, resources.GetString("txtLastName.Error"));
            this.errEmail.SetError(this.txtLastName, resources.GetString("txtLastName.Error1"));
            this.errIdDeleted.SetError(this.txtLastName, resources.GetString("txtLastName.Error2"));
            this.errEmail.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding1"))));
            this.errIdDeleted.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding2"))));
            this.txtLastName.Name = "txtLastName";
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.errorProvider1.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error"));
            this.errEmail.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error1"));
            this.errIdDeleted.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error2"));
            this.errEmail.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding1"))));
            this.errIdDeleted.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding2"))));
            this.txtFirstName.Name = "txtFirstName";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.errorProvider1.SetError(this.txtPassword, resources.GetString("txtPassword.Error"));
            this.errEmail.SetError(this.txtPassword, resources.GetString("txtPassword.Error1"));
            this.errIdDeleted.SetError(this.txtPassword, resources.GetString("txtPassword.Error2"));
            this.errEmail.SetIconAlignment(this.txtPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPassword.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPassword.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.txtPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPassword.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtPassword, ((int)(resources.GetObject("txtPassword.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtPassword, ((int)(resources.GetObject("txtPassword.IconPadding1"))));
            this.errIdDeleted.SetIconPadding(this.txtPassword, ((int)(resources.GetObject("txtPassword.IconPadding2"))));
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtSalary
            // 
            resources.ApplyResources(this.txtSalary, "txtSalary");
            this.errorProvider1.SetError(this.txtSalary, resources.GetString("txtSalary.Error"));
            this.errEmail.SetError(this.txtSalary, resources.GetString("txtSalary.Error1"));
            this.errIdDeleted.SetError(this.txtSalary, resources.GetString("txtSalary.Error2"));
            this.errEmail.SetIconAlignment(this.txtSalary, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSalary.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtSalary, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSalary.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.txtSalary, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSalary.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtSalary, ((int)(resources.GetObject("txtSalary.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtSalary, ((int)(resources.GetObject("txtSalary.IconPadding1"))));
            this.errIdDeleted.SetIconPadding(this.txtSalary, ((int)(resources.GetObject("txtSalary.IconPadding2"))));
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.errorProvider1.SetError(this.txtEmail, resources.GetString("txtEmail.Error"));
            this.errEmail.SetError(this.txtEmail, resources.GetString("txtEmail.Error1"));
            this.errIdDeleted.SetError(this.txtEmail, resources.GetString("txtEmail.Error2"));
            this.errEmail.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding1"))));
            this.errIdDeleted.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding2"))));
            this.txtEmail.Name = "txtEmail";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.errorProvider1.SetError(this.txtID, resources.GetString("txtID.Error"));
            this.errEmail.SetError(this.txtID, resources.GetString("txtID.Error1"));
            this.errIdDeleted.SetError(this.txtID, resources.GetString("txtID.Error2"));
            this.errEmail.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding1"))));
            this.errIdDeleted.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding2"))));
            this.txtID.Name = "txtID";
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.errIdDeleted.SetError(this.label11, resources.GetString("label11.Error"));
            this.errEmail.SetError(this.label11, resources.GetString("label11.Error1"));
            this.errorProvider1.SetError(this.label11, resources.GetString("label11.Error2"));
            this.errEmail.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding"))));
            this.errEmail.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding2"))));
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.errIdDeleted.SetError(this.label10, resources.GetString("label10.Error"));
            this.errEmail.SetError(this.label10, resources.GetString("label10.Error1"));
            this.errorProvider1.SetError(this.label10, resources.GetString("label10.Error2"));
            this.errEmail.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.errEmail.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding2"))));
            this.label10.Name = "label10";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errIdDeleted.SetError(this.label2, resources.GetString("label2.Error"));
            this.errEmail.SetError(this.label2, resources.GetString("label2.Error1"));
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error2"));
            this.errEmail.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.errEmail.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding2"))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errIdDeleted.SetError(this.label1, resources.GetString("label1.Error"));
            this.errEmail.SetError(this.label1, resources.GetString("label1.Error1"));
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error2"));
            this.errEmail.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.errEmail.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding2"))));
            this.label1.Name = "label1";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.errIdDeleted.SetError(this.label14, resources.GetString("label14.Error"));
            this.errEmail.SetError(this.label14, resources.GetString("label14.Error1"));
            this.errorProvider1.SetError(this.label14, resources.GetString("label14.Error2"));
            this.errEmail.SetIconAlignment(this.label14, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label14.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label14, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label14.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label14, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label14.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label14, ((int)(resources.GetObject("label14.IconPadding"))));
            this.errEmail.SetIconPadding(this.label14, ((int)(resources.GetObject("label14.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label14, ((int)(resources.GetObject("label14.IconPadding2"))));
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.errIdDeleted.SetError(this.label15, resources.GetString("label15.Error"));
            this.errEmail.SetError(this.label15, resources.GetString("label15.Error1"));
            this.errorProvider1.SetError(this.label15, resources.GetString("label15.Error2"));
            this.errEmail.SetIconAlignment(this.label15, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label15.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label15, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label15.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label15, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label15.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label15, ((int)(resources.GetObject("label15.IconPadding"))));
            this.errEmail.SetIconPadding(this.label15, ((int)(resources.GetObject("label15.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label15, ((int)(resources.GetObject("label15.IconPadding2"))));
            this.label15.Name = "label15";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.errIdDeleted.SetError(this.label9, resources.GetString("label9.Error"));
            this.errEmail.SetError(this.label9, resources.GetString("label9.Error1"));
            this.errorProvider1.SetError(this.label9, resources.GetString("label9.Error2"));
            this.errEmail.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.errEmail.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding2"))));
            this.label9.Name = "label9";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errIdDeleted.SetError(this.label7, resources.GetString("label7.Error"));
            this.errEmail.SetError(this.label7, resources.GetString("label7.Error1"));
            this.errorProvider1.SetError(this.label7, resources.GetString("label7.Error2"));
            this.errEmail.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.errEmail.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding2"))));
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errIdDeleted.SetError(this.label6, resources.GetString("label6.Error"));
            this.errEmail.SetError(this.label6, resources.GetString("label6.Error1"));
            this.errorProvider1.SetError(this.label6, resources.GetString("label6.Error2"));
            this.errEmail.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.errEmail.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding2"))));
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errIdDeleted.SetError(this.label5, resources.GetString("label5.Error"));
            this.errEmail.SetError(this.label5, resources.GetString("label5.Error1"));
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error2"));
            this.errEmail.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.errEmail.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding2"))));
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errIdDeleted.SetError(this.label4, resources.GetString("label4.Error"));
            this.errEmail.SetError(this.label4, resources.GetString("label4.Error1"));
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error2"));
            this.errEmail.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.errEmail.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding2"))));
            this.label4.Name = "label4";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.errIdDeleted.SetError(this.label8, resources.GetString("label8.Error"));
            this.errEmail.SetError(this.label8, resources.GetString("label8.Error1"));
            this.errorProvider1.SetError(this.label8, resources.GetString("label8.Error2"));
            this.errEmail.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.errEmail.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding2"))));
            this.label8.Name = "label8";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errIdDeleted.SetError(this.label3, resources.GetString("label3.Error"));
            this.errEmail.SetError(this.label3, resources.GetString("label3.Error1"));
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error2"));
            this.errEmail.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.errEmail.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding2"))));
            this.label3.Name = "label3";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // TitleBar
            // 
            resources.ApplyResources(this.TitleBar, "TitleBar");
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(67)))), ((int)(((byte)(58)))));
            this.TitleBar.Controls.Add(this.btnExit);
            this.errIdDeleted.SetError(this.TitleBar, resources.GetString("TitleBar.Error"));
            this.errEmail.SetError(this.TitleBar, resources.GetString("TitleBar.Error1"));
            this.errorProvider1.SetError(this.TitleBar, resources.GetString("TitleBar.Error2"));
            this.errorProvider1.SetIconAlignment(this.TitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TitleBar.IconAlignment"))));
            this.errIdDeleted.SetIconAlignment(this.TitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TitleBar.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.TitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TitleBar.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.TitleBar, ((int)(resources.GetObject("TitleBar.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.TitleBar, ((int)(resources.GetObject("TitleBar.IconPadding1"))));
            this.errEmail.SetIconPadding(this.TitleBar, ((int)(resources.GetObject("TitleBar.IconPadding2"))));
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.errIdDeleted.SetError(this.btnExit, resources.GetString("btnExit.Error"));
            this.errorProvider1.SetError(this.btnExit, resources.GetString("btnExit.Error1"));
            this.errEmail.SetError(this.btnExit, resources.GetString("btnExit.Error2"));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.errEmail.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment1"))));
            this.errIdDeleted.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment2"))));
            this.errIdDeleted.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding"))));
            this.errEmail.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding2"))));
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // errIdDeleted
            // 
            this.errIdDeleted.ContainerControl = this;
            resources.ApplyResources(this.errIdDeleted, "errIdDeleted");
            // 
            // frmAddEmployee
            // 
            this.AcceptButton = this.btnAdd;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEmployee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEmpImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIdDeleted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picboxEmpImg;
        private System.Windows.Forms.ComboBox cbboxPosition;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.DateTimePicker datJoin;
        private System.Windows.Forms.DateTimePicker datBirth;
        private System.Windows.Forms.ErrorProvider errIdDeleted;
        private System.Windows.Forms.ComboBox cboString;
    }
}