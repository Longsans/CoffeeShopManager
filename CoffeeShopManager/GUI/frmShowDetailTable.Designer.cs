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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSetUnavailable = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnSetUnavailable);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.txtCurrentReceipt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTableID);
            this.panel1.Controls.Add(this.txtTableID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 291);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSetUnavailable
            // 
            this.btnSetUnavailable.BackgroundImage = global::GUI.Properties.Resources.hammer_96px;
            this.btnSetUnavailable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetUnavailable.FlatAppearance.BorderSize = 0;
            this.btnSetUnavailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUnavailable.Location = new System.Drawing.Point(242, 212);
            this.btnSetUnavailable.Name = "btnSetUnavailable";
            this.btnSetUnavailable.Size = new System.Drawing.Size(56, 49);
            this.btnSetUnavailable.TabIndex = 14;
            this.btnSetUnavailable.UseVisualStyleBackColor = true;
            this.btnSetUnavailable.Click += new System.EventHandler(this.btnSetUnavailable_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(181, 84);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(117, 26);
            this.txtStatus.TabIndex = 13;
            // 
            // txtCurrentReceipt
            // 
            this.txtCurrentReceipt.Enabled = false;
            this.txtCurrentReceipt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentReceipt.Location = new System.Drawing.Point(181, 141);
            this.txtCurrentReceipt.Name = "txtCurrentReceipt";
            this.txtCurrentReceipt.Size = new System.Drawing.Size(117, 26);
            this.txtCurrentReceipt.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current receipt ID";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackgroundImage = global::GUI.Properties.Resources.ok_48px;
            this.btnCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Location = new System.Drawing.Point(83, 205);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(71, 63);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status";
            // 
            // lblTableID
            // 
            this.lblTableID.AutoSize = true;
            this.lblTableID.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableID.Location = new System.Drawing.Point(38, 35);
            this.lblTableID.Name = "lblTableID";
            this.lblTableID.Size = new System.Drawing.Size(63, 19);
            this.lblTableID.TabIndex = 4;
            this.lblTableID.Text = "Table ID";
            // 
            // txtTableID
            // 
            this.txtTableID.Enabled = false;
            this.txtTableID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableID.Location = new System.Drawing.Point(181, 35);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.Size = new System.Drawing.Size(117, 26);
            this.txtTableID.TabIndex = 5;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(118)))), ((int)(((byte)(69)))));
            this.TitleBar.Controls.Add(this.btnExit);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(395, 30);
            this.TitleBar.TabIndex = 3;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::GUI.Properties.Resources.close_window_24px1;
            this.btnExit.Location = new System.Drawing.Point(364, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmShowDetailTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowDetailTable";
            this.Text = "Detail of table";
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
        private System.Windows.Forms.Button btnSetUnavailable;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}