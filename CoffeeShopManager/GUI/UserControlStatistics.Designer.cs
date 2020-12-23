namespace GUI
{
    partial class UserControlStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboIncomeView = new System.Windows.Forms.ComboBox();
            this.cboProductView = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.pnlShowInfoProductSales = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chartIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlShowInfoIncome = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblAveIncome = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            this.pnlShowInfoProductSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlShowInfoIncome.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartProduct
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProduct.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProduct.Legends.Add(legend1);
            this.chartProduct.Location = new System.Drawing.Point(8, 325);
            this.chartProduct.Name = "chartProduct";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProduct.Series.Add(series1);
            this.chartProduct.Size = new System.Drawing.Size(557, 257);
            this.chartProduct.TabIndex = 1;
            this.chartProduct.Text = "chart2";
            // 
            // cboIncomeView
            // 
            this.cboIncomeView.FormattingEnabled = true;
            this.cboIncomeView.Items.AddRange(new object[] {
            "By year",
            "By quarter",
            "By month",
            "By last 7 days",
            "By last 30 days",
            "By daily"});
            this.cboIncomeView.Location = new System.Drawing.Point(687, 16);
            this.cboIncomeView.Name = "cboIncomeView";
            this.cboIncomeView.Size = new System.Drawing.Size(121, 24);
            this.cboIncomeView.TabIndex = 4;
            this.cboIncomeView.SelectedIndexChanged += new System.EventHandler(this.cboIncomeView_SelectedIndexChanged);
            // 
            // cboProductView
            // 
            this.cboProductView.FormattingEnabled = true;
            this.cboProductView.Items.AddRange(new object[] {
            "All time\t",
            "By year",
            "By month",
            "Last 7 days ",
            "Last 30 days"});
            this.cboProductView.Location = new System.Drawing.Point(687, 334);
            this.cboProductView.Name = "cboProductView";
            this.cboProductView.Size = new System.Drawing.Size(121, 24);
            this.cboProductView.TabIndex = 5;
            this.cboProductView.SelectedIndexChanged += new System.EventHandler(this.cboProductView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total sales:";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(149, 39);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(17, 19);
            this.lblTotalSales.TabIndex = 15;
            this.lblTotalSales.Text = "0";
            // 
            // pnlShowInfoProductSales
            // 
            this.pnlShowInfoProductSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlShowInfoProductSales.Controls.Add(this.label1);
            this.pnlShowInfoProductSales.Controls.Add(this.lblTotalSales);
            this.pnlShowInfoProductSales.Location = new System.Drawing.Point(584, 482);
            this.pnlShowInfoProductSales.Name = "pnlShowInfoProductSales";
            this.pnlShowInfoProductSales.Size = new System.Drawing.Size(322, 100);
            this.pnlShowInfoProductSales.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 34);
            this.label4.TabIndex = 21;
            this.label4.Text = "Statistics";
            // 
            // chartIncome
            // 
            chartArea2.Name = "ChartArea1";
            this.chartIncome.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartIncome.Legends.Add(legend2);
            this.chartIncome.Location = new System.Drawing.Point(3, 51);
            this.chartIncome.Name = "chartIncome";
            this.chartIncome.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chartIncome.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))))};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chartIncome.Series.Add(series2);
            this.chartIncome.Size = new System.Drawing.Size(562, 257);
            this.chartIncome.TabIndex = 0;
            this.chartIncome.Text = "chart1";
            title1.Name = "Income";
            this.chartIncome.Titles.Add(title1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(945, 83);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(62, 36);
            this.dataGridView2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(953, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(54, 61);
            this.dataGridView1.TabIndex = 8;
            // 
            // pnlShowInfoIncome
            // 
            this.pnlShowInfoIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlShowInfoIncome.Controls.Add(this.label3);
            this.pnlShowInfoIncome.Controls.Add(this.label2);
            this.pnlShowInfoIncome.Controls.Add(this.lblTotalIncome);
            this.pnlShowInfoIncome.Controls.Add(this.lblAveIncome);
            this.pnlShowInfoIncome.Location = new System.Drawing.Point(579, 218);
            this.pnlShowInfoIncome.Name = "pnlShowInfoIncome";
            this.pnlShowInfoIncome.Size = new System.Drawing.Size(327, 101);
            this.pnlShowInfoIncome.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Average income:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total income:";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIncome.Location = new System.Drawing.Point(200, 12);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(17, 19);
            this.lblTotalIncome.TabIndex = 13;
            this.lblTotalIncome.Text = "0";
            // 
            // lblAveIncome
            // 
            this.lblAveIncome.AutoSize = true;
            this.lblAveIncome.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAveIncome.Location = new System.Drawing.Point(200, 62);
            this.lblAveIncome.Name = "lblAveIncome";
            this.lblAveIncome.Size = new System.Drawing.Size(17, 19);
            this.lblAveIncome.TabIndex = 14;
            this.lblAveIncome.Text = "0";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(687, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "By:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(582, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Select date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(582, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "By:";
            // 
            // UserControlStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chartProduct);
            this.Controls.Add(this.cboProductView);
            this.Controls.Add(this.pnlShowInfoProductSales);
            this.Controls.Add(this.chartIncome);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlShowInfoIncome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboIncomeView);
            this.Name = "UserControlStatistics";
            this.Size = new System.Drawing.Size(1041, 607);
            this.Load += new System.EventHandler(this.UserControlStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            this.pnlShowInfoProductSales.ResumeLayout(false);
            this.pnlShowInfoProductSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlShowInfoIncome.ResumeLayout(false);
            this.pnlShowInfoIncome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private System.Windows.Forms.ComboBox cboIncomeView;
        private System.Windows.Forms.ComboBox cboProductView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Panel pnlShowInfoProductSales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncome;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlShowInfoIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblAveIncome;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
