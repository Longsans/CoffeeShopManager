using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class UserControlManagerReceiptsTab : UserControl
    {
        private BUS_Receipts busRec = new BUS_Receipts(ConnectionStringHelper.GetConnectionString());
        private BUS_Shop busShop = new BUS_Shop(ConnectionStringHelper.GetConnectionString());
        public EventHandler ReceiptDetailsView;
        public UserControlReceiptsDetail ucRecDetails { get; set; }
        public DTO_Shop dtoShop = new DTO_Shop();
        FilterProperties filProp = new FilterProperties();

        public UserControlManagerReceiptsTab()
        {
            InitializeComponent();
        }

        private void UserControlManagerReceiptsTab_Load(object sender, EventArgs e)
        {
            btnView.Enabled = false;
            btnPrint.Enabled = false;
            datSearch.Visible = false;
            txtSearch.GotFocus += TxtSearch_GotFocus;
            txtSearch.LostFocus += TxtSearch_LostFocus;
            ReloadGridView();
        }

        private void ReloadGridView()
        {
            if (!(string.IsNullOrWhiteSpace(filProp.CurrentFilter) || string.IsNullOrWhiteSpace(filProp.CurrentFilterText)))
            {
                switch (filProp.CurrentFilter)
                {
                    case "ID":
                        {
                            if (int.TryParse(txtSearch.Text, out int id))
                            {
                                grdReceipts.DataSource = busRec.GetReceiptSearchIdFiltered(id, dtoShop.ID);
                            }
                            else
                            {
                                ((DataTable)grdReceipts.DataSource).Clear();
                            }
                        }
                        break;
                    case "Customer ID":
                        {
                            if (int.TryParse(txtSearch.Text, out int cusId))
                            {
                                grdReceipts.DataSource = busRec.GetReceiptSearchCustomersIdFiltered(cusId, dtoShop.ID);
                            }
                            else
                            {
                                ((DataTable)grdReceipts.DataSource).Clear();
                            }
                        }
                        break;
                    case "ID Khách hàng":
                        {
                            if (int.TryParse(txtSearch.Text, out int cusId))
                            {
                                grdReceipts.DataSource = busRec.GetReceiptSearchCustomersIdFiltered(cusId, dtoShop.ID);
                            }
                            else
                            {
                                ((DataTable)grdReceipts.DataSource).Clear();
                            }
                        }
                        break;
                    case "Employee ID":
                        {
                            grdReceipts.DataSource = busRec.GetReceiptSearchEmployeesIdFiltered(filProp.CurrentFilterText, dtoShop.ID);
                        }
                        break;
                    case "ID Nhân viên":
                        {
                            grdReceipts.DataSource = busRec.GetReceiptSearchEmployeesIdFiltered(filProp.CurrentFilterText, dtoShop.ID);
                        }
                        break;
                    case "Date of Payment":
                        {
                            grdReceipts.DataSource = busRec.GetReceiptSearchDateOfPaymentFiltered(datSearch.Value, dtoShop.ID);
                        }
                        break;
                    case "Ngày thanh toán":
                        {
                            grdReceipts.DataSource = busRec.GetReceiptSearchDateOfPaymentFiltered(datSearch.Value, dtoShop.ID);
                        }
                        break;
                }
            }
            else
            {
                grdReceipts.DataSource = busRec.GetAllReceipts(dtoShop.ID);
            }

            if (btnPrint.Text != "Print")
            {
                grdReceipts.Columns[1].HeaderText = "ID khách hàng";
                grdReceipts.Columns[2].HeaderText = "Tên khách hàng";
                grdReceipts.Columns[3].HeaderText = "Họ khách hàng";
                grdReceipts.Columns[4].HeaderText = "Ngày thanh toán";
                grdReceipts.Columns[5].HeaderText = "ID nhân viên";
                grdReceipts.Columns[6].HeaderText = "Tổng tiền";
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ucRecDetails.rec = busRec.GetReceiptById((int)grdReceipts.SelectedRows[0].Cells["ID"].Value, dtoShop.ID);
            OnReceiptDetailsView();
            ucRecDetails.Show();
            ucRecDetails.BringToFront();
        }

        private void grdReceipts_SelectionChanged(object sender, EventArgs e)
        {
            if (grdReceipts.SelectedRows != null)
            {
                if (grdReceipts.SelectedRows.Count == 1)
                {
                    btnView.Enabled = true;
                }
                else
                {
                    btnView.Enabled = false;
                }
                btnPrint.Enabled = true;
            }
            else
            {
                btnView.Enabled = false;
                btnPrint.Enabled = false;
            }
        }

        private void TxtSearch_LostFocus(object sender, EventArgs e)
        {
            if (txtSearch.TextLength == 0)
            {
                txtSearch.ForeColor = Color.DimGray;
                if (btnView.Text == "Chi tiết")
                txtSearch.Text = "Tìm kiếm...";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cboSearch.Text) && (txtSearch.ForeColor != Color.DimGray || datSearch.Visible))
            {
                lblResetFilters.Visible = true;
                filProp.CurrentFilter = cboSearch.Text;
                filProp.CurrentFilterText = txtSearch.Text;
                ReloadGridView();
            }
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSearch.SelectedIndex == 3)
            {
                datSearch.Format = DateTimePickerFormat.Custom;
                datSearch.CustomFormat = "dd/MM/yyyy";
                txtSearch.Visible = false;
                datSearch.Visible = true;
            }
            else
            {
                txtSearch.Visible = true;
                datSearch.Visible = false;
            }
        }

        private void grdReceipts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                grdReceipts.ClearSelection();
                grdReceipts.Rows[e.RowIndex].Selected = true;
                if (e.Button == MouseButtons.Right)
                {
                    ctxRightClick.Show(Cursor.Position);
                }
            }
        }

        protected virtual void OnReceiptDetailsView()
        {
            ReceiptDetailsView?.Invoke(this, null);
        }

        private void grdReceipts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ucRecDetails.rec = busRec.GetReceiptById((int)grdReceipts.SelectedRows[0].Cells["ID"].Value, dtoShop.ID);
                OnReceiptDetailsView();
                ucRecDetails.Show();
                ucRecDetails.BringToFront();
            }
        }

        private void lblResetFilters_MouseDown(object sender, MouseEventArgs e)
        {
            lblResetFilters.ForeColor = Color.Black;
        }

        private void lblResetFilters_MouseUp(object sender, MouseEventArgs e)
        {
            lblResetFilters.ForeColor = SystemColors.Highlight;
            filProp.CurrentFilter = null;
            filProp.CurrentFilterText = null;
            lblResetFilters.Visible = false;
            ReloadGridView();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdReceipts.SelectedRows)
            {
                var rec = busRec.GetReceiptById((int)row.Cells["ID"].Value, dtoShop.ID);
                rec.Shop = busShop.GetShopById(rec.Shop.ID);
                rec.Items = busRec.GetReceiptDetailsListById(rec.Id, rec.Shop.ID);
                PDFPrinter.PrintReceipt(rec);
            }
        }
    }
}
