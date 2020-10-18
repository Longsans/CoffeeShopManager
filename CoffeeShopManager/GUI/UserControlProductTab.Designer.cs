namespace GUI
{
    partial class UserControlProductTab
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
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowDrink = new System.Windows.Forms.Button();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnShowOther = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewImage = new System.Windows.Forms.Button();
            this.btnViewDataGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(89, 29);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(95, 36);
            this.btnShowAll.TabIndex = 0;
            this.btnShowAll.Text = "All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShowDrink
            // 
            this.btnShowDrink.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnShowDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDrink.FlatAppearance.BorderSize = 0;
            this.btnShowDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDrink.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDrink.Location = new System.Drawing.Point(200, 29);
            this.btnShowDrink.Name = "btnShowDrink";
            this.btnShowDrink.Size = new System.Drawing.Size(95, 36);
            this.btnShowDrink.TabIndex = 0;
            this.btnShowDrink.Text = "Drink";
            this.btnShowDrink.UseVisualStyleBackColor = false;
            this.btnShowDrink.Click += new System.EventHandler(this.btnShowDrink_Click);
            // 
            // btnShowFood
            // 
            this.btnShowFood.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnShowFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowFood.FlatAppearance.BorderSize = 0;
            this.btnShowFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFood.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFood.Location = new System.Drawing.Point(317, 29);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(95, 36);
            this.btnShowFood.TabIndex = 0;
            this.btnShowFood.Text = "Food";
            this.btnShowFood.UseVisualStyleBackColor = false;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnShowOther
            // 
            this.btnShowOther.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnShowOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowOther.FlatAppearance.BorderSize = 0;
            this.btnShowOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOther.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOther.Location = new System.Drawing.Point(435, 29);
            this.btnShowOther.Name = "btnShowOther";
            this.btnShowOther.Size = new System.Drawing.Size(95, 36);
            this.btnShowOther.TabIndex = 0;
            this.btnShowOther.Text = "Other";
            this.btnShowOther.UseVisualStyleBackColor = false;
            this.btnShowOther.Click += new System.EventHandler(this.btnShowOther_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(830, 275);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(550, 31);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 33);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(631, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 33);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(550, 81);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 22);
            this.txtSearch.TabIndex = 4;
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "Name",
            "Type",
            "Price"});
            this.cboSearch.Location = new System.Drawing.Point(550, 109);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(148, 24);
            this.cboSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Image = global::GUI.Properties.Resources.search_24px;
            this.btnSearch.Location = new System.Drawing.Point(705, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 27);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnViewImage
            // 
            this.btnViewImage.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewImage.FlatAppearance.BorderSize = 0;
            this.btnViewImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewImage.Image = global::GUI.Properties.Resources.view_details_26px;
            this.btnViewImage.Location = new System.Drawing.Point(742, 32);
            this.btnViewImage.Name = "btnViewImage";
            this.btnViewImage.Size = new System.Drawing.Size(33, 33);
            this.btnViewImage.TabIndex = 2;
            this.btnViewImage.UseVisualStyleBackColor = false;
            // 
            // btnViewDataGrid
            // 
            this.btnViewDataGrid.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDataGrid.FlatAppearance.BorderSize = 0;
            this.btnViewDataGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDataGrid.Image = global::GUI.Properties.Resources.grid_view_24px;
            this.btnViewDataGrid.Location = new System.Drawing.Point(702, 32);
            this.btnViewDataGrid.Name = "btnViewDataGrid";
            this.btnViewDataGrid.Size = new System.Drawing.Size(34, 33);
            this.btnViewDataGrid.TabIndex = 2;
            this.btnViewDataGrid.UseVisualStyleBackColor = false;
            // 
            // UserControlProductTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewImage);
            this.Controls.Add(this.btnViewDataGrid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShowOther);
            this.Controls.Add(this.btnShowFood);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnShowDrink);
            this.Controls.Add(this.btnShowAll);
            this.Name = "UserControlProductTab";
            this.Size = new System.Drawing.Size(830, 446);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowDrink;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnShowOther;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewDataGrid;
        private System.Windows.Forms.Button btnViewImage;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}
