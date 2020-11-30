using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class UserControlStock : UserControl
    {
        BUS_StockItems busStock = new BUS_StockItems();
        public DTO_Shop Shop = new DTO_Shop();

        public UserControlStock()
        {
            InitializeComponent();
        }

        private void UserControlStock_Load(object sender, EventArgs e)
        {
            txtSearch.LostFocus += TxtSearch_LostFocus;
            txtSearch.GotFocus += TxtSearch_GotFocus;
            Reload();
        }

        private void TxtSearch_LostFocus(object sender, EventArgs e)
        {
            if (txtSearch.TextLength == 0)
            {
                txtSearch.ForeColor = Color.DimGray;
                txtSearch.Text = "Search...";
            }
        }

        private void TxtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.DimGray)
            {
                txtSearch.Clear();
                txtSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void grdStock_SelectionChanged(object sender, EventArgs e)
        {
            if (grdStock.SelectedRows != null)
            {
                if (grdStock.SelectedRows.Count == 1)
                {
                    btnEdit.Enabled = true;
                }
                else
                {
                    btnEdit.Enabled = false;
                }
                btnDelete.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void Reload()
        {
            grdStock.DataSource = busStock.GetAllStockItems(Shop.ID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch(cboSearch.Text)
            {
                case "ID":
                    {
                        grdStock.DataSource = busStock.GetDataTableById(txtSearch.Text, Shop.ID);
                    }
                    break;
                case "Name":
                    {
                        grdStock.DataSource = busStock.GetDataTableByName(txtSearch.Text, Shop.ID);
                    }
                    break;
                case "Supplier ID":
                    {
                        grdStock.DataSource = busStock.GetDataTableBySupplierId(txtSearch.Text, Shop.ID);
                    }
                    break;
            }
        }
    }
}
