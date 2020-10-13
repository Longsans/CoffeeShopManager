using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class frmLogin : Form
    {
        BUS_UserInfo busUser = new BUS_UserInfo();
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public frmLogin()
        {
            InitializeComponent();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmRegister fRegis = new frmRegister(this);
            this.Hide();
            fRegis.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUsername.Text == "") MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            else
            {
                DTO_User dtoUser = new DTO_User() { Email = txtUsername.Text, PassWord = txtPassword.Text };
                if (busUser.CheckLogin(dtoUser))
                {
                    frmHome frmHome = new frmHome(this);
                    this.Hide();
                    frmHome.Show();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác");
                }
            }
        }
    }
}
