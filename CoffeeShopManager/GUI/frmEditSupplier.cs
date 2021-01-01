﻿using System;
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
    public partial class frmEditSupplier : Form
    {
        BUS_Suppliers busSup = new BUS_Suppliers(ConnectionStringHelper.GetConnectionString());
        ErrorProvider err = new ErrorProvider();
        Timer tiktoker = new Timer();
        bool emailValid = true;
        public DTO_Supplier sup = new DTO_Supplier();
        public UserControlSuppliers ucSup { get; set; }

        Point prevPoint;
        bool dragging;

        public frmEditSupplier()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
        }

        private void frmEditSupplier_Load(object sender, EventArgs e)
        {
            tiktoker.Interval = 200;
            tiktoker.Tick += Tiktoker_Tick;
            AcceptButton = btnSave;
            txtId.Text = sup.Id;
            txtName.Text = sup.Name;
            txtEmail.Text = sup.Email;
            txtPhone.Text = sup.Phone;
            txtName.TextChanged += Textboxes_TextChanged;
            txtEmail.TextChanged += Textboxes_TextChanged;
            txtPhone.TextChanged += Textboxes_TextChanged;
        }

        private void Tiktoker_Tick(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text)) && emailValid)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Textboxes_TextChanged(object sender, EventArgs e)
        {
            err.SetIconPadding((TextBox)sender, 3);
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                if (btnSave.Text == "Lưu")
                err.SetError((TextBox)sender, "Vui lòng nhập đầy đủ thông tin");
                else err.SetError((TextBox)sender, "Please fill all info fields");

                if (sender == txtEmail)
                {
                    emailValid = false;
                }
            }
            else
            {
                err.SetError((TextBox)sender, "");
                if (sender == txtEmail)
                {
                    if (!EmailHelper.ValidateEmail(txtEmail.Text))
                    {
                        if (btnSave.Text == "Lưu")
                            err.SetError((TextBox)sender, "Email phải theo định dạng 'example@example.example' và không có bất kỳ khoảng trắng nào");
                        else err.SetError((TextBox)sender, "Email must be in the format 'example@example.example' and must not contain any whitespaces");
                        emailValid = false;
                    }
                    else
                    {
                        if (busSup.GetByEmail(txtEmail.Text, sup.Shop.ID) != null)
                        {
                            if (btnSave.Text == "Save")
                            {
                                err.SetError((TextBox)sender, "A supplier with such ID already exists");
                            }
                            else
                            {
                                err.SetError((TextBox)sender, "Đã có nhà cung cấp khác có email này");
                            }
                            emailValid = false;
                        }
                        else
                        {
                            err.SetError((TextBox)sender, "");
                            emailValid = true;
                        }
                    }
                }
            }
            tiktoker.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtPhone.Text, out long phone))
            {
                if (btnSave.Text == "Save")
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
                var updatedSup = new DTO_Supplier
                {
                    Id = sup.Id,
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Shop = sup.Shop
                };

                busSup.Update(updatedSup);
                if (btnSave.Text == "Save")
                    MessageBox.Show("Update successful.", "Update supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Cập nhật thành công", "Cập nhật nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ucSup.ReloadGridView();
            }
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
