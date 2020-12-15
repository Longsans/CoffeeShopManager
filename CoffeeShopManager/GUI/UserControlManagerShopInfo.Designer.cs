namespace GUI
{
    partial class UserControlManagerShopInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlManagerShopInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.txtShopAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.btnChangeAuthCode = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // txtShopName
            // 
            resources.ApplyResources(this.txtShopName, "txtShopName");
            this.txtShopName.Name = "txtShopName";
            // 
            // txtShopAddress
            // 
            resources.ApplyResources(this.txtShopAddress, "txtShopAddress");
            this.txtShopAddress.Name = "txtShopAddress";
            // 
            // txtPhoneNumber
            // 
            resources.ApplyResources(this.txtPhoneNumber, "txtPhoneNumber");
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            // 
            // btnSaveChange
            // 
            resources.ApplyResources(this.btnSaveChange, "btnSaveChange");
            this.btnSaveChange.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSaveChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChange.FlatAppearance.BorderSize = 0;
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.UseVisualStyleBackColor = false;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // btnChangeAuthCode
            // 
            resources.ApplyResources(this.btnChangeAuthCode, "btnChangeAuthCode");
            this.btnChangeAuthCode.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnChangeAuthCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeAuthCode.FlatAppearance.BorderSize = 0;
            this.btnChangeAuthCode.Name = "btnChangeAuthCode";
            this.btnChangeAuthCode.UseVisualStyleBackColor = false;
            this.btnChangeAuthCode.Click += new System.EventHandler(this.btnChangeAuthCode_Click);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEdit.Image = global::GUI.Properties.Resources.edit_30px;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // UserControlManagerShopInfo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.btnChangeAuthCode);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtShopAddress);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlManagerShopInfo";
            this.Load += new System.EventHandler(this.UserControlManagerShopInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.TextBox txtShopAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.Button btnChangeAuthCode;
    }
}
