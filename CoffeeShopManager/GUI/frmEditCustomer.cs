using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmEditCustomer : Form
    {
        BUS_Customers busCus = new BUS_Customers(ConnectionStringHelper.GetConnectionString());
        public DTO_Customer dtoCus { get; set; }
        public UserControlCustomers ucCus { get; set; }
        ErrorProvider err = new ErrorProvider();
        Icon checkIcon,
            errorIcon;
        Point prevPoint;
        bool dragging;

        public frmEditCustomer()
        {
            StartPosition = FormStartPosition.Manual;
            AcceptButton = btnSave;
            InitializeComponent();
        }

        public frmEditCustomer(UserControlCustomers ucc) : this()
        {
            ucCus = ucc;
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            checkIcon = new Icon(GUI.Properties.Resources.check1, err.Icon.Size);
            errorIcon = new Icon(GUI.Properties.Resources.cancel, err.Icon.Size);
            err.SetIconPadding(txtEmail, 5);
            txtId.Text = dtoCus.Id.ToString();
            txtFirstName.Text = dtoCus.FirstName;
            txtLastName.Text = dtoCus.LastName;
            txtEmail.Text = dtoCus.Email;
            datBirthdate.Format = DateTimePickerFormat.Custom;
            datBirthdate.CustomFormat = "dd/MM/yyyy";
            if (dtoCus.Birthdate >= datBirthdate.MinDate && dtoCus.Birthdate <= datBirthdate.MaxDate)
            {
                datBirthdate.Value = dtoCus.Birthdate;
            }
            else
            {
                datBirthdate.CustomFormat = " ";
            }
            btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((DateTime.Now.Year - datBirthdate.Value.Year) >= 5 && datBirthdate.Value.Year <= 2078 && datBirthdate.Value.Year >= 1910)
            {
                dtoCus = new DTO_Customer
                {
                    Id = dtoCus.Id,
                    FirstName = dtoCus.FirstName,
                    LastName = dtoCus.LastName,
                    Email = txtEmail.Text,
                    Birthdate = datBirthdate.Value,
                };

                busCus.Update(dtoCus);
                if (btnSave.Text == "Lưu")
                    MessageBox.Show("Cập nhật thành công.", "Sửa thành công ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Update successful.", "Edit success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ucCus.ReloadGridView();
            }
            else
            {
                if (btnSave.Text == "Lưu")
                    MessageBox.Show("Sai tuổi", "Tuổi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                MessageBox.Show("Wrong age", "Age", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (EmailHelper.ValidateEmail(txtEmail.Text))
                {
                    var cus = busCus.GetCustomerByEmail(txtEmail.Text, dtoCus.Shop.ID);
                    if (cus != null && cus.Email != dtoCus.Email)
                    {
                        err.Icon = errorIcon;
                        if (btnSave.Text == "Lưu")
                            err.SetError(txtEmail, "Khách hàng với email này đã tồn tại.");
                        else err.SetError(txtEmail, "A customer with such email already exists");
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        err.Icon = checkIcon;
                        if (btnSave.Text == "Lưu") 
                            err.SetError(txtEmail, "Hợp lệ");
                        else err.SetError(txtEmail, "Valid");
                        btnSave.Enabled = true;
                    }
                }
                else
                {
                    err.Icon = errorIcon;
                    if (btnSave.Text == "Lưu")
                        err.SetError(txtEmail, "Email phải theo mẫu 'example@example.example' và không được có bất kỳ khoảng trắng nào.");
                    else err.SetError(txtEmail, "Email must be in the format 'example@example.example' and must not contain any whitespaces");
                    btnSave.Enabled = false;
                }
            }
            else
            {
                err.Icon = errorIcon;
                if (btnSave.Text == "Lưu")
                    err.SetError(txtEmail, "Vui lòng nhập đầy đủ thông tin");
                else err.SetError(txtEmail, "Please fill all info fields");
                btnSave.Enabled = false;
            }
        }

        private void datBirthdate_ValueChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            datBirthdate.CustomFormat = "dd/MM/yyyy";
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            prevPoint = Cursor.Position;
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point(this.Location.X + Cursor.Position.X - prevPoint.X, this.Location.Y + Cursor.Position.Y - prevPoint.Y);
                prevPoint = Cursor.Position;
            }
        }
    }
}
