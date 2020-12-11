using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class UserControlReceiptsDetail : UserControl
    {
        private BUS_Receipts busRec = new BUS_Receipts();
        private BUS_Customers busCus = new BUS_Customers();
        public UserControlManagerReceiptsTab UcManReceipt { get; set; }
        public DTO_Receipt rec = new DTO_Receipt();
        public string id = "";

        public UserControlReceiptsDetail()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UcManReceipt.Show();
        }

        private void Reload()
        {
            rec.Customer = busCus.GetCustomerById(rec.Customer.Id);
            txtId.Text = rec.Id.ToString();
            datDop.Format = DateTimePickerFormat.Custom;
            datDop.CustomFormat = "dd/MM/yyyy";
            datDop.Value = rec.DateOfPayMent;
            if (busRec.GetTableOfReceipt(rec.Id) != null)
            {
                txtTabNum.Text = busRec.GetTableOfReceipt(rec.Id).Id.ToString();
            }
            else
            {
                txtTabNum.Text = "(None)";
            }
            txtCusFname.Text = rec.Customer.FirstName;
            txtCusLname.Text = rec.Customer.LastName;
            txtCusEmail.Text = rec.Customer.Email;
            datCusBirthdate.Format = DateTimePickerFormat.Custom;
            datCusBirthdate.CustomFormat = datDop.CustomFormat;
            datCusBirthdate.Value = rec.Customer.Birthdate;

            grdProducts.DataSource = busRec.GetReceiptDetailsGridViewByReceiptId(rec.Id);
            lblTotalDisplay.Text = rec.Total.ToString();
            rtxtDetails.Text = rec.Details;

            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserControlReceiptsDetail_Load(object sender, EventArgs e)
        {
            UcManReceipt.ReceiptDetailsView += Shown;
        }

        private void Shown(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
