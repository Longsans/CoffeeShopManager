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
        public string copyemail;
        private void frmEditEmployees_Load(object sender, EventArgs e)
        {
            datBirth.Format = DateTimePickerFormat.Custom;
            datBirth.CustomFormat = "dd/MM/yyyy";
            datJoin.Format = DateTimePickerFormat.Custom;
            datJoin.CustomFormat = "dd/MM/yyyy";

            txtFirstName.Focus();
            txtID.Text = dtoEmp.Id.ToString();
            txtFirstName.Text = dtoEmp.Firstname;
            txtLastName.Text = dtoEmp.Lastname;
            if (dtoEmp.Gender == "Male") radMale.Checked = true;
            else radFemale.Checked = true;
            cboPosition.Text = dtoEmp.Position;
            txtPhone.Text = dtoEmp.Phone;
            txtEmail.Text = dtoEmp.Email;
            txtCopyemail.Text = dtoEmp.Email;
            datBirth.Value = dtoEmp.Birthdate;
            datJoin.Value = dtoEmp.DateOfJoin;
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
            dtoEmp.Firstname = txtFirstName.Text;
            dtoEmp.Lastname = txtLastName.Text;
            dtoEmp.Address = txtAddress.Text;
            if (cboPosition.Text == "Phục vụ")
                cboPosition.Text = "Waiter";
            if (cboPosition.Text == "Thợ pha cà phê")
                cboPosition.Text = "Barista";
            if (cboPosition.Text == "Nấu ăn")
                cboPosition.Text = "Cook";
            if (cboPosition.Text == "Tiện ích")
                cboPosition.Text = "Utility";
            if (cboPosition.Text == "Vệ sinh")
                cboPosition.Text = "Janitor";
            if (cboPosition.Text == "Bảo vệ")
                cboPosition.Text = "Security";
            if (cboPosition.Text == "Khác")
                cboPosition.Text = "Others";
            dtoEmp.Position = cboPosition.Text;
            dtoEmp.Phone = txtPhone.Text;
            if(checkemail==1)
            dtoEmp.Email = txtEmail.Text;
            else
            {
                MessageBox.Show("Email trung hoac sai", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtSalary.Text = txtSalary.Text.Replace(',', '.');
            dtoEmp.Salary = decimal.Parse(txtSalary.Text);
            dtoEmp.Manager = busMan.GetById(txtManagerID.Text, dtoEmp.Shop.ID);
            dtoEmp.Phone = txtPhone.Text;
            if (radMale.Checked == true)
            {
                if (radMale.Text != "Nam")
                    dtoEmp.Gender = radMale.Text;
                else
                    dtoEmp.Gender = "Male";

            }
            else
            {
                if (radFemale.Text != "Nữ")
                    dtoEmp.Gender = radMale.Text;
                else
                    dtoEmp.Gender = "Female";
            }
            if (checkjoin==1&&checkbirth==1)
            {
                dtoEmp.Birthdate = datBirth.Value;
                dtoEmp.DateOfJoin = datJoin.Value;
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
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (EmailHelper.ValidateEmail(txtEmail.Text))
                {
                    errEmail.SetError(txtEmail, "");
                    errorProvider1.SetError(txtEmail, "Correct");
                    if (busEmp.GetByEmail(txtEmail.Text, frmManager.dtoMan.Shop.ID) == null||txtEmail.Text==dtoEmp.Email)
                    {
                        errEmail.SetError(txtEmail, "");
                        errorProvider1.SetError(txtEmail, "correct");
                        checkemail = 1;

                    }
                    else
                    {
                        errEmail.SetError(txtEmail, "Email had in shop");
                        errorProvider1.SetError(txtEmail, "");
                        checkemail = 0;

                    }
                }
                else
                {
                    errEmail.SetError(txtEmail, "Email must be in the format 'example@example.example' and must not contain any whitespaces");
                    errorProvider1.SetError(txtEmail, "");
                    checkemail = 0;
                }
            }
            else
            {
                errEmail.SetError(txtEmail, "Please fill all info fields");
                errorProvider1.SetError(txtEmail, "");
                checkemail = 0;
            }
            if (checkidmanager == 1 && checkemail == 1 && checkbirth == 1 && checkjoin == 1 && checksalary == 1)
            {
                btnSaveChange.Enabled = true;
            }
            else
            {
                btnSaveChange.Enabled = false;
            }
        }
        public int checkbirth, checkjoin, checkemail, checkidmanager,checksalary;

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtSalary.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double sala))
            {
                errEmail.SetError(txtSalary, "");
                errorProvider1.SetError(txtSalary, "correct");
                checksalary = 1;
            }
            else
            {
                errEmail.SetError(txtSalary, "Wrong format");
                errorProvider1.SetError(txtSalary, "");
                checksalary = 0;
            }
            if (checkidmanager == 1 && checkemail == 1 && checkbirth == 1 && checkjoin == 1&&checksalary==1)
            {
                btnSaveChange.Enabled = true;
            }
            else
            {
                btnSaveChange.Enabled = false;
            }

        }

        private void txtManagerID_TextChanged(object sender, EventArgs e)
        {
            if (busMan.GetById(txtManagerID.Text, dtoEmp.Shop.ID) != null)
            {
                checkidmanager = 1;
                errEmail.SetError(txtManagerID, "");
                errorProvider1.SetError(txtManagerID, "Correct");
            }
            else
            {
                checkidmanager = 0;
                errEmail.SetError(txtManagerID, "Haven't manager in shop");
                errorProvider1.SetError(txtManagerID, "");
            }
            if (checkidmanager == 1 && checkemail == 1 && checkbirth == 1 && checkjoin == 1 && checksalary == 1)
            {
                btnSaveChange.Enabled = true;
            }
            else
            {
                btnSaveChange.Enabled = false;
            }
        }

        private void datBirth_ValueChanged(object sender, EventArgs e)
        {
            datBirth.CustomFormat = "dd/MM/yyyy";
            DateTime now = DateTime.Now;
            if ((datJoin.Value.Year - datBirth.Value.Year) >= 18)
            {
                checkbirth = 1;
                checkjoin = 1;
                errEmail.SetError(datBirth, "");
                errorProvider1.SetError(datBirth, "Correct");
                errEmail.SetError(datJoin, "");
                errorProvider1.SetError(datJoin, "Correct");
            }
            else
            {
                checkjoin = 0;
                errEmail.SetError(datBirth, "Age not enough to work");
                errorProvider1.SetError(datBirth, "");
                errEmail.SetError(datJoin, "");
                errorProvider1.SetError(datJoin, "Correct");
                checkbirth = 0;
            }
            if (checkidmanager == 1 && checkemail == 1 && checkbirth == 1 && checkjoin == 1 && checksalary == 1)
            {
                btnSaveChange.Enabled = true;
            }
            else
            {
                btnSaveChange.Enabled = false;
            }
        }

        private void datJoin_ValueChanged(object sender, EventArgs e)
        {
            datJoin.CustomFormat = "dd/MM/yyyy";
            DateTime now = DateTime.Now;
            if ((datJoin.Value.Year - datBirth.Value.Year) >= 18)
            {
                checkjoin = 1;
                checkbirth = 1;
                errEmail.SetError(datBirth, "");
                errorProvider1.SetError(datBirth, "Correct");
                errEmail.SetError(datJoin, "");
                errorProvider1.SetError(datJoin, "Correct");
            }
            else
            {
                errEmail.SetError(datBirth, "Age not enough to work");
                errorProvider1.SetError(datBirth, "");
                errEmail.SetError(datJoin, "Age not enough to work");
                errorProvider1.SetError(datJoin, "");
                checkjoin = 0;
                checkbirth = 0;
            }
            /* if ((DateTime.Now.Year - datBirth.Value.Year) >= 18)
             {
                 errEmail.SetError(datBirth, "");
                 errorProvider1.SetError(datBirth, "Correct");
                 checkbirth = 1;
             }
             else
             {
                 errEmail.SetError(datBirth, "Age not enough to work");
                 errorProvider1.SetError(datBirth, "");
                 checkbirth = 0;
             }*/
            if (checkidmanager == 1 && checkemail == 1 && checkbirth == 1 && checkjoin == 1 && checksalary == 1)
            {
                btnSaveChange.Enabled = true;
            }
            else
            {
                btnSaveChange.Enabled = false;
            }
        }
    }
}
