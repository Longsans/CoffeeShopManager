﻿using System;
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
namespace GUI
{

    public partial class frmManager : Form
    {
        BUS_Manager busMan = new BUS_Manager();
        public static DTO_Manager dtoMan = new DTO_Manager();
        private bool dragging = false;
        Point startPoint = new Point(0, 0);
        frmLogin _frmLogin = new frmLogin();
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
            lblWelcome.Text = "Welcome, " + dtoMan.Firstname;
            ucHome.dtoMan = dtoMan;
        }
        public void Reload()
        {
            lblWelcome.Text = "Welcome, " + dtoMan.Lastname;
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
            ucStockTab.Show();
            ucStockTab.BringToFront();
            Reload();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnSupplier.Location;
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

        private void btnNoti_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnNoti.Location;
            ucNotifications.Show();
            ucNotifications.BringToFront();
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
            ucHome.SetButton(btnEmployee);
            ucHome.SetPanel(pnlChangeTab);
        }
    }
}
