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
using BUS;

namespace GUI
{
    public partial class frmEmployee : Form
    {
        frmLogin _frmLogin = new frmLogin();
        static public DTO_Employee dtoEmp = new DTO_Employee();
        public DTO_Shop dtoShop = new DTO_Shop();
        BUS_Employee busEmp = new BUS_Employee();
        BUS_Manager busMan = new BUS_Manager();
        BUS_Shop busShop = new BUS_Shop();
        private bool dragging = false;
        Point startPoint = new Point(0, 0);
        public frmEmployee()
        {
            InitializeComponent();
        }
        public frmEmployee(frmLogin fLogin)
        {
            _frmLogin = fLogin;
            InitializeComponent();
        }

        private void btnReceipts_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnReceipts.Location;
            userControlOrderProduct2.BringToFront();
            userControlOrderProduct2.Show();
            userControlOrderProduct2.ReloadTable();
        }
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.ImageIndex = 3;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.ImageIndex = 1;
            }


        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 267)
            {
                pnlMenu.Width = 64;
            }
            else
            {
                pnlMenu.Width = 267;
            }
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnTables.Location;
            ucTable.BringToFront();
            ucTable.Show();
            ucTable.LoadAllTables();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnUser.Location;
            ucUserInfo.BringToFront();
            ucUserInfo.Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnManager.Location;
            ucManagerInfo.BringToFront();
            ucManagerInfo.Show();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
           
            dtoEmp = busEmp.GetEmployeeInfoByUsername(_frmLogin.GetUsername());
            dtoEmp.Account = busEmp.GetUserInfoByUsername(_frmLogin.GetUsername());
            dtoShop = dtoEmp.Shop;
            lblWelcome.Text = "Welcome, " + dtoEmp.Firstname;
            ucTable.SetShopID(dtoShop.ID);
            ucManagerInfo.SetManager(busMan.GetById(dtoEmp.Manager.Id, dtoShop.ID));
            ucManagerInfo.SetShop(busShop.GetShopById(dtoShop.ID));
            ucUserInfo.SetUser(dtoEmp);
            userControlOrderProduct2.dtoEmp = frmEmployee.dtoEmp;
            userControlOrderProduct2.SetShopID(dtoShop.ID);
            userControlOrderProduct2.dtoShop = busShop.GetShopById(dtoEmp.Shop.ID);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmLogin.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resultIndex = -1;
            resultIndex = comboBox1.FindStringExact(comboBox1.Text);
            if (comboBox1.Text == "English")
            {
                var changeLanguage = new ChangeLanguage();
                changeLanguage.UpdateConfig("language", "eng");
                Application.Restart();
            }
            else if (comboBox1.Text == "Vietnamese")
            {
                var changeLanguage = new ChangeLanguage();
                changeLanguage.UpdateConfig("language", "vi-VN");
                Application.Restart();
            }
        }
    }
}
