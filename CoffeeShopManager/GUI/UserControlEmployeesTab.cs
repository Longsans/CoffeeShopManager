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
            Reload();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && !dataGridView1.Rows[dataGridView1.RowCount - 1].Selected)
            {
                frmEditEmployees frmEditEmployees = new frmEditEmployees(this)
                {
                    dtoEmp = busEmp.GetEmployeeInfoByEmail(dataGridView1.SelectedRows[0].Cells[6].Value.ToString())
                };
                frmEditEmployees.ShowDialog();
            }
        }
        public void Reload()
        {
            dataGridView1.DataSource = busEmp.GetAllEmployee();
            txtSearch.Text = "";
            cboSearch.Text = "";
        }

        private void UserControlEmployeesTab_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DTO_Employee dtoEmp = new DTO_Employee();
            if (dataGridView1.SelectedRows != null && !dataGridView1.Rows[dataGridView1.RowCount - 1].Selected )
            {
                DialogResult ret = MessageBox.Show("Do you want to delete this employee?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                    dtoEmp = busEmp.GetEmployeeInfoByEmail(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                    busEmp.DeleteEmployee(dtoEmp);
                    Reload();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cboSearch.Text)
                {
                    case "ID":
                        this.dataGridView1.DataSource = busEmp.GetEmployeesSearchIDFiltered(Int32.Parse(txtSearch.Text));
                        break;
                    case "Name":
                        this.dataGridView1.DataSource = busEmp.GetEmployeesSearchNameFiltered(txtSearch.Text);
                        break;
                    case "Gender":
                        this.dataGridView1.DataSource = busEmp.GetEmployeesSearchGenderFiltered(txtSearch.Text);
                        break;
                    case "Position":
                        this.dataGridView1.DataSource = busEmp.GetEmployeesSearchPositionFiltered(txtSearch.Text);
                        break;
                    case "Phone number":
                        this.dataGridView1.DataSource = busEmp.GetEmployeesSearchPhoneFiltered(txtSearch.Text);
                        break;
                    case "Email":
                        this.dataGridView1.DataSource = busEmp.GetEmployeesSearchEmailFiltered(txtSearch.Text);
                        break;
                    case "Manager's ID":
                        this.dataGridView1.DataSource = busEmp.GetEmployeesSearchManIDFiltered(Int32.Parse(txtSearch.Text));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bro, ông làm gì sai rồi. Thông báo lỗi: {ex.Message}", 
                    "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }
    }
}
