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
    public partial class UserControlSuppliers : UserControl
    {
        BUS_Suppliers busSup = new BUS_Suppliers(ConnectionStringHelper.GetConnectionString());
        FilterProperties filProp = new FilterProperties();
        public DTO_Shop Shop = new DTO_Shop();
        public frmManager frmMan { get; set; }
        public UserControlStock UcStock { get; set; }

        public UserControlSuppliers()
        {
            InitializeComponent();
        }

        private void UserControlSuppliers_Load(object sender, EventArgs e)
        {
            txtSearch.LostFocus += TxtSearch_LostFocus;
            txtSearch.GotFocus += TxtSearch_GotFocus;
            ReloadGridView();
        }

        public void ReloadGridView()
        {
            if (!(string.IsNullOrWhiteSpace(filProp.CurrentFilter) || string.IsNullOrWhiteSpace(filProp.CurrentFilterText)))
            {
                switch(filProp.CurrentFilterIndex)
                {
                    case 0:
                        {
                            grdSup.DataSource = busSup.GetDataTableById(filProp.CurrentFilterText, Shop.ID);
                        }
                        break;
                    case 1:
                        {
                            grdSup.DataSource = busSup.GetDataTableByName(filProp.CurrentFilterText, Shop.ID);
                        }
                        break;
                    case 2:
                        {
                            grdSup.DataSource = busSup.GetDataTableByEmail(filProp.CurrentFilterText, Shop.ID);
                        }
                        break;
                    case 3:
                        {
                            grdSup.DataSource = busSup.GetDataTableByPhoneNumber(filProp.CurrentFilterText, Shop.ID);
                        }
                        break;
                }
            }
            else
            {
                grdSup.DataSource = busSup.GetAllSuppliers(Shop.ID);
            }

            if (lblSuppliers.Text != "Suppliers")
            {
                grdSup.Columns["Name"].HeaderText = "Tên nhà cung";
                grdSup.Columns["Phone Number"].HeaderText = "Điện thoại";
            }
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

        private void grdSup_SelectionChanged(object sender, EventArgs e)
        {
            if (grdSup.SelectedRows != null)
            {
                if (grdSup.SelectedRows.Count == 1)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddSupplier frmAdd = new frmAddSupplier
            {
                Shop = this.Shop,
                ucSup = this
            };
            frmAdd.Location = new Point(frmMan.Location.X + frmMan.Width / 2 - frmAdd.Width / 2,
                    frmMan.Location.Y + frmMan.Height / 2 - frmAdd.Height / 2);
            
            frmAdd.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grdSup.SelectedRows[0];
            frmEditSupplier frmEditSup = new frmEditSupplier
            {
                sup = new DTO_Supplier
                {
                    Id = row.Cells[0].Value.ToString(),
                    Name = row.Cells[1].Value.ToString(),
                    Email = row.Cells[2].Value.ToString(),
                    Phone = row.Cells[3].Value.ToString(),
                    Shop = this.Shop
                },
                ucSup = this
            };

            frmEditSup.Location = new Point(frmMan.Location.X + frmMan.Width / 2 - frmEditSup.Width / 2,
                    frmMan.Location.Y + frmMan.Height / 2 - frmEditSup.Height / 2);
            frmEditSup.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cboSearch.Text) && txtSearch.ForeColor != Color.DimGray)
            {
                filProp.CurrentFilterIndex = cboSearch.SelectedIndex;
                filProp.CurrentFilter = cboSearch.Text;
                filProp.CurrentFilterText = txtSearch.Text;
                lblResetFilters.Visible = true;
                ReloadGridView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdSup.SelectedRows.Count > 0)
            {
                DialogResult ret;

                if (btnDelete.Text == "Delete")
                {
                    ret = MessageBox.Show("Deleting this supplier will also delete all stock items that they provide, are you sure you want to continue?",
                        "Delete supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    ret = MessageBox.Show("Xóa nhà cung cấp này cũng xóa tất cả hàng hóa được họ cung cấp, bạn có muốn tiếp tục?",
                        "Xóa nhà cung cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }

                if (ret == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in grdSup.SelectedRows)
                    {
                        var sup = new DTO_Supplier
                        {
                            Id = row.Cells[0].Value.ToString(),
                            Shop = this.Shop
                        };

                        busSup.Delete(sup);
                    }
                    ReloadGridView();
                    UcStock.ReloadGridView();
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
            filProp.CurrentFilterIndex = -1;
            lblResetFilters.Visible = false;
            ReloadGridView();
        }
    }
}
