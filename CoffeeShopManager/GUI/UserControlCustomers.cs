using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BUS;
using DTO;

namespace GUI
{
    public partial class UserControlCustomers : UserControl
    {
        BUS_Customers busCus = new BUS_Customers(ConnectionStringHelper.GetConnectionString());
        FilterProperties filProp = new FilterProperties();
        public frmManager frmMan { get; set; }
        public DTO_Shop dtoShop = new DTO_Shop();

        public UserControlCustomers()
        {
            InitializeComponent();
        }

        private void UserControlCustomers_Load(object sender, EventArgs e)
        {
            txtSearch.GotFocus += TxtSearch_GotFocus;
            txtSearch.LostFocus += TxtSearch_LostFocus;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
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

        public void ReloadGridView()
        {
            if (!(string.IsNullOrWhiteSpace(filProp.CurrentFilter) || string.IsNullOrWhiteSpace(filProp.CurrentFilterText)))
            {
                //                var resultIndex = cboSearch.FindStringExact(cboSearch.Text);

                switch (filProp.CurrentFilter)
                {
                    case "ID":
                        {
                            if (int.TryParse(filProp.CurrentFilterText, out int id))
                            {
                                grdCustomers.DataSource = busCus.GetCustomerSearchIDFiltered(id, dtoShop.ID);
                            }
                            else
                            {
                                ((DataTable)grdCustomers.DataSource).Clear();
                            }
                        }
                        break;
                    case "Name":
                        {
                            grdCustomers.DataSource = busCus.GetCustomersSearchNameFiltered(filProp.CurrentFilterText, dtoShop.ID);
                        }
                        break;
                    case "Email":
                        {
                            grdCustomers.DataSource = busCus.GetCustomerSearchEmailFiltered(filProp.CurrentFilterText, dtoShop.ID);
                        }
                        break;
                    case "Tên":
                        {
                            grdCustomers.DataSource = busCus.GetCustomersSearchNameFiltered(filProp.CurrentFilterText, dtoShop.ID);
                        }
                        break;
                }
            }
            else
            {
                grdCustomers.DataSource = busCus.GetAllCustomers(dtoShop.ID);
            }
            if (lblCustomer.Text != "Customers")
            {
                grdCustomers.Columns["First Name"].HeaderText = "Họ";
                grdCustomers.Columns["Last Name"].HeaderText = "Tên";
                grdCustomers.Columns["Birthdate"].HeaderText = "Ngày sinh";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = grdCustomers.SelectedRows[0];
            frmEditCustomer frmEdit = new frmEditCustomer(this)
            {
                dtoCus = new DTO_Customer
                {
                    Id = (int)row.Cells["ID"].Value,
                    FirstName = row.Cells["First Name"].Value.ToString(),
                    LastName = row.Cells["Last Name"].Value.ToString(),
                    Email = row.Cells["Email"].Value.ToString(),
                    Shop = dtoShop
                }
            };

            DateTime dat;
            string[] formats = { "dd/MM/yyyy hh:mm:ss tt", "dd/MM/yyyy" };
            try
            {
                if (DateTime.TryParseExact(row.Cells["Birthdate"].Value.ToString(), formats,
                CultureInfo.InvariantCulture, DateTimeStyles.None, out dat))
                {
                    frmEdit.dtoCus.Birthdate = dat;
                }
                //else
                //{
                //    //throw new Exception("Customer's birthdate is in wrong datetime format.");
                //}

                frmEdit.Location = new Point(frmMan.Location.X + frmMan.Width / 2 - frmEdit.Width / 2,
                    frmMan.Location.Y + frmMan.Height / 2 - frmEdit.Height / 2);
                frmEdit.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdCustomers.SelectedRows)
            {
                DTO_Customer cus = new DTO_Customer
                {
                    Id = (int)row.Cells["ID"].Value,
                    Shop = dtoShop
                };
                busCus.Delete(cus);
            }
            ReloadGridView();
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
                            if (int.TryParse(txtSearch.Text, out int id))
                            {
                                grdCustomers.DataSource = busCus.GetCustomerSearchIDFiltered(id, dtoShop.ID);
                            }
                            else
                            {
                                ((DataTable)grdCustomers.DataSource).Clear();
                            }
                        }
                        break;
                    case 1:
                        {
                            grdCustomers.DataSource = busCus.GetCustomersSearchNameFiltered(txtSearch.Text, dtoShop.ID);
                        }
                        break;
                    case 2:
                        {
                            grdCustomers.DataSource = busCus.GetCustomerSearchEmailFiltered(txtSearch.Text, dtoShop.ID);
                        }
                        break;
                }

                lblResetFilters.Visible = true;
                filProp.CurrentFilter = cboSearch.Text;
                filProp.CurrentFilterText = txtSearch.Text;
            }
        }

        private void grdCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (grdCustomers.SelectedRows != null)
            {
                if (grdCustomers.SelectedRows.Count == 1)
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
