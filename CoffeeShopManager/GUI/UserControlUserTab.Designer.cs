namespace GUI
{
    partial class UserControlUserTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlUserTab));
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorTrue = new System.Windows.Forms.ErrorProvider(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.picManagerInfo = new System.Windows.Forms.PictureBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.datBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblManInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorFalse = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorTrue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManagerInfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFalse)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserInfo
            // 
            resources.ApplyResources(this.lblUserInfo, "lblUserInfo");
            this.errorFalse.SetError(this.lblUserInfo, resources.GetString("lblUserInfo.Error"));
            this.errorTrue.SetError(this.lblUserInfo, resources.GetString("lblUserInfo.Error1"));
            this.errorFalse.SetIconAlignment(this.lblUserInfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblUserInfo.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.lblUserInfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblUserInfo.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.lblUserInfo, ((int)(resources.GetObject("lblUserInfo.IconPadding"))));
            this.errorFalse.SetIconPadding(this.lblUserInfo, ((int)(resources.GetObject("lblUserInfo.IconPadding1"))));
            this.lblUserInfo.Name = "lblUserInfo";
            // 
            // btnChangePassword
            // 
            resources.ApplyResources(this.btnChangePassword, "btnChangePassword");
            this.btnChangePassword.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorFalse.SetError(this.btnChangePassword, resources.GetString("btnChangePassword.Error"));
            this.errorTrue.SetError(this.btnChangePassword, resources.GetString("btnChangePassword.Error1"));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.errorTrue.SetIconAlignment(this.btnChangePassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnChangePassword.IconAlignment"))));
            this.errorFalse.SetIconAlignment(this.btnChangePassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnChangePassword.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.btnChangePassword, ((int)(resources.GetObject("btnChangePassword.IconPadding"))));
            this.errorTrue.SetIconPadding(this.btnChangePassword, ((int)(resources.GetObject("btnChangePassword.IconPadding1"))));
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnSaveChange
            // 
            resources.ApplyResources(this.btnSaveChange, "btnSaveChange");
            this.btnSaveChange.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSaveChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorFalse.SetError(this.btnSaveChange, resources.GetString("btnSaveChange.Error"));
            this.errorTrue.SetError(this.btnSaveChange, resources.GetString("btnSaveChange.Error1"));
            this.btnSaveChange.FlatAppearance.BorderSize = 0;
            this.errorTrue.SetIconAlignment(this.btnSaveChange, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSaveChange.IconAlignment"))));
            this.errorFalse.SetIconAlignment(this.btnSaveChange, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSaveChange.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.btnSaveChange, ((int)(resources.GetObject("btnSaveChange.IconPadding"))));
            this.errorTrue.SetIconPadding(this.btnSaveChange, ((int)(resources.GetObject("btnSaveChange.IconPadding1"))));
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.UseVisualStyleBackColor = false;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // errorTrue
            // 
            this.errorTrue.ContainerControl = this;
            resources.ApplyResources(this.errorTrue, "errorTrue");
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.errorFalse.SetError(this.label14, resources.GetString("label14.Error"));
            this.errorTrue.SetError(this.label14, resources.GetString("label14.Error1"));
            this.errorFalse.SetIconAlignment(this.label14, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label14.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.label14, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label14.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.label14, ((int)(resources.GetObject("label14.IconPadding"))));
            this.errorFalse.SetIconPadding(this.label14, ((int)(resources.GetObject("label14.IconPadding1"))));
            this.label14.Name = "label14";
            // 
            // radFemale
            // 
            resources.ApplyResources(this.radFemale, "radFemale");
            this.errorTrue.SetError(this.radFemale, resources.GetString("radFemale.Error"));
            this.errorFalse.SetError(this.radFemale, resources.GetString("radFemale.Error1"));
            this.errorFalse.SetIconAlignment(this.radFemale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radFemale.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.radFemale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radFemale.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.radFemale, ((int)(resources.GetObject("radFemale.IconPadding"))));
            this.errorTrue.SetIconPadding(this.radFemale, ((int)(resources.GetObject("radFemale.IconPadding1"))));
            this.radFemale.Name = "radFemale";
            this.radFemale.TabStop = true;
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            resources.ApplyResources(this.radMale, "radMale");
            this.errorTrue.SetError(this.radMale, resources.GetString("radMale.Error"));
            this.errorFalse.SetError(this.radMale, resources.GetString("radMale.Error1"));
            this.errorFalse.SetIconAlignment(this.radMale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radMale.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.radMale, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("radMale.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.radMale, ((int)(resources.GetObject("radMale.IconPadding"))));
            this.errorTrue.SetIconPadding(this.radMale, ((int)(resources.GetObject("radMale.IconPadding1"))));
            this.radMale.Name = "radMale";
            this.radMale.TabStop = true;
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.errorFalse.SetError(this.label7, resources.GetString("label7.Error"));
            this.errorTrue.SetError(this.label7, resources.GetString("label7.Error1"));
            this.errorFalse.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.errorFalse.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding1"))));
            this.label7.Name = "label7";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorFalse.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorTrue.SetError(this.label1, resources.GetString("label1.Error1"));
            this.errorFalse.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.errorFalse.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding1"))));
            this.label1.Name = "label1";
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorFalse.SetError(this.btnEdit, resources.GetString("btnEdit.Error"));
            this.errorTrue.SetError(this.btnEdit, resources.GetString("btnEdit.Error1"));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.ForeColor = System.Drawing.Color.DarkRed;
            this.errorTrue.SetIconAlignment(this.btnEdit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnEdit.IconAlignment"))));
            this.errorFalse.SetIconAlignment(this.btnEdit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnEdit.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.btnEdit, ((int)(resources.GetObject("btnEdit.IconPadding"))));
            this.errorTrue.SetIconPadding(this.btnEdit, ((int)(resources.GetObject("btnEdit.IconPadding1"))));
            this.btnEdit.Image = global::GUI.Properties.Resources.edit_30px;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.errorFalse.SetError(this.label8, resources.GetString("label8.Error"));
            this.errorTrue.SetError(this.label8, resources.GetString("label8.Error1"));
            this.errorFalse.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.label8, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label8.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding"))));
            this.errorFalse.SetIconPadding(this.label8, ((int)(resources.GetObject("label8.IconPadding1"))));
            this.label8.Name = "label8";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errorFalse.SetError(this.label6, resources.GetString("label6.Error"));
            this.errorTrue.SetError(this.label6, resources.GetString("label6.Error1"));
            this.errorFalse.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.errorFalse.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding1"))));
            this.label6.Name = "label6";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorFalse.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorTrue.SetError(this.label2, resources.GetString("label2.Error1"));
            this.errorFalse.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.errorFalse.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding1"))));
            this.label2.Name = "label2";
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorFalse.SetError(this.btnBrowse, resources.GetString("btnBrowse.Error"));
            this.errorTrue.SetError(this.btnBrowse, resources.GetString("btnBrowse.Error1"));
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.errorTrue.SetIconAlignment(this.btnBrowse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBrowse.IconAlignment"))));
            this.errorFalse.SetIconAlignment(this.btnBrowse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnBrowse.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.btnBrowse, ((int)(resources.GetObject("btnBrowse.IconPadding"))));
            this.errorTrue.SetIconPadding(this.btnBrowse, ((int)(resources.GetObject("btnBrowse.IconPadding1"))));
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Cursor = System.Windows.Forms.Cursors.No;
            this.errorFalse.SetError(this.txtID, resources.GetString("txtID.Error"));
            this.errorTrue.SetError(this.txtID, resources.GetString("txtID.Error1"));
            this.errorFalse.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding"))));
            this.errorTrue.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding1"))));
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.errorFalse.SetError(this.label5, resources.GetString("label5.Error"));
            this.errorTrue.SetError(this.label5, resources.GetString("label5.Error1"));
            this.errorFalse.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.errorFalse.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding1"))));
            this.label5.Name = "label5";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.errorFalse.SetError(this.txtEmail, resources.GetString("txtEmail.Error"));
            this.errorTrue.SetError(this.txtEmail, resources.GetString("txtEmail.Error1"));
            this.errorFalse.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding"))));
            this.errorTrue.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding1"))));
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorFalse.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorTrue.SetError(this.label3, resources.GetString("label3.Error1"));
            this.errorFalse.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.errorFalse.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding1"))));
            this.label3.Name = "label3";
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.errorFalse.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error"));
            this.errorTrue.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error1"));
            this.errorFalse.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding"))));
            this.errorTrue.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding1"))));
            this.txtFirstName.Name = "txtFirstName";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.errorFalse.SetError(this.label4, resources.GetString("label4.Error"));
            this.errorTrue.SetError(this.label4, resources.GetString("label4.Error1"));
            this.errorFalse.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.errorFalse.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding1"))));
            this.label4.Name = "label4";
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.errorFalse.SetError(this.txtPhone, resources.GetString("txtPhone.Error"));
            this.errorTrue.SetError(this.txtPhone, resources.GetString("txtPhone.Error1"));
            this.errorFalse.SetIconAlignment(this.txtPhone, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhone.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.txtPhone, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPhone.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.txtPhone, ((int)(resources.GetObject("txtPhone.IconPadding"))));
            this.errorTrue.SetIconPadding(this.txtPhone, ((int)(resources.GetObject("txtPhone.IconPadding1"))));
            this.txtPhone.Name = "txtPhone";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.errorFalse.SetError(this.txtUsername, resources.GetString("txtUsername.Error"));
            this.errorTrue.SetError(this.txtUsername, resources.GetString("txtUsername.Error1"));
            this.errorFalse.SetIconAlignment(this.txtUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUsername.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.txtUsername, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtUsername.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.txtUsername, ((int)(resources.GetObject("txtUsername.IconPadding"))));
            this.errorTrue.SetIconPadding(this.txtUsername, ((int)(resources.GetObject("txtUsername.IconPadding1"))));
            this.txtUsername.Name = "txtUsername";
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.errorFalse.SetError(this.txtLastName, resources.GetString("txtLastName.Error"));
            this.errorTrue.SetError(this.txtLastName, resources.GetString("txtLastName.Error1"));
            this.errorFalse.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding"))));
            this.errorTrue.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding1"))));
            this.txtLastName.Name = "txtLastName";
            // 
            // picManagerInfo
            // 
            resources.ApplyResources(this.picManagerInfo, "picManagerInfo");
            this.picManagerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorFalse.SetError(this.picManagerInfo, resources.GetString("picManagerInfo.Error"));
            this.errorTrue.SetError(this.picManagerInfo, resources.GetString("picManagerInfo.Error1"));
            this.errorFalse.SetIconAlignment(this.picManagerInfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picManagerInfo.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.picManagerInfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("picManagerInfo.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.picManagerInfo, ((int)(resources.GetObject("picManagerInfo.IconPadding"))));
            this.errorTrue.SetIconPadding(this.picManagerInfo, ((int)(resources.GetObject("picManagerInfo.IconPadding1"))));
            this.picManagerInfo.Name = "picManagerInfo";
            this.picManagerInfo.TabStop = false;
            // 
            // txtPosition
            // 
            resources.ApplyResources(this.txtPosition, "txtPosition");
            this.txtPosition.Cursor = System.Windows.Forms.Cursors.No;
            this.errorFalse.SetError(this.txtPosition, resources.GetString("txtPosition.Error"));
            this.errorTrue.SetError(this.txtPosition, resources.GetString("txtPosition.Error1"));
            this.errorFalse.SetIconAlignment(this.txtPosition, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPosition.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.txtPosition, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPosition.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.txtPosition, ((int)(resources.GetObject("txtPosition.IconPadding"))));
            this.errorTrue.SetIconPadding(this.txtPosition, ((int)(resources.GetObject("txtPosition.IconPadding1"))));
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            // 
            // datBirthdate
            // 
            resources.ApplyResources(this.datBirthdate, "datBirthdate");
            this.errorFalse.SetError(this.datBirthdate, resources.GetString("datBirthdate.Error"));
            this.errorTrue.SetError(this.datBirthdate, resources.GetString("datBirthdate.Error1"));
            this.errorFalse.SetIconAlignment(this.datBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirthdate.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.datBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirthdate.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.datBirthdate, ((int)(resources.GetObject("datBirthdate.IconPadding"))));
            this.errorTrue.SetIconPadding(this.datBirthdate, ((int)(resources.GetObject("datBirthdate.IconPadding1"))));
            this.datBirthdate.Name = "datBirthdate";
            // 
            // lblManInfo
            // 
            resources.ApplyResources(this.lblManInfo, "lblManInfo");
            this.errorFalse.SetError(this.lblManInfo, resources.GetString("lblManInfo.Error"));
            this.errorTrue.SetError(this.lblManInfo, resources.GetString("lblManInfo.Error1"));
            this.errorFalse.SetIconAlignment(this.lblManInfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblManInfo.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.lblManInfo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblManInfo.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.lblManInfo, ((int)(resources.GetObject("lblManInfo.IconPadding"))));
            this.errorFalse.SetIconPadding(this.lblManInfo, ((int)(resources.GetObject("lblManInfo.IconPadding1"))));
            this.lblManInfo.Name = "lblManInfo";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblManInfo);
            this.panel1.Controls.Add(this.datBirthdate);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtPosition);
            this.panel1.Controls.Add(this.radFemale);
            this.panel1.Controls.Add(this.picManagerInfo);
            this.panel1.Controls.Add(this.radMale);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtID);
            this.errorFalse.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorTrue.SetError(this.panel1, resources.GetString("panel1.Error1"));
            this.errorFalse.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.errorFalse.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding1"))));
            this.panel1.Name = "panel1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.errorFalse.SetError(this.comboBox1, resources.GetString("comboBox1.Error"));
            this.errorTrue.SetError(this.comboBox1, resources.GetString("comboBox1.Error1"));
            this.comboBox1.FormattingEnabled = true;
            this.errorFalse.SetIconAlignment(this.comboBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox1.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.comboBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox1.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.comboBox1, ((int)(resources.GetObject("comboBox1.IconPadding"))));
            this.errorFalse.SetIconPadding(this.comboBox1, ((int)(resources.GetObject("comboBox1.IconPadding1"))));
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6"),
            resources.GetString("comboBox1.Items7"),
            resources.GetString("comboBox1.Items8"),
            resources.GetString("comboBox1.Items9"),
            resources.GetString("comboBox1.Items10"),
            resources.GetString("comboBox1.Items11"),
            resources.GetString("comboBox1.Items12")});
            this.comboBox1.Name = "comboBox1";
            // 
            // errorFalse
            // 
            this.errorFalse.ContainerControl = this;
            resources.ApplyResources(this.errorFalse, "errorFalse");
            // 
            // UserControlUserTab
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblUserInfo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorFalse.SetError(this, resources.GetString("$this.Error"));
            this.errorTrue.SetError(this, resources.GetString("$this.Error1"));
            this.errorFalse.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.errorTrue.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.Name = "UserControlUserTab";
            this.Load += new System.EventHandler(this.UserControlUserTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorTrue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picManagerInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFalse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorTrue;
        private System.Windows.Forms.ErrorProvider errorFalse;
        private System.Windows.Forms.Label lblManInfo;
        private System.Windows.Forms.DateTimePicker datBirthdate;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.PictureBox picManagerInfo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
