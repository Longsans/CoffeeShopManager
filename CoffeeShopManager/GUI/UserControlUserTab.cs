using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using BUS;
using DTO;
using System.Globalization;

namespace GUI
{
    public partial class UserControlUserTab : UserControl
    {
        BUS_UserInfo busUser = new BUS_UserInfo();
        BUS_Manager busMan = new BUS_Manager();
        DTO_Manager dtoMan = new DTO_Manager();
        public UserControlUserTab()
        {
            InitializeComponent();
        }

        private void UserControlUserTab_Load(object sender, EventArgs e)
        {
        }
        public void Reload()
        {
            txtID.Text = dtoMan.Id.ToString();
            txtFirstName.Text = dtoMan.Firstname;
            txtLastName.Text = dtoMan.Lastname;
            if (dtoMan.Gender == "Male")
            {
                radMale.Checked = true;
            }
            else radFemale.Checked = true;
            txtPosition.Text = dtoMan.Position;
            txtPhone.Text = dtoMan.Phone;
            txtEmail.Text = dtoMan.Account.Email;
            txtBirthDate.Text = dtoMan.Birthdate.ToString("dd/MM/yyyy");
            if (dtoMan.Image != null)
            {
                picManagerInfo.Image = ImageHelper.ByteArrayToImage(dtoMan.Image);
            }
            DisableTextBox();
            btnSaveChange.Enabled = false;
        }

        public void SetUser(DTO_Manager dtoMan)
        {
            this.dtoMan = dtoMan;
            Reload();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword fChangePass = new frmChangePassword() { dtoUser = dtoMan.Account};
            fChangePass.ShowDialog();

        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            dtoMan.Firstname = txtFirstName.Text;
            dtoMan.Lastname = txtLastName.Text;
            if (picManagerInfo.Image != null)
                dtoMan.Image = ImageHelper.ImageToByteArray(picManagerInfo.Image);
            dtoMan.Phone = txtPhone.Text;
            if (radMale.Checked == true) dtoMan.Gender = "Male";
            else dtoMan.Gender = "Female";
            dtoMan.Account.Email = txtEmail.Text;
            dtoMan.Birthdate = DateTime.ParseExact(txtBirthDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn những thay đổi này không?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                busMan.Update(dtoMan);
                frmHome.dtoMan = dtoMan;
                DisableTextBox();
                btnSaveChange.Enabled = false;
            }
            else if (ret == DialogResult.No)
            {
                DisableTextBox();
                btnSaveChange.Enabled = false;
            }
        }
        private void EnableTextBoxToEdit()
        {
            txtBirthDate.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtPhone.Enabled = true;
            radMale.Enabled = true;
            radFemale.Enabled = true;
            btnBrowse.Enabled = true;
            txtFirstName.Focus();
        }
        private void DisableTextBox()
        {
            txtBirthDate.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhone.Enabled = false;
            radMale.Enabled = false;
            radFemale.Enabled = false;
            btnBrowse.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableTextBoxToEdit();

            btnSaveChange.Enabled = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picManagerInfo.SizeMode = PictureBoxSizeMode.StretchImage;
                picManagerInfo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
