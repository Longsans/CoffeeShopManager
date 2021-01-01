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
        public UserControlSuppliers ucSup { get; set; }
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
                if (btnDelete.Text == "Delete")
                {
                    txtSearch.Text = "Search...";
                }
                else
                {
                    txtSearch.Text = "Tìm kiếm...";
                }
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
                        else grdStock.DataSource = busStock.GetDataTableById(-1, Shop.ID);
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
            if (!string.IsNullOrWhiteSpace(cboSearch.Text) && txtSearch.ForeColor != Color.DimGray)
            {
                lblResetFilters.Visible = true;
                filProp.CurrentFilter = cboSearch.Text;
                filProp.CurrentFilterText = txtSearch.Text;
                ReloadGridView();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddStockItem frmAdd = new frmAddStockItem
            {
                Shop = this.Shop,
                ucStock = this,
                ucSup = this.ucSup
            };

            frmAdd.Location = new Point(frmMan.Location.X + frmMan.Width / 2 - frmAdd.Width / 2,
                    frmMan.Location.Y + frmMan.Height / 2 - frmAdd.Height / 2);
            frmAdd.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdStock.SelectedRows.Count > 0)
            {
                DialogResult ret;

                if (btnDelete.Text == "Delete")
                {
                    ret = MessageBox.Show("Deleting this stock item will also remove it from the item list of any product using it, do you want to continue?",
                        "Delete stock item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    ret = MessageBox.Show("Xóa hàng hóa này cũng sẽ xóa nó khỏi danh sách thành phần của bất kỳ sản phẩm nào đang dùng nó, bạn có muốn tiếp tục?",
                        "Xóa hàng hóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }

                if (ret == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in grdStock.SelectedRows)
                    {
                        var item = new DTO_StockItem
                        {
                            Id = (int)row.Cells[0].Value,
                            Name = row.Cells[1].Value.ToString(),
                            Shop = this.Shop,
                            Supplier = new DTO_Supplier
                            {
                                Id = row.Cells[2].Value.ToString()
                            }
                        };

                        busStock.Delete(item);
                    }
                    ReloadGridView();
                }
            }
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
