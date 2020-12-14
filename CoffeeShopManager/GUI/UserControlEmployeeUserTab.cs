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
    public partial class UserControlEmployeeUserTab : UserControl
    {
        public UserControlEmployeeUserTab()
        {
            InitializeComponent();
        }
        BUS_UserInfo busUser = new BUS_UserInfo();
        DTO_Employee dtoEmp = new DTO_Employee();
        BUS_Employee busEmp = new BUS_Employee();
        ErrorProvider errEmail = new ErrorProvider();
        Timer tiktoker = new Timer();
        bool emailValid = true;

        public void Reload()
        {
            txtID.Text = dtoEmp.Id.ToString();
            txtFirstName.Text = dtoEmp.Firstname;
            txtLastName.Text = dtoEmp.Lastname;
            if (dtoEmp.Gender == "Male")
            {
                radMale.Checked = true;
            }
            else radFemale.Checked = true;
            txtPosition.Text = dtoEmp.Position;
            txtPhone.Text = dtoEmp.Phone;
            txtEmail.Text = dtoEmp.Email;
            txtAddress.Text = dtoEmp.Address;
            txtManagerID.Text = dtoEmp.Manager.Id;
            txtSalary.Text = dtoEmp.Salary.ToString();
            datBirthdate.Format = DateTimePickerFormat.Custom;
            datBirthdate.CustomFormat = "dd/MM/yyyy";
            if (dtoEmp.Birthdate >= datBirthdate.MinDate && dtoEmp.Birthdate <= datBirthdate.MaxDate)
            {
                datBirthdate.Value = dtoEmp.Birthdate;
            }
            datDateOfJoin.Format = DateTimePickerFormat.Custom;
            datDateOfJoin.CustomFormat = "dd/MM/yyyy";
            if (dtoEmp.DateOfJoin >= datDateOfJoin.MinDate && dtoEmp.DateOfJoin <= datDateOfJoin.MaxDate)
            {
                datDateOfJoin.Value = dtoEmp.DateOfJoin;
            }
            txtUsername.Text = dtoEmp.Account.Username;
            if (dtoEmp.Image != null)
            {
                picEmpInfo.Image = ImageHelper.ByteArrayToImage(dtoEmp.Image);
            }
            DisableTextBox();
            btnSaveChange.Enabled = false;
        }

        public void SetUser(DTO_Employee dtoEmp)
        {
            this.dtoEmp = dtoEmp;
            Reload();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword fChangePass = new frmChangePassword() { dtoUser = dtoEmp.Account };
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
                else if (txtUsername.Text != dtoEmp.Account.Username)
                {
                    if (!busUser.CheckUsername(txtUsername.Text))
                    {
                        throw new InvalidOperationException("Username already exists, please choose a different username.");
                    }
                }

                dtoEmp.Firstname = txtFirstName.Text;
                dtoEmp.Lastname = txtLastName.Text;
                dtoEmp.Address = txtAddress.Text;
                dtoEmp.DateOfJoin = datDateOfJoin.Value;
                if (picEmpInfo.Image != null)
                    dtoEmp.Image = ImageHelper.ImageToByteArray(picEmpInfo.Image);
                dtoEmp.Phone = txtPhone.Text;
                if (radMale.Checked == true) dtoEmp.Gender = "Male";
                else dtoEmp.Gender = "Female";
                dtoEmp.Email = txtEmail.Text;
                dtoEmp.Birthdate = datBirthdate.Value;
                dtoEmp.Account.Username = txtUsername.Text;
                DialogResult ret = MessageBox.Show("Are you sure you want to save changes?", "Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    busEmp.EditEmployeeAndAccount(dtoEmp);
                    frmEmployee.dtoEmp = dtoEmp;
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
            txtAddress.Enabled = true;
            txtUsername.Enabled = true;
            txtPhone.Enabled = true;
            datDateOfJoin.Enabled = true;
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
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            datDateOfJoin.Enabled = false;
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
                picEmpInfo.SizeMode = PictureBoxSizeMode.StretchImage;
                picEmpInfo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (EmailHelper.ValidateEmail(txtEmail.Text))
                {
                    errEmail.SetError(txtEmail, "");
                    emailValid = true;
                }
                else
                {
                    errEmail.SetError(txtEmail, "Email must be in the format 'example@example.example' and must not contain any whitespaces");
                    emailValid = false;
                }
            }
            else
            {
                emailValid = false;
            }
            tiktoker.Start();
        }

        private void UserControlEmployeeUserTab_Load(object sender, EventArgs e)
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
    }
}
