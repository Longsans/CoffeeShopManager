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
using BUS;
using System.Globalization;

namespace GUI
{
    public partial class frmEditEmployees : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        UserControlEmployeesTab _ucEmp = new UserControlEmployeesTab();
        public DTO_Employee dtoEmp = new DTO_Employee();
        BUS_Employee busEmp = new BUS_Employee();
        BUS_Manager busMan = new BUS_Manager();
        Timer tiktoker = new Timer();
        bool emailValid = true;

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
            txtFirstName.Focus();
            txtID.Text = dtoEmp.Id.ToString();
            txtFirstName.Text = dtoEmp.Firstname;
            txtLastName.Text = dtoEmp.Lastname;
            if (dtoEmp.Gender == "Male") radMale.Checked = true;
            else radFemale.Checked = true;
            cboPosition.Text = dtoEmp.Position;
            txtPhone.Text = dtoEmp.Phone;
            txtEmail.Text = dtoEmp.Email;
            txtDayBD.Text = dtoEmp.Birthdate.Day.ToString();
            txtMonthBD.Text = dtoEmp.Birthdate.Month.ToString();
            txtYearBD.Text = dtoEmp.Birthdate.Year.ToString();
            txtDayJoin.Text = dtoEmp.DateOfJoin.Day.ToString();
            txtMonthJoin.Text = dtoEmp.DateOfJoin.Month.ToString();
            txtYearJoin.Text = dtoEmp.DateOfJoin.Year.ToString();
            txtAddress.Text = dtoEmp.Address;
            txtSalary.Text = dtoEmp.Salary.ToString();
            txtManagerID.Text = dtoEmp.Manager.Id.ToString();
            picboxEmpImg.SizeMode = PictureBoxSizeMode.StretchImage;
            if (dtoEmp.Image != null)
            {
                picboxEmpImg.Image = ImageHelper.ByteArrayToImage(dtoEmp.Image);
            }
            tiktoker.Interval = 200;
            tiktoker.Tick += Tiktoker_Tick;
        }

        private void Tiktoker_Tick(object sender, EventArgs e)
        {
            if (emailValid)
            {
                btnSaveChange.Enabled = true;
            }
            else
            {
                btnSaveChange.Enabled = false;
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

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            DateTime bdate = new DateTime();
            DateTime doj = new DateTime();
            string[] formats = { "dd/MM/yyyy", "d/M/yyyy" };
            errorProvider1.SetError(txtYearBD, "");
            errorProvider1.SetError(txtYearJoin, "");
            dtoEmp.Firstname = txtFirstName.Text;
            dtoEmp.Lastname = txtLastName.Text;
            dtoEmp.Address = txtAddress.Text;
            dtoEmp.Position = cboPosition.Text;
            dtoEmp.Phone = txtPhone.Text;
            dtoEmp.Email = txtEmail.Text;
            dtoEmp.Salary = decimal.Parse(txtSalary.Text);
            dtoEmp.Manager = busMan.GetById(txtManagerID.Text, dtoEmp.Shop.ID);
            dtoEmp.Phone = txtPhone.Text;
            if (radMale.Checked == true) dtoEmp.Gender = radMale.Text;
            else dtoEmp.Gender = radFemale.Text;
            if (DateTime.TryParseExact(txtDayJoin.Text + "/" + txtMonthJoin.Text + "/" + txtYearJoin.Text,
                formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out doj)
                && DateTime.TryParseExact(txtDayBD.Text + "/" + txtMonthBD.Text + "/" + txtYearBD.Text,
                formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out bdate))
            {
                dtoEmp.Birthdate = new DateTime(bdate.Year, bdate.Month, bdate.Day);
                dtoEmp.DateOfJoin = new DateTime(doj.Year, doj.Month, doj.Day);
                if (this.picboxEmpImg.Image == null)
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh", "Edit employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dtoEmp.Image = ImageHelper.ImageToByteArray(this.picboxEmpImg.Image);
                    busEmp.EditEmployee(dtoEmp);
                    MessageBox.Show("Edit thành công.", "Add employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    _ucEmp.Reload();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ngày hợp lệ.", "Add employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDayBD.ResetText();
                txtMonthBD.ResetText();
                txtYearBD.ResetText();
                txtDayJoin.ResetText();
                txtMonthJoin.ResetText();
                txtYearJoin.ResetText();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (EmailHelper.ValidateEmail(txtEmail.Text))
                {
                    errEmail.SetError(txtEmail, "");
                    emailValid = true;
                }
                else
                {
                    errEmail.SetError(txtEmail, "Email must be in the format 'example@example.example' and must not contain any whitespaces");
                    emailValid = false;
                }
            }
            else
            {
                errEmail.SetError(txtEmail, "Please fill all info fields");
                emailValid = false;
            }
            tiktoker.Start();
        }
    }
}
