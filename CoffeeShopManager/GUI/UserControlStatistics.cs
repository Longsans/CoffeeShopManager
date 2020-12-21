using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class UserControlStatistics : UserControl
    {
        int shopId;
        BUS_Shop busShop = new BUS_Shop();
        //DataGridView dataGridView2 = new DataGridView();
        //DataGridView dataGridView1 = new DataGridView();
        int year, month;
        public UserControlStatistics()
        {
            InitializeComponent();
        }
        public void SetShopID(int id)
        {
            shopId = id;
            cboIncomeView.SelectedIndex = 0;
            cboProductView.SelectedIndex = 0;
        }
        private void UserControlStatistics_Load(object sender, EventArgs e)
        {
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
        }
        private void Reload()
        {

        }
        private void IncomeChartByYear()
        {
            chartIncome.Series.Clear();
            dataGridView1.DataSource = busShop.GetDataTableAnnualIncome(shopId);
            chartIncome.Series.Add("Annual income");
            if (dataGridView1.Rows.Count - 1 > 1)
            chartIncome.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                chartIncome.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            lblTotalIncome.Text = busShop.GetTotalAllTimeIncome(shopId).ToString();
            lblAveIncome.Text = busShop.GetAverageAnnualIncome(shopId).ToString();
        }
        private void IncomeChartByQuarter()
        {
            chartIncome.Series.Clear();
            dataGridView1.DataSource = busShop.GetDataTableQuarterlyIncome(year, shopId);
            chartIncome.Series.Add("Income quarterly");
            if (dataGridView1.Rows.Count - 1 > 1)
                chartIncome.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                chartIncome.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            lblTotalIncome.Text = busShop.GetTotalAnnualIncome(year, shopId).ToString();
            lblAveIncome.Text = busShop.GetAverageQuarterlyIncome(year, shopId).ToString();
        }
        private void IncomeChartByMonth()
        {
            chartIncome.Series.Clear();
            dataGridView1.DataSource = busShop.GetDataTableMonthlyIncome(year, shopId);
            chartIncome.Series.Add("Income monthly");
            if (dataGridView1.Rows.Count - 1 > 1)
                chartIncome.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                chartIncome.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            lblTotalIncome.Text = busShop.GetTotalAnnualIncome(year, shopId).ToString();
            lblAveIncome.Text = busShop.GetAverageMonthlyIncome(year, shopId).ToString();
        }
        private void IncomeChartLast7Days()
        {
            chartIncome.Series.Clear();
            dataGridView1.DataSource = busShop.GetDataTableLastNDaysIncome(7, shopId);
            chartIncome.Series.Add("Income last 7 days");
            if (dataGridView1.Rows.Count - 1 > 1)
                chartIncome.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {   
                chartIncome.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            lblTotalIncome.Text = busShop.GetTotalLastNDaysIncome(7, shopId).ToString();
            lblAveIncome.Text = busShop.GetAverageLastNDaysIncome(7, shopId).ToString();
        }
        private void IncomeChartLast30Days()
        {
            chartIncome.Series.Clear();
            dataGridView1.DataSource = busShop.GetDataTableLastNDaysIncome(30, shopId);
            chartIncome.Series.Add("Income last 30 days");
            if (dataGridView1.Rows.Count - 1 > 1)
                chartIncome.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < dataGridView1.Rows.Count - 1 ; i++)
            {
                chartIncome.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            lblTotalIncome.Text = busShop.GetTotalLastNDaysIncome(30, shopId).ToString();
            lblAveIncome.Text = busShop.GetAverageLastNDaysIncome(30, shopId).ToString();
        }
        private void IncomeChartDaily()
        {
            chartIncome.Series.Clear();
            dataGridView1.DataSource = busShop.GetDataTableDailyIncome(month, year, shopId);
            chartIncome.Series.Add("Income daily");
            if (dataGridView1.Rows.Count - 1 > 1)
                chartIncome.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                chartIncome.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            lblTotalIncome.Text = busShop.GetTotalMonthlyIncome(month, year, shopId).ToString();
            lblAveIncome.Text = busShop.GetAverageDailyIncome(month, year, shopId).ToString();
        }
        private void cboIncomeView_SelectedIndexChanged(object sender, EventArgs e)
        {
           switch(cboIncomeView.SelectedIndex)
            {
                case 0:
                    IncomeChartByYear();
                    break;
                case 1:
                    IncomeChartByQuarter();
                    break;
                case 2:
                    IncomeChartByMonth();
                    break;
                case 3:
                    IncomeChartLast7Days();
                    break;
                case 4:
                    IncomeChartLast30Days();
                    break;
                case 5:
                    IncomeChartDaily();
                    break;
            }
        }
        private void ProductChartByYear()
        {
            chartProduct.Series.Clear();
            dataGridView2.DataSource = busShop.GetDatatableTotalAnnualProductSales(DateTime.Now.Year, shopId);
            chartProduct.Series.Add("Annual product sales");
            chartProduct.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartProduct.Series[0].IsValueShownAsLabel = true;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                chartProduct.Series[0].Points.AddXY(dataGridView2.Rows[i].Cells[1].Value.ToString(), double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()));
            }
        }
        private void ProductChartByQuarter()
        {
            
        }
        private void ProductChartByMonth()
        {
            chartProduct.Series.Clear();
            dataGridView2.DataSource = busShop.GetDatatableTotalMonthlyProductSales(DateTime.Now.Month, DateTime.Now.Year, shopId);
            chartProduct.Series.Add("Monthly product sales");
            chartProduct.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartProduct.Series[0].IsValueShownAsLabel = true;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                chartProduct.Series[0].Points.AddXY(dataGridView2.Rows[i].Cells[1].Value.ToString(), double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()));
            }
        }
        private void ProductChartLast7Days()
        {
            chartProduct.Series.Clear();
            dataGridView2.DataSource = busShop.GetDatatableTotalLastNDaysProductSales(7, shopId);
            chartProduct.Series.Add("Product sales last 7 days");
            chartProduct.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartProduct.Series[0].IsValueShownAsLabel = true;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                chartProduct.Series[0].Points.AddXY(dataGridView2.Rows[i].Cells[1].Value.ToString(), double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()));
            }
        }
        private void ProductChartLast30Days()
        {
            chartProduct.Series.Clear();
            dataGridView2.DataSource = busShop.GetDataTableQuarterlyIncome(30, shopId);
            chartProduct.Series.Add("Product sales last 30 days");
            chartProduct.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartProduct.Series[0].IsValueShownAsLabel = true;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                chartProduct.Series[0].Points.AddXY(dataGridView2.Rows[i].Cells[1].Value.ToString(), double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()));
            }
        }
        private void ProductChartDaily()
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            year = dateTimePicker1.Value.Year;
            month = dateTimePicker1.Value.Month;
            
        }

        private void cboProductView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboProductView.SelectedIndex)
            {
                case 0:
                    ProductChartByYear();
                    break;
                case 1:
                    ProductChartByQuarter();
                    break;
                case 2:
                    ProductChartByMonth();
                    break;
                case 3:
                    ProductChartLast7Days();
                    break;
                case 4:
                    ProductChartLast30Days();
                    break;
                case 5:
                    ProductChartDaily();
                    break;
            }
        }
    }
}
