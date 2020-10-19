using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UserControlHome : UserControl
    {
        UserControlEmployeesTab ucEmpTab = new UserControlEmployeesTab();
        Panel pnlChangeTab = new Panel();
        Button btnGetLocationToChangeTab = new Button(); 
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
        public void SetButton(Button btn)
        {
            btnGetLocationToChangeTab = btn;
        }

        private void picEmployees_Click(object sender, EventArgs e)
        {
            pnlChangeTab.Show();
            pnlChangeTab.Location = btnGetLocationToChangeTab.Location;
            ucEmpTab.Show();
            ucEmpTab.BringToFront();
        }
    }
}
