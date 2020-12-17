namespace GUI
{
    partial class UserControlOrderProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlOrderProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHead = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNoneName = new System.Windows.Forms.Label();
            this.cboCustomerType = new System.Windows.Forms.ComboBox();
            this.datBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTotalSum = new System.Windows.Forms.Label();
            this.lblGrand = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmDown = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmUp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOr = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblHead);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dataGridView1);
            this.errorProvider1.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorProvider2.SetError(this.panel1, resources.GetString("panel1.Error1"));
            this.errEmail.SetError(this.panel1, resources.GetString("panel1.Error2"));
            this.errorProvider1.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding2"))));
            this.panel1.Name = "panel1";
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // lblHead
            // 
            resources.ApplyResources(this.lblHead, "lblHead");
            this.errorProvider2.SetError(this.lblHead, resources.GetString("lblHead.Error"));
            this.errorProvider1.SetError(this.lblHead, resources.GetString("lblHead.Error1"));
            this.errEmail.SetError(this.lblHead, resources.GetString("lblHead.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblHead, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblHead.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblHead, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblHead.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblHead, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblHead.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblHead, ((int)(resources.GetObject("lblHead.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblHead, ((int)(resources.GetObject("lblHead.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblHead, ((int)(resources.GetObject("lblHead.IconPadding2"))));
            this.lblHead.Name = "lblHead";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblNoneName);
            this.panel2.Controls.Add(this.cboCustomerType);
            this.panel2.Controls.Add(this.datBirthdate);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.lblLastName);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblTableNumber);
            this.panel2.Controls.Add(this.lblTable);
            this.panel2.Controls.Add(this.lblBirthday);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblFirstName);
            this.panel2.Controls.Add(this.lblCustomer);
            this.errorProvider1.SetError(this.panel2, resources.GetString("panel2.Error"));
            this.errorProvider2.SetError(this.panel2, resources.GetString("panel2.Error1"));
            this.errEmail.SetError(this.panel2, resources.GetString("panel2.Error2"));
            this.errorProvider1.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.panel2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel2.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.panel2, ((int)(resources.GetObject("panel2.IconPadding2"))));
            this.panel2.Name = "panel2";
            // 
            // lblNoneName
            // 
            resources.ApplyResources(this.lblNoneName, "lblNoneName");
            this.errorProvider2.SetError(this.lblNoneName, resources.GetString("lblNoneName.Error"));
            this.errorProvider1.SetError(this.lblNoneName, resources.GetString("lblNoneName.Error1"));
            this.errEmail.SetError(this.lblNoneName, resources.GetString("lblNoneName.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblNoneName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNoneName.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblNoneName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNoneName.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblNoneName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNoneName.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblNoneName, ((int)(resources.GetObject("lblNoneName.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblNoneName, ((int)(resources.GetObject("lblNoneName.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblNoneName, ((int)(resources.GetObject("lblNoneName.IconPadding2"))));
            this.lblNoneName.Name = "lblNoneName";
            // 
            // cboCustomerType
            // 
            resources.ApplyResources(this.cboCustomerType, "cboCustomerType");
            this.cboCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errorProvider2.SetError(this.cboCustomerType, resources.GetString("cboCustomerType.Error"));
            this.errorProvider1.SetError(this.cboCustomerType, resources.GetString("cboCustomerType.Error1"));
            this.errEmail.SetError(this.cboCustomerType, resources.GetString("cboCustomerType.Error2"));
            this.cboCustomerType.FormattingEnabled = true;
            this.errEmail.SetIconAlignment(this.cboCustomerType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cboCustomerType.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.cboCustomerType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cboCustomerType.IconAlignment1"))));
            this.errorProvider2.SetIconAlignment(this.cboCustomerType, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cboCustomerType.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.cboCustomerType, ((int)(resources.GetObject("cboCustomerType.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.cboCustomerType, ((int)(resources.GetObject("cboCustomerType.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.cboCustomerType, ((int)(resources.GetObject("cboCustomerType.IconPadding2"))));
            this.cboCustomerType.Items.AddRange(new object[] {
            resources.GetString("cboCustomerType.Items"),
            resources.GetString("cboCustomerType.Items1")});
            this.cboCustomerType.Name = "cboCustomerType";
            this.cboCustomerType.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // datBirthdate
            // 
            resources.ApplyResources(this.datBirthdate, "datBirthdate");
            this.errEmail.SetError(this.datBirthdate, resources.GetString("datBirthdate.Error"));
            this.errorProvider2.SetError(this.datBirthdate, resources.GetString("datBirthdate.Error1"));
            this.errorProvider1.SetError(this.datBirthdate, resources.GetString("datBirthdate.Error2"));
            this.errEmail.SetIconAlignment(this.datBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirthdate.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.datBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirthdate.IconAlignment1"))));
            this.errorProvider2.SetIconAlignment(this.datBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirthdate.IconAlignment2"))));
            this.errorProvider2.SetIconPadding(this.datBirthdate, ((int)(resources.GetObject("datBirthdate.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.datBirthdate, ((int)(resources.GetObject("datBirthdate.IconPadding1"))));
            this.errEmail.SetIconPadding(this.datBirthdate, ((int)(resources.GetObject("datBirthdate.IconPadding2"))));
            this.datBirthdate.Name = "datBirthdate";
            this.datBirthdate.ValueChanged += new System.EventHandler(this.datBirthdate_ValueChanged);
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.errEmail.SetError(this.txtID, resources.GetString("txtID.Error"));
            this.errorProvider1.SetError(this.txtID, resources.GetString("txtID.Error1"));
            this.errorProvider2.SetError(this.txtID, resources.GetString("txtID.Error2"));
            this.errorProvider2.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment1"))));
            this.errorProvider1.SetIconAlignment(this.txtID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtID.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.txtID, ((int)(resources.GetObject("txtID.IconPadding2"))));
            this.txtID.Name = "txtID";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.errorProvider2.SetError(this.lblID, resources.GetString("lblID.Error"));
            this.errorProvider1.SetError(this.lblID, resources.GetString("lblID.Error1"));
            this.errEmail.SetError(this.lblID, resources.GetString("lblID.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblID.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblID.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblID.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblID, ((int)(resources.GetObject("lblID.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblID, ((int)(resources.GetObject("lblID.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblID, ((int)(resources.GetObject("lblID.IconPadding2"))));
            this.lblID.Name = "lblID";
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.errEmail.SetError(this.txtLastName, resources.GetString("txtLastName.Error"));
            this.errorProvider1.SetError(this.txtLastName, resources.GetString("txtLastName.Error1"));
            this.errorProvider2.SetError(this.txtLastName, resources.GetString("txtLastName.Error2"));
            this.errorProvider2.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment1"))));
            this.errorProvider1.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding2"))));
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblLastName
            // 
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.errorProvider2.SetError(this.lblLastName, resources.GetString("lblLastName.Error"));
            this.errorProvider1.SetError(this.lblLastName, resources.GetString("lblLastName.Error1"));
            this.errEmail.SetError(this.lblLastName, resources.GetString("lblLastName.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLastName.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLastName.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLastName.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblLastName, ((int)(resources.GetObject("lblLastName.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblLastName, ((int)(resources.GetObject("lblLastName.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblLastName, ((int)(resources.GetObject("lblLastName.IconPadding2"))));
            this.lblLastName.Name = "lblLastName";
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.errorProvider2.SetError(this.comboBox2, resources.GetString("comboBox2.Error"));
            this.errorProvider1.SetError(this.comboBox2, resources.GetString("comboBox2.Error1"));
            this.errEmail.SetError(this.comboBox2, resources.GetString("comboBox2.Error2"));
            this.comboBox2.FormattingEnabled = true;
            this.errEmail.SetIconAlignment(this.comboBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox2.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.comboBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox2.IconAlignment1"))));
            this.errorProvider2.SetIconAlignment(this.comboBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox2.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.comboBox2, ((int)(resources.GetObject("comboBox2.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.comboBox2, ((int)(resources.GetObject("comboBox2.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.comboBox2, ((int)(resources.GetObject("comboBox2.IconPadding2"))));
            this.comboBox2.Name = "comboBox2";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.errEmail.SetError(this.txtEmail, resources.GetString("txtEmail.Error"));
            this.errorProvider1.SetError(this.txtEmail, resources.GetString("txtEmail.Error1"));
            this.errorProvider2.SetError(this.txtEmail, resources.GetString("txtEmail.Error2"));
            this.errorProvider2.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment1"))));
            this.errorProvider1.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding2"))));
            this.txtEmail.Name = "txtEmail";
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.errEmail.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error"));
            this.errorProvider1.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error1"));
            this.errorProvider2.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error2"));
            this.errorProvider2.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment1"))));
            this.errorProvider1.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding2"))));
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtDiscount);
            this.panel3.Controls.Add(this.lblGrandTotal);
            this.panel3.Controls.Add(this.lblTotalSum);
            this.panel3.Controls.Add(this.lblGrand);
            this.panel3.Controls.Add(this.lblDiscount);
            this.panel3.Controls.Add(this.lblTotal);
            this.errorProvider1.SetError(this.panel3, resources.GetString("panel3.Error"));
            this.errorProvider2.SetError(this.panel3, resources.GetString("panel3.Error1"));
            this.errEmail.SetError(this.panel3, resources.GetString("panel3.Error2"));
            this.errorProvider1.SetIconAlignment(this.panel3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel3.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.panel3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel3.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.panel3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel3.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.panel3, ((int)(resources.GetObject("panel3.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.panel3, ((int)(resources.GetObject("panel3.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.panel3, ((int)(resources.GetObject("panel3.IconPadding2"))));
            this.panel3.Name = "panel3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider2.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error1"));
            this.errEmail.SetError(this.label1, resources.GetString("label1.Error2"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding1"))));
            this.errEmail.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding2"))));
            this.label1.Name = "label1";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.NavajoWhite;
            this.errorProvider1.SetError(this.panel4, resources.GetString("panel4.Error"));
            this.errorProvider2.SetError(this.panel4, resources.GetString("panel4.Error1"));
            this.errEmail.SetError(this.panel4, resources.GetString("panel4.Error2"));
            this.errorProvider1.SetIconAlignment(this.panel4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel4.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.panel4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel4.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.panel4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel4.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.panel4, ((int)(resources.GetObject("panel4.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.panel4, ((int)(resources.GetObject("panel4.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.panel4, ((int)(resources.GetObject("panel4.IconPadding2"))));
            this.panel4.Name = "panel4";
            // 
            // txtDiscount
            // 
            resources.ApplyResources(this.txtDiscount, "txtDiscount");
            this.errEmail.SetError(this.txtDiscount, resources.GetString("txtDiscount.Error"));
            this.errorProvider1.SetError(this.txtDiscount, resources.GetString("txtDiscount.Error1"));
            this.errorProvider2.SetError(this.txtDiscount, resources.GetString("txtDiscount.Error2"));
            this.errorProvider2.SetIconAlignment(this.txtDiscount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtDiscount.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.txtDiscount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtDiscount.IconAlignment1"))));
            this.errorProvider1.SetIconAlignment(this.txtDiscount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtDiscount.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtDiscount, ((int)(resources.GetObject("txtDiscount.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtDiscount, ((int)(resources.GetObject("txtDiscount.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.txtDiscount, ((int)(resources.GetObject("txtDiscount.IconPadding2"))));
            this.txtDiscount.Name = "txtDiscount";
            // 
            // lblGrandTotal
            // 
            resources.ApplyResources(this.lblGrandTotal, "lblGrandTotal");
            this.errorProvider2.SetError(this.lblGrandTotal, resources.GetString("lblGrandTotal.Error"));
            this.errorProvider1.SetError(this.lblGrandTotal, resources.GetString("lblGrandTotal.Error1"));
            this.errEmail.SetError(this.lblGrandTotal, resources.GetString("lblGrandTotal.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblGrandTotal, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblGrandTotal.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblGrandTotal, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblGrandTotal.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblGrandTotal, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblGrandTotal.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblGrandTotal, ((int)(resources.GetObject("lblGrandTotal.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblGrandTotal, ((int)(resources.GetObject("lblGrandTotal.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblGrandTotal, ((int)(resources.GetObject("lblGrandTotal.IconPadding2"))));
            this.lblGrandTotal.Name = "lblGrandTotal";
            // 
            // lblTotalSum
            // 
            resources.ApplyResources(this.lblTotalSum, "lblTotalSum");
            this.errorProvider2.SetError(this.lblTotalSum, resources.GetString("lblTotalSum.Error"));
            this.errorProvider1.SetError(this.lblTotalSum, resources.GetString("lblTotalSum.Error1"));
            this.errEmail.SetError(this.lblTotalSum, resources.GetString("lblTotalSum.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblTotalSum, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTotalSum.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblTotalSum, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTotalSum.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblTotalSum, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTotalSum.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblTotalSum, ((int)(resources.GetObject("lblTotalSum.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblTotalSum, ((int)(resources.GetObject("lblTotalSum.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblTotalSum, ((int)(resources.GetObject("lblTotalSum.IconPadding2"))));
            this.lblTotalSum.Name = "lblTotalSum";
            // 
            // lblGrand
            // 
            resources.ApplyResources(this.lblGrand, "lblGrand");
            this.errorProvider2.SetError(this.lblGrand, resources.GetString("lblGrand.Error"));
            this.errorProvider1.SetError(this.lblGrand, resources.GetString("lblGrand.Error1"));
            this.errEmail.SetError(this.lblGrand, resources.GetString("lblGrand.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblGrand, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblGrand.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblGrand, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblGrand.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblGrand, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblGrand.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblGrand, ((int)(resources.GetObject("lblGrand.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblGrand, ((int)(resources.GetObject("lblGrand.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblGrand, ((int)(resources.GetObject("lblGrand.IconPadding2"))));
            this.lblGrand.Name = "lblGrand";
            // 
            // lblDiscount
            // 
            resources.ApplyResources(this.lblDiscount, "lblDiscount");
            this.errorProvider2.SetError(this.lblDiscount, resources.GetString("lblDiscount.Error"));
            this.errorProvider1.SetError(this.lblDiscount, resources.GetString("lblDiscount.Error1"));
            this.errEmail.SetError(this.lblDiscount, resources.GetString("lblDiscount.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblDiscount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDiscount.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblDiscount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDiscount.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblDiscount, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDiscount.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblDiscount, ((int)(resources.GetObject("lblDiscount.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblDiscount, ((int)(resources.GetObject("lblDiscount.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblDiscount, ((int)(resources.GetObject("lblDiscount.IconPadding2"))));
            this.lblDiscount.Name = "lblDiscount";
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.errorProvider2.SetError(this.lblTotal, resources.GetString("lblTotal.Error"));
            this.errorProvider1.SetError(this.lblTotal, resources.GetString("lblTotal.Error1"));
            this.errEmail.SetError(this.lblTotal, resources.GetString("lblTotal.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblTotal, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTotal.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblTotal, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTotal.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblTotal, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTotal.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblTotal, ((int)(resources.GetObject("lblTotal.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblTotal, ((int)(resources.GetObject("lblTotal.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblTotal, ((int)(resources.GetObject("lblTotal.IconPadding2"))));
            this.lblTotal.Name = "lblTotal";
            // 
            // lblTableNumber
            // 
            resources.ApplyResources(this.lblTableNumber, "lblTableNumber");
            this.errorProvider2.SetError(this.lblTableNumber, resources.GetString("lblTableNumber.Error"));
            this.errorProvider1.SetError(this.lblTableNumber, resources.GetString("lblTableNumber.Error1"));
            this.errEmail.SetError(this.lblTableNumber, resources.GetString("lblTableNumber.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblTableNumber, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTableNumber.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblTableNumber, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTableNumber.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblTableNumber, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTableNumber.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblTableNumber, ((int)(resources.GetObject("lblTableNumber.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblTableNumber, ((int)(resources.GetObject("lblTableNumber.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblTableNumber, ((int)(resources.GetObject("lblTableNumber.IconPadding2"))));
            this.lblTableNumber.Name = "lblTableNumber";
            // 
            // lblTable
            // 
            resources.ApplyResources(this.lblTable, "lblTable");
            this.errorProvider2.SetError(this.lblTable, resources.GetString("lblTable.Error"));
            this.errorProvider1.SetError(this.lblTable, resources.GetString("lblTable.Error1"));
            this.errEmail.SetError(this.lblTable, resources.GetString("lblTable.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblTable, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTable.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblTable, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTable.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblTable, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTable.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblTable, ((int)(resources.GetObject("lblTable.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblTable, ((int)(resources.GetObject("lblTable.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblTable, ((int)(resources.GetObject("lblTable.IconPadding2"))));
            this.lblTable.Name = "lblTable";
            // 
            // lblBirthday
            // 
            resources.ApplyResources(this.lblBirthday, "lblBirthday");
            this.errorProvider2.SetError(this.lblBirthday, resources.GetString("lblBirthday.Error"));
            this.errorProvider1.SetError(this.lblBirthday, resources.GetString("lblBirthday.Error1"));
            this.errEmail.SetError(this.lblBirthday, resources.GetString("lblBirthday.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblBirthday, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblBirthday.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblBirthday, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblBirthday.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblBirthday, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblBirthday.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblBirthday, ((int)(resources.GetObject("lblBirthday.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblBirthday, ((int)(resources.GetObject("lblBirthday.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblBirthday, ((int)(resources.GetObject("lblBirthday.IconPadding2"))));
            this.lblBirthday.Name = "lblBirthday";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.errorProvider2.SetError(this.lblEmail, resources.GetString("lblEmail.Error"));
            this.errorProvider1.SetError(this.lblEmail, resources.GetString("lblEmail.Error1"));
            this.errEmail.SetError(this.lblEmail, resources.GetString("lblEmail.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblEmail.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblEmail.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblEmail.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblEmail, ((int)(resources.GetObject("lblEmail.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblEmail, ((int)(resources.GetObject("lblEmail.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblEmail, ((int)(resources.GetObject("lblEmail.IconPadding2"))));
            this.lblEmail.Name = "lblEmail";
            // 
            // lblFirstName
            // 
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.errorProvider2.SetError(this.lblFirstName, resources.GetString("lblFirstName.Error"));
            this.errorProvider1.SetError(this.lblFirstName, resources.GetString("lblFirstName.Error1"));
            this.errEmail.SetError(this.lblFirstName, resources.GetString("lblFirstName.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblFirstName.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblFirstName.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblFirstName.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblFirstName, ((int)(resources.GetObject("lblFirstName.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblFirstName, ((int)(resources.GetObject("lblFirstName.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblFirstName, ((int)(resources.GetObject("lblFirstName.IconPadding2"))));
            this.lblFirstName.Name = "lblFirstName";
            // 
            // lblCustomer
            // 
            resources.ApplyResources(this.lblCustomer, "lblCustomer");
            this.errorProvider2.SetError(this.lblCustomer, resources.GetString("lblCustomer.Error"));
            this.errorProvider1.SetError(this.lblCustomer, resources.GetString("lblCustomer.Error1"));
            this.errEmail.SetError(this.lblCustomer, resources.GetString("lblCustomer.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblCustomer, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCustomer.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblCustomer, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCustomer.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblCustomer, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblCustomer.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblCustomer, ((int)(resources.GetObject("lblCustomer.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblCustomer, ((int)(resources.GetObject("lblCustomer.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblCustomer, ((int)(resources.GetObject("lblCustomer.IconPadding2"))));
            this.lblCustomer.Name = "lblCustomer";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.errorProvider1.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.errorProvider2.SetError(this.btnCancel, resources.GetString("btnCancel.Error1"));
            this.errEmail.SetError(this.btnCancel, resources.GetString("btnCancel.Error2"));
            this.errorProvider1.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment2"))));
            this.errorProvider2.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding1"))));
            this.errEmail.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding2"))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.errorProvider1.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.errorProvider2.SetError(this.btnSave, resources.GetString("btnSave.Error1"));
            this.errEmail.SetError(this.btnSave, resources.GetString("btnSave.Error2"));
            this.errorProvider1.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment2"))));
            this.errorProvider2.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding1"))));
            this.errEmail.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding2"))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProduct,
            this.clmDown,
            this.clmQuantity,
            this.clmUp,
            this.clmTotal,
            this.clmDelete,
            this.clmID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.errorProvider2.SetError(this.dataGridView1, resources.GetString("dataGridView1.Error"));
            this.errorProvider1.SetError(this.dataGridView1, resources.GetString("dataGridView1.Error1"));
            this.errEmail.SetError(this.dataGridView1, resources.GetString("dataGridView1.Error2"));
            this.errorProvider2.SetIconAlignment(this.dataGridView1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dataGridView1.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.dataGridView1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dataGridView1.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.dataGridView1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("dataGridView1.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.dataGridView1, ((int)(resources.GetObject("dataGridView1.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.dataGridView1, ((int)(resources.GetObject("dataGridView1.IconPadding1"))));
            this.errEmail.SetIconPadding(this.dataGridView1, ((int)(resources.GetObject("dataGridView1.IconPadding2"))));
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // clmDown
            // 
            this.clmDown.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDown.FillWeight = 30F;
            resources.ApplyResources(this.clmDown, "clmDown");
            this.clmDown.Name = "clmDown";
            this.clmDown.ReadOnly = true;
            this.clmDown.Text = " -";
            this.clmDown.UseColumnTextForButtonValue = true;
            // 
            // clmUp
            // 
            this.clmUp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmUp.FillWeight = 30F;
            resources.ApplyResources(this.clmUp, "clmUp");
            this.clmUp.Name = "clmUp";
            this.clmUp.ReadOnly = true;
            this.clmUp.Text = " +";
            this.clmUp.UseColumnTextForButtonValue = true;
            // 
            // clmDelete
            // 
            this.clmDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDelete.FillWeight = 44F;
            resources.ApplyResources(this.clmDelete, "clmDelete");
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Tan;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorProvider2.SetError(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.Error"));
            this.errorProvider1.SetError(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.Error1"));
            this.errEmail.SetError(this.flowLayoutPanel1, resources.GetString("flowLayoutPanel1.Error2"));
            this.errEmail.SetIconAlignment(this.flowLayoutPanel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("flowLayoutPanel1.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.flowLayoutPanel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("flowLayoutPanel1.IconAlignment1"))));
            this.errorProvider1.SetIconAlignment(this.flowLayoutPanel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("flowLayoutPanel1.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.flowLayoutPanel1, ((int)(resources.GetObject("flowLayoutPanel1.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.flowLayoutPanel1, ((int)(resources.GetObject("flowLayoutPanel1.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this.flowLayoutPanel1, ((int)(resources.GetObject("flowLayoutPanel1.IconPadding2"))));
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // lblOr
            // 
            resources.ApplyResources(this.lblOr, "lblOr");
            this.errorProvider2.SetError(this.lblOr, resources.GetString("lblOr.Error"));
            this.errorProvider1.SetError(this.lblOr, resources.GetString("lblOr.Error1"));
            this.errEmail.SetError(this.lblOr, resources.GetString("lblOr.Error2"));
            this.errorProvider1.SetIconAlignment(this.lblOr, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblOr.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.lblOr, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblOr.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.lblOr, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblOr.IconAlignment2"))));
            this.errorProvider1.SetIconPadding(this.lblOr, ((int)(resources.GetObject("lblOr.IconPadding"))));
            this.errorProvider2.SetIconPadding(this.lblOr, ((int)(resources.GetObject("lblOr.IconPadding1"))));
            this.errEmail.SetIconPadding(this.lblOr, ((int)(resources.GetObject("lblOr.IconPadding2"))));
            this.lblOr.Name = "lblOr";
            // 
            // txtSearchName
            // 
            resources.ApplyResources(this.txtSearchName, "txtSearchName");
            this.errEmail.SetError(this.txtSearchName, resources.GetString("txtSearchName.Error"));
            this.errorProvider1.SetError(this.txtSearchName, resources.GetString("txtSearchName.Error1"));
            this.errorProvider2.SetError(this.txtSearchName, resources.GetString("txtSearchName.Error2"));
            this.errorProvider2.SetIconAlignment(this.txtSearchName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSearchName.IconAlignment"))));
            this.errEmail.SetIconAlignment(this.txtSearchName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSearchName.IconAlignment1"))));
            this.errorProvider1.SetIconAlignment(this.txtSearchName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSearchName.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.txtSearchName, ((int)(resources.GetObject("txtSearchName.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.txtSearchName, ((int)(resources.GetObject("txtSearchName.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.txtSearchName, ((int)(resources.GetObject("txtSearchName.IconPadding2"))));
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Click += new System.EventHandler(this.txtSearchName_Click);
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.errorProvider2.SetError(this.comboBox1, resources.GetString("comboBox1.Error"));
            this.errorProvider1.SetError(this.comboBox1, resources.GetString("comboBox1.Error1"));
            this.errEmail.SetError(this.comboBox1, resources.GetString("comboBox1.Error2"));
            this.comboBox1.FormattingEnabled = true;
            this.errEmail.SetIconAlignment(this.comboBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox1.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this.comboBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox1.IconAlignment1"))));
            this.errorProvider2.SetIconAlignment(this.comboBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox1.IconAlignment2"))));
            this.errEmail.SetIconPadding(this.comboBox1, ((int)(resources.GetObject("comboBox1.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.comboBox1, ((int)(resources.GetObject("comboBox1.IconPadding1"))));
            this.errorProvider2.SetIconPadding(this.comboBox1, ((int)(resources.GetObject("comboBox1.IconPadding2"))));
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = global::GUI.Properties.Resources.search_128px;
            this.errorProvider1.SetError(this.btnSearch, resources.GetString("btnSearch.Error"));
            this.errorProvider2.SetError(this.btnSearch, resources.GetString("btnSearch.Error1"));
            this.errEmail.SetError(this.btnSearch, resources.GetString("btnSearch.Error2"));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.errorProvider1.SetIconAlignment(this.btnSearch, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSearch.IconAlignment"))));
            this.errorProvider2.SetIconAlignment(this.btnSearch, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSearch.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this.btnSearch, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSearch.IconAlignment2"))));
            this.errorProvider2.SetIconPadding(this.btnSearch, ((int)(resources.GetObject("btnSearch.IconPadding"))));
            this.errorProvider1.SetIconPadding(this.btnSearch, ((int)(resources.GetObject("btnSearch.IconPadding1"))));
            this.errEmail.SetIconPadding(this.btnSearch, ((int)(resources.GetObject("btnSearch.IconPadding2"))));
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            resources.ApplyResources(this.errorProvider2, "errorProvider2");
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            resources.ApplyResources(this.errEmail, "errEmail");
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 200F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 0.1F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // clmProduct
            // 
            this.clmProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmProduct.FillWeight = 200F;
            resources.ApplyResources(this.clmProduct, "clmProduct");
            this.clmProduct.Name = "clmProduct";
            this.clmProduct.ReadOnly = true;
            // 
            // clmQuantity
            // 
            this.clmQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmQuantity.FillWeight = 50F;
            resources.ApplyResources(this.clmQuantity, "clmQuantity");
            this.clmQuantity.Name = "clmQuantity";
            // 
            // clmTotal
            // 
            this.clmTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmTotal.FillWeight = 150F;
            resources.ApplyResources(this.clmTotal, "clmTotal");
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            // 
            // clmID
            // 
            this.clmID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmID.FillWeight = 0.1F;
            resources.ApplyResources(this.clmID, "clmID");
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            // 
            // UserControlOrderProduct
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.errorProvider2.SetError(this, resources.GetString("$this.Error"));
            this.errorProvider1.SetError(this, resources.GetString("$this.Error1"));
            this.errEmail.SetError(this, resources.GetString("$this.Error2"));
            this.errorProvider2.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider1.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errEmail.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment2"))));
            this.errEmail.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.errorProvider2.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.errorProvider1.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding2"))));
            this.Name = "UserControlOrderProduct";
            this.Load += new System.EventHandler(this.UserControlOrderProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTotalSum;
        private System.Windows.Forms.Label lblGrand;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox cboCustomerType;
        private System.Windows.Forms.DateTimePicker datBirthdate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNoneName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduct;
        private System.Windows.Forms.DataGridViewButtonColumn clmDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn clmUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.ErrorProvider errEmail;
    }
}
