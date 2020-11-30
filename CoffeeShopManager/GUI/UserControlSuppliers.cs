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
        BUS_Suppliers busSup = new BUS_Suppliers();
        public DTO_Shop Shop = new DTO_Shop();
        public frmManager frmMan { get; set; }

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
            grdSup.DataSource = busSup.GetAllSuppliers(Shop.ID);
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
    }
}
