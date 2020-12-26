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
    public partial class frmRestoreProduct : Form
    {
        BUS_Product busPro = new BUS_Product(ConnectionStringHelper.GetConnectionString());
        DTO_Product dtoPro = new DTO_Product();
        UserControlProductTab ucPro;
        frmInsertProDuct frmInsPro;
        Point prevPoint;
        bool dragging;

        public frmRestoreProduct()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
        }

        public frmRestoreProduct(UserControlProductTab proTab, frmInsertProDuct frmIns, DTO_Product pro) : this()
        {
            Location = frmIns.Location;
            ucPro = proTab;
            dtoPro = pro;
            frmInsPro = frmIns;
        }

        private void frmRestoreProduct_Load(object sender, EventArgs e)
        {
            txtID.Text = dtoPro.Id.ToString();
            txtName.Text = dtoPro.Name;
            txtType.Text = dtoPro.Type;
            txtPrice.Text = dtoPro.Price.ToString();
            rtxDetail.Text = dtoPro.Details;
            grdItems.DataSource = busPro.GetDataTableItemsOfProduct(dtoPro.Id, dtoPro.Shop.ID);
            picProduct.Image = ImageHelper.ByteArrayToImage(dtoPro.Image);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInsPro.Show();
        }

        private void btnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
            frmInsPro.Show();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                var ret = MessageBox.Show("Restore this product?", "Restore product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    busPro.RestoreDeletedProduct(dtoPro);
                    ucPro.Reload();
                    MessageBox.Show("Deleted product restored.", "Restore successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmInsPro.Show();
                }
            }
            catch
            {
                MessageBox.Show("An error occurred, tab will reload now.", "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            prevPoint = Cursor.Position;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point(this.Location.X + Cursor.Position.X - prevPoint.X, this.Location.Y + Cursor.Position.Y - prevPoint.Y);
                prevPoint = Cursor.Position;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }
    }
}
