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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHome));
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
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = global::GUI.Properties.Resources.chart_48px;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // picStatistics
            // 
            resources.ApplyResources(this.picStatistics, "picStatistics");
            this.picStatistics.BackgroundImage = global::GUI.Properties.Resources.FreeVector_3D_Charts_Graphics;
            this.picStatistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStatistics.Name = "picStatistics";
            this.picStatistics.TabStop = false;
            this.picStatistics.Click += new System.EventHandler(this.picStatistics_Click);
            // 
            // picEmployees
            // 
            resources.ApplyResources(this.picEmployees, "picEmployees");
            this.picEmployees.BackgroundImage = global::GUI.Properties.Resources.Coffee_Shop;
            this.picEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEmployees.Name = "picEmployees";
            this.picEmployees.TabStop = false;
            this.picEmployees.Click += new System.EventHandler(this.picEmployees_Click);
            // 
            // picCustomer
            // 
            resources.ApplyResources(this.picCustomer, "picCustomer");
            this.picCustomer.BackgroundImage = global::GUI.Properties.Resources.GuysDrinkingBeer_Preview_02;
            this.picCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.TabStop = false;
            this.picCustomer.Click += new System.EventHandler(this.picCustomer_Click);
            // 
            // UserControlHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picStatistics);
            this.Controls.Add(this.picEmployees);
            this.Controls.Add(this.picCustomer);
            this.Name = "UserControlHome";
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
