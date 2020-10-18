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

        private void Reload()
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
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DTO_Product dtoPro = new DTO_Product();
            try
            {
                dtoPro.Id = (int)(this.dataGridView1.SelectedRows[0].Cells["Id"].Value);
                busPro.Delete(dtoPro);
            }
            catch
            {

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

    }
}
