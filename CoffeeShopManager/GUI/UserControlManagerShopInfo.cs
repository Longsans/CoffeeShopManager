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
                if (btnEdit.Text == "Sửa")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                else MessageBox.Show("Please fill all info fields.");
            }
            else if (!long.TryParse(txtPhoneNumber.Text, out long phone))
            {
                if (btnEdit.Text == "Edit")
                {
                    MessageBox.Show("Phone number can only contain numeric characters.", "Invalid phone number format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Số điện thoại chỉ được chứa ký tự số.", "Định dạng số điện thoại không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                dtoShop.ShopName = txtShopName.Text;
                dtoShop.ShopAddress = txtShopAddress.Text;
                dtoShop.Phone = txtPhoneNumber.Text;
                busShop.Update(dtoShop);
                DisableTextBox();
                if (btnEdit.Text == "Sửa")
                    MessageBox.Show("Cập nhật thông tin cửa hàng thành công.", "Cập nhật thông tin cửa hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Shop info has been updated", "Update shop info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
