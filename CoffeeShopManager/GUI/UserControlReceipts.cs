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

    public partial class UserControlReceipts : UserControl
    {
        public string SelectedIdReceipts = "";
        UserControlReceiptsDetail _ucReceiptsDetail = new UserControlReceiptsDetail();
        public UserControlReceipts()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControlReceiptsDetail ucReceiptDetail = new UserControlReceiptsDetail();
            ucReceiptDetail.Show();
            //ucReceiptDetail.BringToFront();
            this.Hide();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    dataGridView1.Focus();
                    SelectedIdReceipts = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                catch (Exception)
                {

                }
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        public void SetReceiptDetail(UserControlReceiptsDetail ucReceiptsDetail)
        {
           
        }
    }
}
