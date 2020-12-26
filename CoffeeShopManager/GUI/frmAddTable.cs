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
    public partial class frmAddTable : Form
    {
        Point prevPoint;
        bool dragging;
        Icon checkIcon,
            errorIcon;
        ErrorProvider err = new ErrorProvider();
        BUS_Tables busTable = new BUS_Tables(ConnectionStringHelper.GetConnectionString());
        BUS_Shop busShop = new BUS_Shop(ConnectionStringHelper.GetConnectionString());
        UserControlTableOfManager ucTableManager { get; set; }
        int shopId;
        public frmAddTable(int num, UserControlTableOfManager _ucTableManager)
        {
            InitializeComponent();
            shopId = num;
            ucTableManager = _ucTableManager;
        }

        private void frmAddTable_Load(object sender, EventArgs e)
        {
            checkIcon = new Icon(GUI.Properties.Resources.check1, err.Icon.Size);
            errorIcon = new Icon(GUI.Properties.Resources.cancel, err.Icon.Size);
            txtTableId.GotFocus += TxtTableId_GotFocus;
            txtTableId.LostFocus += TxtTableId_LostFocus;
        }

       

        private void TxtTableId_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTableId.Text))
            {
                txtTableId.ForeColor = Color.DimGray;
                txtTableId.Text = "Enter table ID";
            }
        }


        private void TxtTableId_GotFocus(object sender, EventArgs e)
        {
            if (txtTableId.ForeColor == Color.DimGray)
            {
                txtTableId.Clear();
                txtTableId.ForeColor = SystemColors.WindowText;
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
            DTO_Table table = new DTO_Table();
            table.Id = int.Parse(txtTableId.Text);
            table.Status = "Available";
            table.Shop = busShop.GetShopById(shopId);
            busTable.Insert(table);
            err.SetError(txtTableId, "");
            ResetInput();
            ucTableManager.LoadAllTables();
            MessageBox.Show("New table added to list.", "Add successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetInput()
        {
            txtTableId.ForeColor = Color.DimGray;
            txtTableId.Text = "Enter table ID";
            err.Icon = errorIcon;
            err.SetError(txtTableId, "");
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

        private void txtTableId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTableId.TextLength > 0)
                {
                    if (int.TryParse(txtTableId.Text, out int id))
                    {
                        if (busTable.GetTableById(id, shopId) == null)
                        {
                            err.Icon = checkIcon;
                            err.SetError(txtTableId, "Valid");
                            lblAdd.Enabled = true;
                        }
                        else
                        {
                            throw new Exception("A table with such ID has already been added to the list");
                        }
                    }
                    else
                    {
                        throw new Exception("A table ID must be a natural number");
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
                err.SetError(txtTableId, ex.Message);
                lblAdd.Enabled = false;
            }
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {

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
