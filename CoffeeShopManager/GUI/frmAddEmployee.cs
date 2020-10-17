using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        UserControlEmployeesTab _ucEmp = new UserControlEmployeesTab();
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        public frmAddEmployee(UserControlEmployeesTab ucEmp)
        {
            ucEmp = _ucEmp;
            InitializeComponent();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" ||
                txtPosition.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || txtDayBD.Text == "" ||
                txtMonthBD.Text == "" || txtYearBD.Text == "" || txtSalary.Text == "" || txtPassword.Text == "" ||
                txtDayJoin.Text == "" || txtMonthJoin.Text == "" || txtYearJoin.Text == "" || (radFemale.Checked == false &&
                radMale.Checked == false))
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else
            {
                DateTime tmp = new DateTime();
                errorProvider1.SetError(txtYearBD, "");
                errorProvider1.SetError(txtYearJoin, "");
                DTO_Employee dtoEmp = new DTO_Employee();
                dtoEmp.Firstname = txtFirstName.Text;
                dtoEmp.Lastname = txtLastName.Text;
                dtoEmp.Address = txtAddress.Text;
                dtoEmp.Position = txtPosition.Text;
                string[] formats = { "dd/MM/yyyy", "d/M/yyyy" };
                dtoEmp.Phone = txtPhone.Text;
                dtoEmp.Account.Email = txtEmail.Text;
                dtoEmp.Account.PassWord = txtPassword.Text;
                dtoEmp.Salary = decimal.Parse(txtSalary.Text);
                dtoEmp.Manager = frmHome.dtoMan;
                if (busUser.Insert(dtoEmp.Account) == false)
                {
                    MessageBox.Show("Email đã tồn tại");
                    txtEmail.ResetText();
                    return;
                }
                dtoEmp.Phone = txtPhone.Text;
                if (radMale.Checked == true) dtoEmp.Gender = radMale.Text;
                else dtoEmp.Gender = radFemale.Text;
                if (DateTime.TryParseExact(txtDayJoin.Text + "/" + txtMonthJoin.Text + "/" + txtYearJoin.Text, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp)==true && DateTime.TryParseExact(txtDayBD.Text + "/" + txtMonthBD.Text + "/" + txtYearBD.Text, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp))
                //   if (DateTime.TryParse(txtDayJoin.Text + "/" + txtMonthJoin.Text + "/" + txtYearJoin.Text, out tmp))
                {
                    dtoEmp.Birthdate = new DateTime(tmp.Year, tmp.Month, tmp.Day);
                    dtoEmp.DateOfJoin = new DateTime(tmp.Year, tmp.Month, tmp.Day);
                    MessageBox.Show("" + dtoEmp.Birthdate.Day + dtoEmp.Birthdate.Month + dtoEmp.Birthdate.Year);
                    MessageBox.Show("" + dtoEmp.DateOfJoin.Day + dtoEmp.DateOfJoin.Month + dtoEmp.DateOfJoin.Year);
                    busEmp.AddEmployee(dtoEmp);
                    Reload();
                }
                else
                {
                    MessageBox.Show("Nhap date sai");
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
            txtPosition.Text = "";
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
            radFemale.Checked = false;
            radMale.Checked = false;
            _ucEmp.Reload();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {

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
    }
}
