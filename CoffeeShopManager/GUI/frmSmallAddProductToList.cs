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
    public partial class frmSmallAddProductToList : Form
    {
        public DTO_StockItem Item = new DTO_StockItem();
        public frmEditStockItem frmEditStock { get; set; }
        BUS_StockItems busStock = new BUS_StockItems(ConnectionStringHelper.GetConnectionString());
        BUS_Product busPro = new BUS_Product(ConnectionStringHelper.GetConnectionString());
        Point prevPoint;
        bool dragging;

        public frmSmallAddProductToList()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
        }

        private void frmSmallAddProductToList_Load(object sender, EventArgs e)
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
                if (lblAdd.Text == "Add")
                txtSearch.Text = "Search...";
                else txtSearch.Text = "Tìm...";
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
                Item = Item,
                Product = new DTO_Product
                {
                    Id = Convert.ToInt32(grdProds.SelectedRows[0].Cells[0].Value)
                },
                Shop = Item.Shop
            };

            if (busStock.GetItemForProduct(itemForPro.Item.Id, itemForPro.Product.Id, itemForPro.Shop.ID) != null)
            {
                if (lblAdd.Text == "Add")
                {
                    MessageBox.Show("This product has already been added to list.", "Product already added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Sản phẩm này đã được thêm từ trước.", "Sản phẩm đã có sẵn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                busStock.AddItemForProduct(itemForPro);
                ResetInput();
                frmEditStock.ReloadGridView();
                if (lblAdd.Text == "Thêm")
                    MessageBox.Show("Sản phẩm mới đã được thêm vào danh sách", "Thêm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("New product added to list.", "Add successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReloadGridView()
        {
            if (txtSearch.ForeColor != Color.DimGray)
            {
                switch (cboSearch.SelectedIndex)
                {
                    case 0:
                        if (string.IsNullOrWhiteSpace(txtSearch.Text))
                        {
                            grdProds.DataSource = busPro.GetAllProductsWithoutImages(Item.Shop.ID);
                        }
                        else if (int.TryParse(txtSearch.Text, out int id))
                        {
                            grdProds.DataSource = busPro.GetProductsSearchIDFiltered(id, Item.Shop.ID);
                        }
                        else
                        {
                            grdProds.DataSource = busPro.GetProductsSearchIDFiltered(-1, Item.Shop.ID);
                        }
                        break;
                    case 1:
                        grdProds.DataSource = busPro.GetProductsSearchNameFiltered(txtSearch.Text, Item.Shop.ID);
                        break;
                }
            }
            else
            {
                grdProds.DataSource = busPro.GetAllProductsWithoutImages(Item.Shop.ID);
            }

            if (lblAdd.Text == "Thêm")
            {
                grdProds.Columns[1].HeaderText = "Tên sản phẩm";
                grdProds.Columns[2].HeaderText = "Loại";
                grdProds.Columns[3].HeaderText = "Giá bán";
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

        private void lblCancel_MouseUp(object sender, MouseEventArgs e)
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

        private void txtProId_TextChanged(object sender, EventArgs e)
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

        private void grdProds_SelectionChanged(object sender, EventArgs e)
        {
            if (grdProds.SelectedRows.Count > 0)
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
            if (grdProds.SelectedRows.Count > 0)
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
