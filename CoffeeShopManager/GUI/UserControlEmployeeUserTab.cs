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
        BUS_UserInfo busUser = new BUS_UserInfo(ConnectionStringHelper.GetConnectionString());
        DTO_Employee dtoEmp = new DTO_Employee();
        BUS_Employee busEmp = new BUS_Employee(ConnectionStringHelper.GetConnectionString());
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
                DialogResult ret;
                if (btnBrowse.Text == "Tìm ảnh")
                    ret = MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Lưu thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                else ret = MessageBox.Show("Are you sure you want to save changes?", "Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                        string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                        string.IsNullOrWhiteSpace(txtUsername.Text))
                    {
                        if (btnBrowse.Text == "Tìm ảnh")
                            throw new Exception("Vui lòng nhập đầy đủ thông tin");
                        else throw new Exception("Please fill all info fields.");
                    }
                    else if (txtUsername.Text != dtoEmp.Account.Username)
                    {
                        if (!busUser.CheckUsername(txtUsername.Text))
                        {
                            if (btnBrowse.Text == "Tìm ảnh")
                                throw new InvalidOperationException("Tên tài khoản đã tồn tại, hãy chọn tên tài khoản khác.");
                            else throw new InvalidOperationException("Username already exists, please choose a different username.");
                        }
                    }

                    dtoEmp.Firstname = txtFirstName.Text;
                    dtoEmp.Lastname = txtLastName.Text;
                    dtoEmp.Address = txtAddress.Text;
                    if ((datDateOfJoin.Value.Year - datBirthdate.Value.Year) >= 18 && datBirthdate.Value.Year <= 2078 && datDateOfJoin.Value.Year <= 2078 && datBirthdate.Value.Year >= 1910 && datDateOfJoin.Value.Year >= 1910)
                    {
                        dtoEmp.DateOfJoin = datDateOfJoin.Value;
                        dtoEmp.Birthdate = datBirthdate.Value;
                    }
                    else
                    {
                        if (btnBrowse.Text == "Tìm ảnh")
                            MessageBox.Show("Sai định dạng ngày", "Ngày vào làm, ngày sinh nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else MessageBox.Show("Wrong format date", "Date of join, birthdate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (picEmpInfo.Image != null)
                        dtoEmp.Image = ImageHelper.ImageToByteArray(picEmpInfo.Image);
                    if (!long.TryParse(txtPhone.Text, out long phone))
                    {
                        if (btnBrowse.Text == "Browse")
                        {
                            MessageBox.Show("Phone number can only contain numeric characters.", "Invalid phone number format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại chỉ được chứa ký tự số.", "Định dạng số điện thoại không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        return;
                    }
                    if (radMale.Checked == true)
                    {
                        if (radMale.Text != "Nam")
                            dtoEmp.Gender = radMale.Text;
                        else
                            dtoEmp.Gender = "Male";

                    }
                    else
                    {
                        if (radFemale.Text != "Nữ")
                            dtoEmp.Gender = radMale.Text;
                        else
                            dtoEmp.Gender = "Female";
                    }
                    dtoEmp.Email = txtEmail.Text;
                    dtoEmp.Account.Username = txtUsername.Text;
                    busEmp.EditEmployeeAndAccount(dtoEmp);
                    frmEmployee.dtoEmp = dtoEmp;
                    DisableTextBox();
                    btnSaveChange.Enabled = false;
                }
                else if (ret == DialogResult.No)
                {
                    Reload();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                if (btnBrowse.Text == "Tìm ảnh")
                    MessageBox.Show(ex.Message, "Tên tài khoản không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show(ex.Message, "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                if (btnBrowse.Text == "Tìm ảnh")
                    MessageBox.Show(ex.Message, "Một lỗi đã xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (!EmailHelper.ValidateEmail(txtEmail.Text))
                {
                    if (btnBrowse.Text == "Tìm ảnh")
                        errEmail.SetError(txtEmail, "Email phải theo đinh dạng 'example@example.example' và không được có bất kỳ khoảng trắng nào");
                    else errEmail.SetError(txtEmail, "Email must be in the format 'example@example.example' and must not contain any whitespaces");
                    emailValid = false;
                }
                else if (busEmp.GetByEmail(txtEmail.Text, dtoEmp.Shop.ID) != null && txtEmail.Text != dtoEmp.Email)
                {
                    if (btnBrowse.Text == "Browse")
                    {
                        errEmail.SetError(txtEmail, "A worker with such email already exists");
                    }
                    else
                    {
                        errEmail.SetError(txtEmail, "Email đã tồn tại");
                    }
                    emailValid = false;
                }
                else
                {
                    errEmail.SetError(txtEmail, "");
                    emailValid = true;
                }
            }
            else
            {
                if (btnBrowse.Text == "Browse") {
                    errEmail.SetError(txtEmail, "Please fill all info fields");
                }
                else
                {
                    errEmail.SetError(txtEmail, "Vui lòng nhập đủ thông tin");
                }
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
