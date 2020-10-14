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

namespace GUI
{
    public partial class UserControlEmployeesTab : UserControl
    {
        BUS_Employee busEmp = new BUS_Employee();
        public UserControlEmployeesTab()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEmployee frmAddEmployee = new frmAddEmployee(this);
            frmAddEmployee.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                frmEditEmployees frmEditEmployees = new frmEditEmployees(this);
                frmEditEmployees.ShowDialog();
            }
        }
        public void Reload()
        {
            dataGridView1.DataSource = busEmp.GetAllEmployees();
            txtSearch.Text = "";
            cboSearch.Text = "";
        }

        private void UserControlEmployeesTab_Load(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
