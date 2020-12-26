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
using DTO;

namespace GUI
{
    public partial class frmRestoreEmployee : Form
    {
        private DTO_Employee dtoEmp = new DTO_Employee();
        private BUS_Employee busEmp = new BUS_Employee(ConnectionStringHelper.GetConnectionString());
        private UserControlEmployeesTab ucEmp;
        private frmAddEmployee frmAddEmp;
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public frmRestoreEmployee()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
        }

        public frmRestoreEmployee(UserControlEmployeesTab empTab, frmAddEmployee frmAdd, DTO_Employee emp) : this()
        {
            ucEmp = empTab;
            frmAddEmp = frmAdd;
            dtoEmp = emp;
            this.Location = frmAddEmp.Location;
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

        private void frmRestoreEmployee_Load(object sender, EventArgs e)
        {
            txtID.Text = dtoEmp.Id;
            txtFirstName.Text = dtoEmp.Firstname;
            txtLastName.Text = dtoEmp.Lastname;
            if (dtoEmp.Gender == "Male")
            {
                radMale.Checked = true;
            }
            else
            {
                radFemale.Checked = true;
            }
            cboPosition.Text = dtoEmp.Position;
            txtPhone.Text = dtoEmp.Phone;
            txtEmail.Text = dtoEmp.Email;
            datBirth.Format = DateTimePickerFormat.Custom;
            datBirth.CustomFormat = "dd/MM/yyyy";
            datBirth.Value = dtoEmp.Birthdate;
            txtAddress.Text = dtoEmp.Address;
            datJoin.Format = DateTimePickerFormat.Custom;
            datJoin.CustomFormat = datBirth.CustomFormat;
            datJoin.Value = dtoEmp.DateOfJoin;
            txtSalary.Text = dtoEmp.Salary.ToString();
            txtManagerID.Text = dtoEmp.Manager.Id;
            picboxEmpImg.Image = ImageHelper.ByteArrayToImage(dtoEmp.Image);
        }

        private void btnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
            frmAddEmp.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddEmp.Show();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                var ret = MessageBox.Show("Restore this employee?", "Restore employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    busEmp.RestoreDeletedEmployee(dtoEmp);
                    ucEmp.Reload();
                    MessageBox.Show("Deleted employee restored.", "Restore successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmAddEmp.Show();
                }
            }
            catch
            {
                MessageBox.Show("An error occurred, tab will reload now.", "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
