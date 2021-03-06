﻿using System;
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
        BUS_Employee busEmp = new BUS_Employee(ConnectionStringHelper.GetConnectionString());
        public DTO_Manager dtoMan { get; set; } = new DTO_Manager();
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
                    dtoEmp = busEmp.GetInfoByIdNotDeleted(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dtoMan.Shop.ID)
                };
                frmEditEmployees.ShowDialog();
            }
        }

        private void TxtSearch_LostFocus(object sender, EventArgs e)
        {
            if (txtSearch.TextLength == 0)
            {
                txtSearch.ForeColor = Color.DimGray;
                if (btnEdit.Text == "Sửa")
                    txtSearch.Text = "Tìm kiếm...";
                else txtSearch.Text = "Search...";
            }
        }

        private void TxtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.DimGray)
            {
                txtSearch.Clear();
                txtSearch.ForeColor = SystemColors.WindowText;
            }
        }

        public void Reload()
        {
            dataGridView1.DataSource = busEmp.GetAllEmployee(dtoMan.Shop.ID);
            if (btnShowAll.Text != "Show All")
            {
                dataGridView1.Columns["Last Name"].HeaderText = "Họ";
                dataGridView1.Columns["First Name"].HeaderText = "Tên";
                dataGridView1.Columns["Position"].HeaderText = "Chức vụ";
                dataGridView1.Columns["Phone"].HeaderText = "SĐT";
                dataGridView1.Columns["Gender"].HeaderText = "Giới tính";
                dataGridView1.Columns["Manager's ID"].HeaderText = "ID Quản lý";
            }
            if (btnEdit.Text == "Sửa")
                txtSearch.Text = "Tìm kiếm...";
            else txtSearch.Text = "Search...";
            cboSearch.Text = "";
        }

        private void UserControlEmployeesTab_Load(object sender, EventArgs e)
        {
            txtSearch.GotFocus += TxtSearch_GotFocus;
            txtSearch.LostFocus += TxtSearch_LostFocus;
            Reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DTO_Employee dtoEmp = new DTO_Employee();
            if (dataGridView1.SelectedRows != null && !dataGridView1.Rows[dataGridView1.RowCount - 1].Selected )
            {
                DialogResult ret;
                if (btnEdit.Text == "Sửa")
                    ret = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                else ret = MessageBox.Show("Do you want to delete this employee?", "Delete employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                    dtoEmp = busEmp.GetInfoByIdNotDeleted(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dtoMan.Shop.ID);
                    if (busEmp.CheckReceiptExists(dtoEmp))
                    {
                        busEmp.FalseDelete(dtoEmp);
                    }
                    else
                    {
                        busEmp.TrueDelete(dtoEmp);
                    }
                    Reload();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.ForeColor != Color.DimGray)
                {
                    var resultIndex = cboSearch.FindStringExact(cboSearch.Text);

                    switch (resultIndex)
                    {
                        case 0:
                            this.dataGridView1.DataSource = busEmp.GetEmployeesSearchIDFiltered(txtSearch.Text, dtoMan.Shop.ID);
                            break;
                        case 1:
                            this.dataGridView1.DataSource = busEmp.GetEmployeesSearchNameFiltered(txtSearch.Text, dtoMan.Shop.ID);
                            break;
                        case 2:
                            this.dataGridView1.DataSource = busEmp.GetEmployeesSearchGenderFiltered(txtSearch.Text, dtoMan.Shop.ID);
                            break;
                        case 3:
                            this.dataGridView1.DataSource = busEmp.GetEmployeesSearchPositionFiltered(txtSearch.Text, dtoMan.Shop.ID);
                            break;
                        case 4:
                            this.dataGridView1.DataSource = busEmp.GetEmployeesSearchPhoneFiltered(txtSearch.Text, dtoMan.Shop.ID);
                            break;
                        case 5:
                            this.dataGridView1.DataSource = busEmp.GetEmployeesSearchEmailFiltered(txtSearch.Text, dtoMan.Shop.ID);
                            break;
                        case 6:
                            this.dataGridView1.DataSource = busEmp.GetEmployeesSearchManIDFiltered(txtSearch.Text, dtoMan.Shop.ID);
                            break;
                    }
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

        }
    }
}
