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
namespace GUI
{

    public partial class frmHome : Form
    {
        BUS_Manager busMan = new BUS_Manager();
        public static DTO_Manager dtoMan = new DTO_Manager();
        private bool dragging = false;
        Point startPoint = new Point(0, 0);
        frmLogin _frmLogin = new frmLogin();
        public frmHome()
        {
            InitializeComponent();
            ucUserTab.Parent = this;
        }
        public frmHome(frmLogin frm)
        {
            _frmLogin = frm;
            InitializeComponent();
            ucUserTab.Parent = this;
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
            if (pnlMenu.Width == 221)
            {
                pnlMenu.Width = 64;
            }
            else
            {
                pnlMenu.Width = 221;
            }
        }


        private void btnOrderhistory_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnOrderhistory.Location;
            ucOrderHistorycs1.Show();
            ucOrderHistorycs1.BringToFront();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmLogin.Show();

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnEmployee.Location;
            ucEmployeeTab.Show();
            ucEmployeeTab.BringToFront();
            ucUserTab.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnProduct.Location;
            ucProductTab.Show();
            ucProductTab.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
            _frmLogin.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + dtoMan.Lastname;
            dtoMan = busMan.GetByEmail(_frmLogin.GetEmail());

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Hide();
            ucHome.Show();
            ucHome.BringToFront();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnStock.Location;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnSupplier.Location;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnCustomer.Location;
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnStatistic.Location;
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnEvent.Location;
        }

        private void btnNoti_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnNoti.Location;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnUser.Location;
            ucUserTab.SetUser(dtoMan);
            ucUserTab.Show();
            ucUserTab.BringToFront();
            
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            dtoMan = busMan.GetByEmail(_frmLogin.GetEmail());
        }
    }

}
