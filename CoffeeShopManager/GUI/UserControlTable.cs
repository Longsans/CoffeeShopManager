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
        DTO_Employee dtoEmp = new DTO_Employee();
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
            if (cboBy.Text == "ID Table")
            {
                listTable = new List<DTO_Table>();
                if(table.GetTableById(int.Parse(txtSearch.Text), shopID) != null)
                    listTable.Add(table.GetTableById(int.Parse(txtSearch.Text), shopID));
                ReloadTable();
            }
            else if(cboBy.Text == "ID Customer")
            {
                listTable = new List<DTO_Table>();
                List<DTO_Table> list = new List<DTO_Table>();
                list = table.GetTablesByShopId(shopID);
                DTO_Receipt dtoReceipt = new DTO_Receipt();
                for (int i = 0; i < list.Count; i++)
                {
                    dtoReceipt = table.GetCurrentReceiptOfTable(list[i].Id, shopID);
                    if ((dtoReceipt != null) && dtoReceipt.Customer.Id == int.Parse(txtSearch.Text))
                    {
                        MessageBox.Show(dtoReceipt.Customer.Id.ToString());
                        listTable.Add(list[i]);
                    }
                }               
                ReloadTable();
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
        public void SetEmployee(DTO_Employee emp)
        {
            dtoEmp = emp;
        }
        public DTO_Employee GetEmployee()
        {
            return dtoEmp;
        }
    }
}
