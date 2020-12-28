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
            this.cboErrMsg = new System.Windows.Forms.ComboBox();
            this.datBirthdate = new System.Windows.Forms.DateTimePicker();
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
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errShop = new System.Windows.Forms.ErrorProvider(this.components);
            this.errManId = new System.Windows.Forms.ErrorProvider(this.components);
            this.TitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.fpnlCreateNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxManImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errManId)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            resources.ApplyResources(this.TitleBar, "TitleBar");
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(67)))), ((int)(((byte)(58)))));
            this.TitleBar.Controls.Add(this.btnExit);
            this.errManId.SetError(this.TitleBar, resources.GetString("TitleBar.Error"));
            this.errorProvider1.SetError(this.TitleBar, resources.GetString("TitleBar.Error1"));
            this.errEmail.SetError(this.TitleBar, resources.GetString("TitleBar.Error2"));
            this.errShop.SetError(this.TitleBar, resources.GetString("TitleBar.Error3"));
            this.errEmail.SetIconAlignment(this.TitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TitleBar.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.TitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TitleBar.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.TitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TitleBar.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.TitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TitleBar.IconAlignment3"))));
            this.errManId.SetIconPadding(this.TitleBar, ((int)(resources.GetObject("TitleBar.IconPadding"))));
            this.errShop.SetIconPadding(this.TitleBar, ((int)(resources.GetObject("TitleBar.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.TitleBar, ((int)(resources.GetObject("TitleBar.IconPadding2"))));
            this.errEmail.SetIconPadding(this.TitleBar, ((int)(resources.GetObject("TitleBar.IconPadding3"))));
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.errShop.SetError(this.btnExit, resources.GetString("btnExit.Error"));
            this.errEmail.SetError(this.btnExit, resources.GetString("btnExit.Error1"));
            this.errManId.SetError(this.btnExit, resources.GetString("btnExit.Error2"));
            this.errorProvider1.SetError(this.btnExit, resources.GetString("btnExit.Error3"));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.errorProvider1.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment"))));
            this.errManId.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment3"))));
            this.errManId.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding1"))));
            this.errEmail.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding2"))));
            this.errShop.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding3"))));
            this.btnExit.Image = global::GUI.Properties.Resources.close_window_24px1;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(134)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.cboErrMsg);
            this.panel1.Controls.Add(this.datBirthdate);
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
            this.errManId.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorProvider1.SetError(this.panel1, resources.GetString("panel1.Error1"));
            this.errEmail.SetError(this.panel1, resources.GetString("panel1.Error2"));
            this.errShop.SetError(this.panel1, resources.GetString("panel1.Error3"));
            this.errEmail.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment3"))));
            this.errManId.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.errShop.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding2"))));
            this.errEmail.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding3"))));
            this.panel1.Name = "panel1";
            // 
            // cboErrMsg
            // 
            resources.ApplyResources(this.cboErrMsg, "cboErrMsg");
            this.errShop.SetError(this.cboErrMsg, resources.GetString("cboErrMsg.Error"));
            this.errEmail.SetError(this.cboErrMsg, resources.GetString("cboErrMsg.Error1"));
            this.errorProvider1.SetError(this.cboErrMsg, resources.GetString("cboErrMsg.Error2"));
            this.errManId.SetError(this.cboErrMsg, resources.GetString("cboErrMsg.Error3"));
            this.cboErrMsg.FormattingEnabled = true;
            this.errEmail.SetIconAlignment(this.cboErrMsg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cboErrMsg.IconAlignment"))));
            this.errShop.SetIconAlignment(this.cboErrMsg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cboErrMsg.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.cboErrMsg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cboErrMsg.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.cboErrMsg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cboErrMsg.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.cboErrMsg, ((int)(resources.GetObject("cboErrMsg.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.cboErrMsg, ((int)(resources.GetObject("cboErrMsg.IconPadding1"))));
            this.errShop.SetIconPadding(this.cboErrMsg, ((int)(resources.GetObject("cboErrMsg.IconPadding2"))));
            this.errManId.SetIconPadding(this.cboErrMsg, ((int)(resources.GetObject("cboErrMsg.IconPadding3"))));
            this.cboErrMsg.Items.AddRange(new object[] {
            resources.GetString("cboErrMsg.Items"),
            resources.GetString("cboErrMsg.Items1"),
            resources.GetString("cboErrMsg.Items2"),
            resources.GetString("cboErrMsg.Items3"),
            resources.GetString("cboErrMsg.Items4"),
            resources.GetString("cboErrMsg.Items5"),
            resources.GetString("cboErrMsg.Items6")});
            this.cboErrMsg.Name = "cboErrMsg";
            // 
            // datBirthdate
            // 
            resources.ApplyResources(this.datBirthdate, "datBirthdate");
            this.errShop.SetError(this.datBirthdate, resources.GetString("datBirthdate.Error"));
            this.errEmail.SetError(this.datBirthdate, resources.GetString("datBirthdate.Error1"));
            this.errorProvider1.SetError(this.datBirthdate, resources.GetString("datBirthdate.Error2"));
            this.errManId.SetError(this.datBirthdate, resources.GetString("datBirthdate.Error3"));
            this.errManId.SetIconAlignment(this.datBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirthdate.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.datBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirthdate.IconAlignment1"))));
            this.errShop.SetIconAlignment(this.datBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirthdate.IconAlignment2"))));
            this.errEmail.SetIconAlignment(this.datBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirthdate.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.datBirthdate, ((int)(resources.GetObject("datBirthdate.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.datBirthdate, ((int)(resources.GetObject("datBirthdate.IconPadding1"))));
            this.errManId.SetIconPadding(this.datBirthdate, ((int)(resources.GetObject("datBirthdate.IconPadding2"))));
            this.errShop.SetIconPadding(this.datBirthdate, ((int)(resources.GetObject("datBirthdate.IconPadding3"))));
            this.datBirthdate.Name = "datBirthdate";
            // 
            // btnBack
            // 
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errShop.SetError(this.btnBack, resources.GetString("btnBack.Error"));
            this.errEmail.SetError(this.btnBack, resources.GetString("btnBack.Error1"));
            this.errManId.SetError(this.btnBack, resources.GetString("btnBack.Error2"));
            this.errorProvider1.SetError(this.btnBack, resources.GetString("btnBack.Error3"));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.errorProvider1.SetIconAlignment(this.btnBack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBack.IconAlignment"))));
            this.errManId.SetIconAlignment(this.btnBack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBack.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.btnBack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBack.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.btnBack, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBack.IconAlignment3"))));
            this.errManId.SetIconPadding(this.btnBack, ((int)(resources.GetObject("btnBack.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnBack, ((int)(resources.GetObject("btnBack.IconPadding1"))));
            this.errEmail.SetIconPadding(this.btnBack, ((int)(resources.GetObject("btnBack.IconPadding2"))));
            this.errShop.SetIconPadding(this.btnBack, ((int)(resources.GetObject("btnBack.IconPadding3"))));
            this.btnBack.Image = global::GUI.Properties.Resources.back_32px;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblShopName
            // 
            resources.ApplyResources(this.lblShopName, "lblShopName");
            this.errShop.SetError(this.lblShopName, resources.GetString("lblShopName.Error"));
            this.errManId.SetError(this.lblShopName, resources.GetString("lblShopName.Error1"));
            this.errEmail.SetError(this.lblShopName, resources.GetString("lblShopName.Error2"));
            this.errorProvider1.SetError(this.lblShopName, resources.GetString("lblShopName.Error3"));
            this.errManId.SetIconAlignment(this.lblShopName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblShopName.IconAlignment"))));
            this.errShop.SetIconAlignment(this.lblShopName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblShopName.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblShopName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblShopName.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.lblShopName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblShopName.IconAlignment3"))));
            this.errShop.SetIconPadding(this.lblShopName, ((int)(resources.GetObject("lblShopName.IconPadding"))));
            this.errEmail.SetIconPadding(this.lblShopName, ((int)(resources.GetObject("lblShopName.IconPadding1"))));
            this.errManId.SetIconPadding(this.lblShopName, ((int)(resources.GetObject("lblShopName.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.lblShopName, ((int)(resources.GetObject("lblShopName.IconPadding3"))));
            this.lblShopName.Name = "lblShopName";
            // 
            // lblAuthCode
            // 
            resources.ApplyResources(this.lblAuthCode, "lblAuthCode");
            this.errShop.SetError(this.lblAuthCode, resources.GetString("lblAuthCode.Error"));
            this.errManId.SetError(this.lblAuthCode, resources.GetString("lblAuthCode.Error1"));
            this.errEmail.SetError(this.lblAuthCode, resources.GetString("lblAuthCode.Error2"));
            this.errorProvider1.SetError(this.lblAuthCode, resources.GetString("lblAuthCode.Error3"));
            this.errManId.SetIconAlignment(this.lblAuthCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblAuthCode.IconAlignment"))));
            this.errShop.SetIconAlignment(this.lblAuthCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblAuthCode.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblAuthCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblAuthCode.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.lblAuthCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblAuthCode.IconAlignment3"))));
            this.errShop.SetIconPadding(this.lblAuthCode, ((int)(resources.GetObject("lblAuthCode.IconPadding"))));
            this.errEmail.SetIconPadding(this.lblAuthCode, ((int)(resources.GetObject("lblAuthCode.IconPadding1"))));
            this.errManId.SetIconPadding(this.lblAuthCode, ((int)(resources.GetObject("lblAuthCode.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.lblAuthCode, ((int)(resources.GetObject("lblAuthCode.IconPadding3"))));
            this.lblAuthCode.Name = "lblAuthCode";
            // 
            // fpnlCreateNew
            // 
            resources.ApplyResources(this.fpnlCreateNew, "fpnlCreateNew");
            this.fpnlCreateNew.BackColor = System.Drawing.Color.White;
            this.fpnlCreateNew.Controls.Add(this.pictureBox2);
            this.fpnlCreateNew.Controls.Add(this.label15);
            this.fpnlCreateNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errShop.SetError(this.fpnlCreateNew, resources.GetString("fpnlCreateNew.Error"));
            this.errEmail.SetError(this.fpnlCreateNew, resources.GetString("fpnlCreateNew.Error1"));
            this.errorProvider1.SetError(this.fpnlCreateNew, resources.GetString("fpnlCreateNew.Error2"));
            this.errManId.SetError(this.fpnlCreateNew, resources.GetString("fpnlCreateNew.Error3"));
            this.errorProvider1.SetIconAlignment(this.fpnlCreateNew, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("fpnlCreateNew.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.fpnlCreateNew, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("fpnlCreateNew.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.fpnlCreateNew, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("fpnlCreateNew.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.fpnlCreateNew, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("fpnlCreateNew.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.fpnlCreateNew, ((int)(resources.GetObject("fpnlCreateNew.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.fpnlCreateNew, ((int)(resources.GetObject("fpnlCreateNew.IconPadding1"))));
            this.errManId.SetIconPadding(this.fpnlCreateNew, ((int)(resources.GetObject("fpnlCreateNew.IconPadding2"))));
            this.errShop.SetIconPadding(this.fpnlCreateNew, ((int)(resources.GetObject("fpnlCreateNew.IconPadding3"))));
            this.fpnlCreateNew.Name = "fpnlCreateNew";
            this.fpnlCreateNew.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.add_new_30px;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errShop.SetError(this.pictureBox2, resources.GetString("pictureBox2.Error"));
            this.errEmail.SetError(this.pictureBox2, resources.GetString("pictureBox2.Error1"));
            this.errorProvider1.SetError(this.pictureBox2, resources.GetString("pictureBox2.Error2"));
            this.errManId.SetError(this.pictureBox2, resources.GetString("pictureBox2.Error3"));
            this.errEmail.SetIconAlignment(this.pictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox2.IconAlignment"))));
            this.errManId.SetIconAlignment(this.pictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox2.IconAlignment1"))));
            this.errShop.SetIconAlignment(this.pictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox2.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.pictureBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox2.IconAlignment3"))));
            this.errorProvider1.SetIconPadding(this.pictureBox2, ((int)(resources.GetObject("pictureBox2.IconPadding"))));
            this.errEmail.SetIconPadding(this.pictureBox2, ((int)(resources.GetObject("pictureBox2.IconPadding1"))));
            this.errManId.SetIconPadding(this.pictureBox2, ((int)(resources.GetObject("pictureBox2.IconPadding2"))));
            this.errShop.SetIconPadding(this.pictureBox2, ((int)(resources.GetObject("pictureBox2.IconPadding3"))));
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errShop.SetError(this.label15, resources.GetString("label15.Error"));
            this.errorProvider1.SetError(this.label15, resources.GetString("label15.Error1"));
            this.errEmail.SetError(this.label15, resources.GetString("label15.Error2"));
            this.errManId.SetError(this.label15, resources.GetString("label15.Error3"));
            this.errShop.SetIconAlignment(this.label15, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label15.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.label15, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label15.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.label15, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label15.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.label15, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label15.IconAlignment3"))));
            this.errManId.SetIconPadding(this.label15, ((int)(resources.GetObject("label15.IconPadding"))));
            this.errShop.SetIconPadding(this.label15, ((int)(resources.GetObject("label15.IconPadding1"))));
            this.errEmail.SetIconPadding(this.label15, ((int)(resources.GetObject("label15.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.label15, ((int)(resources.GetObject("label15.IconPadding3"))));
            this.label15.Name = "label15";
            this.label15.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblShopId
            // 
            resources.ApplyResources(this.lblShopId, "lblShopId");
            this.errShop.SetError(this.lblShopId, resources.GetString("lblShopId.Error"));
            this.errManId.SetError(this.lblShopId, resources.GetString("lblShopId.Error1"));
            this.errEmail.SetError(this.lblShopId, resources.GetString("lblShopId.Error2"));
            this.errorProvider1.SetError(this.lblShopId, resources.GetString("lblShopId.Error3"));
            this.errManId.SetIconAlignment(this.lblShopId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblShopId.IconAlignment"))));
            this.errShop.SetIconAlignment(this.lblShopId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblShopId.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblShopId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblShopId.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.lblShopId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblShopId.IconAlignment3"))));
            this.errShop.SetIconPadding(this.lblShopId, ((int)(resources.GetObject("lblShopId.IconPadding"))));
            this.errEmail.SetIconPadding(this.lblShopId, ((int)(resources.GetObject("lblShopId.IconPadding1"))));
            this.errManId.SetIconPadding(this.lblShopId, ((int)(resources.GetObject("lblShopId.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.lblShopId, ((int)(resources.GetObject("lblShopId.IconPadding3"))));
            this.lblShopId.Name = "lblShopId";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.errShop.SetError(this.label11, resources.GetString("label11.Error"));
            this.errManId.SetError(this.label11, resources.GetString("label11.Error1"));
            this.errEmail.SetError(this.label11, resources.GetString("label11.Error2"));
            this.errorProvider1.SetError(this.label11, resources.GetString("label11.Error3"));
            this.errManId.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment"))));
            this.errShop.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.label11, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label11.IconAlignment3"))));
            this.errShop.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding"))));
            this.errEmail.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding1"))));
            this.errManId.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.label11, ((int)(resources.GetObject("label11.IconPadding3"))));
            this.label11.Name = "label11";
            // 
            // txtShopId
            // 
            resources.ApplyResources(this.txtShopId, "txtShopId");
            this.errShop.SetError(this.txtShopId, resources.GetString("txtShopId.Error"));
            this.errorProvider1.SetError(this.txtShopId, resources.GetString("txtShopId.Error1"));
            this.errEmail.SetError(this.txtShopId, resources.GetString("txtShopId.Error2"));
            this.errManId.SetError(this.txtShopId, resources.GetString("txtShopId.Error3"));
            this.txtShopId.ForeColor = System.Drawing.Color.DimGray;
            this.errEmail.SetIconAlignment(this.txtShopId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtShopId.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtShopId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtShopId.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.txtShopId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtShopId.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.txtShopId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtShopId.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.txtShopId, ((int)(resources.GetObject("txtShopId.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtShopId, ((int)(resources.GetObject("txtShopId.IconPadding1"))));
            this.errManId.SetIconPadding(this.txtShopId, ((int)(resources.GetObject("txtShopId.IconPadding2"))));
            this.errShop.SetIconPadding(this.txtShopId, ((int)(resources.GetObject("txtShopId.IconPadding3"))));
            this.txtShopId.Name = "txtShopId";
            this.txtShopId.TextChanged += new System.EventHandler(this.txtShopId_TextChanged);
            // 
            // txtAuthCode
            // 
            resources.ApplyResources(this.txtAuthCode, "txtAuthCode");
            this.errShop.SetError(this.txtAuthCode, resources.GetString("txtAuthCode.Error"));
            this.errorProvider1.SetError(this.txtAuthCode, resources.GetString("txtAuthCode.Error1"));
            this.errEmail.SetError(this.txtAuthCode, resources.GetString("txtAuthCode.Error2"));
            this.errManId.SetError(this.txtAuthCode, resources.GetString("txtAuthCode.Error3"));
            this.txtAuthCode.ForeColor = System.Drawing.Color.DimGray;
            this.errEmail.SetIconAlignment(this.txtAuthCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAuthCode.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtAuthCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAuthCode.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.txtAuthCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAuthCode.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.txtAuthCode, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAuthCode.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.txtAuthCode, ((int)(resources.GetObject("txtAuthCode.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtAuthCode, ((int)(resources.GetObject("txtAuthCode.IconPadding1"))));
            this.errManId.SetIconPadding(this.txtAuthCode, ((int)(resources.GetObject("txtAuthCode.IconPadding2"))));
            this.errShop.SetIconPadding(this.txtAuthCode, ((int)(resources.GetObject("txtAuthCode.IconPadding3"))));
            this.txtAuthCode.Name = "txtAuthCode";
            this.txtAuthCode.TextChanged += new System.EventHandler(this.txtAuthCode_TextChanged);
            // 
            // txtShopName
            // 
            resources.ApplyResources(this.txtShopName, "txtShopName");
            this.errShop.SetError(this.txtShopName, resources.GetString("txtShopName.Error"));
            this.errorProvider1.SetError(this.txtShopName, resources.GetString("txtShopName.Error1"));
            this.errEmail.SetError(this.txtShopName, resources.GetString("txtShopName.Error2"));
            this.errManId.SetError(this.txtShopName, resources.GetString("txtShopName.Error3"));
            this.txtShopName.ForeColor = System.Drawing.Color.DimGray;
            this.errEmail.SetIconAlignment(this.txtShopName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtShopName.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtShopName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtShopName.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.txtShopName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtShopName.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.txtShopName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtShopName.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.txtShopName, ((int)(resources.GetObject("txtShopName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtShopName, ((int)(resources.GetObject("txtShopName.IconPadding1"))));
            this.errManId.SetIconPadding(this.txtShopName, ((int)(resources.GetObject("txtShopName.IconPadding2"))));
            this.errShop.SetIconPadding(this.txtShopName, ((int)(resources.GetObject("txtShopName.IconPadding3"))));
            this.txtShopName.Name = "txtShopName";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.errShop.SetError(this.txtID, resources.GetString("txtID.Error"));
            this.errorProvider1.SetError(this.txtID, resources.GetString("txtID.Error1"));
            this.errEmail.SetError(this.txtID, resources.GetString("txtID.Error2"));
            this.errManId.SetError(this.txtID, resources.GetString("txtID.Error3"));
            this.errEmail.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding1"))));
            this.errManId.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding2"))));
            this.errShop.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding3"))));
            this.txtID.Name = "txtID";
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.errShop.SetError(this.label8, resources.GetString("label8.Error"));
            this.errManId.SetError(this.label8, resources.GetString("label8.Error1"));
            this.errEmail.SetError(this.label8, resources.GetString("label8.Error2"));
            this.errorProvider1.SetError(this.label8, resources.GetString("label8.Error3"));
            this.errManId.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.errShop.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment3"))));
            this.errShop.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.errEmail.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding1"))));
            this.errManId.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding3"))));
            this.label8.Name = "label8";
            // 
            // btnBrowseImg
            // 
            resources.ApplyResources(this.btnBrowseImg, "btnBrowseImg");
            this.btnBrowseImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBrowseImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errShop.SetError(this.btnBrowseImg, resources.GetString("btnBrowseImg.Error"));
            this.errEmail.SetError(this.btnBrowseImg, resources.GetString("btnBrowseImg.Error1"));
            this.errManId.SetError(this.btnBrowseImg, resources.GetString("btnBrowseImg.Error2"));
            this.errorProvider1.SetError(this.btnBrowseImg, resources.GetString("btnBrowseImg.Error3"));
            this.btnBrowseImg.FlatAppearance.BorderSize = 0;
            this.btnBrowseImg.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errorProvider1.SetIconAlignment(this.btnBrowseImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBrowseImg.IconAlignment"))));
            this.errManId.SetIconAlignment(this.btnBrowseImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBrowseImg.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.btnBrowseImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBrowseImg.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.btnBrowseImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBrowseImg.IconAlignment3"))));
            this.errManId.SetIconPadding(this.btnBrowseImg, ((int)(resources.GetObject("btnBrowseImg.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnBrowseImg, ((int)(resources.GetObject("btnBrowseImg.IconPadding1"))));
            this.errEmail.SetIconPadding(this.btnBrowseImg, ((int)(resources.GetObject("btnBrowseImg.IconPadding2"))));
            this.errShop.SetIconPadding(this.btnBrowseImg, ((int)(resources.GetObject("btnBrowseImg.IconPadding3"))));
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.UseVisualStyleBackColor = false;
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // lblNoImg
            // 
            resources.ApplyResources(this.lblNoImg, "lblNoImg");
            this.errShop.SetError(this.lblNoImg, resources.GetString("lblNoImg.Error"));
            this.errManId.SetError(this.lblNoImg, resources.GetString("lblNoImg.Error1"));
            this.errEmail.SetError(this.lblNoImg, resources.GetString("lblNoImg.Error2"));
            this.errorProvider1.SetError(this.lblNoImg, resources.GetString("lblNoImg.Error3"));
            this.errManId.SetIconAlignment(this.lblNoImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNoImg.IconAlignment"))));
            this.errShop.SetIconAlignment(this.lblNoImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNoImg.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblNoImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNoImg.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.lblNoImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNoImg.IconAlignment3"))));
            this.errShop.SetIconPadding(this.lblNoImg, ((int)(resources.GetObject("lblNoImg.IconPadding"))));
            this.errEmail.SetIconPadding(this.lblNoImg, ((int)(resources.GetObject("lblNoImg.IconPadding1"))));
            this.errManId.SetIconPadding(this.lblNoImg, ((int)(resources.GetObject("lblNoImg.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.lblNoImg, ((int)(resources.GetObject("lblNoImg.IconPadding3"))));
            this.lblNoImg.Name = "lblNoImg";
            // 
            // picboxManImg
            // 
            resources.ApplyResources(this.picboxManImg, "picboxManImg");
            this.picboxManImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorProvider1.SetError(this.picboxManImg, resources.GetString("picboxManImg.Error"));
            this.errEmail.SetError(this.picboxManImg, resources.GetString("picboxManImg.Error1"));
            this.errManId.SetError(this.picboxManImg, resources.GetString("picboxManImg.Error2"));
            this.errShop.SetError(this.picboxManImg, resources.GetString("picboxManImg.Error3"));
            this.errEmail.SetIconAlignment(this.picboxManImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picboxManImg.IconAlignment"))));
            this.errShop.SetIconAlignment(this.picboxManImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picboxManImg.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.picboxManImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picboxManImg.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.picboxManImg, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picboxManImg.IconAlignment3"))));
            this.errorProvider1.SetIconPadding(this.picboxManImg, ((int)(resources.GetObject("picboxManImg.IconPadding"))));
            this.errEmail.SetIconPadding(this.picboxManImg, ((int)(resources.GetObject("picboxManImg.IconPadding1"))));
            this.errShop.SetIconPadding(this.picboxManImg, ((int)(resources.GetObject("picboxManImg.IconPadding2"))));
            this.errManId.SetIconPadding(this.picboxManImg, ((int)(resources.GetObject("picboxManImg.IconPadding3"))));
            this.picboxManImg.Name = "picboxManImg";
            this.picboxManImg.TabStop = false;
            this.picboxManImg.Tag = "";
            // 
            // radFemale
            // 
            resources.ApplyResources(this.radFemale, "radFemale");
            this.errShop.SetError(this.radFemale, resources.GetString("radFemale.Error"));
            this.errEmail.SetError(this.radFemale, resources.GetString("radFemale.Error1"));
            this.errManId.SetError(this.radFemale, resources.GetString("radFemale.Error2"));
            this.errorProvider1.SetError(this.radFemale, resources.GetString("radFemale.Error3"));
            this.errEmail.SetIconAlignment(this.radFemale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radFemale.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.radFemale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radFemale.IconAlignment1"))));
            this.errShop.SetIconAlignment(this.radFemale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radFemale.IconAlignment2"))));
            this.errManId.SetIconAlignment(this.radFemale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radFemale.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.radFemale, ((int)(resources.GetObject("radFemale.IconPadding"))));
            this.errShop.SetIconPadding(this.radFemale, ((int)(resources.GetObject("radFemale.IconPadding1"))));
            this.errManId.SetIconPadding(this.radFemale, ((int)(resources.GetObject("radFemale.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.radFemale, ((int)(resources.GetObject("radFemale.IconPadding3"))));
            this.radFemale.Name = "radFemale";
            this.radFemale.TabStop = true;
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            resources.ApplyResources(this.radMale, "radMale");
            this.errShop.SetError(this.radMale, resources.GetString("radMale.Error"));
            this.errEmail.SetError(this.radMale, resources.GetString("radMale.Error1"));
            this.errManId.SetError(this.radMale, resources.GetString("radMale.Error2"));
            this.errorProvider1.SetError(this.radMale, resources.GetString("radMale.Error3"));
            this.errEmail.SetIconAlignment(this.radMale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radMale.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.radMale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radMale.IconAlignment1"))));
            this.errShop.SetIconAlignment(this.radMale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radMale.IconAlignment2"))));
            this.errManId.SetIconAlignment(this.radMale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radMale.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.radMale, ((int)(resources.GetObject("radMale.IconPadding"))));
            this.errShop.SetIconPadding(this.radMale, ((int)(resources.GetObject("radMale.IconPadding1"))));
            this.errManId.SetIconPadding(this.radMale, ((int)(resources.GetObject("radMale.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.radMale, ((int)(resources.GetObject("radMale.IconPadding3"))));
            this.radMale.Name = "radMale";
            this.radMale.TabStop = true;
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.errShop.SetError(this.txtEmail, resources.GetString("txtEmail.Error"));
            this.errorProvider1.SetError(this.txtEmail, resources.GetString("txtEmail.Error1"));
            this.errEmail.SetError(this.txtEmail, resources.GetString("txtEmail.Error2"));
            this.errManId.SetError(this.txtEmail, resources.GetString("txtEmail.Error3"));
            this.errEmail.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding1"))));
            this.errManId.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding2"))));
            this.errShop.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding3"))));
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.errShop.SetError(this.txtPhone, resources.GetString("txtPhone.Error"));
            this.errorProvider1.SetError(this.txtPhone, resources.GetString("txtPhone.Error1"));
            this.errEmail.SetError(this.txtPhone, resources.GetString("txtPhone.Error2"));
            this.errManId.SetError(this.txtPhone, resources.GetString("txtPhone.Error3"));
            this.errEmail.SetIconAlignment(this.txtPhone, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhone.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtPhone, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhone.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.txtPhone, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhone.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.txtPhone, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhone.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.txtPhone, ((int)(resources.GetObject("txtPhone.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtPhone, ((int)(resources.GetObject("txtPhone.IconPadding1"))));
            this.errManId.SetIconPadding(this.txtPhone, ((int)(resources.GetObject("txtPhone.IconPadding2"))));
            this.errShop.SetIconPadding(this.txtPhone, ((int)(resources.GetObject("txtPhone.IconPadding3"))));
            this.txtPhone.Name = "txtPhone";
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.errShop.SetError(this.txtLastName, resources.GetString("txtLastName.Error"));
            this.errorProvider1.SetError(this.txtLastName, resources.GetString("txtLastName.Error1"));
            this.errEmail.SetError(this.txtLastName, resources.GetString("txtLastName.Error2"));
            this.errManId.SetError(this.txtLastName, resources.GetString("txtLastName.Error3"));
            this.errEmail.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding1"))));
            this.errManId.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding2"))));
            this.errShop.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding3"))));
            this.txtLastName.Name = "txtLastName";
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.errShop.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error"));
            this.errorProvider1.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error1"));
            this.errEmail.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error2"));
            this.errManId.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error3"));
            this.errEmail.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding1"))));
            this.errManId.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding2"))));
            this.errShop.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding3"))));
            this.txtFirstName.Name = "txtFirstName";
            // 
            // lblBirthdate
            // 
            resources.ApplyResources(this.lblBirthdate, "lblBirthdate");
            this.errShop.SetError(this.lblBirthdate, resources.GetString("lblBirthdate.Error"));
            this.errManId.SetError(this.lblBirthdate, resources.GetString("lblBirthdate.Error1"));
            this.errEmail.SetError(this.lblBirthdate, resources.GetString("lblBirthdate.Error2"));
            this.errorProvider1.SetError(this.lblBirthdate, resources.GetString("lblBirthdate.Error3"));
            this.errManId.SetIconAlignment(this.lblBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblBirthdate.IconAlignment"))));
            this.errShop.SetIconAlignment(this.lblBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblBirthdate.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblBirthdate.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.lblBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblBirthdate.IconAlignment3"))));
            this.errShop.SetIconPadding(this.lblBirthdate, ((int)(resources.GetObject("lblBirthdate.IconPadding"))));
            this.errEmail.SetIconPadding(this.lblBirthdate, ((int)(resources.GetObject("lblBirthdate.IconPadding1"))));
            this.errManId.SetIconPadding(this.lblBirthdate, ((int)(resources.GetObject("lblBirthdate.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.lblBirthdate, ((int)(resources.GetObject("lblBirthdate.IconPadding3"))));
            this.lblBirthdate.Name = "lblBirthdate";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.errShop.SetError(this.label10, resources.GetString("label10.Error"));
            this.errManId.SetError(this.label10, resources.GetString("label10.Error1"));
            this.errEmail.SetError(this.label10, resources.GetString("label10.Error2"));
            this.errorProvider1.SetError(this.label10, resources.GetString("label10.Error3"));
            this.errManId.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.errShop.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment3"))));
            this.errShop.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.errEmail.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding1"))));
            this.errManId.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding3"))));
            this.label10.Name = "label10";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errShop.SetError(this.label5, resources.GetString("label5.Error"));
            this.errManId.SetError(this.label5, resources.GetString("label5.Error1"));
            this.errEmail.SetError(this.label5, resources.GetString("label5.Error2"));
            this.errorProvider1.SetError(this.label5, resources.GetString("label5.Error3"));
            this.errManId.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errShop.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment3"))));
            this.errShop.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.errEmail.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding1"))));
            this.errManId.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding3"))));
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errShop.SetError(this.label6, resources.GetString("label6.Error"));
            this.errManId.SetError(this.label6, resources.GetString("label6.Error1"));
            this.errEmail.SetError(this.label6, resources.GetString("label6.Error2"));
            this.errorProvider1.SetError(this.label6, resources.GetString("label6.Error3"));
            this.errManId.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errShop.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment3"))));
            this.errShop.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.errEmail.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding1"))));
            this.errManId.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding3"))));
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errShop.SetError(this.label7, resources.GetString("label7.Error"));
            this.errManId.SetError(this.label7, resources.GetString("label7.Error1"));
            this.errEmail.SetError(this.label7, resources.GetString("label7.Error2"));
            this.errorProvider1.SetError(this.label7, resources.GetString("label7.Error3"));
            this.errManId.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errShop.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment3"))));
            this.errShop.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.errEmail.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding1"))));
            this.errManId.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding3"))));
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errShop.SetError(this.label4, resources.GetString("label4.Error"));
            this.errManId.SetError(this.label4, resources.GetString("label4.Error1"));
            this.errEmail.SetError(this.label4, resources.GetString("label4.Error2"));
            this.errorProvider1.SetError(this.label4, resources.GetString("label4.Error3"));
            this.errManId.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errShop.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment3"))));
            this.errShop.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.errEmail.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding1"))));
            this.errManId.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding3"))));
            this.label4.Name = "label4";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.user_40px;
            this.errorProvider1.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.errEmail.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error1"));
            this.errManId.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error2"));
            this.errShop.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error3"));
            this.errEmail.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.errShop.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment3"))));
            this.errorProvider1.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.errEmail.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding1"))));
            this.errShop.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding2"))));
            this.errManId.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding3"))));
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnExit2
            // 
            resources.ApplyResources(this.btnExit2, "btnExit2");
            this.btnExit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errShop.SetError(this.btnExit2, resources.GetString("btnExit2.Error"));
            this.errEmail.SetError(this.btnExit2, resources.GetString("btnExit2.Error1"));
            this.errManId.SetError(this.btnExit2, resources.GetString("btnExit2.Error2"));
            this.errorProvider1.SetError(this.btnExit2, resources.GetString("btnExit2.Error3"));
            this.btnExit2.FlatAppearance.BorderSize = 0;
            this.btnExit2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errorProvider1.SetIconAlignment(this.btnExit2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit2.IconAlignment"))));
            this.errManId.SetIconAlignment(this.btnExit2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit2.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.btnExit2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit2.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.btnExit2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit2.IconAlignment3"))));
            this.errManId.SetIconPadding(this.btnExit2, ((int)(resources.GetObject("btnExit2.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnExit2, ((int)(resources.GetObject("btnExit2.IconPadding1"))));
            this.errEmail.SetIconPadding(this.btnExit2, ((int)(resources.GetObject("btnExit2.IconPadding2"))));
            this.errShop.SetIconPadding(this.btnExit2, ((int)(resources.GetObject("btnExit2.IconPadding3"))));
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.UseVisualStyleBackColor = false;
            this.btnExit2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSignUp
            // 
            resources.ApplyResources(this.btnSignUp, "btnSignUp");
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errShop.SetError(this.btnSignUp, resources.GetString("btnSignUp.Error"));
            this.errEmail.SetError(this.btnSignUp, resources.GetString("btnSignUp.Error1"));
            this.errManId.SetError(this.btnSignUp, resources.GetString("btnSignUp.Error2"));
            this.errorProvider1.SetError(this.btnSignUp, resources.GetString("btnSignUp.Error3"));
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errorProvider1.SetIconAlignment(this.btnSignUp, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSignUp.IconAlignment"))));
            this.errManId.SetIconAlignment(this.btnSignUp, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSignUp.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.btnSignUp, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSignUp.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.btnSignUp, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSignUp.IconAlignment3"))));
            this.errManId.SetIconPadding(this.btnSignUp, ((int)(resources.GetObject("btnSignUp.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnSignUp, ((int)(resources.GetObject("btnSignUp.IconPadding1"))));
            this.errEmail.SetIconPadding(this.btnSignUp, ((int)(resources.GetObject("btnSignUp.IconPadding2"))));
            this.errShop.SetIconPadding(this.btnSignUp, ((int)(resources.GetObject("btnSignUp.IconPadding3"))));
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtConfirm
            // 
            resources.ApplyResources(this.txtConfirm, "txtConfirm");
            this.errShop.SetError(this.txtConfirm, resources.GetString("txtConfirm.Error"));
            this.errorProvider1.SetError(this.txtConfirm, resources.GetString("txtConfirm.Error1"));
            this.errEmail.SetError(this.txtConfirm, resources.GetString("txtConfirm.Error2"));
            this.errManId.SetError(this.txtConfirm, resources.GetString("txtConfirm.Error3"));
            this.errEmail.SetIconAlignment(this.txtConfirm, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtConfirm.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtConfirm, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtConfirm.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.txtConfirm, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtConfirm.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.txtConfirm, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtConfirm.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.txtConfirm, ((int)(resources.GetObject("txtConfirm.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtConfirm, ((int)(resources.GetObject("txtConfirm.IconPadding1"))));
            this.errManId.SetIconPadding(this.txtConfirm, ((int)(resources.GetObject("txtConfirm.IconPadding2"))));
            this.errShop.SetIconPadding(this.txtConfirm, ((int)(resources.GetObject("txtConfirm.IconPadding3"))));
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            resources.ApplyResources(this.txtPass, "txtPass");
            this.errShop.SetError(this.txtPass, resources.GetString("txtPass.Error"));
            this.errorProvider1.SetError(this.txtPass, resources.GetString("txtPass.Error1"));
            this.errEmail.SetError(this.txtPass, resources.GetString("txtPass.Error2"));
            this.errManId.SetError(this.txtPass, resources.GetString("txtPass.Error3"));
            this.errEmail.SetIconAlignment(this.txtPass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPass.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtPass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPass.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.txtPass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPass.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.txtPass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPass.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.txtPass, ((int)(resources.GetObject("txtPass.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtPass, ((int)(resources.GetObject("txtPass.IconPadding1"))));
            this.errManId.SetIconPadding(this.txtPass, ((int)(resources.GetObject("txtPass.IconPadding2"))));
            this.errShop.SetIconPadding(this.txtPass, ((int)(resources.GetObject("txtPass.IconPadding3"))));
            this.txtPass.Name = "txtPass";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.errShop.SetError(this.txtUsername, resources.GetString("txtUsername.Error"));
            this.errorProvider1.SetError(this.txtUsername, resources.GetString("txtUsername.Error1"));
            this.errEmail.SetError(this.txtUsername, resources.GetString("txtUsername.Error2"));
            this.errManId.SetError(this.txtUsername, resources.GetString("txtUsername.Error3"));
            this.errEmail.SetIconAlignment(this.txtUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUsername.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.txtUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUsername.IconAlignment1"))));
            this.errManId.SetIconAlignment(this.txtUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUsername.IconAlignment2"))));
            this.errShop.SetIconAlignment(this.txtUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUsername.IconAlignment3"))));
            this.errEmail.SetIconPadding(this.txtUsername, ((int)(resources.GetObject("txtUsername.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtUsername, ((int)(resources.GetObject("txtUsername.IconPadding1"))));
            this.errManId.SetIconPadding(this.txtUsername, ((int)(resources.GetObject("txtUsername.IconPadding2"))));
            this.errShop.SetIconPadding(this.txtUsername, ((int)(resources.GetObject("txtUsername.IconPadding3"))));
            this.txtUsername.Name = "txtUsername";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errShop.SetError(this.label3, resources.GetString("label3.Error"));
            this.errManId.SetError(this.label3, resources.GetString("label3.Error1"));
            this.errEmail.SetError(this.label3, resources.GetString("label3.Error2"));
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error3"));
            this.errManId.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errShop.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment3"))));
            this.errShop.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.errEmail.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding1"))));
            this.errManId.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding3"))));
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errShop.SetError(this.label2, resources.GetString("label2.Error"));
            this.errManId.SetError(this.label2, resources.GetString("label2.Error1"));
            this.errEmail.SetError(this.label2, resources.GetString("label2.Error2"));
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error3"));
            this.errManId.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errShop.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment3"))));
            this.errShop.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.errEmail.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding1"))));
            this.errManId.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding3"))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errShop.SetError(this.label1, resources.GetString("label1.Error"));
            this.errManId.SetError(this.label1, resources.GetString("label1.Error1"));
            this.errEmail.SetError(this.label1, resources.GetString("label1.Error2"));
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error3"));
            this.errManId.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errShop.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment2"))));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment3"))));
            this.errShop.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.errEmail.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding1"))));
            this.errManId.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding2"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding3"))));
            this.label1.Name = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            resources.ApplyResources(this.errEmail, "errEmail");
            // 
            // errShop
            // 
            this.errShop.ContainerControl = this;
            resources.ApplyResources(this.errShop, "errShop");
            // 
            // errManId
            // 
            this.errManId.ContainerControl = this;
            resources.ApplyResources(this.errManId, "errManId");
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
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errManId)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errShop;
        private System.Windows.Forms.DateTimePicker datBirthdate;
        private System.Windows.Forms.ErrorProvider errManId;
        private System.Windows.Forms.ComboBox cboErrMsg;
    }
}