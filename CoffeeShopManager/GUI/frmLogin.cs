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
        BUS_Employee busEmp = new BUS_Employee();
        BUS_Manager busMan = new BUS_Manager();
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
        public string GetUsername()
        {
            return txtUsername.Text;
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
            txtUsername.Select();
            if (lblPassword.Text == "Password")
            {
                btnEng.Enabled = false;
                btnVie.Enabled = true;
            }
            else
            {
                btnEng.Enabled = true;
                btnVie.Enabled = false;
            }
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
                DTO_User dtoUser = new DTO_User() { Username = txtUsername.Text, PassWord = txtPassword.Text };
                if (busUser.CheckLogin(dtoUser))
                {
                    if (busMan.GetByUsername(txtUsername.Text).Position == "Manager")
                    {
                        frmManager frmManager = new frmManager(this);
                        this.Hide();
                        frmManager.Show();
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                    }
                    else
                    {
                        frmEmployee frmEmployee = new frmEmployee(this);
                        this.Hide();
                        frmEmployee.Show();
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác");
                }
            }
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtUsername.Select();
        }

        private void btnVie_Click(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "vi-VN");
            Application.Restart();
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "en");
            Application.Restart();
        }
    }
}
