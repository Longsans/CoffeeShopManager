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
    public partial class frmEditEmployees : Form
    {
        UserControlEmployeesTab _ucEmp = new UserControlEmployeesTab();
        public frmEditEmployees()
        {
            InitializeComponent();
        }
        public frmEditEmployees(UserControlEmployeesTab ucEmp)
        {
            _ucEmp = ucEmp;
            InitializeComponent();
        }
    }
}
