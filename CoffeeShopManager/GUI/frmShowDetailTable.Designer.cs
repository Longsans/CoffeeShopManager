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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.txtCurrentReceipt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTableID);
            this.panel1.Controls.Add(this.txtTableID);
            this.errorProvider1.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorProvider1.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtStatus
            // 
            resources.ApplyResources(this.txtStatus, "txtStatus");
            this.errorProvider1.SetError(this.txtStatus, resources.GetString("txtStatus.Error"));
            this.errorProvider1.SetIconAlignment(this.txtStatus, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtStatus.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtStatus, ((int)(resources.GetObject("txtStatus.IconPadding"))));
            this.txtStatus.Name = "txtStatus";
            this.toolTip1.SetToolTip(this.txtStatus, resources.GetString("txtStatus.ToolTip"));
            // 
            // txtCurrentReceipt
            // 
            resources.ApplyResources(this.txtCurrentReceipt, "txtCurrentReceipt");
            this.errorProvider1.SetError(this.txtCurrentReceipt, resources.GetString("txtCurrentReceipt.Error"));
            this.errorProvider1.SetIconAlignment(this.txtCurrentReceipt, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCurrentReceipt.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtCurrentReceipt, ((int)(resources.GetObject("txtCurrentReceipt.IconPadding"))));
            this.txtCurrentReceipt.Name = "txtCurrentReceipt";
            this.toolTip1.SetToolTip(this.txtCurrentReceipt, resources.GetString("txtCurrentReceipt.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // btnCheckOut
            // 
            resources.ApplyResources(this.btnCheckOut, "btnCheckOut");
            this.btnCheckOut.BackgroundImage = global::GUI.Properties.Resources.ok_48px;
            this.errorProvider1.SetError(this.btnCheckOut, resources.GetString("btnCheckOut.Error"));
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.errorProvider1.SetIconAlignment(this.btnCheckOut, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCheckOut.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnCheckOut, ((int)(resources.GetObject("btnCheckOut.IconPadding"))));
            this.btnCheckOut.Name = "btnCheckOut";
            this.toolTip1.SetToolTip(this.btnCheckOut, resources.GetString("btnCheckOut.ToolTip"));
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // lblTableID
            // 
            resources.ApplyResources(this.lblTableID, "lblTableID");
            this.errorProvider1.SetError(this.lblTableID, resources.GetString("lblTableID.Error"));
            this.errorProvider1.SetIconAlignment(this.lblTableID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTableID.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.lblTableID, ((int)(resources.GetObject("lblTableID.IconPadding"))));
            this.lblTableID.Name = "lblTableID";
            this.toolTip1.SetToolTip(this.lblTableID, resources.GetString("lblTableID.ToolTip"));
            // 
            // txtTableID
            // 
            resources.ApplyResources(this.txtTableID, "txtTableID");
            this.errorProvider1.SetError(this.txtTableID, resources.GetString("txtTableID.Error"));
            this.errorProvider1.SetIconAlignment(this.txtTableID, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtTableID.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.txtTableID, ((int)(resources.GetObject("txtTableID.IconPadding"))));
            this.txtTableID.Name = "txtTableID";
            this.toolTip1.SetToolTip(this.txtTableID, resources.GetString("txtTableID.ToolTip"));
            // 
            // TitleBar
            // 
            resources.ApplyResources(this.TitleBar, "TitleBar");
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.TitleBar.Controls.Add(this.btnExit);
            this.errorProvider1.SetError(this.TitleBar, resources.GetString("TitleBar.Error"));
            this.errorProvider1.SetIconAlignment(this.TitleBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("TitleBar.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.TitleBar, ((int)(resources.GetObject("TitleBar.IconPadding"))));
            this.TitleBar.Name = "TitleBar";
            this.toolTip1.SetToolTip(this.TitleBar, resources.GetString("TitleBar.ToolTip"));
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
            this.toolTip1.SetToolTip(this.btnExit, resources.GetString("btnExit.ToolTip"));
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // frmShowDetailTable
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowDetailTable";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
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