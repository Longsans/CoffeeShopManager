using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmEditEmployees : Form
    {
        UserControlEmployeesTab _ucEmp = new UserControlEmployeesTab();
        public DTO_Employee dtoEmp = new DTO_Employee();
        public frmEditEmployees()
        {
            InitializeComponent();
        }
        public frmEditEmployees(UserControlEmployeesTab ucEmp)
        {
            _ucEmp = ucEmp;
            InitializeComponent();
        }

        private void frmEditEmployees_Load(object sender, EventArgs e)
        {
            txtID.Text = dtoEmp.Id.ToString();
            txtFirstName.Text = dtoEmp.Firstname;
            txtLastName.Text = dtoEmp.Lastname;
            if (radMale.Checked) dtoEmp.Gender = "Male";
            else dtoEmp.Gender = "Female";
            txtPosition.Text = dtoEmp.Position;
            txtPhone.Text = dtoEmp.Phone;
            txtEmail.Text = dtoEmp.Account.Email;
            txtAddress.Text = dtoEmp.Address;
            txtSalary.Text = dtoEmp.Salary.ToString();
        }
    }
}
