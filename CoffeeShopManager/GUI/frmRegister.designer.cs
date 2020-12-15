namespace GUI
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblShopName = new System.Windows.Forms.Label();
            this.lblAuthCode = new System.Windows.Forms.Label();
            this.fpnlCreateNew = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblShopId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtShopId = new System.Windows.Forms.TextBox();
            this.txtAuthCode = new System.Windows.Forms.TextBox();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBrowseImg = new System.Windows.Forms.Button();
            this.lblNoImg = new System.Windows.Forms.Label();
            this.picboxManImg = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYearBD = new System.Windows.Forms.TextBox();
            this.txtMonthBD = new System.Windows.Forms.TextBox();
            this.txtDayBD = new System.Windows.Forms.TextBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.fpnlCreateNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxManImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            resources.ApplyResources(this.TitleBar, "TitleBar");
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(67)))), ((int)(((byte)(58)))));
            this.TitleBar.Controls.Add(this.btnExit);
            this.errorProvider1.SetError(this.TitleBar, resources.GetString("TitleBar.Error"));
            this.errorProvider1.SetIconAlignment(this.TitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TitleBar.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.TitleBar, ((int)(resources.GetObject("TitleBar.IconPadding"))));
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.errorProvider1.SetError(this.btnExit, resources.GetString("btnExit.Error"));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.errorProvider1.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding"))));
            this.btnExit.Image = global::GUI.Properties.Resources.close_window_24px1;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(134)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblShopName);
            this.panel1.Controls.Add(this.lblAuthCode);
            this.panel1.Controls.Add(this.fpnlCreateNew);
            this.panel1.Controls.Add(this.lblShopId);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtShopId);
            this.panel1.Controls.Add(this.txtAuthCode);
            this.panel1.Controls.Add(this.txtShopName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnBrowseImg);
            this.panel1.Controls.Add(this.lblNoImg);
            this.panel1.Controls.Add(this.picboxManImg);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtYearBD);
            this.panel1.Controls.Add(this.txtMonthBD);
            this.panel1.Controls.Add(this.txtDayBD);
            this.panel1.Controls.Add(this.radFemale);
            this.panel1.Controls.Add(this.radMale);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.lblBirthdate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnExit2);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Controls.Add(this.txtConfirm);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.errorProvider1.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorProvider1.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.panel1.Name = "panel1";
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.btnBack, resources.GetString("btnBack.Error"));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.errorProvider1.SetIconAlignment(this.btnBack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBack.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnBack, ((int)(resources.GetObject("btnBack.IconPadding"))));
            this.btnBack.Image = global::GUI.Properties.Resources.back_32px;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblShopName
            // 
            resources.ApplyResources(this.lblShopName, "lblShopName");
            this.errorProvider1.SetError(this.lblShopName, resources.GetString("lblShopName.Error"));
            this.errorProvider1.SetIconAlignment(this.lblShopName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblShopName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblShopName, ((int)(resources.GetObject("lblShopName.IconPadding"))));
            this.lblShopName.Name = "lblShopName";
            // 
            // lblAuthCode
            // 
            resources.ApplyResources(this.lblAuthCode, "lblAuthCode");
            this.errorProvider1.SetError(this.lblAuthCode, resources.GetString("lblAuthCode.Error"));
            this.errorProvider1.SetIconAlignment(this.lblAuthCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblAuthCode.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblAuthCode, ((int)(resources.GetObject("lblAuthCode.IconPadding"))));
            this.lblAuthCode.Name = "lblAuthCode";
            // 
            // fpnlCreateNew
            // 
            resources.ApplyResources(this.fpnlCreateNew, "fpnlCreateNew");
            this.fpnlCreateNew.BackColor = System.Drawing.Color.White;
            this.fpnlCreateNew.Controls.Add(this.pictureBox2);
            this.fpnlCreateNew.Controls.Add(this.label15);
            this.fpnlCreateNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.fpnlCreateNew, resources.GetString("fpnlCreateNew.Error"));
            this.errorProvider1.SetIconAlignment(this.fpnlCreateNew, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("fpnlCreateNew.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.fpnlCreateNew, ((int)(resources.GetObject("fpnlCreateNew.IconPadding"))));
            this.fpnlCreateNew.Name = "fpnlCreateNew";
            this.fpnlCreateNew.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.add_new_30px;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.pictureBox2, resources.GetString("pictureBox2.Error"));
            this.errorProvider1.SetIconAlignment(this.pictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.pictureBox2, ((int)(resources.GetObject("pictureBox2.IconPadding"))));
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.label15, resources.GetString("label15.Error"));
            this.errorProvider1.SetIconAlignment(this.label15, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label15.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label15, ((int)(resources.GetObject("label15.IconPadding"))));
            this.label15.Name = "label15";
            this.label15.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblShopId
            // 
            resources.ApplyResources(this.lblShopId, "lblShopId");
            this.errorProvider1.SetError(this.lblShopId, resources.GetString("lblShopId.Error"));
            this.errorProvider1.SetIconAlignment(this.lblShopId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblShopId.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblShopId, ((int)(resources.GetObject("lblShopId.IconPadding"))));
            this.lblShopId.Name = "lblShopId";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.errorProvider1.SetError(this.label11, resources.GetString("label11.Error"));
            this.errorProvider1.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding"))));
            this.label11.Name = "label11";
            // 
            // txtShopId
            // 
            resources.ApplyResources(this.txtShopId, "txtShopId");
            this.errorProvider1.SetError(this.txtShopId, resources.GetString("txtShopId.Error"));
            this.txtShopId.ForeColor = System.Drawing.Color.DimGray;
            this.errorProvider1.SetIconAlignment(this.txtShopId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtShopId.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtShopId, ((int)(resources.GetObject("txtShopId.IconPadding"))));
            this.txtShopId.Name = "txtShopId";
            this.txtShopId.TextChanged += new System.EventHandler(this.txtShopId_TextChanged);
            // 
            // txtAuthCode
            // 
            resources.ApplyResources(this.txtAuthCode, "txtAuthCode");
            this.errorProvider1.SetError(this.txtAuthCode, resources.GetString("txtAuthCode.Error"));
            this.txtAuthCode.ForeColor = System.Drawing.Color.DimGray;
            this.errorProvider1.SetIconAlignment(this.txtAuthCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAuthCode.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtAuthCode, ((int)(resources.GetObject("txtAuthCode.IconPadding"))));
            this.txtAuthCode.Name = "txtAuthCode";
            this.txtAuthCode.TextChanged += new System.EventHandler(this.txtAuthCode_TextChanged);
            // 
            // txtShopName
            // 
            resources.ApplyResources(this.txtShopName, "txtShopName");
            this.errorProvider1.SetError(this.txtShopName, resources.GetString("txtShopName.Error"));
            this.txtShopName.ForeColor = System.Drawing.Color.DimGray;
            this.errorProvider1.SetIconAlignment(this.txtShopName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtShopName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtShopName, ((int)(resources.GetObject("txtShopName.IconPadding"))));
            this.txtShopName.Name = "txtShopName";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.errorProvider1.SetError(this.txtID, resources.GetString("txtID.Error"));
            this.errorProvider1.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding"))));
            this.txtID.Name = "txtID";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.errorProvider1.SetError(this.label8, resources.GetString("label8.Error"));
            this.errorProvider1.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.label8.Name = "label8";
            // 
            // btnBrowseImg
            // 
            resources.ApplyResources(this.btnBrowseImg, "btnBrowseImg");
            this.btnBrowseImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBrowseImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.btnBrowseImg, resources.GetString("btnBrowseImg.Error"));
            this.btnBrowseImg.FlatAppearance.BorderSize = 0;
            this.btnBrowseImg.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errorProvider1.SetIconAlignment(this.btnBrowseImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBrowseImg.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnBrowseImg, ((int)(resources.GetObject("btnBrowseImg.IconPadding"))));
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.UseVisualStyleBackColor = false;
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // lblNoImg
            // 
            resources.ApplyResources(this.lblNoImg, "lblNoImg");
            this.errorProvider1.SetError(this.lblNoImg, resources.GetString("lblNoImg.Error"));
            this.errorProvider1.SetIconAlignment(this.lblNoImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNoImg.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblNoImg, ((int)(resources.GetObject("lblNoImg.IconPadding"))));
            this.lblNoImg.Name = "lblNoImg";
            // 
            // picboxManImg
            // 
            resources.ApplyResources(this.picboxManImg, "picboxManImg");
            this.picboxManImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorProvider1.SetError(this.picboxManImg, resources.GetString("picboxManImg.Error"));
            this.errorProvider1.SetIconAlignment(this.picboxManImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picboxManImg.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.picboxManImg, ((int)(resources.GetObject("picboxManImg.IconPadding"))));
            this.picboxManImg.Name = "picboxManImg";
            this.picboxManImg.TabStop = false;
            this.picboxManImg.Tag = "";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.errorProvider1.SetError(this.label13, resources.GetString("label13.Error"));
            this.errorProvider1.SetIconAlignment(this.label13, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label13.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label13, ((int)(resources.GetObject("label13.IconPadding"))));
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.errorProvider1.SetError(this.label12, resources.GetString("label12.Error"));
            this.errorProvider1.SetIconAlignment(this.label12, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label12.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label12, ((int)(resources.GetObject("label12.IconPadding"))));
            this.label12.Name = "label12";
            // 
            // txtYearBD
            // 
            resources.ApplyResources(this.txtYearBD, "txtYearBD");
            this.errorProvider1.SetError(this.txtYearBD, resources.GetString("txtYearBD.Error"));
            this.errorProvider1.SetIconAlignment(this.txtYearBD, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtYearBD.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtYearBD, ((int)(resources.GetObject("txtYearBD.IconPadding"))));
            this.txtYearBD.Name = "txtYearBD";
            // 
            // txtMonthBD
            // 
            resources.ApplyResources(this.txtMonthBD, "txtMonthBD");
            this.errorProvider1.SetError(this.txtMonthBD, resources.GetString("txtMonthBD.Error"));
            this.errorProvider1.SetIconAlignment(this.txtMonthBD, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtMonthBD.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtMonthBD, ((int)(resources.GetObject("txtMonthBD.IconPadding"))));
            this.txtMonthBD.Name = "txtMonthBD";
            // 
            // txtDayBD
            // 
            resources.ApplyResources(this.txtDayBD, "txtDayBD");
            this.errorProvider1.SetError(this.txtDayBD, resources.GetString("txtDayBD.Error"));
            this.errorProvider1.SetIconAlignment(this.txtDayBD, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtDayBD.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtDayBD, ((int)(resources.GetObject("txtDayBD.IconPadding"))));
            this.txtDayBD.Name = "txtDayBD";
            // 
            // radFemale
            // 
            resources.ApplyResources(this.radFemale, "radFemale");
            this.errorProvider1.SetError(this.radFemale, resources.GetString("radFemale.Error"));
            this.errorProvider1.SetIconAlignment(this.radFemale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radFemale.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.radFemale, ((int)(resources.GetObject("radFemale.IconPadding"))));
            this.radFemale.Name = "radFemale";
            this.radFemale.TabStop = true;
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            resources.ApplyResources(this.radMale, "radMale");
            this.errorProvider1.SetError(this.radMale, resources.GetString("radMale.Error"));
            this.errorProvider1.SetIconAlignment(this.radMale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radMale.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.radMale, ((int)(resources.GetObject("radMale.IconPadding"))));
            this.radMale.Name = "radMale";
            this.radMale.TabStop = true;
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.errorProvider1.SetError(this.txtEmail, resources.GetString("txtEmail.Error"));
            this.errorProvider1.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding"))));
            this.txtEmail.Name = "txtEmail";
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.errorProvider1.SetError(this.txtPhone, resources.GetString("txtPhone.Error"));
            this.errorProvider1.SetIconAlignment(this.txtPhone, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhone.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtPhone, ((int)(resources.GetObject("txtPhone.IconPadding"))));
            this.txtPhone.Name = "txtPhone";
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.errorProvider1.SetError(this.txtLastName, resources.GetString("txtLastName.Error"));
            this.errorProvider1.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding"))));
            this.txtLastName.Name = "txtLastName";
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.errorProvider1.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error"));
            this.errorProvider1.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding"))));
            this.txtFirstName.Name = "txtFirstName";
            // 
            // lblBirthdate
            // 
            resources.ApplyResources(this.lblBirthdate, "lblBirthdate");
            this.errorProvider1.SetError(this.lblBirthdate, resources.GetString("lblBirthdate.Error"));
            this.errorProvider1.SetIconAlignment(this.lblBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblBirthdate.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblBirthdate, ((int)(resources.GetObject("lblBirthdate.IconPadding"))));
            this.lblBirthdate.Name = "lblBirthdate";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.errorProvider1.SetError(this.label10, resources.GetString("label10.Error"));
            this.errorProvider1.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.label10.Name = "label10";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error"));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errorProvider1.SetError(this.label6, resources.GetString("label6.Error"));
            this.errorProvider1.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errorProvider1.SetError(this.label7, resources.GetString("label7.Error"));
            this.errorProvider1.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.user_40px;
            this.errorProvider1.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.errorProvider1.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnExit2
            // 
            resources.ApplyResources(this.btnExit2, "btnExit2");
            this.btnExit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.btnExit2, resources.GetString("btnExit2.Error"));
            this.btnExit2.FlatAppearance.BorderSize = 0;
            this.btnExit2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errorProvider1.SetIconAlignment(this.btnExit2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnExit2, ((int)(resources.GetObject("btnExit2.IconPadding"))));
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.UseVisualStyleBackColor = false;
            this.btnExit2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSignUp
            // 
            resources.ApplyResources(this.btnSignUp, "btnSignUp");
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.btnSignUp, resources.GetString("btnSignUp.Error"));
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errorProvider1.SetIconAlignment(this.btnSignUp, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSignUp.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnSignUp, ((int)(resources.GetObject("btnSignUp.IconPadding"))));
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtConfirm
            // 
            resources.ApplyResources(this.txtConfirm, "txtConfirm");
            this.errorProvider1.SetError(this.txtConfirm, resources.GetString("txtConfirm.Error"));
            this.errorProvider1.SetIconAlignment(this.txtConfirm, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtConfirm.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtConfirm, ((int)(resources.GetObject("txtConfirm.IconPadding"))));
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            resources.ApplyResources(this.txtPass, "txtPass");
            this.errorProvider1.SetError(this.txtPass, resources.GetString("txtPass.Error"));
            this.errorProvider1.SetIconAlignment(this.txtPass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPass.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtPass, ((int)(resources.GetObject("txtPass.IconPadding"))));
            this.txtPass.Name = "txtPass";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.errorProvider1.SetError(this.txtUsername, resources.GetString("txtUsername.Error"));
            this.errorProvider1.SetIconAlignment(this.txtUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUsername.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtUsername, ((int)(resources.GetObject("txtUsername.IconPadding"))));
            this.txtUsername.Name = "txtUsername";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // frmRegister
            // 
            this.AcceptButton = this.btnSignUp;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.TitleBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.fpnlCreateNew.ResumeLayout(false);
            this.fpnlCreateNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxManImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtYearBD;
        private System.Windows.Forms.TextBox txtMonthBD;
        private System.Windows.Forms.TextBox txtDayBD;
        private System.Windows.Forms.PictureBox picboxManImg;
        private System.Windows.Forms.Button btnBrowseImg;
        private System.Windows.Forms.Label lblNoImg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblShopId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.FlowLayoutPanel fpnlCreateNew;
        private System.Windows.Forms.TextBox txtShopId;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Label lblAuthCode;
        private System.Windows.Forms.TextBox txtAuthCode;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Button btnBack;
    }
}