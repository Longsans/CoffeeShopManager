using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

using BUS;
using System.Globalization;

namespace GUI
{
    public partial class frmAddEmployee : Form
    {
        BUS_Employee busEmp = new BUS_Employee(ConnectionStringHelper.GetConnectionString());
        BUS_UserInfo busUser = new BUS_UserInfo(ConnectionStringHelper.GetConnectionString());
        UserControlEmployeesTab _ucEmp;
        Timer tiktoker = new Timer();
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public int checkbirth,checkjoin;
        private bool checkIdDeleted = true;

        public frmAddEmployee()
        {
            InitializeComponent();
        }

        public frmAddEmployee(UserControlEmployeesTab ucEmp)
        {
            _ucEmp = ucEmp;
            InitializeComponent();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkid == 0)
            {
                MessageBox.Show(cboString.Items[0].ToString());
                return;
            }
            else
            {
                if (!checkIdDeleted)
                {
                    var ret = MessageBox.Show(cboString.Items[1].ToString(),
                        cboString.Items[2].ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (ret == DialogResult.Yes)
                    {
                        frmRestoreEmployee frmRes = new frmRestoreEmployee(_ucEmp, this,
                            busEmp.GetInfoByIdDeletedAndNotDeleted(txtID.Text, frmManager.dtoMan.Shop.ID));
                        this.Hide();
                        this.Reload();
                        frmRes.Show();
                        frmRes.TopMost = true;
                    }

                }
                else if (txtID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" ||
                    cbboxPosition.Text == "" || txtPhone.Text == "" || txtEmail.Text == ""
                    || txtSalary.Text == "" || txtUsername.Text == "" || txtPassword.Text == ""
                   || (radFemale.Checked == false &&
                    radMale.Checked == false))
                {
                    MessageBox.Show(cboString.Items[3].ToString(), cboString.Items[4].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbboxPosition.Text == "Manager")
                {
                    MessageBox.Show(cboString.Items[5].ToString(), cboString.Items[6].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorProvider1.SetError(cbboxPosition, cboString.Items[7].ToString());
                }
                else if (!long.TryParse(txtPhone.Text, out long phone))
                {
                    if (btnAdd.Text == "Add")
                    {
                        MessageBox.Show("Phone number can only contain numeric characters.", "Invalid phone number format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại chỉ được chứa ký tự số.", "Định dạng số điện thoại không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    DateTime bdate = new DateTime();
                    DateTime doj = new DateTime();
                    string[] formats = { "dd/MM/yyyy", "d/M/yyyy" };

                    DTO_Employee dtoEmp = new DTO_Employee();
                    dtoEmp.Id = txtID.Text;
                    dtoEmp.Firstname = txtFirstName.Text;
                    dtoEmp.Lastname = txtLastName.Text;
                    dtoEmp.Address = txtAddress.Text;
                    int resultIndex = cbboxPosition.FindStringExact(cbboxPosition.Text);
                    if (resultIndex == 0)
                        cbboxPosition.Text = "Waiter";
                    else if (resultIndex == 1)
                        cbboxPosition.Text = "Barista";
                    else if (resultIndex == 2)
                        cbboxPosition.Text = "Cook";
                    else if (resultIndex == 3)
                        cbboxPosition.Text = "Utility";
                    else if (resultIndex == 4)
                        cbboxPosition.Text = "Janitor";
                    else if (resultIndex == 5)
                        cbboxPosition.Text = "Security";
                    else
                        cbboxPosition.Text = "Others";
                    dtoEmp.Position = cbboxPosition.Text;
                    dtoEmp.Phone = txtPhone.Text;
                    dtoEmp.Email = txtEmail.Text;
                    dtoEmp.Account.Username = txtUsername.Text;
                    dtoEmp.Account.PassWord = txtPassword.Text;
                    txtSalary.Text = txtSalary.Text.Replace(',', '.');
                    if (double.TryParse(txtSalary.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double sala)==false)
                    {
                        if (label3.Text == "Add employee")
                        {
                            MessageBox.Show("Wrong salary", "Salary", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("Sai tiền lương","tiền lương", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (double.TryParse(txtSalary.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out sala))
                        dtoEmp.Salary = (decimal)sala;
                    dtoEmp.Manager = frmManager.dtoMan;
                    dtoEmp.Shop.ID = frmManager.dtoMan.Shop.ID;
                    dtoEmp.Account = busUser.EncodePass(dtoEmp);

                    if (!busUser.CheckUsername(dtoEmp.Account.Username))
                    {
                        MessageBox.Show(cboString.Items[8].ToString(), cboString.Items[9].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtEmail.ResetText();
                        return;
                    }
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

                    if (checkbirth == 1 && checkjoin == 1)
                    {
                        dtoEmp.Birthdate = datBirth.Value;
                        dtoEmp.DateOfJoin = datJoin.Value;

                        if (this.picboxEmpImg.Image == null)
                        {
                            MessageBox.Show(cboString.Items[10].ToString(), cboString.Items[11].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            dtoEmp.Image = ImageHelper.ImageToByteArray(this.picboxEmpImg.Image);
                            busEmp.AddEmployee(dtoEmp);
                            Reload();
                            errorProvider1.SetError(cbboxPosition, "");
                            MessageBox.Show(cboString.Items[12].ToString(), cboString.Items[4].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(cboString.Items[13].ToString(), cboString.Items[14].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void Reload()
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            cbboxPosition.Text = string.Empty;
            cbboxPosition.SelectedIndex = -1;
            txtPhone.Text = "";
            txtEmail.Text = "";

            txtSalary.Text = "";
            txtPassword.Text = "";

            txtUsername.Text = "";
            radFemale.Checked = false;
            radMale.Checked = false;
            picboxEmpImg.Image = null;
            txtFirstName.Focus();
            _ucEmp.Reload();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            datBirth.Format = DateTimePickerFormat.Custom;
            datBirth.CustomFormat = "dd/MM/yyyy";
            datBirth.Value = DateTime.Now;
            datJoin.Format = DateTimePickerFormat.Custom;
            datJoin.CustomFormat = "dd/MM/yyyy";
            datJoin.Value = DateTime.Now;

            txtEmail.LostFocus += TxtEmail_LostFocus;
            tiktoker.Interval = 200;
            tiktoker.Tick += Tiktoker_Tick;
        }
        public int checkmail=0,checkid=0;
        private void Tiktoker_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errEmail.SetError(txtEmail, cboString.Items[15].ToString());
                errorProvider1.SetError(txtEmail, "");
                checkmail = 0;
                btnAdd.Enabled = false;
            }
            else
            {
                if (EmailHelper.ValidateEmail(txtEmail.Text))
                {
                    if (busEmp.GetByEmail(txtEmail.Text, frmManager.dtoMan.Shop.ID) == null)
                    {
                        errEmail.SetError(txtEmail, "");
                        errorProvider1.SetError(txtEmail, cboString.Items[16].ToString());
                        checkmail = 1;
                        btnAdd.Enabled = true;
                    }
                    else
                    {
                        errEmail.SetError(txtEmail, cboString.Items[17].ToString());
                        errorProvider1.SetError(txtEmail, "");
                        checkmail = 0;
                        btnAdd.Enabled = false;
                    }
                }
                else
                {
                    errEmail.SetError(txtEmail, cboString.Items[18].ToString());
                    errorProvider1.SetError(txtEmail, "");
                    checkmail = 0;
                    btnAdd.Enabled = false;
                }
            }
        }

        private void TxtEmail_LostFocus(object sender, EventArgs e)
        {
            tiktoker.Start();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picboxEmpImg.SizeMode = PictureBoxSizeMode.StretchImage;
                picboxEmpImg.Image = Image.FromFile(openFileDialog1.FileName);
            }
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var emp = busEmp.GetInfoByIdDeletedAndNotDeleted(txtID.Text, frmManager.dtoMan.Shop.ID);
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                checkid = 0;
                checkIdDeleted = true;
                errEmail.SetError(txtID, cboString.Items[3].ToString());
                errorProvider1.SetError(txtID, "");
                errIdDeleted.SetError(txtID, "");
            }
            else if (emp != null)
            {
                if (!emp.Deleted)
                {
                    checkid = 0;
                    checkIdDeleted = true;
                    errEmail.SetError(txtID, cboString.Items[19].ToString());
                    errorProvider1.SetError(txtID, "");
                    errIdDeleted.SetError(txtID, "");
                }
                else
                {
                    checkIdDeleted = false;
                    checkid = 1;
                    errEmail.SetError(txtID, "");
                    errorProvider1.SetError(txtID, "");
                    errIdDeleted.SetError(txtID, cboString.Items[20].ToString());
                }
            }
            else
            {
                checkid = 1;
                checkIdDeleted = true;
                errEmail.SetError(txtID, "");
                errIdDeleted.SetError(txtID, "");
                errorProvider1.SetError(txtID, cboString.Items[21].ToString());

            }
            if (checkidmanager == 1 && checkmail == 1 && checkbirth == 1 && checkjoin == 1 && checkuser == 1 && checksalary == 1 && checkid == 1)
            {
                btnAdd.Enabled = true;
            }
            else if (!checkIdDeleted)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
        public int checkuser=0;
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (busEmp.GetEmployeeInfoByUsername(txtUsername.Text) != null)
            {
                checkuser = 1;
                errEmail.SetError(txtUsername, cboString.Items[22].ToString());
                errorProvider1.SetError(txtUsername, "");

            }
            else
            {
                checkuser = 0;
                errEmail.SetError(txtUsername, "");
                errorProvider1.SetError(txtUsername, cboString.Items[16].ToString());

            }
            if (checkidmanager == 1 && checkmail == 1 && checkbirth == 1 && checkjoin == 1 &&checkuser==1&& checksalary == 1 && checkid == 1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
        public int checksalary=0,checkidmanager=0;

        private void cbboxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
           var resultIndex = cbboxPosition.FindStringExact(cbboxPosition.Text);
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtSalary.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double sala))
            {
                errEmail.SetError(txtSalary, "");
                errorProvider1.SetError(txtSalary, cboString.Items[16].ToString());
                checksalary = 1;
            }
            else
            {
                errEmail.SetError(txtSalary, cboString.Items[23].ToString());
                errorProvider1.SetError(txtSalary, "");
                checksalary = 0;
            }
            if (checkidmanager == 1 && checkmail == 1 && checkbirth == 1 && checkjoin == 1 && checkuser == 1 && checksalary == 1 && checkid == 1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }

        }

        private void datJoin_ValueChanged(object sender, EventArgs e)
        {
            datJoin.CustomFormat = "dd/MM/yyyy";
            DateTime now = DateTime.Now;
            if ((datJoin.Value.Year - datBirth.Value.Year) >= 18 && datBirth.Value.Year <= 2078 && datJoin.Value.Year <= 2078 && datBirth.Value.Year >= 1910 && datJoin.Value.Year >= 1910  )
            {
                checkjoin = 1;
                checkbirth = 1;
                errEmail.SetError(datBirth, "");
                errorProvider1.SetError(datBirth, cboString.Items[16].ToString());
                errEmail.SetError(datJoin, "");
                errorProvider1.SetError(datJoin, cboString.Items[16].ToString());
            }
            else
            {
                errEmail.SetError(datBirth, cboString.Items[24].ToString());
                errorProvider1.SetError(datBirth, "");
                errEmail.SetError(datJoin, cboString.Items[24].ToString());
                errorProvider1.SetError(datJoin, "");
                checkjoin = 0;
                checkbirth = 0;
            }
            if (checkidmanager == 1 && checkmail == 1 && checkbirth == 1 && checkjoin == 1 && checkuser == 1 && checksalary == 1 && checkid == 1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }

        }

        private void datBirth_ValueChanged(object sender, EventArgs e)
        {
            datBirth.CustomFormat = "dd/MM/yyyy";
            DateTime now = DateTime.Now;
            if ((datJoin.Value.Year - datBirth.Value.Year) >= 18 && datBirth.Value.Year <= 2078 && datJoin.Value.Year <= 2078&& datBirth.Value.Year>=1910 &&datJoin.Value.Year>=1910)
            {
                checkbirth = 1;
                checkjoin = 1;
                errEmail.SetError(datBirth, "");
                errorProvider1.SetError(datBirth, cboString.Items[16].ToString());
                errEmail.SetError(datJoin, "");
                errorProvider1.SetError(datJoin, cboString.Items[16].ToString());
            }
            else
            {
                checkjoin = 0;
                errEmail.SetError(datBirth, cboString.Items[24].ToString());
                errorProvider1.SetError(datBirth, "");
                errEmail.SetError(datJoin, "");
                errorProvider1.SetError(datJoin, cboString.Items[16].ToString());
                checkbirth = 0;
            }
            if (checkidmanager == 1 && checkmail == 1 && checkbirth == 1 && checkjoin == 1 && checkuser == 1 && checksalary == 1 && checkid == 1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }

        }
    }
}
