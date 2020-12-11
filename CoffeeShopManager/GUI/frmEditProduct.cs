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
            txtID.Text = dtoPro.Id;
            txtName1.Text = dtoPro.Name;
            savename = dtoPro.Name;
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
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Insert product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkname == 1 && checktype == 1 && checkprice == 1)
            {
                dtoPro.Name = txtName1.Text;
                dtoPro.Price = decimal.Parse(txtCopyPrice.Text);
                dtoPro.Type = cbxType.Text;
                dtoPro.Detail = rtxDetail.Text;
                dtoPro.Image = ImageHelper.ImageToByteArray(this.pictureBox1.Image);
                if (busPro.GetByName(dtoPro.Name, dtoPro.Shop.ID) == null||savename==txtName1.Text)
                {
                    dtoPro.Image = ImageHelper.ImageToByteArray(this.pictureBox1.Image); ;
                    busPro.Update(dtoPro);
                    //Reload();
                    _ucPro.Reload();
                    _ucPro.GetCong();
                    _ucPro.GetData();
                    MessageBox.Show("Edit thành công.", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (savename != txtName1.Text)
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
                errorProvider1.SetError(txtPrice, "Please provide Price");
                errorProvider2.SetError(txtPrice, "");
            }
            else
            {
                string s = txtPrice.Text.ToString();

                for(int i=0;i<s.Length;i++)
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
                if (IsNumber(txtPrice.Text) == true&&countdoc<=1)
                {
                    errorProvider2.SetError(txtPrice, "Correct");
                    errorProvider1.SetError(txtPrice, "");
                    checkprice = 1;
                }
                else 
                {
                    errorProvider1.SetError(txtPrice, "Wrong format");
                    errorProvider2.SetError(txtPrice, "");
                }
                if (s[s.Length - 1] == '.' || s[s.Length - 1] == ',')
                {
                    errorProvider1.SetError(txtPrice, "Wrong format");
                    errorProvider2.SetError(txtPrice, "");
                }
            }
        }

        private void txtName1_TextChanged(object sender, EventArgs e)
        {
            if (busPro.GetByName(txtName1.Text, dtoPro.Shop.ID) != null && savename != txtName1.Text)
            {
                errorProvider1.SetError(txtName1, "Had name before");
                errorProvider2.SetError(txtName1, "");
            }
            if (txtName1.Text == string.Empty)
            {
                errorProvider1.SetError(txtName1, "Please Enter Name");
                errorProvider2.SetError(txtName1, "");
            }
            else
            {
                errorProvider1.SetError(txtName1, "");
                errorProvider2.SetError(txtName1, "Correct");
                checkname = 1;
            }
        }

        private void cbxType_TextChanged(object sender, EventArgs e)
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
                checktype = 1;
            }
        }
    }
}
