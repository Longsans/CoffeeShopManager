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
            errorIcon,
            warningIcon;
        ErrorProvider err = new ErrorProvider();
        BUS_Tables busTable = new BUS_Tables(ConnectionStringHelper.GetConnectionString());
        BUS_Shop busShop = new BUS_Shop(ConnectionStringHelper.GetConnectionString());
        UserControlTableOfManager ucTableManager { get; set; }
        int shopId;
        bool checkDeleted = true;

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
            warningIcon = new Icon(GUI.Properties.Resources.warning, err.Icon.Size);
            err.SetIconPadding(txtTableId, 3);
            txtTableId.GotFocus += TxtTableId_GotFocus;
            txtTableId.LostFocus += TxtTableId_LostFocus;
        }

       

        private void TxtTableId_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTableId.Text))
            {
                txtTableId.ForeColor = Color.DimGray;
                if (lblAdd.Text == "Thêm") txtTableId.Text = "Nhập ID bàn";
                else txtTableId.Text = "Enter table ID";
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
            DTO_Table table = new DTO_Table
            {
                Id = int.Parse(txtTableId.Text),
                Shop = busShop.GetShopById(shopId)
            };

            if (checkDeleted)
            {
                table.Status = "Available";
                busTable.Insert(table);
                err.SetError(txtTableId, "");
                ResetInput();
                ucTableManager.LoadAllTables();
                if (lblAdd.Text == "Thêm")
                    MessageBox.Show("Bàn mới đã được thêm vào danh sách", "Thêm thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("New table added to list.", "Add successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult ret;
                if (lblAdd.Text == "Thêm") ret = MessageBox.Show("Có dữ liệu liên quan đến bàn này. Bạn có muốn khôi phục nó?", "Không thể thêm bản sao bàn",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                else ret = MessageBox.Show("There are data related to a table with this ID. Do you want to restore it?", "Cannot add a duplicate table",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                    busTable.RestoreDeletedTable(table);
                    ResetInput();
                    ucTableManager.LoadAllTables();
                    if (lblAdd.Text == "Thêm")
                        MessageBox.Show("Khôi phục bàn đã bị xóa", "Khôi phục thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Deleted table restored.", "Restore successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ResetInput()
        {
            txtTableId.ForeColor = Color.DimGray;
            if (lblAdd.Text == "Thêm") txtTableId.Text = "Nhập ID bàn";
            else txtTableId.Text = "Enter table ID";
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
                    if (int.TryParse(txtTableId.Text, out int id) && id > 0)
                    {
                        var dbtab = busTable.GetTableByIdDeletedAndNotDeleted(id, shopId);
                        if (dbtab == null)
                        {
                            err.Icon = checkIcon;
                            if (lblAdd.Text == "Thêm")
                                err.SetError(txtTableId, "Hợp lệ");
                            else err.SetError(txtTableId, "Valid");
                            lblAdd.Enabled = true;
                            checkDeleted = true;
                        }
                        else if (dbtab.Deleted)
                        {
                            checkDeleted = false;
                            if (lblAdd.Text == "Thêm")
                                throw new Exception("Có dữ liệu liên quan đến bàn này");
                            else throw new Exception("There are data related to a table with such ID");
                        }
                        else
                        {
                            checkDeleted = true;
                            if (lblAdd.Text == "Thêm")
                                throw new Exception("Bàn có ID này đã được thêm vào danh sách từ trước");
                            else throw new Exception("A table with such ID has already been added to the list");
                        }
                    }
                    else
                    {
                        checkDeleted = true;
                        if (lblAdd.Text == "Thêm")
                            throw new Exception("ID bàn phải là số tự nhiên");
                        else 
                        throw new Exception("A table ID must be a natural number");
                    }
                }
                else
                {
                    checkDeleted = true;
                    if (lblAdd.Text == "Thêm")
                        throw new Exception("Vui lòng nhập đủ thông tin");
                    else throw new Exception("Please fill all info fields");
                }
            }
            catch (Exception ex)
            {
                if (!checkDeleted)
                {
                    err.Icon = warningIcon;
                    lblAdd.Enabled = true;
                }
                else
                {
                    err.Icon = errorIcon;
                    lblAdd.Enabled = false;
                }
                err.SetError(txtTableId, ex.Message);
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
