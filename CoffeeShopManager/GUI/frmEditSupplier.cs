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
            tiktoker.Interval = 500;
            tiktoker.Tick += Tiktoker_Tick;
            AcceptButton = btnSave;
            txtId.Text = sup.Id;
            txtName.Text = sup.Name;
            txtEmail.Text = sup.Email;
            txtPhone.Text = sup.Phone;
        }

        private void Tiktoker_Tick(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text)) && emailValid)
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

        private void Textboxes_Validating(object sender, CancelEventArgs e)
        {
            err.SetIconPadding((TextBox)sender, 3);
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                if (btnSave.Text == "Lưu")
                err.SetError((TextBox)sender, "Vui lòng nhập đầy đủ thông tin");
                else err.SetError((TextBox)sender, "Please fill all info fields");
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
                        emailValid = true;
                    }
                }
            }
            tiktoker.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            if (btnSave.Text == "Lưu")
                MessageBox.Show("Update successful.", "Update supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Cập nhật thành công", "Cập nhật nhà cung cấp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            ucSup.ReloadGridView();
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
