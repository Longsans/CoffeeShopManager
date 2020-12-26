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
        DTO_Employee dtoEmp = new DTO_Employee();
        DTO_Table table = new DTO_Table();
        BUS_Tables bus_table = new BUS_Tables(ConnectionStringHelper.GetConnectionString());
        UserControlTable ucTable { get; set; }
        UserControlTableOfManager ucTableManager { get; set; }
        public Table()
        {
            InitializeComponent();
        }
        public Table(DTO_Table _table, UserControlTable _ucTable)
        {
            InitializeComponent();
            table = _table;
            ucTable = _ucTable;
            dtoEmp = ucTable.GetEmployee();
            this.ContextMenuStrip = contextMenuStrip1;
            Reload();
        }
        public Table(DTO_Table _table, UserControlTableOfManager _ucTable)
        {
            InitializeComponent();
            table = _table;
            ucTableManager = _ucTable;
            this.ContextMenuStrip = contextMenuStrip2;
            if (table.Status == "Unavailable")
            {
                setStatusToolStripMenuItem.Enabled = true;
                setRepairingToolStripMenuItem.Enabled = false;
                removeTableToolStripMenuItem.Enabled = true;
            }
            else if (table.Status == "Occupied")
            {
                setStatusToolStripMenuItem.Enabled = false;
                setRepairingToolStripMenuItem.Enabled = false;
                removeTableToolStripMenuItem.Enabled = false;
            }
            else
            {
                setStatusToolStripMenuItem.Enabled = false;
                setRepairingToolStripMenuItem.Enabled = true;
                removeTableToolStripMenuItem.Enabled = true;
            }
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
            if (status == "Available") orderToolStripMenuItem.Enabled = true;
            else orderToolStripMenuItem.Enabled = false;
        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmShowDetailTable frmShowDetail = new frmShowDetailTable(table, ucTable);
                frmShowDetail.ShowDialog();
            }
            catch
            {
                MessageBox.Show("An error occurred, tab will reload now.", "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucTable.ReloadTable();
            }
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmOrderForTable frmOrder = new frmOrderForTable(table.Id, ucTable.GetShopID(), dtoEmp, ucTable);
                frmOrder.ShowDialog();
            }
            catch
            {
                MessageBox.Show("An error occurred, tab will reload now.", "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucTable.ReloadTable();
            }
        }

        private void setRepairingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                table.Status = "Unavailable";
                if (bus_table.GetTableById(table.Id, table.Shop.ID) == null)
                {
                    throw new Exception();
                }
                bus_table.Update(table);
            }
            catch
            {
                MessageBox.Show("An error occurred, tab will reload now.", "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ucTableManager.LoadAllTables();
        }

        private void setStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                table.Status = "Available";
                if (bus_table.GetTableById(table.Id, table.Shop.ID) == null)
                {
                    throw new Exception();
                }
                bus_table.Update(table);
            }
            catch
            {
                MessageBox.Show("An error occurred, tab will reload now.", "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ucTableManager.LoadAllTables();
        }

        private void removeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bus_table.Delete(table);
            }
            catch
            {
                MessageBox.Show("An error occurred, tab will reload now.", "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ucTableManager.LoadAllTables();
        }
    }
}
