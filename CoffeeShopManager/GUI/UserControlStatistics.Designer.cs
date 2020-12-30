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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStatistics));
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.chartIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlShowInfoIncome = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblAveIncome = new System.Windows.Forms.Label();
            this.datStats = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNoDataProduct = new System.Windows.Forms.Label();
            this.lblNoDataIncome = new System.Windows.Forms.Label();
            this.cboString = new System.Windows.Forms.ComboBox();
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
            resources.ApplyResources(this.chartProduct, "chartProduct");
            this.chartProduct.Name = "chartProduct";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProduct.Series.Add(series1);
            // 
            // cboIncomeView
            // 
            this.cboIncomeView.FormattingEnabled = true;
            this.cboIncomeView.Items.AddRange(new object[] {
            resources.GetString("cboIncomeView.Items"),
            resources.GetString("cboIncomeView.Items1"),
            resources.GetString("cboIncomeView.Items2"),
            resources.GetString("cboIncomeView.Items3"),
            resources.GetString("cboIncomeView.Items4"),
            resources.GetString("cboIncomeView.Items5")});
            resources.ApplyResources(this.cboIncomeView, "cboIncomeView");
            this.cboIncomeView.Name = "cboIncomeView";
            this.cboIncomeView.SelectedIndexChanged += new System.EventHandler(this.cboIncomeView_SelectedIndexChanged);
            // 
            // cboProductView
            // 
            this.cboProductView.FormattingEnabled = true;
            this.cboProductView.Items.AddRange(new object[] {
            resources.GetString("cboProductView.Items"),
            resources.GetString("cboProductView.Items1"),
            resources.GetString("cboProductView.Items2"),
            resources.GetString("cboProductView.Items3"),
            resources.GetString("cboProductView.Items4")});
            resources.ApplyResources(this.cboProductView, "cboProductView");
            this.cboProductView.Name = "cboProductView";
            this.cboProductView.SelectedIndexChanged += new System.EventHandler(this.cboProductView_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblTotalSales
            // 
            resources.ApplyResources(this.lblTotalSales, "lblTotalSales");
            this.lblTotalSales.Name = "lblTotalSales";
            // 
            // pnlShowInfoProductSales
            // 
            this.pnlShowInfoProductSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlShowInfoProductSales.Controls.Add(this.label1);
            this.pnlShowInfoProductSales.Controls.Add(this.lblTotalSales);
            resources.ApplyResources(this.pnlShowInfoProductSales, "pnlShowInfoProductSales");
            this.pnlShowInfoProductSales.Name = "pnlShowInfoProductSales";
            // 
            // lblTitle
            // 
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // chartIncome
            // 
            chartArea2.Name = "ChartArea1";
            this.chartIncome.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartIncome.Legends.Add(legend2);
            resources.ApplyResources(this.chartIncome, "chartIncome");
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
            title1.Name = "Income";
            this.chartIncome.Titles.Add(title1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // pnlShowInfoIncome
            // 
            this.pnlShowInfoIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlShowInfoIncome.Controls.Add(this.label3);
            this.pnlShowInfoIncome.Controls.Add(this.label2);
            this.pnlShowInfoIncome.Controls.Add(this.lblTotalIncome);
            this.pnlShowInfoIncome.Controls.Add(this.lblAveIncome);
            resources.ApplyResources(this.pnlShowInfoIncome, "pnlShowInfoIncome");
            this.pnlShowInfoIncome.Name = "pnlShowInfoIncome";
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
            // lblTotalIncome
            // 
            resources.ApplyResources(this.lblTotalIncome, "lblTotalIncome");
            this.lblTotalIncome.Name = "lblTotalIncome";
            // 
            // lblAveIncome
            // 
            resources.ApplyResources(this.lblAveIncome, "lblAveIncome");
            this.lblAveIncome.Name = "lblAveIncome";
            // 
            // datStats
            // 
            resources.ApplyResources(this.datStats, "datStats");
            this.datStats.Name = "datStats";
            this.datStats.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lblNoDataProduct
            // 
            resources.ApplyResources(this.lblNoDataProduct, "lblNoDataProduct");
            this.lblNoDataProduct.Name = "lblNoDataProduct";
            // 
            // lblNoDataIncome
            // 
            resources.ApplyResources(this.lblNoDataIncome, "lblNoDataIncome");
            this.lblNoDataIncome.Name = "lblNoDataIncome";
            // 
            // cboString
            // 
            this.cboString.FormattingEnabled = true;
            this.cboString.Items.AddRange(new object[] {
            resources.GetString("cboString.Items"),
            resources.GetString("cboString.Items1"),
            resources.GetString("cboString.Items2"),
            resources.GetString("cboString.Items3"),
            resources.GetString("cboString.Items4"),
            resources.GetString("cboString.Items5"),
            resources.GetString("cboString.Items6"),
            resources.GetString("cboString.Items7"),
            resources.GetString("cboString.Items8"),
            resources.GetString("cboString.Items9"),
            resources.GetString("cboString.Items10")});
            resources.ApplyResources(this.cboString, "cboString");
            this.cboString.Name = "cboString";
            // 
            // UserControlStatistics
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.cboString);
            this.Controls.Add(this.lblNoDataIncome);
            this.Controls.Add(this.lblNoDataProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datStats);
            this.Controls.Add(this.chartProduct);
            this.Controls.Add(this.cboProductView);
            this.Controls.Add(this.pnlShowInfoProductSales);
            this.Controls.Add(this.chartIncome);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlShowInfoIncome);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cboIncomeView);
            this.Name = "UserControlStatistics";
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIncome;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlShowInfoIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblAveIncome;
        private System.Windows.Forms.DateTimePicker datStats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNoDataProduct;
        private System.Windows.Forms.Label lblNoDataIncome;
        private System.Windows.Forms.ComboBox cboString;
    }
}
