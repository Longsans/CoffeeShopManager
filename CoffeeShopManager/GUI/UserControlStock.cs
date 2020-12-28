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
        BUS_StockItems busStock = new BUS_StockItems(ConnectionStringHelper.GetConnectionString());
        FilterProperties filProp = new FilterProperties();
        ErrorProvider err = new ErrorProvider();
        public DTO_Shop Shop = new DTO_Shop();
        public frmManager frmMan { get; set; }

        public UserControlStock()
        {
            InitializeComponent();
        }

        private void UserControlStock_Load(object sender, EventArgs e)
        {
            err.SetIconPadding(txtSearch, -10);
            txtSearch.LostFocus += TxtSearch_LostFocus;
            txtSearch.GotFocus += TxtSearch_GotFocus;
            ReloadGridView();
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

        public void ReloadGridView()
        {
            switch(filProp.CurrentFilter)
            {
                case "ID":
                    {
                        if (int.TryParse(filProp.CurrentFilterText, out int id))
                        {
                            grdStock.DataSource = busStock.GetDataTableById(id, Shop.ID);
                        }
                    }
                    break;
                case "Name":
                    {
                        grdStock.DataSource = busStock.GetDataTableByName(filProp.CurrentFilterText, Shop.ID);
                    }
                    break;
                case "Supplier ID":
                    {
                        grdStock.DataSource = busStock.GetDataTableBySupplierId(filProp.CurrentFilterText, Shop.ID);
                    }
                    break;
                case "Supplier Name":
                    {
                        grdStock.DataSource = busStock.GetDataTableBySupplierName(filProp.CurrentFilterText, Shop.ID);
                    }
                    break;
                case "Tên":
                    {
                        grdStock.DataSource = busStock.GetDataTableByName(filProp.CurrentFilterText, Shop.ID);
                    }
                    break;
                case "ID nhà cung cấp":
                    {
                        grdStock.DataSource = busStock.GetDataTableBySupplierId(filProp.CurrentFilterText, Shop.ID);
                    }
                    break;
                case "Tên nhà cung cấp":
                    {
                        grdStock.DataSource = busStock.GetDataTableBySupplierName(filProp.CurrentFilterText, Shop.ID);
                    }
                    break;
                default:
                    {
                        grdStock.DataSource = busStock.GetAllStockItems(Shop.ID);
                    }
                    break;
            }
            if (lblStock.Text != "Stock")
            {
                grdStock.Columns["Item Name"].HeaderText = "Tên sản phẩm";
                grdStock.Columns["Supplier ID"].HeaderText = "ID Nhà cung";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cboSearch.Text))
            {
                err.SetError(txtSearch, "");
                var resultIndex = cboSearch.FindStringExact(cboSearch.Text);
                switch (resultIndex)
                {
                    case 0:
                        {
                            if (int.TryParse(txtSearch.Text, out int id))
                            {
                                grdStock.DataSource = busStock.GetDataTableById(id, Shop.ID);
                            }
                            else
                            {
                                if (btnEdit.Text == "Sửa")
                                err.SetError(txtSearch, "ID hàng hóa phải là số tự nhiên");
                                else err.SetError(txtSearch, "Stock item ID must be a natural number");
                            }
                        }
                        break;
                    case 1:
                        {
                            grdStock.DataSource = busStock.GetDataTableByName(txtSearch.Text, Shop.ID);
                        }
                        break;
                    case 2:
                        {
                            grdStock.DataSource = busStock.GetDataTableBySupplierId(txtSearch.Text, Shop.ID);
                        }
                        break;
                    case 3:
                        {
                            grdStock.DataSource = busStock.GetDataTableBySupplierName(txtSearch.Text, Shop.ID);
                        }
                        break;
                }
                lblResetFilters.Visible = true;
                filProp.CurrentFilter = cboSearch.Text;
                filProp.CurrentFilterText = txtSearch.Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddStockItem frmAdd = new frmAddStockItem
            {
                Shop = this.Shop,
                ucStock = this
            };

            frmAdd.Location = new Point(frmMan.Location.X + frmMan.Width / 2 - frmAdd.Width / 2,
                    frmMan.Location.Y + frmMan.Height / 2 - frmAdd.Height / 2);
            frmAdd.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdStock.SelectedRows)
            {
                if (lblStock.Text == "Stock")
                {

                    var item = new DTO_StockItem
                    {
                        Id = (int)row.Cells["ID"].Value,
                        Name = row.Cells["Item Name"].Value.ToString(),
                        Shop = this.Shop,
                        Supplier = new DTO_Supplier
                        {
                            Id = row.Cells["Supplier ID"].Value.ToString()
                        }
                    };

                    busStock.Delete(item);
                }
                else
                {
                    var item = new DTO_StockItem
                    {
                        Id = (int)row.Cells["ID"].Value,
                        Name = row.Cells["Tên sản phẩm"].Value.ToString(),
                        Shop = this.Shop,
                        Supplier = new DTO_Supplier
                        {
                            Id = row.Cells["ID Nhà cung"].Value.ToString()
                        }
                    };

                    busStock.Delete(item);
                }
            }
            ReloadGridView();
        }

        private void lblResetFilters_MouseDown(object sender, MouseEventArgs e)
        {
            lblResetFilters.ForeColor = Color.Black;
        }

        private void lblResetFilters_MouseUp(object sender, MouseEventArgs e)
        {
            lblResetFilters.ForeColor = SystemColors.Highlight;
            filProp.CurrentFilter = null;
            filProp.CurrentFilterText = null;
            lblResetFilters.Visible = false;
            ReloadGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grdStock.SelectedRows[0];
            frmEditStockItem frmEdit = new frmEditStockItem
            {

                Item = new DTO_StockItem
                {
                    
                    Id = (int)row.Cells["ID"].Value,
                    Name = row.Cells["Item Name"].Value.ToString(),
                    Shop = this.Shop,
                    Supplier = new DTO_Supplier
                    {
                        Id = row.Cells["Supplier ID"].Value.ToString(),
                        Shop = this.Shop
                    }
                },
                ucStock = this
            };
            frmEdit.Location = new Point(frmMan.Location.X + frmMan.Width / 2 - frmEdit.Width / 2,
                    frmMan.Location.Y + frmMan.Height / 2 - frmEdit.Height / 2);
            frmEdit.ShowDialog();
        }
    }
}
