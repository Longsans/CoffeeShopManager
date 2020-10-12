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
            //DTO_Employee dtoEmp = new DTO_Employee();
            //dtoEmp.Address = "Ho Chi Minh";
            //dtoEmp.Birthdate = DateTime.Today;
            //dtoEmp.DateOfJoin = DateTime.Today;
            //dtoEmp.Firstname = "Nguyen";
            //dtoEmp.Gender = "Male";
            //dtoEmp.Id = 1;
            ////dtoEmp.Manager = ";
            //dtoEmp.Phone = "123456";
            //dtoEmp.Position = "Bartender";
            //dtoEmp.Salary = 1000000;
            //dtoEmp.Account.Email = "ncuoong";
            //dtoEmp.Account.PassWord = "123456";
            //BUS_Employee bUS_Employee = new BUS_Employee();
            //bUS_Employee.AddEmployee(dtoEmp);
            //_ucEmp.
                
        }
    }
}
