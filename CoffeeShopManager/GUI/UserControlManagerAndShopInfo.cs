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
    public partial class UserControlManagerAndShopInfo : UserControl
    {
        DTO_Manager dtoMan = new DTO_Manager();
        DTO_Shop dtoShop = new DTO_Shop();
        public UserControlManagerAndShopInfo()
        {
            InitializeComponent();
        }

        private void UserControlManagerAndShopInfo_Load(object sender, EventArgs e)
        {
 
        }
        private void ReloadManager()
        {
            txtManID.Text = dtoMan.Id.ToString();
            txtFirstName.Text = dtoMan.Firstname;
            txtLastName.Text = dtoMan.Lastname;
            txtGender.Text = dtoMan.Gender;
            txtManPhoneNumer.Text = dtoMan.Phone;
            txtPosition.Text = dtoMan.Position;
            txtBirthDate.Text = dtoMan.Birthdate.ToString("dd/MM/yyyy");
            txtEmail.Text = dtoMan.Email;
            if (dtoMan.Image != null)
            {
                picMan.Image = ImageHelper.ByteArrayToImage(dtoMan.Image);
            }
        }
        private void ReloadShopInfo()
        {
            txtShopAddress.Text = dtoShop.ShopAddress;
            txtShopName.Text = dtoShop.ShopName;
            txtShopPhone.Text = dtoShop.Phone;
        }
        public void SetManager(DTO_Manager man)
        {
            dtoMan = man;
            ReloadManager();
        }
        public void SetShop(DTO_Shop shop)
        {
            dtoShop = shop;
            ReloadShopInfo();
        }
        
    }
}
