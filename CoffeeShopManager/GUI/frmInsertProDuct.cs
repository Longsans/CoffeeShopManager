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
            txtName1.Text = dtoPro.Name;
            txtPrice.Text = dtoPro.Price.ToString();
            cbxType.Text = dtoPro.Type;
            rtxDetail.Text = dtoPro.Detail;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (dtoPro.Image != null)
            {
                pictureBox1.Image = ImageHelper.ByteArrayToImage(dtoPro.Image);
            }
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
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName1.Text==""||txtPrice.Text==""||cbxType.Text==""||rtxDetail.Text=="")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Insert product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(IsNumber(txtPrice.Text)== false)
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin ở price", "Insert product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("" + IsNumber(txtPrice.Text).ToString());
                DTO_Product dtoPro = new DTO_Product();
                dtoPro.Id = txtID.Text;
                dtoPro.Name = txtName1.Text;
                dtoPro.Price =decimal.Parse(txtPrice.Text);
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
            }this.Close();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
          /*  if (txtName1.Text == "" || txtPrice.Text == "" || cbxType.Text == "" || rtxDetail.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Insert product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                dtoPro.Name = txtName1.Text;
                dtoPro.Price = decimal.Parse(txtPrice.Text);
                dtoPro.Type = cbxType.Text;
                dtoPro.Detail = rtxDetail.Text;
                dtoPro.Image = ImageHelper.ImageToByteArray(this.pictureBox1.Image);
                busPro.Update(dtoPro);
                Reload();
                _ucPro.Reload();
                MessageBox.Show("Edit thành công.", "Add employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }*/
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (txtPrice.Text == string.Empty)
            {
                errorProvider1.SetError(txtPrice, "Please provide Price");

            }
            else
            {
                if(IsNumber(txtPrice.Text) == true)
                {
                    errorProvider2.SetError(txtPrice, "Correct");
                    errorProvider1.SetError(txtPrice, "");
                }
                else
                {
                    errorProvider1.SetError(txtPrice, "Wrong format");
                    errorProvider2.SetError(txtPrice, "");
                }
            }    
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                errorProvider1.SetError(txtID, "Please Enter ID");
                errorProvider2.SetError(txtID, "");
            }
            else
            {
                if (busPro.GetById(txtID.Text,1) !=null)
                {
                    errorProvider1.SetError(txtID, "ID trung");
                    errorProvider2.SetError(txtID, "");
                }
                else
                {
                    errorProvider1.SetError(txtID, "");
                    errorProvider2.SetError(txtID, "Correct");
                }
            }
        }

        private void txtName1_Validating(object sender, CancelEventArgs e)
        {
            if (txtName1.Text == string.Empty)
            {
                errorProvider1.SetError(txtName1, "Please Enter Name");
                errorProvider2.SetError(txtName1, "");
            }
            else
            {
                errorProvider1.SetError(txtName1, "");
                errorProvider2.SetError(txtName1, "Correct");
            }
        }

        private void cbxType_Validating(object sender, CancelEventArgs e)
        {
            if (cbxType.Text == string.Empty)
            {
                errorProvider1.SetError(cbxType, "Please choose");
                errorProvider2.SetError(cbxType, "");
            }
            else
            {
                errorProvider1.SetError(cbxType, "");
                errorProvider2.SetError(cbxType, "Correct");
            }
        }
    }
    
}
