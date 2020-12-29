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
using BUS;
using DTO;

namespace GUI
{
    public partial class frmAddSupplier : Form
    {
        BUS_Suppliers busSup = new BUS_Suppliers(ConnectionStringHelper.GetConnectionString());
        ErrorProvider err = new ErrorProvider(),
            errtwo = new ErrorProvider();
        public DTO_Shop Shop = new DTO_Shop();
        public UserControlSuppliers ucSup { get; set; }
        Timer tiktoker = new Timer();
        Icon checkIcon,
            errorIcon;
        Point prevPoint;
        bool dragging;

        public frmAddSupplier()
        {
            StartPosition = FormStartPosition.Manual;
            AcceptButton = btnAdd;
            InitializeComponent();
        }

        private void frmAddSupplier_Load(object sender, EventArgs e)
        {
            checkIcon = new Icon(GUI.Properties.Resources.check1, err.Icon.Size);
            errorIcon = new Icon(GUI.Properties.Resources.cancel, err.Icon.Size);
            err.SetIconPadding(txtId, 3);
            errtwo.SetIconPadding(txtEmail, 3);
            tiktoker.Interval = 200;
            tiktoker.Tick += Tiktoker_Tick;
            tiktoker.Start();
        }

        private void Tiktoker_Tick(object sender, EventArgs e)
        {
            if (err.Icon == checkIcon && errtwo.Icon == checkIcon && !string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtPhone.Text, out long phone))
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
                var sup = new DTO_Supplier
                {
                    Id = txtId.Text,
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Shop = this.Shop
                };

                busSup.Insert(sup);
                ucSup.ReloadGridView();
                if (btnAdd.Text == "Thêm")
                    MessageBox.Show("Thêm thành công", "Thêm hàng hóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Insert successful.", "Add supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetTextboxes();
            }
        }

        private void ResetTextboxes()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                if (busSup.GetById(txtId.Text, Shop.ID) != null)
                {
                    err.Icon = errorIcon;
                    if (btnAdd.Text == "Thêm")
                        err.SetError(txtId, "ID nhà cung cấp đã tồn tại");
                    else err.SetError(txtId, "A supplier with such ID already exists");
                }
                else
                {
                    err.Icon = checkIcon;
                    if (btnAdd.Text == "Thêm")
                        err.SetError(txtId, "Hợp lệ");
                    else err.SetError(txtId, "Valid");
                }
            }
            else
            {
                err.Icon = errorIcon;
                if (btnAdd.Text == "Thêm")
                    err.SetError(txtId, "Vui lòng nhập đầy đủ thông tin");
                else err.SetError(txtId, "Please fill all info fields");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (busSup.GetByEmail(txtEmail.Text, Shop.ID) != null)
                {
                    errtwo.Icon = errorIcon;
                    if (btnAdd.Text == "Thêm")
                        errtwo.SetError(txtEmail, "Email nhà cung cấp đã tồn tại");
                    else errtwo.SetError(txtEmail, "A supplier with such email already exists");
                }
                else
                {
                    if (EmailHelper.ValidateEmail(txtEmail.Text))
                    {
                        errtwo.Icon = checkIcon;
                        if (btnAdd.Text == "Thêm")
                            errtwo.SetError(txtEmail, "Hợp lệ");
                        else errtwo.SetError(txtEmail, "Valid");
                    }
                    else
                    {
                        errtwo.Icon = errorIcon;
                        if (btnAdd.Text == "Thêm")
                            errtwo.SetError(txtEmail, "Email phải theo định dạng 'example@example.example' và không có bất kỳ khoảng trắng nào");
                        else errtwo.SetError(txtEmail, "Email must be in the format 'example@example.example' and must not contain any whitespaces");
                    }
                }
            }
            else
            {
                errtwo.Icon = errorIcon;
                if (btnAdd.Text == "Thêm")
                    errtwo.SetError(txtEmail, "Vui lòng nhập đầy đủ thông tin");
                else errtwo.SetError(txtEmail, "Please fill all info fields");
            }
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
