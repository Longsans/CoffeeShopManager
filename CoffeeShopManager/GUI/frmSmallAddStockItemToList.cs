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
        ErrorProvider err = new ErrorProvider();
        Icon checkIcon,
            errorIcon;
        Point prevPoint;
        bool dragging;

        public frmSmallAddStockItemToList()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
        }


        private void frmSmallAddStockItemToList_Load(object sender, EventArgs e)
        {
            checkIcon = new Icon(GUI.Properties.Resources.check1, err.Icon.Size);
            errorIcon = new Icon(GUI.Properties.Resources.cancel, err.Icon.Size);
            err.SetIconPadding(txtItemId, 5);
            txtItemId.GotFocus += TxtItemId_GotFocus;
            txtItemId.LostFocus += TxtItemId_LostFocus;
        }

        private void TxtItemId_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemId.Text))
            {
                txtItemId.ForeColor = Color.DimGray;
                txtItemId.Text = "Enter product ID";
            }
        }
        private void TxtItemId_GotFocus(object sender, EventArgs e)
        {
            if (txtItemId.ForeColor == Color.DimGray)
            {
                txtItemId.Clear();
                txtItemId.ForeColor = SystemColors.WindowText;
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
                    Id = int.Parse(txtItemId.Text),
                    Shop = this.Product.Shop
                },
                Product = this.Product,
                Shop = this.Product.Shop
            };
            busPro.AddItemForProduct(itemForPro);
            ResetInput();
            frmEditPro.ReloadGridView();
            MessageBox.Show("New item added to list.", "Add successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetInput()
        {
            txtItemId.ForeColor = Color.DimGray;
            txtItemId.Text = "Enter product ID";
            err.Icon = errorIcon;
            err.SetError(txtItemId, "");
            lblAdd.Enabled = false;
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

        private void txtItemId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtItemId.TextLength > 0 && txtItemId.ForeColor != Color.DimGray)
                {
                    if (int.TryParse(txtItemId.Text, out int id))
                    {
                        if (busStock.GetById(id, Product.Shop.ID) != null)
                        {
                            if (busStock.GetItemForProduct(id, Product.Id, Product.Shop.ID) == null)
                            {
                                err.Icon = checkIcon;
                                err.SetError(txtItemId, "Valid");
                                lblAdd.Enabled = true;
                            }
                            else
                            {
                                throw new Exception("A stock item with such ID has already been added to the list");
                            }
                        }
                        else
                        {
                            throw new Exception("A stock item with such ID does not exist");
                        }
                    }
                    else
                    {
                        throw new Exception("Stock item ID must be a natural number");
                    }
                }
                else
                {
                    throw new Exception("Please fill all info fields");
                }
            }
            catch (Exception ex)
            {
                err.Icon = errorIcon;
                err.SetError(txtItemId, ex.Message);
                lblAdd.Enabled = false;
            }
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
