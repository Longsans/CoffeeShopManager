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
namespace GUI
{
    public partial class frmAddEmployee : Form
    {
        BUS_Employee busEmp = new BUS_Employee();
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
                dtoEmp.Id = int.Parse(txtID.Text);
                dtoEmp.Firstname = txtFirstName.Text;
                dtoEmp.Lastname = txtLastName.Text;
                dtoEmp.Address = txtAddress.Text;
                dtoEmp.Position = txtPosition.Text;
                if (DateTime.TryParse(txtDayBD.Text + "/" + txtMonthBD.Text + "/" + txtYearBD.Text, out tmp))
                {
                    dtoEmp.Birthdate = tmp;
                }
                else errorProvider1.SetError(txtYearBD, "Date is invalid");
                dtoEmp.Phone = txtPhone.Text;
                dtoEmp.Account.Email = txtEmail.Text;
                dtoEmp.Account.PassWord = txtPassword.Text;
                dtoEmp.Salary = double.Parse(txtSalary.Text);
                if (DateTime.TryParse(txtDayJoin.Text + "/" + txtMonthJoin.Text + "/" + txtYearJoin.Text, out tmp))
                {
                    dtoEmp.Birthdate = tmp;
                }
                else errorProvider1.SetError(txtYearJoin, "Date is invalid");
                dtoEmp.Phone = txtPhone.Text;
                if (radMale.Checked == true) dtoEmp.Gender = radMale.Text;
                else dtoEmp.Gender = radFemale.Text;
                dtoEmp.Manager = frmHome.dtoMan;
                busEmp.AddEmployee(dtoEmp);
                Reload();
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
    }
}
