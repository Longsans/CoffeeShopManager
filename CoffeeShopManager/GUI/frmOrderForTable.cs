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
        BUS_Shop busShop = new BUS_Shop();
        int shopId;
        int tableId;
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        public frmOrderForTable()
        {
            InitializeComponent();
        }
        public frmOrderForTable(int num1, int num2, DTO_Employee dtoEmp)
        {
            InitializeComponent();
            tableId = num1;
            shopId = num2;
            ucOrderProduct.SetShopID(shopId);
            ucOrderProduct.dtoEmp = dtoEmp;
            ucOrderProduct.dtoShop = busShop.GetShopById(shopId);
            ucOrderProduct.SetTable(tableId);
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
        }
    }
}
