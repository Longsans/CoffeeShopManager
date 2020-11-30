using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmEditCustomer : Form
    {
        public DTO_Customer dtoCus { get; set; }
        public UserControlCustomers ucCus { get; set; }
        Point prevPoint;
        bool dragging;
        BUS_Customers busCus = new BUS_Customers();

        public frmEditCustomer()
        {
            StartPosition = FormStartPosition.Manual;
            AcceptButton = btnSave;
            InitializeComponent();
        }

        public frmEditCustomer(UserControlCustomers ucc) : this()
        {
            ucCus = ucc;
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            txtId.Text = dtoCus.Id.ToString();
            txtFirstName.Text = dtoCus.FirstName;
            txtLastName.Text = dtoCus.LastName;
            txtEmail.Text = dtoCus.Email;
            datBirthdate.Format = DateTimePickerFormat.Custom;
            datBirthdate.CustomFormat = "dd/MM/yyyy";
            if (dtoCus.Birthdate >= datBirthdate.MinDate && dtoCus.Birthdate <= datBirthdate.MaxDate)
            {
                datBirthdate.Value = dtoCus.Birthdate;
            }
            else
            {
                datBirthdate.CustomFormat = " ";
            }
            btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dtoCus = new DTO_Customer
            {
                Id = dtoCus.Id,
                FirstName = dtoCus.FirstName,
                LastName = dtoCus.LastName,
                Email = txtEmail.Text,
                Birthdate = datBirthdate.Value,
            };

            busCus.Update(dtoCus);
            MessageBox.Show("Update succeeded.", "Edit success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            ucCus.ReloadGridView();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void datBirthdate_ValueChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            datBirthdate.CustomFormat = "dd/MM/yyyy";
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
