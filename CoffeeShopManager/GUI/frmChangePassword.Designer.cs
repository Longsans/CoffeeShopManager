namespace GUI
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRetypeNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(134)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.btnSaveChange);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRetypeNewPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtCurrentPassword);
            this.errorProvider1.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorProvider1.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.panel1.Name = "panel1";
            // 
            // btnSaveChange
            // 
            resources.ApplyResources(this.btnSaveChange, "btnSaveChange");
            this.btnSaveChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSaveChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorProvider1.SetError(this.btnSaveChange, resources.GetString("btnSaveChange.Error"));
            this.btnSaveChange.FlatAppearance.BorderSize = 0;
            this.btnSaveChange.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.errorProvider1.SetIconAlignment(this.btnSaveChange, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSaveChange.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnSaveChange, ((int)(resources.GetObject("btnSaveChange.IconPadding"))));
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.UseVisualStyleBackColor = false;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // txtRetypeNewPassword
            // 
            resources.ApplyResources(this.txtRetypeNewPassword, "txtRetypeNewPassword");
            this.errorProvider1.SetError(this.txtRetypeNewPassword, resources.GetString("txtRetypeNewPassword.Error"));
            this.errorProvider1.SetIconAlignment(this.txtRetypeNewPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtRetypeNewPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtRetypeNewPassword, ((int)(resources.GetObject("txtRetypeNewPassword.IconPadding"))));
            this.txtRetypeNewPassword.Name = "txtRetypeNewPassword";
            this.txtRetypeNewPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // txtNewPassword
            // 
            resources.ApplyResources(this.txtNewPassword, "txtNewPassword");
            this.errorProvider1.SetError(this.txtNewPassword, resources.GetString("txtNewPassword.Error"));
            this.errorProvider1.SetIconAlignment(this.txtNewPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNewPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtNewPassword, ((int)(resources.GetObject("txtNewPassword.IconPadding"))));
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.errorProvider1.SetError(this.lblPassword, resources.GetString("lblPassword.Error"));
            this.errorProvider1.SetIconAlignment(this.lblPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblPassword, ((int)(resources.GetObject("lblPassword.IconPadding"))));
            this.lblPassword.Name = "lblPassword";
            // 
            // txtCurrentPassword
            // 
            resources.ApplyResources(this.txtCurrentPassword, "txtCurrentPassword");
            this.errorProvider1.SetError(this.txtCurrentPassword, resources.GetString("txtCurrentPassword.Error"));
            this.errorProvider1.SetIconAlignment(this.txtCurrentPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCurrentPassword.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtCurrentPassword, ((int)(resources.GetObject("txtCurrentPassword.IconPadding"))));
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.UseSystemPasswordChar = true;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // frmChangePassword
            // 
            this.AcceptButton = this.btnSaveChange;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRetypeNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}