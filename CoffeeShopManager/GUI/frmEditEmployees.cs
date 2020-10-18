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
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
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
            if (dtoEmp.Gender == "Male") radMale.Checked = true;
            else radFemale.Checked = true;
            cboPosition.Text = dtoEmp.Position;
            txtPhone.Text = dtoEmp.Phone;
            txtEmail.Text = dtoEmp.Account.Email;
            txtDayBD.Text = dtoEmp.Birthdate.Day.ToString();
            txtMonthBD.Text = dtoEmp.Birthdate.Month.ToString();
            txtYearBD.Text = dtoEmp.Birthdate.Year.ToString();
            txtDayJoin.Text = dtoEmp.DateOfJoin.Day.ToString();
            txtMonthJoin.Text = dtoEmp.DateOfJoin.Month.ToString();
            txtYearJoin.Text = dtoEmp.DateOfJoin.Year.ToString();
            txtAddress.Text = dtoEmp.Address;
            txtSalary.Text = dtoEmp.Salary.ToString();
            picboxEmpImg.SizeMode = PictureBoxSizeMode.StretchImage;
            
            if (dtoEmp.Image != null)
            {
                picboxEmpImg.Image = ImageHelper.ByteArrayToImage(dtoEmp.Image);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //

            dtoEmp.Image = ImageHelper.ImageToByteArray(picboxEmpImg.Image);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtYearJoin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYearBD_TextChanged(object sender, EventArgs e)
        {

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
    }
}
