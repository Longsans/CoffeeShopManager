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
        private BUS_Receipts busRec = new BUS_Receipts();
        public EventHandler ReceiptDetailsView;
        public UserControlReceiptsDetail ucRecDetails { get; set; }
        public DTO_Shop dtoShop = new DTO_Shop();

        public UserControlManagerReceiptsTab()
        {
            InitializeComponent();
        }

        private void UserControlManagerReceiptsTab_Load(object sender, EventArgs e)
        {
            btnView.Enabled = false;
            btnDelete.Enabled = false;
            datSearch.Visible = false;
            txtSearch.GotFocus += TxtSearch_GotFocus;
            txtSearch.LostFocus += TxtSearch_LostFocus;
            Reload();
        }

        private void Reload()
        {
            grdReceipts.DataSource = busRec.GetAllReceipts(dtoShop.ID);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ucRecDetails.rec = busRec.GetReceiptById((int)grdReceipts.SelectedRows[0].Cells["ID"].Value);
            OnReceiptDetailsView();
            ucRecDetails.Show();
            ucRecDetails.BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in grdReceipts.SelectedRows)
            {
                DTO_Receipt rec = new DTO_Receipt
                {
                    Id = (int)row.Cells["ID"].Value
                };
                busRec.DeleteReceipt(rec);
            }
            Reload();
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
                btnDelete.Enabled = true;
            }
            else
            {
                btnView.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void TxtSearch_LostFocus(object sender, EventArgs e)
        {
            if (txtSearch.TextLength == 0)
            {
                txtSearch.ForeColor = Color.DimGray;
                txtSearch.Text = "Search...";
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
            if (txtSearch.Visible)
            {
                switch (cboSearch.Text)
                {
                    case "ID":
                        {
                            grdReceipts.DataSource = busRec.GetReceiptSearchIdFiltered(int.Parse(txtSearch.Text));
                        }
                        break;
                    case "Customer ID":
                        {
                            grdReceipts.DataSource = busRec.GetReceiptSearchCustomersIdFiltered(int.Parse(txtSearch.Text));
                        }
                        break;
                }
            }
            else if (datSearch.Visible)
            {
                grdReceipts.DataSource = busRec.GetReceiptSearchDateOfPaymentFiltered(datSearch.Value);
            }
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSearch.Text == "Date of Payment")
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
                ucRecDetails.rec = busRec.GetReceiptById((int)grdReceipts.SelectedRows[0].Cells["ID"].Value);
                OnReceiptDetailsView();
                ucRecDetails.Show();
                ucRecDetails.BringToFront();
            }
        }
    }
}
