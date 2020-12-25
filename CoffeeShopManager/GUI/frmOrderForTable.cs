using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmOrderForTable : Form
    {
        BUS_Shop busShop = new BUS_Shop(ConnectionStringHelper.GetConnectionString());
        int shopId;
        int tableId;
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        UserControlTable ucTable { get; set; }
        Timer timer = new Timer();
        public frmOrderForTable()
        {
            InitializeComponent();
        }
        public frmOrderForTable(int num1, int num2, DTO_Employee dtoEmp, UserControlTable u)
        {
            InitializeComponent();
            tableId = num1;
            shopId = num2;
            ucTable = u;
            ucOrderProduct.SetShopID(shopId);
            ucOrderProduct.dtoEmp = dtoEmp;
            ucOrderProduct.dtoShop = busShop.GetShopById(shopId);
            ucOrderProduct.SetTable(tableId);
            ucOrderProduct.isOrderAtTable = true;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ucOrderProduct.closeFormOrderAtTable) Close();
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
        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            ucTable.LoadAllTables();
        }
    }
}
