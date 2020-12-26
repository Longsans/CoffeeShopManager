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
    public partial class frmChangeAuthCodeShop : Form
    {
        BUS_Shop busShop = new BUS_Shop(ConnectionStringHelper.GetConnectionString());
        public DTO_Shop dtoShop = new DTO_Shop();
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public frmChangeAuthCodeShop()
        {
            InitializeComponent();
        }
        public frmChangeAuthCodeShop(DTO_Shop shop)
        {
            InitializeComponent();
            dtoShop = shop; 
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
            errorProvider1.SetError(txtCurrentPassword, "");
            errorProvider1.SetError(txtNewPassword, "");
            errorProvider1.SetError(txtRetypeNewPassword, "");
            if (txtCurrentPassword.Text == "" || txtNewPassword.Text == "" || txtRetypeNewPassword.Text == "")
            {
                if (btnSaveChange.Text == "Lưu")
                    MessageBox.Show("Vui lòng nhâp đầy đủ thông tin.");
                else MessageBox.Show("Please fill into all fields.");
            }
            else
            {
                if (dtoShop.AuthCode != busShop.EncodeAuthCode(txtCurrentPassword.Text))
                {
                    if (btnSaveChange.Text == "Lưu")
                        errorProvider1.SetError(txtCurrentPassword, "Code không chính xác");
                    else errorProvider1.SetError(txtCurrentPassword, "Your code is incorrect");
                    return;
                }
                if (txtNewPassword.Text != txtRetypeNewPassword.Text)
                {
                    if (btnSaveChange.Text == "Lưu")
                        errorProvider1.SetError(txtRetypeNewPassword, "Code không khớp");
                    else errorProvider1.SetError(txtRetypeNewPassword, "Retyped new code does not match new code.");
                    return;
                }
                if (txtNewPassword.Text == txtCurrentPassword.Text)
                {
                    if (btnSaveChange.Text == "Lưu")
                        errorProvider1.SetError(txtNewPassword, "Code mới trùng code cũ.");
                    else errorProvider1.SetError(txtNewPassword, "New code is as same as current code.");
                    return;
                }
                dtoShop.AuthCode = busShop.EncodeAuthCode(txtNewPassword.Text);
                busShop.Update(dtoShop);
                if (btnSaveChange.Text == "Lưu")
                    MessageBox.Show("Bạn đã thay đổi code của shop thành công.");
                else MessageBox.Show("You have changed code successfully. ");
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
