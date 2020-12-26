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
    public partial class frmEditStockItem : Form
    {
        public UserControlStock ucStock { get; set; }
        public DTO_StockItem Item = new DTO_StockItem();
        BUS_StockItems busStock = new BUS_StockItems(ConnectionStringHelper.GetConnectionString());
        BUS_Suppliers busSup = new BUS_Suppliers(ConnectionStringHelper.GetConnectionString());
        ErrorProvider err = new ErrorProvider(),
            errtwo = new ErrorProvider();
        Timer tiktoker = new Timer();
        Icon checkIcon,
            errorIcon;
        Point prevPoint;
        bool dragging;

        public frmEditStockItem()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditStockItem_Load(object sender, EventArgs e)
        {
            checkIcon = new Icon(GUI.Properties.Resources.check1, err.Icon.Size);
            errorIcon = new Icon(GUI.Properties.Resources.cancel, errtwo.Icon.Size);
            err.Icon = checkIcon;
            errtwo.Icon = checkIcon;
            err.SetIconPadding(txtItemName, 5);
            errtwo.SetIconPadding(txtSupId, 5);
            txtId.Text = Item.Id.ToString();
            txtItemName.Text = Item.Name;
            txtSupId.Text = Item.Supplier.Id;
            lblListCaption.Text += $"{Item.Name}:";
            tiktoker.Interval = 200;
            tiktoker.Tick += Tiktoker_Tick;
            ReloadGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Item = new DTO_StockItem
            {
                Id = int.Parse(txtId.Text),
                Name = txtItemName.Text,
                Supplier = new DTO_Supplier
                {
                    Id = txtSupId.Text
                },
                Shop = Item.Shop
            };
            busStock.Update(Item);
            this.Close();
            ucStock.ReloadGridView();
            MessageBox.Show("Stock item updated.", "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtItemName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                var stockItem = busStock.GetByName(txtItemName.Text, Item.Shop.ID);
                if (stockItem == null || stockItem.Id == this.Item.Id)
                {
                    err.Icon = checkIcon;
                    err.SetError(txtItemName, "Valid");
                }
                else
                {
                    err.Icon = errorIcon;
                    err.SetError(txtItemName, "A stock item with such name already exists");
                }
            }
            else
            {
                err.Icon = errorIcon;
                err.SetError(txtItemName, "Please fill all info fields");
            }
            tiktoker.Start();
        }

        private void txtSupId_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSupId.Text))
            {
                if (busSup.GetById(txtSupId.Text, Item.Shop.ID) != null)
                {
                    errtwo.Icon = checkIcon;
                    errtwo.SetError(txtSupId, "Valid");
                }
                else
                {
                    errtwo.Icon = errorIcon;
                    errtwo.SetError(txtSupId, "A supplier with such ID does not exist");
                }
            }
            else
            {
                errtwo.Icon = errorIcon;
                errtwo.SetError(txtSupId, "Please fill all info fields");
            }
            tiktoker.Start();
        }

        private void lblRemoveFromList_MouseDown(object sender, MouseEventArgs e)
        {
            ((Label)sender).ForeColor = SystemColors.Highlight;
        }

        private void lblAddToList_MouseUp(object sender, MouseEventArgs e)
        {
            lblAddToList.ForeColor = SystemColors.ControlText;
            frmSmallAddProductToList frmSmallAdd = new frmSmallAddProductToList
            {
                Item = this.Item,
                frmEditStock = this
            };
            frmSmallAdd.Location = new Point(this.Location.X + this.Width / 2 - frmSmallAdd.Width / 2,
                this.Location.Y + this.Height / 2 - frmSmallAdd.Height / 2);
            frmSmallAdd.ShowDialog();
        }

        private void lblRemoveFromList_MouseUp(object sender, MouseEventArgs e)
        {
            lblRemoveFromList.ForeColor = SystemColors.ControlText;
            if (grdProds.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Remove these products from the list?", "Remove products"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in grdProds.SelectedRows)
                    {
                        var itemForPro = new DTO_StockItemForProduct
                        {
                            Item = this.Item,
                            Product = new DTO_Product
                            {
                                Id = (int)row.Cells["Product ID"].Value,
                                Shop = this.Item.Shop
                            },
                            Shop = this.Item.Shop
                        };
                        busStock.RemoveItemForProduct(itemForPro);
                    }
                    ReloadGridView();
                }
            }
        }

        private void Tiktoker_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text) || string.IsNullOrWhiteSpace(txtSupId.Text) ||
                err.Icon != checkIcon || errtwo.Icon != checkIcon)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        public void ReloadGridView()
        {
            grdProds.DataSource = busStock.GetDataTableProductsUsingItem(Item.Id, Item.Shop.ID);
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

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point(this.Location.X + Cursor.Position.X - prevPoint.X, this.Location.Y + Cursor.Position.Y - prevPoint.Y);
                prevPoint = Cursor.Position;
            }
        }
    }
}
