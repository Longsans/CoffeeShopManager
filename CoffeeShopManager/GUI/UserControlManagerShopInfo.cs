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
    public partial class UserControlManagerShopInfo : UserControl
    {
        DTO_Shop dtoShop = new DTO_Shop();
        BUS_Shop busShop = new BUS_Shop(ConnectionStringHelper.GetConnectionString());
        public DTO_Manager dtoMan = new DTO_Manager();
        
        public UserControlManagerShopInfo()
        {
            InitializeComponent();
        }

        private void UserControlManagerShopInfo_Load(object sender, EventArgs e)
        {
            
        }
        private void DisableTextBox()
        {
            txtShopName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtShopAddress.Enabled = false;
            btnSaveChange.Enabled = false;
            
        }
        private void EnableTextBox()
        {
            txtShopName.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtShopAddress.Enabled = true;
        }
        public void SetShop(DTO_Manager dtoMan1)
        {
            this.dtoMan = dtoMan1;
            Reload();
        }
        public void Reload()
        {
            dtoShop = busShop.GetShopById(dtoMan.Shop.ID);
            txtID.Text = dtoShop.ID.ToString();
            txtPhoneNumber.Text = dtoShop.Phone;
            txtShopAddress.Text = dtoShop.ShopAddress;
            txtShopName.Text = dtoShop.ShopName;
            DisableTextBox();
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtShopName.Text) || string.IsNullOrWhiteSpace(txtShopAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please fill all info fields.");
            }
            else
            {
                dtoShop.ShopName = txtShopName.Text;
                dtoShop.ShopAddress = txtShopAddress.Text;
                dtoShop.Phone = txtPhoneNumber.Text;
                busShop.Update(dtoShop);
                DisableTextBox();
                MessageBox.Show("You have updated shop info successfully");
            }
        }
        public void SetManager(DTO_Manager man)
        {
            dtoMan = man;
            Reload();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableTextBox();
            btnSaveChange.Enabled = true;
        }

        private void btnChangeAuthCode_Click(object sender, EventArgs e)
        {
            frmChangeAuthCodeShop frmChangeAuthCode = new frmChangeAuthCodeShop(dtoShop);
            frmChangeAuthCode.ShowDialog();
        }
    }
}
