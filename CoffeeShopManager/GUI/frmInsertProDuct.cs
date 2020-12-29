using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frmInsertProDuct : Form
    {
        BUS_Product busPro = new BUS_Product(ConnectionStringHelper.GetConnectionString());

        BUS_UserInfo busUser = new BUS_UserInfo(ConnectionStringHelper.GetConnectionString());
        UserControlProductTab _ucPro;
        public DTO_Product dtoPro = new DTO_Product();
        int checkname, checktype, checkprice;
        bool checkNameDeleted = true;
        Point prevPoint;
        bool dragging;

        public frmInsertProDuct(UserControlProductTab product)
        {
            _ucPro = product;
            InitializeComponent();
        }
        public frmInsertProDuct()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;

        }

        private void frmInsertProDuct_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnAdd.Enabled = false;
           // txtName1.Text = dtoPro.Name;
          //  txtPrice.Text = dtoPro.Price.ToString();
           // cbxType.Text = dtoPro.Type;
            //rtxDetail.Text = dtoPro.Detail;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //if (dtoPro.Image != null)
            //{
               // pictureBox1.Image = ImageHelper.ByteArrayToImage(dtoPro.Image);
            //}
            //btnSave.Visible = false;

        }
        private void Reload()
        {
            txtName1.Text = "";
            txtPrice.Text = "";
            rtxDetail.Text = "";
            pictureBox1.Image = null;
            cbxType.Text = "";
            _ucPro.Reload();
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c) && c != '.' && c !=',')
                    return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkNameDeleted)
            {
                DialogResult ret;
                if (btnAdd.Text == "Thêm")
                {
                    ret = MessageBox.Show("Có dữ liệu liên quan đến 1 tên sản phẩm bị xóa. Bạn có muốn xem nó và khôi phục không?",
                      "Không thể thêm sản phẩm trùng tên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    ret = MessageBox.Show("There are data related to a deleted product with this name. Do you want to view it for restoring instead?",
                      "Cannot insert a duplicate product name", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                if (ret == DialogResult.Yes)
                {
                    frmRestoreProduct res = new frmRestoreProduct(_ucPro, this, busPro.GetByNameDeletedAndNotDeleted(txtName1.Text, _ucPro.dtoShop.ID));
                    this.Reload();
                    this.Hide();
                    res.TopMost = true;
                    res.Show();
                }
                return;
            }
            if (checkname == 0 || checktype == 0 || checkprice == 0)
            {
                if (btnAdd.Text == "Thêm")
                    MessageBox.Show("Sai định dạng","Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MessageBox.Show("Wrong format","Insert product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAdd.Enabled = false;
                return;
            }
            else
            {
                DTO_Product dtoPro = new DTO_Product();
                dtoPro.Name = txtName1.Text;
                txtPrice.Text = txtPrice.Text.Replace(',', '.');
                if (double.TryParse(txtPrice.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double sala)==false)
                {
                    if(lblName.Text=="Tên")
                        MessageBox.Show("Sai tiền", "tiền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Wrong money", "money", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                if (double.TryParse(txtPrice.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out sala))
                    dtoPro.Price = (decimal)sala;
                var resultIndex = cbxType.FindStringExact(cbxType.Text);

                if (resultIndex == 0)
                    cbxType.Text = "Food";
                if (resultIndex == 1)
                    cbxType.Text = "Drink";
                else
                    cbxType.Text = "Others";
                dtoPro.Type = cbxType.Text;
                dtoPro.Details = rtxDetail.Text;
                dtoPro.Shop = _ucPro.dtoShop;
                if (this.pictureBox1.Image == null)
                {
                    if (busPro.GetByNameNotDeleted(dtoPro.Name, dtoPro.Shop.ID) == null)
                    {
                   //     dtoPro.Image = ImageHelper.ImageToByteArray(this.pictureBox1.Image);
                        busPro.InsertWithoutImage(dtoPro);
                        Reload();
                        _ucPro.Reload();
                        if (btnAdd.Text == "Thêm")
                            MessageBox.Show("Thêm thành công", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("Add successfully", "Add product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtName1.ResetText();
                        if (btnAdd.Text == "Thêm")
                            MessageBox.Show("Trùng tên thức ăn đã có sẵn");
                        else MessageBox.Show("A product with this name has already existed.");
                    }
                   // MessageBox.Show("Vui lòng chọn hình ảnh", "Add employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (busPro.GetByNameNotDeleted(dtoPro.Name, dtoPro.Shop.ID) == null)
                    {
                        dtoPro.Image = ImageHelper.ImageToByteArray(this.pictureBox1.Image);
                        busPro.InsertWithImage(dtoPro);
                        Reload();
                        _ucPro.Reload();
                        if (btnAdd.Text == "Thêm")
                            MessageBox.Show("Thêm thành công.", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("Add successfully", "Add product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtName1.ResetText();
                        if (btnAdd.Text == "Thêm")
                            MessageBox.Show("Trùng tên thức ăn đã có sẵn");
                        else MessageBox.Show("A product with this name has already existed.");
                    }
                }
            }
            _ucPro.Reload();
            _ucPro.GetCong();
            _ucPro.GetData();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName1_TextChanged(object sender, EventArgs e)
        {
            var matchedPro = busPro.GetByNameDeletedAndNotDeleted(txtName1.Text, _ucPro.dtoShop.ID);
            if (txtName1.Text == string.Empty)
            {
                if (btnAdd.Text == "Thêm")
                    errorProvider1.SetError(txtName1, "Vui lòng nhập tên sản phẩm");
                else errorProvider1.SetError(txtName1, "Name is required");
                errorProvider2.SetError(txtName1, "");
                errNameDeleted.SetError(txtName1, "");
                checkname = 0;
            }
            else if (matchedPro != null)
            {
                if (matchedPro.Deleted)
                {
                    if (btnAdd.Text == "Thêm")
                        errNameDeleted.SetError(txtName1, "Đã có thông tin liên quan đến tên sản phẩm này");
                    else errNameDeleted.SetError(txtName1, "There is existing info related to a product with such name");
                    errorProvider2.SetError(txtName1, "");
                    checkNameDeleted = false;
                }
                else
                {
                    if (btnAdd.Text == "Thêm")
                        errorProvider1.SetError(txtName1, "Tên sản phẩm đã tồn tại.");
                    else errorProvider1.SetError(txtName1, "A product with such name already exists");
                    errorProvider2.SetError(txtName1, "");
                    errNameDeleted.SetError(txtName1, "");
                    checkname = 0;
                }
            }
            else
            {
                errorProvider1.SetError(txtName1, "");
                if (btnAdd.Text == "Thêm")
                    errorProvider2.SetError(txtName1, "Hợp lệ");
                else errorProvider2.SetError(txtName1, "Valid");
                errNameDeleted.SetError(txtName1, "");
                checkname = 1;
                checkNameDeleted = true;
            }

            if (checkname == 1 && checktype == 1 && checkprice == 1)
            {
                btnAdd.Enabled = true;
        }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void cbxType_TextChanged(object sender, EventArgs e)
        {
            if (cbxType.Text == string.Empty)
            {
                if (btnAdd.Text == "Thêm")
                    errorProvider1.SetError(cbxType, "Vui lòng chọn");
                else errorProvider1.SetError(cbxType, "Please choose");
                errorProvider2.SetError(cbxType, "");
                checktype = 0;
            }
            else
            {
                errorProvider1.SetError(cbxType, "");
                if (btnAdd.Text == "Thêm")
                    errorProvider2.SetError(cbxType, "Hợp lệ");
                else errorProvider2.SetError(cbxType, "Correct");
                checktype = 1;
            }
            if (checkname == 1 && checktype == 1 && checkprice == 1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int countdoc = 0;
            string sums = null;
            if (txtPrice.Text == string.Empty)
            {
                if (btnAdd.Text == "Thêm")
                    errorProvider1.SetError(txtPrice, "Vui lòng nhập giá");
                else errorProvider1.SetError(txtPrice, "Please provide Price");
                errorProvider2.SetError(txtPrice, "");
                checkprice = 0;
            }
            else
            {
                if (double.TryParse(txtPrice.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double sala))
                {
                    if (btnAdd.Text == "Thêm")
                        errorProvider2.SetError(txtPrice, "Hợp lệ");
                    else errorProvider2.SetError(txtPrice, "Correct");
                        errorProvider1.SetError(txtPrice, "");
                    checkprice = 1;
                }
                else
                {
                    if (btnAdd.Text == "Thêm")
                        errorProvider1.SetError(txtPrice, "Sai định dạng");
                    else errorProvider1.SetError(txtPrice, "Wrong format");
                    errorProvider2.SetError(txtPrice, "");
                    checkprice = 0;
                }

            }
            if (checkname == 1 && checktype == 1 && checkprice == 1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
    }
    
}
