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
    public partial class frmSmallAddStockItemToList : Form
    {
        public DTO_Product Product = new DTO_Product();
        public frmEditProduct frmEditPro { get; set; }
        BUS_Product busPro = new BUS_Product(ConnectionStringHelper.GetConnectionString());
        BUS_StockItems busStock = new BUS_StockItems(ConnectionStringHelper.GetConnectionString());
        Point prevPoint;
        bool dragging;

        public frmSmallAddStockItemToList()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
        }


        private void frmSmallAddStockItemToList_Load(object sender, EventArgs e)
        {
            txtSearch.GotFocus += TxtSearch_GotFocus;
            txtSearch.LostFocus += TxtSearch_LostFocus;
            ResetInput();
        }

        private void TxtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.ForeColor = Color.DimGray;
                if(lblAdd.Text == "Thêm")
                txtSearch.Text = "Tìm...";
                else txtSearch.Text = "Search...";
            }
        }
        private void TxtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.DimGray)
            {
                txtSearch.Clear();
                txtSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void lblAdd_MouseDown(object sender, MouseEventArgs e)
        {
            ((Label)sender).ForeColor = SystemColors.Highlight;
        }

        private void lblAdd_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.FromArgb(139, 89, 50);
        }


        private void lblAdd_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = SystemColors.ControlText;
        }

        private void lblAdd_MouseUp(object sender, MouseEventArgs e)
        {
            var itemForPro = new DTO_StockItemForProduct
            {
                Item = new DTO_StockItem
                {
                    Id = Convert.ToInt32(grdStock.SelectedRows[0].Cells[0].Value),
                    Shop = this.Product.Shop
                },
                Product = this.Product,
                Shop = this.Product.Shop
            };

            if (busPro.GetItemForProduct(itemForPro.Item.Id, itemForPro.Product.Id, itemForPro.Shop.ID) != null)
            {
                if (lblAdd.Text == "Add")
                {
                    MessageBox.Show("This item has already been added to list.", "Item already added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Hàng hóa này đã được thêm từ trước.", "Hàng hóa đã có sẵn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                busPro.AddItemForProduct(itemForPro);
                ResetInput();
                frmEditPro.ReloadGridView();
                if (lblAdd.Text == "Thêm")
                    MessageBox.Show("Hàng hóa mới đã được thêm vào danh sách", "Thêm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("New item added to list.", "Add successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetInput()
        {
            txtSearch.ForeColor = Color.DimGray;
            if (lblAdd.Text == "Thêm")
                txtSearch.Text = "Tìm...";
            else txtSearch.Text = "Search...";
            cboSearch.SelectedIndex = 0;
            ReloadGridView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            prevPoint = Cursor.Position;
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ReloadGridView();
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point(this.Location.X + Cursor.Position.X - prevPoint.X, this.Location.Y + Cursor.Position.Y - prevPoint.Y);
                prevPoint = Cursor.Position;
            }
        }

        public void ReloadGridView()
        {
            if (txtSearch.ForeColor != Color.DimGray)
            {
                switch (cboSearch.SelectedIndex)
                {
                    case 0:
                        if (string.IsNullOrWhiteSpace(txtSearch.Text))
                        {
                            grdStock.DataSource = busStock.GetAllStockItems(Product.Shop.ID);
                        }
                        else if (int.TryParse(txtSearch.Text, out int id))
                        {
                            grdStock.DataSource = busStock.GetDataTableById(id, Product.Shop.ID);
                        }
                        else
                        {
                            grdStock.DataSource = busStock.GetDataTableById(-1, Product.Shop.ID);
                        }
                        break;
                    case 1:
                        grdStock.DataSource = busStock.GetDataTableByName(txtSearch.Text, Product.Shop.ID);
                        break;
                }
            }
            else
            {
                grdStock.DataSource = busStock.GetAllStockItems(Product.Shop.ID);
            }

            if (lblAdd.Text == "Thêm")
            {
                grdStock.Columns[1].HeaderText = "Tên hàng";
                grdStock.Columns[2].HeaderText = "ID nhà cung cấp";
            }
        }

        private void grdStock_SelectionChanged(object sender, EventArgs e)
        {
            if (grdStock.SelectedRows.Count > 0)
            {
                lblAdd.Enabled = true;
            }
            else
            {
                lblAdd.Enabled = false;
            }
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadGridView();
            if (grdStock.SelectedRows.Count > 0)
            {
                lblAdd.Enabled = true;
            }
            else
            {
                lblAdd.Enabled = false;
            }
        }
    }
}
