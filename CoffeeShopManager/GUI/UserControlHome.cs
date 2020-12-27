using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class UserControlHome : UserControl
    {
        UserControlEmployeesTab ucEmpTab = new UserControlEmployeesTab();
        Panel pnlChangeTab = new Panel();
        frmManager frm { get; set; }
        Button btnGetLocationToChangeTabEmp { get; set; }
        Button btnGetLocationToChangeTabCus { get; set; }
        Button btnGetLocationToChangeTabStat { get; set; }
        UserControlStatistics ucStatistics { get; set; }
        UserControlCustomers ucCustomer { get; set; }
        public DTO_Manager dtoMan{ get; set; }
        public UserControlHome()
        {
            InitializeComponent();
        }
        public void SetEmpTab(UserControlEmployeesTab ucEmpTab)
        {
            this.ucEmpTab = ucEmpTab;
        }
        public void SetPanel(Panel panel)
        {
            pnlChangeTab = panel;
        }
        public void SetButtonCus(Button btn)
        {
            btnGetLocationToChangeTabCus = btn;
        }
        public void SetButtonEmp(Button btn)
        {
            btnGetLocationToChangeTabEmp = btn;
        }
        public void SetButtonStat(Button btn)
        {
            btnGetLocationToChangeTabStat = btn;
        }
        public void SetStatisticsTab(UserControlStatistics uc)
        {
            ucStatistics = uc;
        }
        public void SetCusTab(UserControlCustomers uc)
        {
            ucCustomer = uc;
        }
        public void SetFrmMan(frmManager f)
        {
            frm = f;
        }

        private void picEmployees_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnGetLocationToChangeTabEmp.Location;
            ucEmpTab.dtoMan = dtoMan;
            ucEmpTab.Show();
            ucEmpTab.BringToFront();
        }

        private void picCustomer_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnGetLocationToChangeTabCus.Location;
            ucCustomer.dtoShop = dtoMan.Shop;
            ucCustomer.frmMan = frm ;
            ucCustomer.Show();
            ucCustomer.BringToFront();
        }

        private void picStatistics_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnGetLocationToChangeTabStat.Location;
            ucStatistics.SetShopID(dtoMan.Shop.ID);
            ucStatistics.Show();
            ucStatistics.BringToFront();
        }
    }
}
