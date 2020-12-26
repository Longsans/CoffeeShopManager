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
    public partial class frmShowDetailTable : Form
    {
        public UserControlTable ucTable { get; set; }
        DTO_Table table = new DTO_Table();
        BUS_Tables busTable = new BUS_Tables(ConnectionStringHelper.GetConnectionString());
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public frmShowDetailTable()
        {
            InitializeComponent();
        }
        public frmShowDetailTable(DTO_Table _table, UserControlTable _ucTable)
        {
            InitializeComponent();
            ucTable = _ucTable;
            table = _table;
            if (table.Status == "Occupied")
            {
                btnCheckOut.Enabled = true;
                btnCheckOut.BackgroundImage = global::GUI.Properties.Resources.ok_48px;
            }
            else
            {
                btnCheckOut.Enabled = false;
                btnCheckOut.BackgroundImage = global::GUI.Properties.Resources.checked_80px;
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmShowDetailTable_Load(object sender, EventArgs e)
        {
            txtTableID.Text = table.Id.ToString();
            if (busTable.GetCurrentReceiptOfTable(table.Id, table.Shop.ID) != null)
                txtCurrentReceipt.Text = busTable.GetCurrentReceiptOfTable(table.Id, table.Shop.ID).Id.ToString();
            else txtCurrentReceipt.Text = "None";
            txtStatus.Text = table.Status.ToString();
            if (label1.Text == "Trạng thái")
            {
                if (txtStatus.Text == "Occupied") txtStatus.Text = "Đã đặt";
                else if (txtStatus.Text == "Available") txtStatus.Text = "Còn trống";
                else txtStatus.Text = "Đang sửa";
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            if (label1.Text == "Trạng thái")
            ret = MessageBox.Show("Bạn có muốn trả bàn này?", "Trả bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            else ret = MessageBox.Show("Do you want to clear this table ?", "Clear table", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            table.Status = "Available";
            if (ret == DialogResult.Yes) busTable.Update(table);
            btnCheckOut.BackgroundImage = global::GUI.Properties.Resources.checked_80px;
            btnCheckOut.Enabled = false;
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frmShowDetailTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            ucTable.LoadAllTables();
        }

    }
}
