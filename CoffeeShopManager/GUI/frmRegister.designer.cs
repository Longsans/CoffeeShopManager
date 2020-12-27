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
            this.datBirthdate = new System.Windows.Forms.DateTimePicker();
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
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(67)))), ((int)(((byte)(58)))));
            this.TitleBar.Controls.Add(this.btnExit);
            resources.ApplyResources(this.TitleBar, "TitleBar");
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Image = global::GUI.Properties.Resources.close_window_24px1;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(134)))), ((int)(((byte)(102)))));
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Image = global::GUI.Properties.Resources.back_32px;
            this.btnBack.Name = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblShopName
            // 
            resources.ApplyResources(this.lblShopName, "lblShopName");
            this.lblShopName.Name = "lblShopName";
            // 
            // lblAuthCode
            // 
            resources.ApplyResources(this.lblAuthCode, "lblAuthCode");
            this.lblAuthCode.Name = "lblAuthCode";
            // 
            // fpnlCreateNew
            // 
            resources.ApplyResources(this.fpnlCreateNew, "fpnlCreateNew");
            this.fpnlCreateNew.BackColor = System.Drawing.Color.White;
            this.fpnlCreateNew.Controls.Add(this.pictureBox2);
            this.fpnlCreateNew.Controls.Add(this.label15);
            this.fpnlCreateNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fpnlCreateNew.Name = "fpnlCreateNew";
            this.fpnlCreateNew.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GUI.Properties.Resources.add_new_30px;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Name = "label15";
            this.label15.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblShopId
            // 
            resources.ApplyResources(this.lblShopId, "lblShopId");
            this.lblShopId.Name = "lblShopId";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // txtShopId
            // 
            resources.ApplyResources(this.txtShopId, "txtShopId");
            this.txtShopId.ForeColor = System.Drawing.Color.DimGray;
            this.txtShopId.Name = "txtShopId";
            this.txtShopId.TextChanged += new System.EventHandler(this.txtShopId_TextChanged);
            // 
            // txtAuthCode
            // 
            resources.ApplyResources(this.txtAuthCode, "txtAuthCode");
            this.txtAuthCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtAuthCode.Name = "txtAuthCode";
            this.txtAuthCode.TextChanged += new System.EventHandler(this.txtAuthCode_TextChanged);
            // 
            // txtShopName
            // 
            resources.ApplyResources(this.txtShopName, "txtShopName");
            this.txtShopName.ForeColor = System.Drawing.Color.DimGray;
            this.txtShopName.Name = "txtShopName";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBrowseImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseImg.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnBrowseImg, "btnBrowseImg");
            this.btnBrowseImg.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.UseVisualStyleBackColor = false;
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // lblNoImg
            // 
            resources.ApplyResources(this.lblNoImg, "lblNoImg");
            this.lblNoImg.Name = "lblNoImg";
            // 
            // picboxManImg
            // 
            this.picboxManImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.picboxManImg, "picboxManImg");
            this.picboxManImg.Name = "picboxManImg";
            this.picboxManImg.TabStop = false;
            this.picboxManImg.Tag = "";
            // 
            // radFemale
            // 
            resources.ApplyResources(this.radFemale, "radFemale");
            this.radFemale.Name = "radFemale";
            this.radFemale.TabStop = true;
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            resources.ApplyResources(this.radMale, "radMale");
            this.radMale.Name = "radMale";
            this.radMale.TabStop = true;
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            resources.ApplyResources(this.txtPhone, "txtPhone");
            this.txtPhone.Name = "txtPhone";
            // 
            // txtLastName
            // 
            resources.ApplyResources(this.txtLastName, "txtLastName");
            this.txtLastName.Name = "txtLastName";
            // 
            // txtFirstName
            // 
            resources.ApplyResources(this.txtFirstName, "txtFirstName");
            this.txtFirstName.Name = "txtFirstName";
            // 
            // lblBirthdate
            // 
            resources.ApplyResources(this.lblBirthdate, "lblBirthdate");
            this.lblBirthdate.Name = "lblBirthdate";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GUI.Properties.Resources.user_40px;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnExit2
            // 
            this.btnExit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnExit2, "btnExit2");
            this.btnExit2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.UseVisualStyleBackColor = false;
            this.btnExit2.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSignUp, "btnSignUp");
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtConfirm
            // 
            resources.ApplyResources(this.txtConfirm, "txtConfirm");
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            resources.ApplyResources(this.txtPass, "txtPass");
            this.txtPass.Name = "txtPass";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            // 
            // errShop
            // 
            this.errShop.ContainerControl = this;
            // 
            // datBirthdate
            // 
            resources.ApplyResources(this.datBirthdate, "datBirthdate");
            this.datBirthdate.Name = "datBirthdate";
            // 
            // errManId
            // 
            this.errManId.ContainerControl = this;
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
    }
}