namespace GUI
{
    partial class UserControlHome
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picStatistics = new System.Windows.Forms.PictureBox();
            this.picEmployees = new System.Windows.Forms.PictureBox();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Employees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Statistics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Customer";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GUI.Properties.Resources.chart_48px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(28, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dashboard";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // picStatistics
            // 
            this.picStatistics.BackgroundImage = global::GUI.Properties.Resources.FreeVector_3D_Charts_Graphics;
            this.picStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStatistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStatistics.Location = new System.Drawing.Point(306, 294);
            this.picStatistics.Name = "picStatistics";
            this.picStatistics.Size = new System.Drawing.Size(192, 145);
            this.picStatistics.TabIndex = 8;
            this.picStatistics.TabStop = false;
            // 
            // picEmployees
            // 
            this.picEmployees.BackgroundImage = global::GUI.Properties.Resources.Coffee_Shop;
            this.picEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEmployees.Location = new System.Drawing.Point(140, 98);
            this.picEmployees.Name = "picEmployees";
            this.picEmployees.Size = new System.Drawing.Size(194, 145);
            this.picEmployees.TabIndex = 7;
            this.picEmployees.TabStop = false;
            this.picEmployees.Click += new System.EventHandler(this.picEmployees_Click);
            // 
            // picCustomer
            // 
            this.picCustomer.BackgroundImage = global::GUI.Properties.Resources.GuysDrinkingBeer_Preview_02;
            this.picCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCustomer.Location = new System.Drawing.Point(488, 98);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(183, 145);
            this.picCustomer.TabIndex = 6;
            this.picCustomer.TabStop = false;
            // 
            // UserControlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picStatistics);
            this.Controls.Add(this.picEmployees);
            this.Controls.Add(this.picCustomer);
            this.Name = "UserControlHome";
            this.Size = new System.Drawing.Size(824, 484);
            ((System.ComponentModel.ISupportInitialize)(this.picStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCustomer;
        private System.Windows.Forms.PictureBox picEmployees;
        private System.Windows.Forms.PictureBox picStatistics;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
