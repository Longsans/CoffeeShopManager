using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class UserControlProductTab : UserControl
    {
        BUS_Product busPro = new BUS_Product(ConnectionStringHelper.GetConnectionString());
        PictureBox pic;
        Label pricelb;
        Label namelb;
        Button bt;
        DTO_Product dto_pro;
        public DTO_Shop dtoShop = new DTO_Shop();
        public UserControlProductTab()
        {
            InitializeComponent();
        }

        private void UserControlProductTab_Load(object sender, EventArgs e)
        {
            Reload();
            GetCong();
            GetData();
            pictureBox1.BackColor = Color.FromArgb(62,62,66);
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lblSumTotal.Left = lblTotal.Right + 5;
            txtSearch.GotFocus += TxtSearch_GotFocus;
            txtSearch.LostFocus += TxtSearch_LostFocus;
        }

        public void Reload()
        {
            this.cboSearch.Text = "";
            flowLayoutPanel1.Controls.Clear();
          //  GetData(busPro.GetAllProducts(dtoShop.ID));
            this.dataGridView1.DataSource = busPro.GetAllProductsWithImages(dtoShop.ID);
            if (lblProducts.Text != "Products")
            {
                dataGridView1.Columns["Name"].HeaderText = "Tên sản phẩm";
                dataGridView1.Columns["Type"].HeaderText = "Loại";
                dataGridView1.Columns["Price"].HeaderText = "Giá";
                dataGridView1.Columns["Image"].HeaderText = "Ảnh";
                lblTotal.Text = "Tất cả:";
            }
            else
            {
                lblTotal.Text = "Total All:";
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                dataGridView1.Columns[i].Width = 50;
            }
            //  dataGridView1.Columns["Image"].Visible = false;
            
        }

        private void TxtSearch_LostFocus(object sender, EventArgs e)
        {
            if (txtSearch.TextLength == 0)
            {
                txtSearch.ForeColor = Color.DimGray;
                if (lblProducts.Text == "Products")
                {
                    txtSearch.Text = "Search...";
                }
                else
                {
                    txtSearch.Text = "Tìm kiếm...";
                }
            }
        }

        private void TxtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.ForeColor == Color.DimGray)
            {
                txtSearch.Clear();
                txtSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Reload();
            GetCong();
            GetData();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllDrinks(dtoShop.ID);
            flowLayoutPanel1.Controls.Clear();
            GetCong();
            GetData();
            if (lblProducts.Text == "Products")
            {
                lblTotal.Text = "Total Drink:";
            }
            else
            {
                lblTotal.Text = "Tất cả thức uống:";
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllFood(dtoShop.ID);
            flowLayoutPanel1.Controls.Clear();
            GetCong();
            GetData();
            if (lblProducts.Text == "Products")
            {
                lblTotal.Text = "Total Food:";
            }
            else
            {
                lblTotal.Text = "Tất cả đồ ăn:";
            }
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllOtherProducts(dtoShop.ID);
            flowLayoutPanel1.Controls.Clear();
            GetCong();
            GetData();
            if (lblProducts.Text == "Products")
            {
                lblTotal.Text = "Total Others:";
            }
            else
            {
                lblTotal.Text = "Tất cả SP khác:";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertProDuct frmInsert = new frmInsertProDuct(this);
            frmInsert.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                DialogResult ret;
                if (btnDelete.Text == "Delete")
                {
                    ret = MessageBox.Show("Do you want to delete this product?", "Delete product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    ret = MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }

                if (ret == DialogResult.Yes)
                {
                   // MessageBox.Show(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    DTO_Product dtoPro = busPro.GetByIdNotDeleted((int)dataGridView1.SelectedRows[0].Cells[0].Value, dtoShop.ID);
                    if (busPro.CheckProductReceiptsExist(dtoPro))
                    {
                        busPro.FalseDelete(dtoPro);
                    }
                    else
                    {
                        busPro.TrueDelete(dtoPro);
                    }
                    Reload();
                    GetCong();
                    GetData();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.ForeColor != Color.DimGray || txtPriceSearchLower.Visible)
                {
                    var resultIndex = cboSearch.FindStringExact(cboSearch.Text);

                    switch (resultIndex)
                    {

                        case 0:
                            if (int.TryParse(txtSearch.Text, out int id))
                            {
                                this.dataGridView1.DataSource = busPro.GetProductsSearchIDFiltered(id, dtoShop.ID);
                            }
                            else
                            {
                                this.dataGridView1.DataSource = busPro.GetProductsSearchIDFiltered(-1, dtoShop.ID);
                            }
                            flowLayoutPanel1.Controls.Clear();
                            GetData();
                            break;
                        case 1:
                            this.dataGridView1.DataSource = busPro.GetProductsSearchNameFiltered(txtSearch.Text, dtoShop.ID);
                            flowLayoutPanel1.Controls.Clear();
                            GetData();
                            break;
                        case 2:
                            this.dataGridView1.DataSource = busPro.GetProductsSearchTypeFiltered(txtSearch.Text, dtoShop.ID);
                            flowLayoutPanel1.Controls.Clear();
                            GetData();
                            break;
                        case 3:
                            if (int.Parse(txtPriceSearchLower.Text) > 0 && int.Parse(txtPriceSearchUpper.Text) > 0)
                            {
                                if (int.Parse(txtPriceSearchLower.Text) <= int.Parse(txtPriceSearchUpper.Text))
                                {
                                    this.dataGridView1.DataSource = busPro.GetProductsSearchPriceFiltered(
                                    Int32.Parse(txtPriceSearchLower.Text), Int32.Parse(txtPriceSearchUpper.Text),
                                    dtoShop.ID);
                                    flowLayoutPanel1.Controls.Clear();
                                    GetData();
                                }
                                else
                                {
                                    throw new Exception("Upper bound value must be greater than lower bound value.");
                                }
                            }
                            else
                            {
                                throw new Exception("Money value must be positive.");
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            var resultIndex = cboSearch.FindStringExact(cboSearch.Text);

            if (resultIndex==3)
            {
                txtSearch.Visible = false;
                txtPriceSearchLower.Visible = true;
                txtPriceSearchUpper.Visible = true;
                label2.Visible = true;
            }
            else
            {
                txtSearch.Visible = true;
                txtPriceSearchLower.Visible = false;
                txtPriceSearchUpper.Visible = false;
                label2.Visible = false;
            }

            txtSearch.Text = "Search...";
            txtSearch.ForeColor = Color.DimGray;
            txtPriceSearchLower.Clear();
            txtPriceSearchUpper.Clear();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            //e.RowIndex != dataGridView1.Rows.Count - 1
            if (dataGridView1.SelectedRows != null )
            {
               frmEditProduct frmEdit = new frmEditProduct(this)
                {
                    dtoPro = busPro.GetByIdNotDeleted((int)dataGridView1.SelectedRows[0].Cells[0].Value, dtoShop.ID)
                };
                frmEdit.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }
        public void GetCong()
        {
            btnImageadd.Tag = "add";
            btnImageadd.Visible = true;
            // bt = btnImageadd;
            btnImageadd.Width = 146;
            btnImageadd.Height = 150;
            flowLayoutPanel1.Controls.Add(btnImageadd);
        }
        public void GetData()
        {
            dto_pro = new DTO_Product();
            int dem = 0;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                dem++;
                pic = new PictureBox();
                pricelb = new Label();
                namelb = new Label();
                Label prlabel = new Label();
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                dto_pro = busPro.GetByIdNotDeleted((int)row.Cells[0].Value, dtoShop.ID);
                pic.Width = 146;
                pic.Height = 150;
                pic.Image = ImageHelper.ByteArrayToImage(dto_pro.Image);
                pic.Tag = row.Cells[0].Value.ToString();

                pricelb.Text = row.Cells[3].Value.ToString() +"$";
                pricelb.BackColor = Color.FromArgb(255,121,121);
                pricelb.Width = 20;
                pricelb.TextAlign = ContentAlignment.MiddleRight;
                pricelb.Dock = DockStyle.Bottom;
                pic.BorderStyle = BorderStyle.FixedSingle;


                namelb.Text = row.Cells[1].Value.ToString();
                namelb.BackColor = Color.FromArgb(46, 134, 222);
                namelb.TextAlign = ContentAlignment.MiddleLeft;
                namelb.Dock = DockStyle.Top;
 
                namelb.Tag = row.Cells[1].Value.ToString();



               // pic.DoubleClick += new EventHandler(OnClick);

                bt = new Button();
                bt.Tag = pic.Tag;
                bt.BackgroundImage = pic.Image;
                bt.BackgroundImageLayout = ImageLayout.Stretch;
                bt.Width = 146;
                bt.Height = 150;
                bt.Controls.Add(namelb);
                bt.Controls.Add(pricelb);
                flowLayoutPanel1.Controls.Add(bt);
                bt.Click += new EventHandler(OnClick);

                ContextMenuStrip menu = new ContextMenuStrip();
                ContextMenuStrip menuflw = new ContextMenuStrip();
                menu.Items.Add("Delete");
                menuflw.Items.Add("Add");

                menu.ItemClicked += new ToolStripItemClickedEventHandler(deleteToolStripMenuItem);
                menuflw.ItemClicked += new ToolStripItemClickedEventHandler(InsertClick);

              

                bt.ContextMenuStrip = menu;
                flowLayoutPanel1.ContextMenuStrip = menuflw;
                flowLayoutPanel1.Controls.Add(bt);
            }
            lblSumTotal.Text = dem.ToString();
        }
        //public void ClickCong(object sender,EventArgs e)
        //{
            /*if (((Button)sender).Tag.ToString() == "add")
            {
                frmInsertProDuct frmInsert = new frmInsertProDuct(this);
                frmInsert.ShowDialog();
                Reload();
                GetCong();
                GetData();
            }*/
       // }
       public void ClickAdd(object sender, EventArgs e)
        {
            frmInsertProDuct frmInsert1 = new frmInsertProDuct(this);
            frmInsert1.ShowDialog();
            frmInsert1.Close();
        }
        public void OnClick(object sender,EventArgs e)
        {
            //Button clickedButton = (Button)sender;
            //Process.Start((string)clickedButton.Tag);
            //MessageBox.Show(clickedButton.Tag.ToString());
            // MessageBox.Show(""+1);
            //   if (dataGridView1.SelectedRows != null && !dataGridView1.Rows[dataGridView1.RowCount - 1].Selected)
            //   {
            //textBox1.Text = ((Button)sender).Tag.ToString();
            // MessageBox.Show(textBox1.Text);

                frmEditProduct frmEdit = new frmEditProduct(this)
                {
                    // dtoPro = busPro.GetByName(namelb.Text)
                    dtoPro = busPro.GetByIdNotDeleted(Convert.ToInt32(((Button)sender).Tag), dtoShop.ID)
                };
                frmEdit.ShowDialog();
          //  }
        }
        private void InsertClick(object sender, EventArgs e)
        {
            frmInsertProDuct frmInsert = new frmInsertProDuct(this);
            frmInsert.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            flowLayoutPanel1.Visible = false;
            btnDelete.Visible = true;
            btnEdit.Visible = true;
            pictureBox1.BackColor = Color.FromArgb(62,62,66);
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            flowLayoutPanel1.Visible = true;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            pictureBox2.BackColor = Color.FromArgb(62,62,66);
            pictureBox1.BackColor = Color.Transparent;
        }

        private void editToolStripMenuItem(object sender, EventArgs e)
        {
            //   Reload();
            // GetData();

            //Button btn;
            /*  foreach (Control item in flowLayoutPanel1.Controls)
              {
                  if (item.Controls == null) { continue; }
                  bt = (sender as ContextMenuStrip).SourceControl as Button;
                  /*if (string.IsNullOrEmpty(btn.Text.Trim()))
                       {
                       frmEditProduct frmEdit = new frmEditProduct(this);
                           frmEdit.ShowDialog();

                          // btn.Text = frmEdit.TextInfo;
                           btn.Tag = 0;
                       }
                   }*/

            //   }
            // textBox1.Text = ((ToolStripButton)sender).Tag.ToString();

            frmEditProduct frmEdit = new frmEditProduct(this)
            {
                    // dtoPro = busPro.GetByName(namelb.Text)
                       dtoPro = busPro.GetByIdNotDeleted(Convert.ToInt32(((sender as ContextMenuStrip).SourceControl as Button).Tag), dtoShop.ID)
            // dtoPro = busPro.GetById(((Button)sender).Tag.ToString(), 1)

                 
            };
               // frmEdit.ShowDialog();
            // OnClick(sender, e);
        }


        private void deleteToolStripMenuItem(object sender, EventArgs e)
        {
            DTO_Product dtoPro = new DTO_Product();
            
                DialogResult ret = MessageBox.Show("Do you want to delete this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // MessageBox.Show(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            if (ret == DialogResult.Yes)
            {
                dtoPro = busPro.GetByIdNotDeleted(Convert.ToInt32(((sender as ContextMenuStrip).SourceControl as Button).Tag), dtoShop.ID);

                busPro.FalseDelete(dtoPro);
                Reload();
                GetCong();
                GetData();

            }


        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
         //   GetData();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnImageadd_Click(object sender, EventArgs e)
        {

            frmInsertProDuct frmInsert = new frmInsertProDuct(this);
            frmInsert.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.ForeColor != Color.DimGray)
                {
                    var resultIndex = cboSearch.FindStringExact(cboSearch.Text);

                    switch (resultIndex)
                    {

                        case 0:
                            if (int.TryParse(txtSearch.Text, out int id))
                            {
                                this.dataGridView1.DataSource = busPro.GetProductsSearchIDFiltered(id, dtoShop.ID);
                            }
                            else
                            {
                                this.dataGridView1.DataSource = busPro.GetProductsSearchIDFiltered(-1, dtoShop.ID);
                            }
                            flowLayoutPanel1.Controls.Clear();
                            GetData();
                            break;
                        case 1:
                            this.dataGridView1.DataSource = busPro.GetProductsSearchNameFiltered(txtSearch.Text, dtoShop.ID);
                            flowLayoutPanel1.Controls.Clear();
                            GetData();
                            break;
                        case 2:
                            this.dataGridView1.DataSource = busPro.GetProductsSearchTypeFiltered(txtSearch.Text, dtoShop.ID);
                            flowLayoutPanel1.Controls.Clear();
                            GetData();
                            break;
                        case 3:
                            if (int.Parse(txtPriceSearchLower.Text) > 0 && int.Parse(txtPriceSearchUpper.Text) > 0)
                            {
                                if (int.Parse(txtPriceSearchLower.Text) <= int.Parse(txtPriceSearchUpper.Text))
                                {
                                    this.dataGridView1.DataSource = busPro.GetProductsSearchPriceFiltered(
                                    Int32.Parse(txtPriceSearchLower.Text), Int32.Parse(txtPriceSearchUpper.Text),
                                    dtoShop.ID);
                                    flowLayoutPanel1.Controls.Clear();
                                    GetData();
                                }
                                else
                                {
                                    throw new Exception("Upper bound value must be greater than lower bound value.");
                                }
                            }
                            else
                            {
                                throw new Exception("Money value must be positive.");
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTotal_SizeChanged(object sender, EventArgs e)
        {
            lblSumTotal.Left = lblTotal.Right + 5;
        }
    }
}
