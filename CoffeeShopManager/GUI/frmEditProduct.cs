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
    public partial class frmEditProduct : Form
    {
        BUS_Product busPro = new BUS_Product();
        public DTO_Product dtoPro = new DTO_Product();
        BUS_UserInfo busUser = new BUS_UserInfo();
        UserControlProductTab _ucPro;
        Point prevPoint;
        bool dragging;

        public frmEditProduct()
        {
            InitializeComponent();
        }
        public frmEditProduct(UserControlProductTab product)
        {
            _ucPro = product;
            InitializeComponent();
        }
        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            txtID.Text = dtoPro.Id;
            txtName1.Text = dtoPro.Name;
            txtPrice.Text = dtoPro.Price.ToString();
            cbxType.Text = dtoPro.Type;
            rtxDetail.Text = dtoPro.Detail;
            lblListCaption.Text += $"{dtoPro.Name}:";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (dtoPro.Image != null)
            {
                pictureBox1.Image = ImageHelper.ByteArrayToImage(dtoPro.Image);
            }
            ReloadGridView();
        }
        private void Reload()
        {
            txtID.Text = "";
            txtName1.Text = "";
            txtPrice.Text = "";
            rtxDetail.Text = "";
            pictureBox1.Image = null;
            cbxType.Items.Clear();
            cbxType.Text = "";
            _ucPro.Reload();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            dlg.Title = "Select image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName1.Text == "" || txtPrice.Text == "" || cbxType.Text == "" || rtxDetail.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Insert product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                dtoPro.Name = txtName1.Text;
                dtoPro.Price = decimal.Parse(txtPrice.Text);
                dtoPro.Type = cbxType.Text;
                dtoPro.Detail = rtxDetail.Text;
                dtoPro.Image = ImageHelper.ImageToByteArray(this.pictureBox1.Image);
                if (busPro.GetByName(dtoPro.Name, dtoPro.Shop.ID) == null)
                {
                    dtoPro.Image = ImageHelper.ImageToByteArray(this.pictureBox1.Image); ;
                    busPro.Update(dtoPro);
                    Reload();
                    _ucPro.Reload();
                    MessageBox.Show("Edit thành công.", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtName1.ResetText();
                    MessageBox.Show("Trùng tên thức ăn đã có sẵn");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRemoveFromList_MouseDown(object sender, MouseEventArgs e)
        {
            ((Label)sender).ForeColor = SystemColors.Highlight;
        }

        public void ReloadGridView()
        {
            grdItems.DataSource = busPro.GetDataTableItemsOfProduct(dtoPro.Id, dtoPro.Shop.ID);
        }

        private void lblAdd_MouseUp(object sender, MouseEventArgs e)
        {
            lblAdd.ForeColor = SystemColors.ControlText;
            var frmAdd = new frmSmallAddStockItemToList
            {
                Product = dtoPro,
                frmEditPro = this
            };
            frmAdd.Location = new Point(this.Location.X + this.Width / 2 - frmAdd.Width / 2, 
                this.Location.Y + this.Height / 2 - frmAdd.Height / 2);
            frmAdd.ShowDialog();
        }

        private void lblRemove_MouseUp(object sender, MouseEventArgs e)
        {
            lblRemove.ForeColor = SystemColors.ControlText;
            if (grdItems.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Remove these items from list?", "Remove items",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in grdItems.SelectedRows)
                    {
                        var itemForPro = new DTO_StockItemsForProducts
                        {
                            Item = new DTO_StockItem
                            {
                                Id = row.Cells["Item ID"].Value.ToString(),
                                Shop = dtoPro.Shop
                            },
                            Product = dtoPro,
                            Shop = dtoPro.Shop
                        };
                        busPro.RemoveItemForProduct(itemForPro);
                    }
                    ReloadGridView();
                }
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
