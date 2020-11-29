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
        BUS_Shop busShop = new BUS_Shop();
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
                MessageBox.Show("Vui lòng nhâp đầy đủ thông tin");
            }
            else
            {
                if (dtoShop.AuthCode != busShop.EncodeAuthCode(txtCurrentPassword.Text))
                {
                    errorProvider1.SetError(txtCurrentPassword, "Your password is incorrect");
                    return;
                }
                if (txtNewPassword.Text != txtRetypeNewPassword.Text)
                {
                    errorProvider1.SetError(txtRetypeNewPassword, "Mật khẩu không khớp");
                    return;
                }
                if (txtNewPassword.Text == txtCurrentPassword.Text)
                {
                    errorProvider1.SetError(txtNewPassword, "Mật khẩu mới trùng mật khẩu cũ");
                    return;
                }
                dtoShop.AuthCode = busShop.EncodeAuthCode(txtNewPassword.Text);
                busShop.Update(dtoShop);
                MessageBox.Show("You have changed password successfully ");
                Close();
            }
        }
    }
}
