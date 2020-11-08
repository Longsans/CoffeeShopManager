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
    public partial class UserControlReceiptsDetail : UserControl
    {
        //UserControlReceipts _ucReceipts = new UserControlReceipts();
        public string id = "";
        public UserControlReceiptsDetail()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            //_ucReceipts.Show();
            this.Hide();
        }

        public void Reload()
        {

        }
    }
}
