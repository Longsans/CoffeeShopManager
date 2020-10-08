using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHome : Form
    {
        private bool dragging = false;
        Point startPoint = new Point(0, 0);
        frmLogin _frmLogin = new frmLogin();
        public frmHome()
        {
            InitializeComponent();
        }
        public frmHome(frmLogin frm)
        {
            _frmLogin = frm;
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
                pnlMenu.Width = 45;
                lblLogo.Hide();
                //btnMenu.Location = lblLogo.Location;
            }
            else
            {
                pnlMenu.Width = 221;
                lblLogo.Show();
            }
        }


        private void btnOrderhistory_Click(object sender, EventArgs e)
        {
            ucOrderHistorycs1.Show();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmLogin.Show();

        }
    }

}
