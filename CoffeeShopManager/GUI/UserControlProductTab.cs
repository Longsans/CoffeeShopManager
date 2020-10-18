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
    public partial class UserControlProductTab : UserControl
    {
        BUS_Product busPro = new BUS_Product();
        public UserControlProductTab()
        {
            InitializeComponent();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busPro.GetAllProducts();
        }

        private void btnShowDrink_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busPro.GetAllDrinks();
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busPro.GetAllFood();
        }

        private void btnShowOther_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busPro.GetAllOtherProducts();
        }

        private void UserControlProductTab_Load(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
        {
            this.cboSearch.Text = "";
            this.dataGridView1.DataSource = busPro.GetAllProducts();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllDrinks();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllFood();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllOtherProducts();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertProDuct frmInsert = new frmInsertProDuct(this);
            frmInsert.ShowDialog();
            Reload();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DTO_Product dtoPro = new DTO_Product();
            if (dataGridView1.SelectedRows != null && !dataGridView1.Rows[dataGridView1.RowCount - 1].Selected)
            {
                DialogResult ret = MessageBox.Show("Do you want to delete this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                   // MessageBox.Show(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    dtoPro = busPro.GetByName(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    busPro.Delete(dtoPro);
                    Reload();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cboSearch.Text)
                {

                    case "ID":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchIDFiltered(Int32.Parse(txtSearch.Text));
                        break;
                    case "Name":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchNameFiltered(txtSearch.Text);
                        break;
                    case "Type":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchTypeFiltered(txtSearch.Text);
                        break;
                    case "Price":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchPriceFiltered(
                            Int32.Parse(txtPriceSearchLower.Text), Int32.Parse(txtPriceSearchUpper.Text));

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bro, ông làm gì sai rồi. Thông báo lỗi: {ex.Message}",
                    "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSearch.SelectedItem.ToString() == "Price")
            {
                txtSearch.Visible = false;
                txtPriceSearchLower.Visible = true;
                txtPriceSearchUpper.Visible = true;
                label2.Visible = true;
            }
            else
            {
                txtSearch.Visible = true;
                txtPriceSearchLower.Visible = false;
                txtPriceSearchUpper.Visible = false;
                label2.Visible = false;
            }

            txtSearch.Clear();
            txtPriceSearchLower.Clear();
            txtPriceSearchUpper.Clear();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && !dataGridView1.Rows[dataGridView1.RowCount - 1].Selected)
            {
               frmEditProduct frmEdit = new frmEditProduct(this)
                {
                    dtoPro = busPro.GetByName(dataGridView1.SelectedRows[0].Cells[1].Value.ToString())
                };
                frmEdit.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

    }
}
