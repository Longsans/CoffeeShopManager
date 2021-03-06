﻿using System;
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
        BUS_Shop busShop = new BUS_Shop(ConnectionStringHelper.GetConnectionString());
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
            datStats.Format = DateTimePickerFormat.Custom;
            datStats.CustomFormat = "dd/MM/yyyy";
        }
        public void Reload()
        {
            ReloadIncomeChart();
            ReloadProductChart();
        }
        private void IncomeChartByYear()
        {
            chartIncome.Series.Clear();
            dataGridView1.DataSource = busShop.GetDataTableAnnualIncome(shopId);
            chartIncome.Series.Add(cboString.Items[0].ToString());
            if (dataGridView1.Rows.Count - 1 > 1)
            chartIncome.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                chartIncome.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            lblTotalIncome.Text = busShop.GetTotalAllTimeIncome(shopId).ToString();
            lblAveIncome.Text = busShop.GetAverageAnnualIncome(shopId).ToString();
            if (lblTotalIncome.Text == "-1") lblTotalIncome.Text = "0";
            if (lblAveIncome.Text == "-1") lblAveIncome.Text = "0";
            if (double.Parse(lblTotalIncome.Text) == 0 || double.Parse(lblAveIncome.Text) == 0) lblNoDataIncome.Show();
            else lblNoDataIncome.Hide();
        }
        private void IncomeChartByQuarter()
        {
            chartIncome.Series.Clear();
            dataGridView1.DataSource = busShop.GetDataTableQuarterlyIncome(year, shopId);
            chartIncome.Series.Add(cboString.Items[1].ToString());
            if (dataGridView1.Rows.Count - 1 > 1)
                chartIncome.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                chartIncome.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            lblTotalIncome.Text = busShop.GetTotalAnnualIncome(year, shopId).ToString();
            lblAveIncome.Text = busShop.GetAverageQuarterlyIncome(year, shopId).ToString();
            if (lblTotalIncome.Text == "-1") lblTotalIncome.Text = "0";
            if (lblAveIncome.Text == "-1") lblAveIncome.Text = "0";
            if (double.Parse(lblTotalIncome.Text) == 0 || double.Parse(lblAveIncome.Text) == 0) lblNoDataIncome.Show();
            else lblNoDataIncome.Hide();
        }
        private void IncomeChartByMonth()
        {
            chartIncome.Series.Clear();
            dataGridView1.DataSource = busShop.GetDataTableMonthlyIncome(year, shopId);
            chartIncome.Series.Add(cboString.Items[2].ToString());
            if (dataGridView1.Rows.Count - 1 > 1)
                chartIncome.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                chartIncome.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            lblTotalIncome.Text = busShop.GetTotalAnnualIncome(year, shopId).ToString();
            lblAveIncome.Text = busShop.GetAverageMonthlyIncome(year, shopId).ToString();
            if (lblTotalIncome.Text == "-1") lblTotalIncome.Text = "0";
            if (lblAveIncome.Text == "-1") lblAveIncome.Text = "0";
            if (double.Parse(lblTotalIncome.Text) == 0 || double.Parse(lblAveIncome.Text) == 0) lblNoDataIncome.Show();
            else lblNoDataIncome.Hide();
        }
        private void IncomeChartLast7Days()
        {
            chartIncome.Series.Clear();
            dataGridView1.DataSource = busShop.GetDataTableLastNDaysIncome(7, shopId);
            chartIncome.Series.Add(cboString.Items[3].ToString());
            if (dataGridView1.Rows.Count - 1 > 1)
                chartIncome.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {   
                chartIncome.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            lblTotalIncome.Text = busShop.GetTotalLastNDaysIncome(7, shopId).ToString();
            lblAveIncome.Text = busShop.GetAverageLastNDaysIncome(7, shopId).ToString();
            if (lblTotalIncome.Text == "-1") lblTotalIncome.Text = "0";
            if (lblAveIncome.Text == "-1") lblAveIncome.Text = "0";
            if (double.Parse(lblTotalIncome.Text) == 0 || double.Parse(lblAveIncome.Text) == 0) lblNoDataIncome.Show();
            else lblNoDataIncome.Hide();
        }
        private void IncomeChartLast30Days()
        {
            chartIncome.Series.Clear();
            dataGridView1.DataSource = busShop.GetDataTableLastNDaysIncome(30, shopId);
            chartIncome.Series.Add(cboString.Items[4].ToString());
            if (dataGridView1.Rows.Count - 1 > 1)
                chartIncome.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < dataGridView1.Rows.Count - 1 ; i++)
            {
                chartIncome.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            lblTotalIncome.Text = busShop.GetTotalLastNDaysIncome(30, shopId).ToString();
            lblAveIncome.Text = busShop.GetAverageLastNDaysIncome(30, shopId).ToString();
            if (lblTotalIncome.Text == "-1") lblTotalIncome.Text = "0";
            if (lblAveIncome.Text == "-1") lblAveIncome.Text = "0";
            if (double.Parse(lblTotalIncome.Text) == 0 || double.Parse(lblAveIncome.Text) == 0) lblNoDataIncome.Show();
            else lblNoDataIncome.Hide();
        }
        private void IncomeChartDaily()
        {
            chartIncome.Series.Clear();
            dataGridView1.DataSource = busShop.GetDataTableDailyIncome(month, year, shopId);
            chartIncome.Series.Add(cboString.Items[5].ToString());
            if (dataGridView1.Rows.Count - 1 > 1)
                chartIncome.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                chartIncome.Series[0].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
            }
            lblTotalIncome.Text = busShop.GetTotalMonthlyIncome(month, year, shopId).ToString();
            lblAveIncome.Text = busShop.GetAverageDailyIncome(month, year, shopId).ToString();
            if (lblTotalIncome.Text == "-1") lblTotalIncome.Text = "0";
            if (lblAveIncome.Text == "-1") lblAveIncome.Text = "0";
            if (double.Parse(lblTotalIncome.Text) == 0 || double.Parse(lblAveIncome.Text) == 0) lblNoDataIncome.Show();
            else lblNoDataIncome.Hide();
        }
        private void cboIncomeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadIncomeChart();
        }
        private void ProductChartByYear()
        {
            DataTable dt = new DataTable();
            chartProduct.Series.Clear();
            dt = busShop.GetDatatableTotalAnnualProductSales(year, shopId);
            dataGridView2.DataSource = dt;
            chartProduct.Series.Add(cboString.Items[6].ToString());
            chartProduct.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartProduct.Series[0].IsValueShownAsLabel = true;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                chartProduct.Series[0].Points.AddXY(dataGridView2.Rows[i].Cells[1].Value.ToString(), double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()));
            }
            lblTotalSales.Text = busShop.GetTotalAllProductSalesFromDataTable(dt).ToString();
            if (lblTotalSales.Text == "0" || lblTotalSales.Text == "-1") lblNoDataProduct.Show();
            else lblNoDataProduct.Hide();
        }
        private void ProductChartAllTime()
        {
            DataTable dt = new DataTable();
            chartProduct.Series.Clear();
            dt = busShop.GetDatatableTotalAllTimeProductSales(shopId);
            dataGridView2.DataSource = dt;
            chartProduct.Series.Add(cboString.Items[7].ToString());
            chartProduct.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartProduct.Series[0].IsValueShownAsLabel = true;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                chartProduct.Series[0].Points.AddXY(dataGridView2.Rows[i].Cells[1].Value.ToString(), double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()));
            }
            lblTotalSales.Text = busShop.GetTotalAllProductSalesFromDataTable(dt).ToString();
            if (lblTotalSales.Text == "0" || lblTotalSales.Text == "-1") lblNoDataProduct.Show();
            else lblNoDataProduct.Hide();
        }
        private void ProductChartByMonth()
        {
            DataTable dt = new DataTable();
            chartProduct.Series.Clear();
            dt = busShop.GetDatatableTotalMonthlyProductSales(month, year, shopId);
            dataGridView2.DataSource = dt;
            chartProduct.Series.Add(cboString.Items[8].ToString());
            chartProduct.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartProduct.Series[0].IsValueShownAsLabel = true;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                chartProduct.Series[0].Points.AddXY(dataGridView2.Rows[i].Cells[1].Value.ToString(), double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()));
            }
            lblTotalSales.Text = busShop.GetTotalAllProductSalesFromDataTable(dt).ToString();
            if (lblTotalSales.Text == "0" || lblTotalSales.Text == "-1") lblNoDataProduct.Show();
            else lblNoDataProduct.Hide();
        }
        private void ProductChartLast7Days()
        {
            DataTable dt = new DataTable();
            chartProduct.Series.Clear();
            dt = busShop.GetDatatableTotalLastNDaysProductSales(7, shopId);
            dataGridView2.DataSource = dt;
            chartProduct.Series.Add(cboString.Items[9].ToString());
            chartProduct.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartProduct.Series[0].IsValueShownAsLabel = true;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                chartProduct.Series[0].Points.AddXY(dataGridView2.Rows[i].Cells[1].Value.ToString(), double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()));
            }
            lblTotalSales.Text = busShop.GetTotalAllProductSalesFromDataTable(dt).ToString();
            if (lblTotalSales.Text == "0" || lblTotalSales.Text == "-1") lblNoDataProduct.Show();
            else lblNoDataProduct.Hide();
        }
        private void ProductChartLast30Days()
        {
            DataTable dt = new DataTable();
            chartProduct.Series.Clear();
            dt = busShop.GetDatatableTotalLastNDaysProductSales(30, shopId);
            dataGridView2.DataSource = dt;
            chartProduct.Series.Add(cboString.Items[10].ToString());
            chartProduct.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartProduct.Series[0].IsValueShownAsLabel = true;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                chartProduct.Series[0].Points.AddXY(dataGridView2.Rows[i].Cells[1].Value.ToString(), double.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()));
            }
            lblTotalSales.Text = busShop.GetTotalAllProductSalesFromDataTable(dt).ToString();
            if (lblTotalSales.Text == "0" || lblTotalSales.Text == "-1") lblNoDataProduct.Show();
            else lblNoDataProduct.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            year = datStats.Value.Year;
            month = datStats.Value.Month;
            ReloadIncomeChart();
            ReloadProductChart();

        }

        private void cboProductView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadProductChart();
        }
        private void ReloadIncomeChart()
        {
            switch (cboIncomeView.SelectedIndex)
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
        private void ReloadProductChart()
        {
            switch (cboProductView.SelectedIndex)
            {
                case 0:
                    ProductChartAllTime();
                    break;
                case 1:
                    ProductChartByYear();
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
            }
        }
    }
}
