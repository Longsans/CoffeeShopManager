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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTable));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.btnOccupied = new System.Windows.Forms.Button();
            this.btnUnavailable = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboBy = new System.Windows.Forms.ComboBox();
            this.lblBy = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnAll
            // 
            resources.ApplyResources(this.btnAll, "btnAll");
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.Name = "btnAll";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnAvailable
            // 
            resources.ApplyResources(this.btnAvailable, "btnAvailable");
            this.btnAvailable.FlatAppearance.BorderSize = 0;
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // btnOccupied
            // 
            resources.ApplyResources(this.btnOccupied, "btnOccupied");
            this.btnOccupied.FlatAppearance.BorderSize = 0;
            this.btnOccupied.Name = "btnOccupied";
            this.btnOccupied.UseVisualStyleBackColor = true;
            this.btnOccupied.Click += new System.EventHandler(this.btnOccupied_Click);
            // 
            // btnUnavailable
            // 
            resources.ApplyResources(this.btnUnavailable, "btnUnavailable");
            this.btnUnavailable.FlatAppearance.BorderSize = 0;
            this.btnUnavailable.Name = "btnUnavailable";
            this.btnUnavailable.UseVisualStyleBackColor = true;
            this.btnUnavailable.Click += new System.EventHandler(this.btnUnavailable_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            // 
            // cboBy
            // 
            resources.ApplyResources(this.cboBy, "cboBy");
            this.cboBy.FormattingEnabled = true;
            this.cboBy.Items.AddRange(new object[] {
            resources.GetString("cboBy.Items"),
            resources.GetString("cboBy.Items1")});
            this.cboBy.Name = "cboBy";
            // 
            // lblBy
            // 
            resources.ApplyResources(this.lblBy, "lblBy");
            this.lblBy.Name = "lblBy";
            // 
            // lblSearch
            // 
            resources.ApplyResources(this.lblSearch, "lblSearch");
            this.lblSearch.Name = "lblSearch";
            // 
            // btnCollapse
            // 
            resources.ApplyResources(this.btnCollapse, "btnCollapse");
            this.btnCollapse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.Image = global::GUI.Properties.Resources.sort_right_24px;
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExpand
            // 
            resources.ApplyResources(this.btnExpand, "btnExpand");
            this.btnExpand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExpand.FlatAppearance.BorderSize = 0;
            this.btnExpand.Image = global::GUI.Properties.Resources.sort_left_24px;
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Image = global::GUI.Properties.Resources.search_24px;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UserControlTable
            // 
            resources.ApplyResources(this, "$this");
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
            this.Load += new System.EventHandler(this.UserControlTable_Load);
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
    }
}
