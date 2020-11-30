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
    public partial class UserControlTable : UserControl
    {
        List<DTO_Table> listTable = new List<DTO_Table>();
        BUS_Tables table = new BUS_Tables();
        int shopID;
        public UserControlTable()
        {
            InitializeComponent();
        }

        private void UserControlTable_Load(object sender, EventArgs e)
        {
            btnExpand.Hide();
            LoadAllTables();
        }
        private void ReloadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < listTable.Count; i++)
            {
                Table ucTable = new Table(listTable[i]);
                flowLayoutPanel1.Controls.Add(ucTable);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadAllTables();
        }
        private void LoadAvailableTables()
        {
            listTable = table.GetAvailableTables(shopID);
            ReloadTable();
        }
        private void LoadAllTables()
        {
            listTable = table.GetTablesByShopId(shopID);
            ReloadTable();
        }
        private void LoadOccupiedTables()
        {
            listTable = table.GetOccupiedTables(shopID);
            ReloadTable();
        }
        private void LoadUnavailableTables()
        {
            listTable = table.GetUnavailableTables(shopID);
            ReloadTable();
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            LoadAvailableTables();
        }

        private void btnOccupied_Click(object sender, EventArgs e)
        {
            LoadOccupiedTables();
        }

        private void btnUnavailable_Click(object sender, EventArgs e)
        {
            LoadUnavailableTables();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            lblBy.Show();
            lblSearch.Show();
            cboBy.Show();
            txtSearch.Show();
            btnExpand.Hide();
            btnCollapse.Show();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            lblBy.Hide();
            lblSearch.Hide(); 
            cboBy.Hide(); ;
            txtSearch.Hide();
            btnExpand.Show();
            btnCollapse.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboBy.Text == "ID Table")
            {
                listTable = new List<DTO_Table>();
                if(table.GetTableById(int.Parse(txtSearch.Text), shopID) != null)
                    listTable.Add(table.GetTableById(int.Parse(txtSearch.Text), shopID));
                ReloadTable();
            }
            else if(cboBy.Text == "ID Customer")
            {

            }
        }
        public void SetShopID(int id)
        {
            shopID = id;
            LoadAllTables();
        }
    }
}
