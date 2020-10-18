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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cboSearch.Text)
                {
                    case "Name":
                        this.dataGridView1.DataSource = busPro.GetByName(txtSearch.Text);
                        break;
                    case "Id":
                        this.dataGridView1.DataSource = busPro.GetById(int.Parse(txtSearch.Text));
                        break;
                    case "Type":
                        this.dataGridView1.DataSource = busPro.GetAllProducts();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bro, ông làm gì sai rồi. Thông báo lỗi: {ex.Message}",
                    "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
