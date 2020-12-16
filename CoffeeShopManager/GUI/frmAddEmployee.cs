﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

using BUS;
using System.Globalization;

namespace GUI
{
    public partial class frmAddEmployee : Form
    {
        BUS_Employee busEmp = new BUS_Employee();
        BUS_UserInfo busUser = new BUS_UserInfo();
        UserControlEmployeesTab _ucEmp;
        Timer tiktoker = new Timer();
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        public frmAddEmployee(UserControlEmployeesTab ucEmp)
        {
            _ucEmp = ucEmp;
            InitializeComponent();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txtID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" ||
                cbboxPosition.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || txtDayBD.Text == "" ||
                txtMonthBD.Text == "" || txtYearBD.Text == "" || txtSalary.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" ||
                txtDayJoin.Text == "" || txtMonthJoin.Text == "" || txtYearJoin.Text == "" || (radFemale.Checked == false &&
                radMale.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Add employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbboxPosition.Text == "Manager")
            {
                MessageBox.Show("Employee's position cannot be \"Manager\".", "Invalid employee position", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(cbboxPosition, "Position can't be \"Manager\"");
            }
            else
            {
                DateTime bdate = new DateTime();
                DateTime doj = new DateTime();
                string[] formats = { "dd/MM/yyyy", "d/M/yyyy" };
                errorProvider1.SetError(txtYearBD, "");
                errorProvider1.SetError(txtYearJoin, "");
                DTO_Employee dtoEmp = new DTO_Employee();
                dtoEmp.Id = txtID.Text;
                dtoEmp.Firstname = txtFirstName.Text;
                dtoEmp.Lastname = txtLastName.Text;
                dtoEmp.Address = txtAddress.Text;
                if (cbboxPosition.Text == "Phục vụ")
                    cbboxPosition.Text = "Waiter";
                if (cbboxPosition.Text == "Thợ pha cà phê")
                    cbboxPosition.Text = "Barista";
                if (cbboxPosition.Text == "Nấu ăn")
                    cbboxPosition.Text = "Cook";
                if (cbboxPosition.Text == "Tiện ích")
                    cbboxPosition.Text = "Utility";
                if (cbboxPosition.Text == "Vệ sinh")
                    cbboxPosition.Text = "Janitor";
                if (cbboxPosition.Text == "Bảo vệ")
                    cbboxPosition.Text = "Security";
                if (cbboxPosition.Text == "Khác")
                    cbboxPosition.Text = "Others";
                dtoEmp.Position = cbboxPosition.Text;
                dtoEmp.Phone = txtPhone.Text;
                dtoEmp.Email = txtEmail.Text;
                dtoEmp.Account.Username = txtUsername.Text;
                dtoEmp.Account.PassWord = txtPassword.Text;
                dtoEmp.Salary = decimal.Parse(txtSalary.Text);
                dtoEmp.Manager = frmManager.dtoMan;
                dtoEmp.Shop.ID = frmManager.dtoMan.Shop.ID;
                dtoEmp.Account = busUser.EncodePass(dtoEmp);

                if (!busUser.CheckUsername(dtoEmp.Account.Username))
                {
                    MessageBox.Show("Username has already existed.", "Username taken", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.ResetText();
                    return;
                }
                dtoEmp.Phone = txtPhone.Text;

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

                if (DateTime.TryParseExact(txtDayJoin.Text + "/" + txtMonthJoin.Text + "/" + txtYearJoin.Text, 
                    formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out doj)
                    && DateTime.TryParseExact(txtDayBD.Text + "/" + txtMonthBD.Text + "/" + txtYearBD.Text, 
                    formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out bdate))
                {
                    dtoEmp.Birthdate = new DateTime(bdate.Year, bdate.Month, bdate.Day);
                    dtoEmp.DateOfJoin = new DateTime(doj.Year, doj.Month, doj.Day);

                    if (this.picboxEmpImg.Image == null)
                    {
                        MessageBox.Show("Please select a picture.", "Picture not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        dtoEmp.Image = ImageHelper.ImageToByteArray(this.picboxEmpImg.Image);
                        busEmp.AddEmployee(dtoEmp);
                        Reload();
                        errorProvider1.SetError(cbboxPosition, "");
                        MessageBox.Show("New employee added.", "Add employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid date fields.", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDayBD.ResetText();
                    txtMonthBD.ResetText();
                    txtYearBD.ResetText();
                    txtDayJoin.ResetText();
                    txtMonthJoin.ResetText();
                    txtYearJoin.ResetText();
                }
            }

        }

        private void Reload()
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            cbboxPosition.Items.Clear();
            cbboxPosition.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtDayBD.Text = ""; 
            txtMonthBD.Text = "";
            txtYearBD.Text = "";
            txtSalary.Text = "";
            txtPassword.Text = "";
            txtDayJoin.Text = "";
            txtMonthJoin.Text = "";
            txtYearJoin.Text = "";
            txtUsername.Text = "";
            radFemale.Checked = false;
            radMale.Checked = false;
            picboxEmpImg.Image = null;
            txtFirstName.Focus();
            _ucEmp.Reload();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            txtEmail.LostFocus += TxtEmail_LostFocus;
            tiktoker.Interval = 200;
            tiktoker.Tick += Tiktoker_Tick;
        }

        private void Tiktoker_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errEmail.SetError(txtEmail, "Email is required");
                btnAdd.Enabled = false;
            }
            else
            {
                if (EmailHelper.ValidateEmail(txtEmail.Text))
                {
                    errEmail.SetError(txtEmail, "");
                    btnAdd.Enabled = true;
                }
                else
                {
                    errEmail.SetError(txtEmail, "Email must be in the format 'example@example.example' and must not contain any whitespaces");
                    btnAdd.Enabled = false;
                }
            }
        }

        private void TxtEmail_LostFocus(object sender, EventArgs e)
        {
            tiktoker.Start();
        }

        private void txtDayBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYearBD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picboxEmpImg.SizeMode = PictureBoxSizeMode.StretchImage;
                picboxEmpImg.Image = Image.FromFile(openFileDialog1.FileName);
            }
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
