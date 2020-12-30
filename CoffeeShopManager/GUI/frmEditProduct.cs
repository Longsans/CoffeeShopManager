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
using System.Globalization;

namespace GUI
{
    public partial class frmEditProduct : Form
    {
        BUS_Product busPro = new BUS_Product(ConnectionStringHelper.GetConnectionString());
        public DTO_Product dtoPro = new DTO_Product();
        BUS_UserInfo busUser = new BUS_UserInfo(ConnectionStringHelper.GetConnectionString());
        UserControlProductTab _ucPro;
        Point prevPoint;
        bool dragging;
        string savename;
        int checkname, checktype, checkprice;
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
            txtID.Text = dtoPro.Id.ToString();
            savename = dtoPro.Name;
            txtName1.Text = dtoPro.Name;
            txtPrice.Text = dtoPro.Price.ToString();
            
            if (dtoPro.Type == "Food")
            {
                cbxType.SelectedIndex = 0;
            }
            else if (dtoPro.Type == "Drink")
            {
                cbxType.SelectedIndex = 1;
            }
            else
            {
                cbxType.SelectedIndex = 2;
            }
            rtxDetail.Text = dtoPro.Details;
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
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c)&&c!='.'&&c!=',')
                    return false;
            }
            return true;
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
            if (txtName1.Text == "" || txtPrice.Text == "" || cbxType.Text == "")
            {
                if(lblName.Text=="Tên")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Insert product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Fill enough infomation", "Insert product", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if (checkname == 1 && checktype == 1 && checkprice == 1)
            {
                dtoPro.Name = txtName1.Text;
                txtPrice.Text = txtPrice.Text.Replace(',', '.');
                if (double.TryParse(txtPrice.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double sala) == false)
                {
                    if (btnSave.Text != "Lưu")
                    {
                        MessageBox.Show("Wrong money", "Money", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Sai tiền", "tiền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (double.TryParse(txtPrice.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out sala))
                    dtoPro.Price = (decimal)sala;
                var resultIndex = cbxType.FindStringExact(cbxType.Text);

                if (resultIndex==0)
                    cbxType.Text = "Food";
                else if (resultIndex == 1)
                    cbxType.Text = "Drink";
                else
                    cbxType.Text = "Others";
                dtoPro.Type = cbxType.Text;
                dtoPro.Details = rtxDetail.Text;
                dtoPro.Image = ImageHelper.ImageToByteArray(this.pictureBox1.Image);
                if (busPro.GetByNameDeletedAndNotDeleted(dtoPro.Name, dtoPro.Shop.ID) == null||savename==txtName1.Text)
                {
                    dtoPro.Image = ImageHelper.ImageToByteArray(this.pictureBox1.Image); ;
                    busPro.Update(dtoPro);
                    //Reload();
                    _ucPro.Reload();
                    _ucPro.GetCong();
                    _ucPro.GetData();
                    if (lblName.Text == "Tên")
                        MessageBox.Show("Edit thành công.", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Edit successful", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else if (savename != txtName1.Text)
                {
                    txtName1.ResetText();
                    if (lblName.Text == "Tên")
                        MessageBox.Show("Nhập tên không được trùng tên có sẵn", "Tên sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    MessageBox.Show("Please ensure that product name has not been used", "Duplicate product name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (btnCancel.Text != "Cancel")
            {
                grdItems.Columns[0].HeaderText = "ID hàng";
                grdItems.Columns[1].HeaderText = "Tên hàng";
            }
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
                        var itemForPro = new DTO_StockItemForProduct
                        {
                            Item = new DTO_StockItem
                            {
                                Id = (int)row.Cells["Item ID"].Value,
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
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int countdoc = 0;
            string sums=null;
            if (txtPrice.Text == string.Empty)
            {
                if (lblName.Text == "Tên")
                {
                    errorProvider1.SetError(txtPrice, "Yêu cầu giá");
                    errorProvider2.SetError(txtPrice, "");
                    checkprice = 0;
                }
                else
                {
                    errorProvider1.SetError(txtPrice, "Price is required");
                    errorProvider2.SetError(txtPrice, "");
                    checkprice = 0;
                }
            }
            else
            {
                if (double.TryParse(txtPrice.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double sala))
                {
                    if (btnSave.Text == "Lưu")
                        errorProvider2.SetError(txtPrice, "Hợp lệ");
                    else errorProvider2.SetError(txtPrice, "Correct");
                    errorProvider1.SetError(txtPrice, "");
                    checkprice = 1;
                }
                else
                {
                    if (btnSave.Text == "Lưu")
                        errorProvider1.SetError(txtPrice, "Sai định dạng");
                    else errorProvider1.SetError(txtPrice, "Wrong format");
                    errorProvider2.SetError(txtPrice, "");
                    checkprice = 0;
                }
            }
        }

        private void txtCopyPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void grdItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rtxDetail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblDetails_Click(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void lblListCaption_Click(object sender, EventArgs e)
        {

        }

        private void lblRemove_Click(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void txtName1_TextChanged(object sender, EventArgs e)
        {
            if (txtName1.Text == string.Empty)
            {
                if (lblName.Text == "Tên")
                {
                    errorProvider1.SetError(txtName1, "Bắt buộc");
                    errorProvider2.SetError(txtName1, "");
                }
                else
                {
                    errorProvider1.SetError(txtName1, "Name is required");
                    errorProvider2.SetError(txtName1, "");
                }
            }
            else if (busPro.GetByNameDeletedAndNotDeleted(txtName1.Text, dtoPro.Shop.ID) != null && savename != txtName1.Text)
            {
                if (lblName.Text == "Tên")
                {
                    errorProvider1.SetError(txtName1, "Có thông tin hiện có liên quan đến một sản phẩm có tên như vậy");
                    errorProvider2.SetError(txtName1, "");
                }
                else
                {
                    errorProvider1.SetError(txtName1, "There is existing info related to a product with such name");
                    errorProvider2.SetError(txtName1, "");
                }
            }
            else
            {
                errorProvider1.SetError(txtName1, "");
                errorProvider2.SetError(txtName1, "Valid");
                checkname = 1;
            }
        }

        private void cbxType_TextChanged(object sender, EventArgs e)
        {
            if (cbxType.Text == string.Empty)
            {
                if (lblName.Text == "Tên")
                    errorProvider1.SetError(cbxType, "Làm ơn chọn");
                else
                errorProvider1.SetError(cbxType, "Please choose");
                errorProvider2.SetError(cbxType, "");
            }
            else
            {
                errorProvider1.SetError(cbxType, "");
                errorProvider2.SetError(cbxType, "Correct");
                checktype = 1;
            }
        }
    }
}
