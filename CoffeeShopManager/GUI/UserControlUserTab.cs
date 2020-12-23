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
        ErrorProvider errEmail = new ErrorProvider();
        Timer tiktoker = new Timer();
        bool emailValid = true;

        public UserControlUserTab()
        {
            InitializeComponent();
        }

        private void UserControlUserTab_Load(object sender, EventArgs e)
        {
            tiktoker.Interval = 200;
            tiktoker.Tick += Tiktoker_Tick;
        }

        private void Tiktoker_Tick(object sender, EventArgs e)
        {
            if (emailValid)
            {
                btnSaveChange.Enabled = true;
            }
            else
            {
                btnSaveChange.Enabled = false;
            }
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
            txtEmail.Text = dtoMan.Email;
            datBirthdate.Format = DateTimePickerFormat.Custom;
            datBirthdate.CustomFormat = "dd/MM/yyyy";
            if (dtoMan.Birthdate >= datBirthdate.MinDate && dtoMan.Birthdate <= datBirthdate.MaxDate)
            {
                datBirthdate.Value = dtoMan.Birthdate;
            }
            txtUsername.Text = dtoMan.Account.Username;
            if (dtoMan.Image != null)
            {
                picManagerInfo.Image = ImageHelper.ByteArrayToImage(dtoMan.Image);
            }
            DisableTextBox();
            btnSaveChange.Enabled = false;
            errEmail.SetError(txtEmail, "");
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
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    throw new Exception("Please fill all info fields.");
                }
                else if (txtUsername.Text != dtoMan.Account.Username)
                {
                    if (!busUser.CheckUsername(txtUsername.Text))
                    {
                        throw new InvalidOperationException("Username already exists, please choose a different username.");
                    }
                }

                dtoMan.Firstname = txtFirstName.Text;
                dtoMan.Lastname = txtLastName.Text;
                if (picManagerInfo.Image != null)
                    dtoMan.Image = ImageHelper.ImageToByteArray(picManagerInfo.Image);
                dtoMan.Phone = txtPhone.Text;
                if (radMale.Checked == true)
                {
                    if (radMale.Text != "Nam")
                        dtoMan.Gender = radMale.Text;
                    else
                        dtoMan.Gender = "Male";

                }
                else
                {
                    if (radFemale.Text != "Nữ")
                        dtoMan.Gender = radMale.Text;
                    else
                        dtoMan.Gender = "Female";
                }
                if(checkemail==1)
                dtoMan.Email = txtEmail.Text;
                else
                {
                    MessageBox.Show("Wrong email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((DateTime.Now.Year- datBirthdate.Value.Year)>=18)
                dtoMan.Birthdate = datBirthdate.Value;
                else
                {
                    MessageBox.Show("Wrong age to work", "Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                dtoMan.Account.Username = txtUsername.Text;
                DialogResult ret = MessageBox.Show("Are you sure you want to save changes?", "Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    busMan.UpdateInfoAndAccount(dtoMan);
                    frmManager.dtoMan = dtoMan;
                    DisableTextBox();
                    btnSaveChange.Enabled = false;
                }
                else if (ret == DialogResult.No)
                {
                    DisableTextBox();
                    btnSaveChange.Enabled = false;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EnableTextBoxToEdit()
        {
            datBirthdate.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtUsername.Enabled = true;
            radMale.Enabled = true;
            radFemale.Enabled = true;
            btnBrowse.Enabled = true;
            txtFirstName.Focus();
        }
        private void DisableTextBox()
        {
            datBirthdate.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtUsername.Enabled = false;
            radMale.Enabled = false;
            radFemale.Enabled = false;
            btnBrowse.Enabled = false;
            tiktoker.Stop();
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
        public int checkemail = 0;
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (EmailHelper.ValidateEmail(txtEmail.Text))
                {
                    errorFalse.SetError(txtEmail, "");
                    errorTrue.SetError(txtEmail, "Correct");
                    if (busMan.GetByEmail(txtEmail.Text, frmManager.dtoMan.Shop.ID) == null||txtEmail.Text==dtoMan.Email)
                    {
                        
                        errorFalse.SetError(txtEmail, "");
                        errorTrue.SetError(txtEmail, "correct");
                        checkemail = 1;

                    }
                    else
                    {
                        errorFalse.SetError(txtEmail, "Email had in shop");
                        errorTrue.SetError(txtEmail, "");
                        checkemail = 0;

                    }
                    // errEmail.SetError(txtEmail, "");
                    //emailValid = true;
                }
                else
                {
                    errorFalse.SetError(txtEmail, "Email must be in the format 'example@example.example' and must not contain any whitespaces");
                    errorTrue.SetError(txtEmail, "");
                    checkemail = 0;
                }
            }
            else
            {
                checkemail = 0;
            }
        }

        private void datBirthdate_ValueChanged(object sender, EventArgs e)
        {
            datBirthdate.Format = DateTimePickerFormat.Custom;
            datBirthdate.CustomFormat = "dd/MM/yyyy";

        }
    }
}
