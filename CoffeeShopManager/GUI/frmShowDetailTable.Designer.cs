namespace GUI
{
    partial class frmShowDetailTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowDetailTable));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCurrentReceipt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTableID = new System.Windows.Forms.Label();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.txtCurrentReceipt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTableID);
            this.panel1.Controls.Add(this.txtTableID);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtStatus
            // 
            resources.ApplyResources(this.txtStatus, "txtStatus");
            this.txtStatus.Name = "txtStatus";
            // 
            // txtCurrentReceipt
            // 
            resources.ApplyResources(this.txtCurrentReceipt, "txtCurrentReceipt");
            this.txtCurrentReceipt.Name = "txtCurrentReceipt";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackgroundImage = global::GUI.Properties.Resources.ok_48px;
            resources.ApplyResources(this.btnCheckOut, "btnCheckOut");
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblTableID
            // 
            resources.ApplyResources(this.lblTableID, "lblTableID");
            this.lblTableID.Name = "lblTableID";
            // 
            // txtTableID
            // 
            resources.ApplyResources(this.txtTableID, "txtTableID");
            this.txtTableID.Name = "txtTableID";
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmShowDetailTable
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowDetailTable";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmShowDetailTable_FormClosed);
            this.Load += new System.EventHandler(this.frmShowDetailTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTableID;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtCurrentReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}