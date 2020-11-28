namespace GUI
{
    partial class UserControlTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.btnOccupied = new System.Windows.Forms.Button();
            this.btnUnavailable = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboBy = new System.Windows.Forms.ComboBox();
            this.lblBy = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filter by:";
            // 
            // btnAll
            // 
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.Location = new System.Drawing.Point(139, 99);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 28);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnAvailable
            // 
            this.btnAvailable.FlatAppearance.BorderSize = 0;
            this.btnAvailable.Location = new System.Drawing.Point(230, 99);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(75, 28);
            this.btnAvailable.TabIndex = 3;
            this.btnAvailable.Text = "Available";
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // btnOccupied
            // 
            this.btnOccupied.FlatAppearance.BorderSize = 0;
            this.btnOccupied.Location = new System.Drawing.Point(321, 99);
            this.btnOccupied.Name = "btnOccupied";
            this.btnOccupied.Size = new System.Drawing.Size(87, 28);
            this.btnOccupied.TabIndex = 3;
            this.btnOccupied.Text = "Occupied";
            this.btnOccupied.UseVisualStyleBackColor = true;
            this.btnOccupied.Click += new System.EventHandler(this.btnOccupied_Click);
            // 
            // btnUnavailable
            // 
            this.btnUnavailable.FlatAppearance.BorderSize = 0;
            this.btnUnavailable.Location = new System.Drawing.Point(414, 99);
            this.btnUnavailable.Name = "btnUnavailable";
            this.btnUnavailable.Size = new System.Drawing.Size(101, 28);
            this.btnUnavailable.TabIndex = 3;
            this.btnUnavailable.Text = "Unavailable";
            this.btnUnavailable.UseVisualStyleBackColor = true;
            this.btnUnavailable.Click += new System.EventHandler(this.btnUnavailable_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(47, 143);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(675, 391);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 28);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(580, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(158, 22);
            this.txtSearch.TabIndex = 9;
            // 
            // cboBy
            // 
            this.cboBy.FormattingEnabled = true;
            this.cboBy.Items.AddRange(new object[] {
            "ID Customer",
            "ID Table"});
            this.cboBy.Location = new System.Drawing.Point(580, 67);
            this.cboBy.Name = "cboBy";
            this.cboBy.Size = new System.Drawing.Size(126, 24);
            this.cboBy.TabIndex = 8;
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBy.Location = new System.Drawing.Point(501, 67);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(29, 19);
            this.lblBy.TabIndex = 5;
            this.lblBy.Text = "By:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(501, 28);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 19);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search:";
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Image = global::GUI.Properties.Resources.sort_right_24px;
            this.btnCollapse.Location = new System.Drawing.Point(802, 29);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(14, 24);
            this.btnCollapse.TabIndex = 11;
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExpand.FlatAppearance.BorderSize = 0;
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Image = global::GUI.Properties.Resources.sort_left_24px;
            this.btnExpand.Location = new System.Drawing.Point(744, 29);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(18, 24);
            this.btnExpand.TabIndex = 10;
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::GUI.Properties.Resources.search_24px;
            this.btnSearch.Location = new System.Drawing.Point(768, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 22);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UserControlTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboBy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblBy);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnUnavailable);
            this.Controls.Add(this.btnOccupied);
            this.Controls.Add(this.btnAvailable);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UserControlTable";
            this.Size = new System.Drawing.Size(887, 550);
            this.Load += new System.EventHandler(this.UserControlTable_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.Button btnOccupied;
        private System.Windows.Forms.Button btnUnavailable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    }
}
