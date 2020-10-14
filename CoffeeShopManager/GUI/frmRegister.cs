using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    
    public partial class frmRegister : Form
    {
        BUS_UserInfo busUser = new BUS_UserInfo();
        frmLogin _frmLogin = new frmLogin();
        public frmRegister()
        {
            InitializeComponent();
        }
        public frmRegister(frmLogin frm)
        {
            _frmLogin = frm;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            _frmLogin.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //DTO_User dtoUser = new DTO_User() { Email = txtEmail.Text, PassWord = txtPass.Text };
            //busUser.Insert(dtoUser);
            
        }
    }
}
