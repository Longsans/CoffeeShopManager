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
using BUS;

namespace GUI
{
    public partial class Table : UserControl
    {
        string stt;
        DTO_Table table = new DTO_Table();
        public Table()
        {
            InitializeComponent();
        }
        public Table(DTO_Table _table)
        {
            InitializeComponent();
            table = _table;
            Reload();
        }
        private void Reload()
        {
            lblTable.Text = table.Id.ToString();
            string status = table.Status;
            lblStatus.Text = status;
            if (status == "Available")
                BackColor = Color.FromArgb(186, 243, 157);
            else if (status == "Occupied")
                BackColor = Color.FromArgb(248, 246, 158);
            else BackColor = Color.FromArgb(254, 238, 238);
        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDetailTable frmShowDetail = new frmShowDetailTable(table);
            frmShowDetail.ShowDialog();
        }

    }
}
