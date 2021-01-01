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
    public partial class UserControlTableOfManager : UserControl
    {
        public UserControlTableOfManager()
        {
            InitializeComponent();
        }
        List<DTO_Table> listTable = new List<DTO_Table>();
        BUS_Tables table = new BUS_Tables(ConnectionStringHelper.GetConnectionString());
        int shopID;

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
                Table ucTable = new Table(listTable[i], this);
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
        public void LoadAllTables()
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
            if (int.TryParse(txtSearch.Text, out int id))
            {
                if (cboBy.SelectedIndex == 1)
                {
                    listTable = new List<DTO_Table>();
                    var tab = table.GetTableByIdNotDeleted(id, shopID);
                    if (tab != null)
                    {
                        listTable.Add(tab);
                    }
                    ReloadTable();
                }
                else if (cboBy.SelectedIndex == 0)
                {
                    listTable = new List<DTO_Table>();
                    List<DTO_Table> list = new List<DTO_Table>();
                    list = table.GetTablesByShopId(shopID);
                    DTO_Receipt dtoReceipt = new DTO_Receipt();
                    for (int i = 0; i < list.Count; i++)
                    {
                        dtoReceipt = table.GetCurrentReceiptOfTable(list[i].Id, shopID);
                        if ((dtoReceipt != null) && dtoReceipt.Customer.Id == id)
                        {
                            listTable.Add(list[i]);
                        }
                    }
                    ReloadTable();
                }
            }
        }

        public void SetShopID(int id)
        {
            shopID = id;
            LoadAllTables();
        }
        public int GetShopID()
        {
            return shopID;
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            frmAddTable frmAddTable = new frmAddTable(shopID, this);
            frmAddTable.ShowDialog();
        }

        private void UserControlTableOfManager_Load(object sender, EventArgs e)
        {
            btnExpand.Hide();
            LoadAllTables();
        }
    }
}
