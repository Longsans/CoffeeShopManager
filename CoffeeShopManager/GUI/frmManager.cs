using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DTO;
using BUS;
using System.Threading;

namespace GUI
{

    public partial class frmManager : Form
    {
        BUS_Manager busMan = new BUS_Manager(ConnectionStringHelper.GetConnectionString());
        public static DTO_Manager dtoMan = new DTO_Manager();
        private bool dragging = false;
        Point startPoint = new Point(0, 0);
        frmLogin _frmLogin = new frmLogin();
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public frmManager()
        {
            InitializeComponent();
        }
        public frmManager(frmLogin frm)
        {
            _frmLogin = frm;
            DoubleBuffered = true;
            InitializeComponent();
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
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
            if (pnlMenu.Width == btnEmployee.Width)
            {
                pnlMenu.Width = btnMenu.Width;
            }
            else
            {
                pnlMenu.Width = btnEmployee.Width;
            }
        }


        private void btnReceipts_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnReceipts.Location;
            ucReceipts.dtoShop = dtoMan.Shop;
            ucReceipts.ucRecDetails = ucReceiptDetails;
            ucReceipts.Show();
            ucReceipts.BringToFront();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmLogin.Show();

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnEmployee.Location;
            ucEmployeeTab.dtoMan = dtoMan;
            ucEmployeeTab.Show();
            ucEmployeeTab.BringToFront();
            Reload();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnProduct.Location;
            ucProductTab.dtoShop = dtoMan.Shop;
            ucProductTab.Show();
            ucProductTab.BringToFront();
            Reload();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
            _frmLogin.Show();
            Reload();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
            dtoMan = busMan.GetByUsername(_frmLogin.GetUsername());
            dtoMan.Account = busMan.GetUserInfoByUsername(_frmLogin.GetUsername());
            ucHome.dtoMan = dtoMan;
            ucShopInfoTab.SetManager(dtoMan);
            t.Enabled = true;
            t.Interval = 50;
            t.Tick += T_Tick;
            Reload();
            
            
        }

        private void T_Tick(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
        {
            BUS_Shop busShop = new BUS_Shop(ConnectionStringHelper.GetConnectionString());
            lblWelcome.Text = "Welcome, " + dtoMan.Firstname;
            DTO_Shop dtoShop = busShop.GetShopById(dtoMan.Shop.ID);
            if (string.IsNullOrEmpty(dtoShop.ShopAddress) || string.IsNullOrEmpty(dtoShop.Phone))
            {
                if (btnLogout.Text == "Đăng xuất")
                    err.SetError(btnShop, "Vui lòng nhập đầy đủ thông tin của shop để có thể sử dụng các chức năng khác");
                else err.SetError(btnShop, "Please provide full info of shop to use another feature!");
                btnEmployee.Enabled = false;
                btnProduct.Enabled = false;
            }
            else
            {
                err.SetError(btnShop, "");
                btnEmployee.Enabled = true;
                btnProduct.Enabled = true;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Hide();
            ucHome.Show();
            ucHome.BringToFront();
            Reload();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnStock.Location;
            ucStockTab.Shop = dtoMan.Shop;
            ucStockTab.frmMan = this;
            ucStockTab.Show();
            ucStockTab.BringToFront();
            Reload();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnSupplier.Location;
            ucSuppliersTab.Shop = dtoMan.Shop;
            ucSuppliersTab.UcStock = this.ucStockTab;
            ucSuppliersTab.frmMan = this;
            ucSuppliersTab.Show();
            ucSuppliersTab.BringToFront();
            Reload();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnCustomer.Location;
            ucCustomersTab.dtoShop = dtoMan.Shop;
            ucCustomersTab.frmMan = this;
            ucCustomersTab.Show();
            ucCustomersTab.BringToFront();
            Reload();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnStatistic.Location;
            ucStatisticsTab.Show();
            ucStatisticsTab.BringToFront();
            ucStatisticsTab.SetShopID(dtoMan.Shop.ID);
            Reload();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnEvent.Location;
            ucEventsTab.Show();
            ucEventsTab.BringToFront();
            Reload();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnUser.Location;
            ucUserTab.SetUser(dtoMan);
            ucUserTab.Show();
            ucUserTab.BringToFront();
            ucUserTab.Reload();
            Reload();
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            ucHome.SetEmpTab(ucEmployeeTab);
            ucHome.SetButtonEmp(btnEmployee);
            ucHome.SetPanel(pnlChangeTab);
            ucHome.SetCusTab(ucCustomersTab);
            ucHome.SetButtonCus(btnCustomer);
            ucHome.SetStatisticsTab(ucStatisticsTab);
            ucHome.SetButtonStat(btnStatistic);
            ucHome.SetFrmMan(this);
        }

        private void ucShopInfoTab_Load(object sender, EventArgs e)
        {
           
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnShop.Location;
            ucShopInfoTab.SetShop(dtoMan);
            ucShopInfoTab.Show();
            ucShopInfoTab.BringToFront();
            ucShopInfoTab.Reload();
            Reload();
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
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnTable.Location;
            ucTable.Show();
            ucTable.BringToFront();
            ucTable.SetShopID(dtoMan.Shop.ID);
            Reload();
        }
    }
}
