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
    public partial class frmInsertProDuct : Form
    {
        BUS_Product busPro = new BUS_Product();

        BUS_UserInfo busUser = new BUS_UserInfo();
        UserControlProductTab _ucPro;
        public DTO_Product dtoPro = new DTO_Product();
        int checkid, checkname, checktype, checkprice;
        public frmInsertProDuct(UserControlProductTab product)
        {
            _ucPro = product;
            InitializeComponent();
        }
        public frmInsertProDuct()
        {
            InitializeComponent();
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
                if (!Char.IsDigit(c) && c != '.' && c !=',')
                    return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkname == 0 || checkid == 0 || checktype == 0 || checkprice == 0)
            {
                MessageBox.Show("Wrong format","Insert product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAdd.Enabled = false;
                return;
            }
            else
            {
                DTO_Product dtoPro = new DTO_Product();
                dtoPro.Id = txtID.Text;
                dtoPro.Name = txtName1.Text;
                dtoPro.Price =decimal.Parse(txtCopyPrice.Text);
                if (cbxType.Text == "Thức ăn")
                    cbxType.Text = "Food";
                if (cbxType.Text == "Nước uống")
                    cbxType.Text = "Drink";
                if (cbxType.Text == "Khác")
                    cbxType.Text = "Others";
                dtoPro.Type = cbxType.Text;
                dtoPro.Detail = rtxDetail.Text;
                dtoPro.Shop = _ucPro.dtoShop;
                if (this.pictureBox1.Image == null)
                {
                    if (busPro.GetByName(dtoPro.Name, dtoPro.Shop.ID) == null)
                    {
                   //     dtoPro.Image = ImageHelper.ImageToByteArray(this.pictureBox1.Image);
                        busPro.InsertWithoutImage(dtoPro);
                        Reload();
                        _ucPro.Reload();
                        MessageBox.Show("Thêm thành công.", "Add employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtName1.ResetText();
                        MessageBox.Show("Trùng tên thức ăn đã có sẵn");
                    }
                   // MessageBox.Show("Vui lòng chọn hình ảnh", "Add employees", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (busPro.GetByName(dtoPro.Name, dtoPro.Shop.ID) == null)
                    {
                        dtoPro.Image = ImageHelper.ImageToByteArray(this.pictureBox1.Image);
                        busPro.InsertWithImage(dtoPro);
                        Reload();
                        _ucPro.Reload();
                        MessageBox.Show("Thêm thành công.", "Add employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        txtName1.ResetText();
                        MessageBox.Show("Trùng tên thức ăn đã có sẵn");
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
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                errorProvider1.SetError(txtID, "Please Enter ID");
                errorProvider2.SetError(txtID, "");
                checkid = 0;
            }
            else
            {
                if (busPro.GetById(txtID.Text, _ucPro.dtoShop.ID) != null)
                {
                    errorProvider1.SetError(txtID, "ID trung");
                    errorProvider2.SetError(txtID, "");
                    checkid = 0;
                }
                else
                {
                    errorProvider1.SetError(txtID, "");
                    errorProvider2.SetError(txtID, "Correct");
                    checkid = 1;
                }
            }
            if (checkname == 1 && checkid == 1 && checktype == 1 && checkprice == 1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
        private void txtName1_TextChanged(object sender, EventArgs e)
        {
            if (txtName1.Text == string.Empty)
            {
                errorProvider1.SetError(txtName1, "Please Enter Name");
                errorProvider2.SetError(txtName1, "");
                checkname = 0;
            }
            if (busPro.GetByName(txtName1.Text, _ucPro.dtoShop.ID) != null)
            {
                errorProvider1.SetError(txtName1, "Had name before");
                errorProvider2.SetError(txtName1, "");
                checkname = 0;
            }
            else
            {

                errorProvider1.SetError(txtName1, "");
                errorProvider2.SetError(txtName1, "Correct");
                checkname = 1;
            }
            if (checkname == 1 && checkid == 1 && checktype == 1 && checkprice == 1)
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
                errorProvider1.SetError(cbxType, "Please choose");
                errorProvider2.SetError(cbxType, "");
                checktype = 0;
            }
            else
            {
                errorProvider1.SetError(cbxType, "");
                errorProvider2.SetError(cbxType, "Correct");
                checktype = 1;
            }
            if (checkname == 1 && checkid == 1 && checktype == 1 && checkprice == 1)
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
                errorProvider1.SetError(txtPrice, "Please provide Price");
                errorProvider2.SetError(txtPrice, "");
                checkprice = 0;
            }
            else
            {
                string s = txtPrice.Text.ToString();

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '.' || s[i] == ',')
                    {
                        countdoc++;
                        sums += '.';
                    }
                    else
                        sums += s[i];
                }
                txtCopyPrice.Text = sums;
                if (IsNumber(txtPrice.Text) == true && countdoc <= 1)
                {
                    errorProvider2.SetError(txtPrice, "Correct");
                    errorProvider1.SetError(txtPrice, "");
                    checkprice = 1;
                }
                else
                {
                    errorProvider1.SetError(txtPrice, "Wrong format");
                    errorProvider2.SetError(txtPrice, "");
                    checkprice = 0;
                }
                if (s[s.Length - 1] == '.' || s[s.Length - 1] == ',')
                {
                    errorProvider1.SetError(txtPrice, "Wrong format");
                    errorProvider2.SetError(txtPrice, "");
                    checkprice = 0;
                }
            }
            if (checkname == 1 && checkid == 1 && checktype == 1 && checkprice == 1)
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
