namespace GUI
{
    partial class UserControlManagerReceiptsTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlManagerReceiptsTab));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnView = new System.Windows.Forms.Button();
            this.grdReceipts = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.lblReceipts = new System.Windows.Forms.Label();
            this.datSearch = new System.Windows.Forms.DateTimePicker();
            this.ctxRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblResetFilters = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceipts)).BeginInit();
            this.ctxRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnView
            // 
            resources.ApplyResources(this.btnView, "btnView");
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            this.btnView.Name = "btnView";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // grdReceipts
            // 
            resources.ApplyResources(this.grdReceipts, "grdReceipts");
            this.grdReceipts.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdReceipts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdReceipts.BackgroundColor = System.Drawing.Color.White;
            this.grdReceipts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdReceipts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdReceipts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReceipts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(171)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdReceipts.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdReceipts.EnableHeadersVisualStyles = false;
            this.grdReceipts.Name = "grdReceipts";
            this.grdReceipts.ReadOnly = true;
            this.grdReceipts.RowHeadersVisible = false;
            this.grdReceipts.RowTemplate.Height = 24;
            this.grdReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdReceipts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReceipts_CellDoubleClick);
            this.grdReceipts.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdReceipts_CellMouseDown);
            this.grdReceipts.SelectionChanged += new System.EventHandler(this.grdReceipts_SelectionChanged);
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Name = "txtSearch";
            // 
            // cboSearch
            // 
            resources.ApplyResources(this.cboSearch, "cboSearch");
            this.cboSearch.BackColor = System.Drawing.Color.White;
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            resources.GetString("cboSearch.Items"),
            resources.GetString("cboSearch.Items1"),
            resources.GetString("cboSearch.Items2"),
            resources.GetString("cboSearch.Items3")});
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.cboSearch_SelectedIndexChanged);
            // 
            // lblReceipts
            // 
            resources.ApplyResources(this.lblReceipts, "lblReceipts");
            this.lblReceipts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            this.lblReceipts.Name = "lblReceipts";
            // 
            // datSearch
            // 
            resources.ApplyResources(this.datSearch, "datSearch");
            this.datSearch.Name = "datSearch";
            // 
            // ctxRightClick
            // 
            resources.ApplyResources(this.ctxRightClick, "ctxRightClick");
            this.ctxRightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.printToolStripMenuItem});
            this.ctxRightClick.Name = "ctxRightClick";
            // 
            // viewToolStripMenuItem
            // 
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.btnView_Click);
            // 
            // printToolStripMenuItem
            // 
            resources.ApplyResources(this.printToolStripMenuItem, "printToolStripMenuItem");
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblResetFilters
            // 
            resources.ApplyResources(this.lblResetFilters, "lblResetFilters");
            this.lblResetFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResetFilters.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResetFilters.Name = "lblResetFilters";
            this.lblResetFilters.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblResetFilters_MouseDown);
            this.lblResetFilters.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblResetFilters_MouseUp);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(179)))), ((int)(((byte)(134)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(56)))), ((int)(((byte)(46)))));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UserControlManagerReceiptsTab
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblResetFilters);
            this.Controls.Add(this.datSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.grdReceipts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.lblReceipts);
            this.Name = "UserControlManagerReceiptsTab";
            this.Load += new System.EventHandler(this.UserControlManagerReceiptsTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReceipts)).EndInit();
            this.ctxRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView grdReceipts;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Label lblReceipts;
        private System.Windows.Forms.DateTimePicker datSearch;
        private System.Windows.Forms.ContextMenuStrip ctxRightClick;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Label lblResetFilters;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}
