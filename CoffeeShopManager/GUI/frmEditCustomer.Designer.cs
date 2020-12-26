namespace GUI
{
    partial class frmEditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCustomer));
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datBirthdate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorFalse = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTrue = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFalse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTrue)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            resources.ApplyResources(this.pnlTitleBar, "pnlTitleBar");
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(67)))), ((int)(((byte)(58)))));
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.errorTrue.SetError(this.pnlTitleBar, resources.GetString("pnlTitleBar.Error"));
            this.errorFalse.SetError(this.pnlTitleBar, resources.GetString("pnlTitleBar.Error1"));
            this.errorTrue.SetIconAlignment(this.pnlTitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pnlTitleBar.IconAlignment"))));
            this.errorFalse.SetIconAlignment(this.pnlTitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pnlTitleBar.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.pnlTitleBar, ((int)(resources.GetObject("pnlTitleBar.IconPadding"))));
            this.errorTrue.SetIconPadding(this.pnlTitleBar, ((int)(resources.GetObject("pnlTitleBar.IconPadding1"))));
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.pnlTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.errorFalse.SetError(this.btnExit, resources.GetString("btnExit.Error"));
            this.errorTrue.SetError(this.btnExit, resources.GetString("btnExit.Error1"));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.errorFalse.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.btnExit, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnExit.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding"))));
            this.errorFalse.SetIconPadding(this.btnExit, ((int)(resources.GetObject("btnExit.IconPadding1"))));
            this.btnExit.Image = global::GUI.Properties.Resources.close_window_24px1;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.datBirthdate);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.errorTrue.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorFalse.SetError(this.panel1, resources.GetString("panel1.Error1"));
            this.errorTrue.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorFalse.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment1"))));
            this.errorFalse.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.errorTrue.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding1"))));
            this.panel1.Name = "panel1";
            // 
            // datBirthdate
            // 
            resources.ApplyResources(this.datBirthdate, "datBirthdate");
            this.errorTrue.SetError(this.datBirthdate, resources.GetString("datBirthdate.Error"));
            this.errorFalse.SetError(this.datBirthdate, resources.GetString("datBirthdate.Error1"));
            this.errorFalse.SetIconAlignment(this.datBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirthdate.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.datBirthdate, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("datBirthdate.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.datBirthdate, ((int)(resources.GetObject("datBirthdate.IconPadding"))));
            this.errorFalse.SetIconPadding(this.datBirthdate, ((int)(resources.GetObject("datBirthdate.IconPadding1"))));
            this.datBirthdate.Name = "datBirthdate";
            this.datBirthdate.ValueChanged += new System.EventHandler(this.datBirthdate_ValueChanged);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorFalse.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.errorTrue.SetError(this.btnCancel, resources.GetString("btnCancel.Error1"));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            this.errorFalse.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.errorFalse.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding1"))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorFalse.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.errorTrue.SetError(this.btnSave, resources.GetString("btnSave.Error1"));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            this.errorFalse.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.errorFalse.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding1"))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.errorFalse.SetError(this.txtEmail, resources.GetString("txtEmail.Error"));
            this.errorTrue.SetError(this.txtEmail, resources.GetString("txtEmail.Error1"));
            this.errorTrue.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment"))));
            this.errorFalse.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding"))));
            this.errorFalse.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding1"))));
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.No;
            this.errorFalse.SetError(this.txtLastName, resources.GetString("txtLastName.Error"));
            this.errorTrue.SetError(this.txtLastName, resources.GetString("txtLastName.Error1"));
            this.errorTrue.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment"))));
            this.errorFalse.SetIconAlignment(this.txtLastName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLastName.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding"))));
            this.errorFalse.SetIconPadding(this.txtLastName, ((int)(resources.GetObject("txtLastName.IconPadding1"))));
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.No;
            this.errorFalse.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error"));
            this.errorTrue.SetError(this.txtFirstName, resources.GetString("txtFirstName.Error1"));
            this.errorTrue.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment"))));
            this.errorFalse.SetIconAlignment(this.txtFirstName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFirstName.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding"))));
            this.errorFalse.SetIconPadding(this.txtFirstName, ((int)(resources.GetObject("txtFirstName.IconPadding1"))));
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Cursor = System.Windows.Forms.Cursors.No;
            this.errorFalse.SetError(this.txtId, resources.GetString("txtId.Error"));
            this.errorTrue.SetError(this.txtId, resources.GetString("txtId.Error1"));
            this.errorTrue.SetIconAlignment(this.txtId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtId.IconAlignment"))));
            this.errorFalse.SetIconAlignment(this.txtId, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtId.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.txtId, ((int)(resources.GetObject("txtId.IconPadding"))));
            this.errorFalse.SetIconPadding(this.txtId, ((int)(resources.GetObject("txtId.IconPadding1"))));
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorFalse.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorTrue.SetError(this.label1, resources.GetString("label1.Error1"));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            this.errorFalse.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorTrue.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment1"))));
            this.errorTrue.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.errorFalse.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding1"))));
            this.label1.Name = "label1";
            // 
            // errorFalse
            // 
            this.errorFalse.ContainerControl = this;
            resources.ApplyResources(this.errorFalse, "errorFalse");
            // 
            // errorTrue
            // 
            this.errorTrue.ContainerControl = this;
            resources.ApplyResources(this.errorTrue, "errorTrue");
            // 
            // frmEditCustomer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditCustomer";
            this.Load += new System.EventHandler(this.frmEditCustomer_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFalse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTrue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker datBirthdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorFalse;
        private System.Windows.Forms.ErrorProvider errorTrue;
    }
}