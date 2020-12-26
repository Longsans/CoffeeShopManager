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
                switch(filProp.CurrentFilter)
                {
                    case "ID":
                        {
                            grdSup.DataSource = busSup.GetDataTableById(filProp.CurrentFilterText, Shop.ID);
                        }
                        break;
                    case "Name":
                        {
                            grdSup.DataSource = busSup.GetDataTableByName(filProp.CurrentFilterText, Shop.ID);
                        }
                        break;
                    case "Email":
                        {
                            grdSup.DataSource = busSup.GetDataTableByEmail(filProp.CurrentFilterText, Shop.ID);
                        }
                        break;
                    case "Phone Number":
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
               // grdSup.Columns["Name"].HeaderText = "Tên nhà cung";
               // grdSup.Columns["Phone Number"].HeaderText = "Điện thoại";
            }
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
            
            frmAdd.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grdSup.SelectedRows[0];
            frmEditSupplier frmEditSup = new frmEditSupplier
            {
                sup = new DTO_Supplier
                {
                    Id = row.Cells["ID"].Value.ToString(),
                    Name = row.Cells["Name"].Value.ToString(),
                    Email = row.Cells["Email"].Value.ToString(),
                    Phone = row.Cells["Phone Number"].Value.ToString(),
                    Shop = this.Shop
                },
                ucSup = this
            };

            frmEditSup.Location = new Point(frmMan.Location.X + frmMan.Width / 2 - frmEditSup.Width / 2,
                    frmMan.Location.Y + frmMan.Height / 2 - frmEditSup.Height / 2);
            frmEditSup.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cboSearch.Text))
            {
                var resultIndex = cboSearch.FindStringExact(cboSearch.Text);
                switch (resultIndex)
                {
                    case 0:
                        {
                            grdSup.DataSource = busSup.GetDataTableById(txtSearch.Text, Shop.ID);
                        }
                        break;
                    case 1:
                        {
                            grdSup.DataSource = busSup.GetDataTableByName(txtSearch.Text, Shop.ID);
                        }
                        break;
                    case 2:
                        {
                            grdSup.DataSource = busSup.GetDataTableByEmail(txtSearch.Text, Shop.ID);
                        }
                        break;
                    case 3:
                        {
                            grdSup.DataSource = busSup.GetDataTableByPhoneNumber(txtSearch.Text, Shop.ID);
                        }
                        break;
                }

                filProp.CurrentFilter = cboSearch.Text;
                filProp.CurrentFilterText = txtSearch.Text;
                lblResetFilters.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in grdSup.SelectedRows)
            {
                var sup = new DTO_Supplier
                {
                    Id = row.Cells["ID"].Value.ToString(),
                    Shop = this.Shop
                };

                busSup.Delete(sup);
            }
            ReloadGridView();
            UcStock.ReloadGridView();
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
    }
}
