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
        ErrorProvider err = new ErrorProvider();
        Icon checkIcon,
            errorIcon;
        Point prevPoint;
        bool dragging;

        public frmSmallAddProductToList()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
        }

        private void frmSmallAddProductToList_Load(object sender, EventArgs e)
        {
            checkIcon = new Icon(GUI.Properties.Resources.check1, err.Icon.Size);
            errorIcon = new Icon(GUI.Properties.Resources.cancel, err.Icon.Size);
            err.SetIconPadding(txtProId, 5);
            txtProId.GotFocus += TxtProId_GotFocus;
            txtProId.LostFocus += TxtProId_LostFocus;
        }

        private void TxtProId_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProId.Text))
            {
                txtProId.ForeColor = Color.DimGray;
                txtProId.Text = "Enter product ID";
            }
        }

        private void TxtProId_GotFocus(object sender, EventArgs e)
        {
            if (txtProId.ForeColor == Color.DimGray)
            {
                txtProId.Clear();
                txtProId.ForeColor = SystemColors.WindowText;
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
                Item = this.Item,
                Product = new DTO_Product
                {
                    Id = int.Parse(txtProId.Text),
                    Shop = this.Item.Shop
                },
                Shop = this.Item.Shop
            };
            busStock.AddItemForProduct(itemForPro);
            ResetInput();
            frmEditStock.ReloadGridView();
            MessageBox.Show("New product added to list.", "Add successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetInput()
        {
            txtProId.ForeColor = Color.DimGray;
            txtProId.Text = "Enter product ID";
            err.Icon = errorIcon;
            err.SetError(txtProId, "");
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

        private void txtProId_TextChanged(object sender, EventArgs e)
        {
            if (txtProId.TextLength > 0)
            {
                if (int.TryParse(txtProId.Text, out int id) && busPro.GetByIdNotDeleted(id, Item.Shop.ID) != null)
                {
                    if (busPro.GetItemForProduct(Item.Id, id, Item.Shop.ID) != null)
                    {
                        err.Icon = errorIcon;
                        err.SetError(txtProId, "A product with such ID has already been added to the list");
                        lblAdd.Enabled = false;
                    }
                    else
                    {
                        err.Icon = checkIcon;
                        err.SetError(txtProId, "Valid");
                        lblAdd.Enabled = true;
                    }
                }
                else
                {
                    err.Icon = errorIcon;
                    err.SetError(txtProId, "A product with such ID does not exist");
                    lblAdd.Enabled = false;
                }
            }
            else
            {
                err.Icon = errorIcon;
                err.SetError(txtProId, "Please fill all info fields");
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
