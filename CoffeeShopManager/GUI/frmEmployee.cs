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
using System.Threading;
using System.Configuration;

namespace GUI
{
    public partial class frmEmployee : Form
    {
        frmLogin _frmLogin = new frmLogin();
        static public DTO_Employee dtoEmp = new DTO_Employee();
        public DTO_Shop dtoShop = new DTO_Shop();
        BUS_Employee busEmp = new BUS_Employee(ConnectionStringHelper.GetConnectionString());
        BUS_Manager busMan = new BUS_Manager(ConnectionStringHelper.GetConnectionString());
        BUS_Shop busShop = new BUS_Shop(ConnectionStringHelper.GetConnectionString());
        private bool dragging = false;
        Point startPoint = new Point(0, 0);
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
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
            userControlOrderProduct2.dtoEmp = frmEmployee.dtoEmp;
            userControlOrderProduct2.SetShopID(dtoShop.ID);
            userControlOrderProduct2.dtoShop = busShop.GetShopById(dtoEmp.Shop.ID);
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
            ucTable.SetEmployee(dtoEmp);
            ucTable.SetShopID(dtoShop.ID);
            ucTable.BringToFront();
            ucTable.Show();
            ucTable.LoadAllTables();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnUser.Location;
            ucUserInfo.SetUser(dtoEmp);
            ucUserInfo.BringToFront();
            ucUserInfo.Reload();
            ucUserInfo.Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnManager.Location;
            ucManagerInfo.SetShop(busShop.GetShopById(dtoEmp.Shop.ID));
            ucManagerInfo.SetManager(busMan.GetById(dtoEmp.Manager.Id, dtoShop.ID));
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
            ucTable.SetEmployee(dtoEmp);
            t1.Interval = 1000;
            t1.Start();
            t1.Tick += Timer_Click;
        }
        public void Timer_Click(object sender, EventArgs e)
        {
            if (busEmp.GetInfoByIdNotDeleted(dtoEmp.Id, dtoShop.ID) == null)
            {
                t1.Stop();
                if(btnLogout.Text=="Log out")
                MessageBox.Show("Yêu cầu đăng nhập lại", "Đăng nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("You have been logged out. Please log in again","Log in again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        public void ResetDCM()
        {
            dtoShop = dtoEmp.Shop;
            lblWelcome.Text = "Welcome, " + dtoEmp.Firstname;
            ucTable.SetShopID(dtoShop.ID);
            ucManagerInfo.SetManager(busMan.GetById(dtoEmp.Manager.Id, dtoShop.ID));
            ucManagerInfo.SetShop(busShop.GetShopById(dtoShop.ID));
            ucUserInfo.SetUser(dtoEmp);
            userControlOrderProduct2.dtoEmp = frmEmployee.dtoEmp;
            userControlOrderProduct2.SetShopID(dtoShop.ID);
            userControlOrderProduct2.dtoShop = busShop.GetShopById(dtoEmp.Shop.ID);
            ucTable.SetEmployee(dtoEmp);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            t1.Dispose();
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
                var language = ConfigurationManager.AppSettings["language"];
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
                this.Controls.Clear();
                this.InitializeComponent();
                ResetDCM();
                
            }
            else if (comboBox1.Text == "Vietnamese")
            {
                var changeLanguage = new ChangeLanguage();
                changeLanguage.UpdateConfig("language", "vi-VN");
                var language = ConfigurationManager.AppSettings["language"];
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
                this.Controls.Clear();
                this.InitializeComponent();
                ResetDCM();
            }
        }
    }
}
