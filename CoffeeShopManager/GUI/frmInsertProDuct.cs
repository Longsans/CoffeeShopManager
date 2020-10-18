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
            txtID.Text = dtoPro.Id.ToString();
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName1.Text==""||txtPrice.Text==""||cbxType.Text==""||rtxDetail.Text=="")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Insert product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DTO_Product dtoPro = new DTO_Product();
                dtoPro.Name = txtName1.Text;
                dtoPro.Price =decimal.Parse(txtPrice.Text);
                dtoPro.Type = cbxType.Text;
                dtoPro.Detail = rtxDetail.Text;
                if (this.pictureBox1.Image == null)
                {
                    if (busPro.GetByName(dtoPro.Name) == null)
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
                    if (busPro.GetByName(dtoPro.Name) == null)
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
    }
}
