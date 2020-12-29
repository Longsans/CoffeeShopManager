﻿using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Globalization;

namespace GUI
{
    public partial class frmEditEmployees : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        UserControlEmployeesTab _ucEmp = new UserControlEmployeesTab();
        public DTO_Employee dtoEmp = new DTO_Employee();
        BUS_Employee busEmp = new BUS_Employee(ConnectionStringHelper.GetConnectionString());
        BUS_Manager busMan = new BUS_Manager(ConnectionStringHelper.GetConnectionString());
        Timer tiktoker = new Timer();
        bool emailValid = true;

        public frmEditEmployees()
        {
            InitializeComponent();
        }
        public frmEditEmployees(UserControlEmployeesTab ucEmp)
        {
            _ucEmp = ucEmp;
            InitializeComponent();
        }
        public string copyemail;
        private void frmEditEmployees_Load(object sender, EventArgs e)
        {
            datBirth.Format = DateTimePickerFormat.Custom;
            datBirth.CustomFormat = "dd/MM/yyyy";
            datJoin.Format = DateTimePickerFormat.Custom;
            datJoin.CustomFormat = "dd/MM/yyyy";

            txtFirstName.Focus();
            txtID.Text = dtoEmp.Id.ToString();
            txtFirstName.Text = dtoEmp.Firstname;
            txtLastName.Text = dtoEmp.Lastname;
            if (dtoEmp.Gender == "Male") radMale.Checked = true;
            else radFemale.Checked = true;
            cboPosition.Text = dtoEmp.Position;
            txtPhone.Text = dtoEmp.Phone;
            txtEmail.Text = dtoEmp.Email;
            txtCopyemail.Text = dtoEmp.Email;
            datBirth.Value = dtoEmp.Birthdate;
            datJoin.Value = dtoEmp.DateOfJoin;
            txtAddress.Text = dtoEmp.Address;
            txtSalary.Text = dtoEmp.Salary.ToString();
            txtManagerID.Text = dtoEmp.Manager.Id.ToString();
            picboxEmpImg.SizeMode = PictureBoxSizeMode.StretchImage;
            if (dtoEmp.Image != null)
            {
                picboxEmpImg.Image = ImageHelper.ByteArrayToImage(dtoEmp.Image);
            }
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

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp"
            };
            if (op.ShowDialog() == DialogResult.OK)
            {
                picboxEmpImg.Image = Image.FromFile(op.FileName);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) 
                || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                if (btnCancel.Text == "Cancel")
                {
                    MessageBox.Show("Please fill all info fields.", "More information is required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Nhập đủ thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }
            dtoEmp.Firstname = txtFirstName.Text;
            dtoEmp.Lastname = txtLastName.Text;
            dtoEmp.Address = txtAddress.Text;
            var resultIndex = cboPosition.FindStringExact(cboPosition.Text);
            if (resultIndex == 0)
                cboPosition.Text = "Waiter";
            else if (resultIndex == 1)
                cboPosition.Text = "Barista";
            else if (resultIndex == 2)
                cboPosition.Text = "Cook";
            else if (resultIndex == 3)
                cboPosition.Text = "Utility";
            else if (resultIndex == 4)
                cboPosition.Text = "Janitor";
            else if (resultIndex == 5)
                cboPosition.Text = "Security";
            else
                cboPosition.Text = "Others";
            dtoEmp.Position = cboPosition.Text;

            if (!long.TryParse(txtPhone.Text, out long phone))
            {
                if (btnCancel.Text == "Cancel")
                {
                    MessageBox.Show("Phone number can only contain numeric characters.", "Invalid phone number format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Số điện thoại chỉ được chứa ký tự số.", "Định dạng số điện thoại không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }
            dtoEmp.Phone = txtPhone.Text;
            if(checkemail==1)
            dtoEmp.Email = txtEmail.Text;
            else
            {
                if (btnCancel.Text == "Cancel")
                {
                    MessageBox.Show("Email is already taken or is in invalid format", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Email trùng hoặc sai", "Email không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }
            txtSalary.Text = txtSalary.Text.Replace(',', '.');
            if (double.TryParse(txtSalary.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double sala) == false)
            {
                if (label3.Text == "Add employee")
                {
                    MessageBox.Show("Wrong salary", "Salary", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Sai tiền lương", "tiền lương", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (double.TryParse(txtSalary.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out sala))
                dtoEmp.Salary = (decimal)sala; dtoEmp.Manager = busMan.GetById(txtManagerID.Text, dtoEmp.Shop.ID);
            dtoEmp.Phone = txtPhone.Text;
            if (radMale.Checked == true)
            {
                dtoEmp.Gender = "Male";
            }
            else
            {
                dtoEmp.Gender = "Female";
            }
            if (checkjoin==1&&checkbirth==1)
            {
                dtoEmp.Birthdate = datBirth.Value;
                dtoEmp.DateOfJoin = datJoin.Value;
                if (this.picboxEmpImg.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh", "Edit employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dtoEmp.Image = ImageHelper.ImageToByteArray(this.picboxEmpImg.Image);
                    busEmp.EditEmployee(dtoEmp);
                    MessageBox.Show("Edit thành công.", "Add employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    _ucEmp.Reload();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ngày hợp lệ.", "Add employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (EmailHelper.ValidateEmail(txtEmail.Text))
                {
                    errEmail.SetError(txtEmail, "");
                    errorProvider1.SetError(txtEmail, "Valid");
                    if (busEmp.GetByEmail(txtEmail.Text, frmManager.dtoMan.Shop.ID) == null||txtEmail.Text==dtoEmp.Email)
                    {
                        errEmail.SetError(txtEmail, "");
                        errorProvider1.SetError(txtEmail, "Valid");
                        checkemail = 1;

                    }
                    else
                    {
                        errEmail.SetError(txtEmail, "Email had in shop");
                        errorProvider1.SetError(txtEmail, "");
                        checkemail = 0;

                    }
                }
                else
                {
                    errEmail.SetError(txtEmail, "Email must be in the format 'example@example.example' and must not contain any whitespaces");
                    errorProvider1.SetError(txtEmail, "");
                    checkemail = 0;
                }
            }
            else
            {
                errEmail.SetError(txtEmail, "Please fill all info fields");
                errorProvider1.SetError(txtEmail, "");
                checkemail = 0;
            }
            if (checkidmanager == 1 && checkemail == 1 && checkbirth == 1 && checkjoin == 1 && checksalary == 1)
            {
                btnSaveChange.Enabled = true;
            }
            else
            {
                btnSaveChange.Enabled = false;
            }
        }
        public int checkbirth, checkjoin, checkemail, checkidmanager,checksalary;

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtSalary.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double sala))
            {
                errEmail.SetError(txtSalary, "");
                errorProvider1.SetError(txtSalary, "correct");
                checksalary = 1;
            }
            else
            {
                errEmail.SetError(txtSalary, "Wrong format");
                errorProvider1.SetError(txtSalary, "");
                checksalary = 0;
            }
            if (checkidmanager == 1 && checkemail == 1 && checkbirth == 1 && checkjoin == 1&&checksalary==1)
            {
                btnSaveChange.Enabled = true;
            }
            else
            {
                btnSaveChange.Enabled = false;
            }

        }

        private void txtManagerID_TextChanged(object sender, EventArgs e)
        {
            if (busMan.GetById(txtManagerID.Text, dtoEmp.Shop.ID) != null)
            {
                checkidmanager = 1;
                errEmail.SetError(txtManagerID, "");
                errorProvider1.SetError(txtManagerID, "Correct");
            }
            else
            {
                checkidmanager = 0;
                errEmail.SetError(txtManagerID, "Haven't manager in shop");
                errorProvider1.SetError(txtManagerID, "");
            }
            if (checkidmanager == 1 && checkemail == 1 && checkbirth == 1 && checkjoin == 1 && checksalary == 1)
            {
                btnSaveChange.Enabled = true;
            }
            else
            {
                btnSaveChange.Enabled = false;
            }
        }

        private void datBirth_ValueChanged(object sender, EventArgs e)
        {
            datBirth.CustomFormat = "dd/MM/yyyy";
            DateTime now = DateTime.Now;
            if ((datJoin.Value.Year - datBirth.Value.Year) >= 18 && datJoin.Value <= now && datBirth.Value.Year >= 1910)
            {
                checkbirth = 1;
                checkjoin = 1;
                errEmail.SetError(datBirth, "");
                if(label5.Text=="Tên")
                    errorProvider1.SetError(datBirth, "Luôn đúng");
                else
                    errorProvider1.SetError(datBirth, "Correct");

                errEmail.SetError(datJoin, "");
                if (label5.Text == "Tên")
                    errorProvider1.SetError(datJoin, "Chính xác");
                else
                errorProvider1.SetError(datJoin, "Correct");
            }
            else
            {
                checkjoin = 0;
                if (label5.Text == "Tên")
                    errEmail.SetError(datBirth, "Không đủ tuổi làm viêc");
                else
                errEmail.SetError(datBirth, "Age not enough to work");
                errorProvider1.SetError(datBirth, "");
                errEmail.SetError(datJoin, "");
                if (label5.Text == "Tên")
                    errorProvider1.SetError(datJoin, "Chính xác");
                else
                errorProvider1.SetError(datJoin, "Correct");
                checkbirth = 0;
            }
            if (checkidmanager == 1 && checkemail == 1 && checkbirth == 1 && checkjoin == 1 && checksalary == 1)
            {
                btnSaveChange.Enabled = true;
            }
            else
            {
                btnSaveChange.Enabled = false;
            }
        }

        private void datJoin_ValueChanged(object sender, EventArgs e)
        {
            datJoin.CustomFormat = "dd/MM/yyyy";
            DateTime now = DateTime.Now;
            if ((datJoin.Value.Year - datBirth.Value.Year) >= 18 && datJoin.Value <= now && datBirth.Value.Year >= 1910)
            {
                checkjoin = 1;
                checkbirth = 1;
                errEmail.SetError(datBirth, "");
                if(label5.Text=="Tên")
                    errorProvider1.SetError(datBirth, "Chính xác");
                else
                errorProvider1.SetError(datBirth, "Correct");
                errEmail.SetError(datJoin, "");
                if(label5.Text=="Tên")
                    errorProvider1.SetError(datJoin, "Chính xác");
                else
                errorProvider1.SetError(datJoin, "Correct");
            }
            else
            {
                if(label5.Text=="Tên")
                    errEmail.SetError(datBirth, "Không đủ tuổi đi làm");
                else
                errEmail.SetError(datBirth, "Age not enough to work");
                errorProvider1.SetError(datBirth, "");
                if(label5.Text=="Tên")
                    errEmail.SetError(datJoin, "Không đủ tuổi đi làm");
                else
                errEmail.SetError(datJoin, "Age not enough to work");
                errorProvider1.SetError(datJoin, "");
                checkjoin = 0;
                checkbirth = 0;
            }
            /* if ((DateTime.Now.Year - datBirth.Value.Year) >= 18)
             {
                 errEmail.SetError(datBirth, "");
                 errorProvider1.SetError(datBirth, "Correct");
                 checkbirth = 1;
             }
             else
             {
                 errEmail.SetError(datBirth, "Age not enough to work");
                 errorProvider1.SetError(datBirth, "");
                 checkbirth = 0;
             }*/
            if (checkidmanager == 1 && checkemail == 1 && checkbirth == 1 && checkjoin == 1 && checksalary == 1)
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
