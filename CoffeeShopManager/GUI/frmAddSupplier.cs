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
    public partial class frmAddSupplier : Form
    {
        BUS_Suppliers busSup = new BUS_Suppliers();
        ErrorProvider err = new ErrorProvider();
        public DTO_Shop Shop = new DTO_Shop();
        public UserControlSuppliers ucSup { get; set; }
        Point prevPoint;
        bool dragging;

        public frmAddSupplier()
        {
            StartPosition = FormStartPosition.Manual;
            AcceptButton = btnAdd;
            InitializeComponent();
        }

        private void frmAddSupplier_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var sup = new DTO_Supplier
            {
                Id = txtId.Text,
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Shop = this.Shop
            };

            busSup.Insert(sup);
            ucSup.ReloadGridView();
            ResetTextboxes();
        }

        private void ResetTextboxes()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                var dbsup = busSup.GetById(txtId.Text, Shop.ID);

                if (dbsup != null)
                {
                    err.SetError(txtId, "A supplier with such ID already exists");
                    btnAdd.Enabled = false;
                }
                else
                {
                    err.SetError(txtId, "");
                    btnAdd.Enabled = true;
                }
            }
            else
            {
                btnAdd.Enabled = false;
            }
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
