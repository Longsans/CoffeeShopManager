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
        BUS_Product busPro = new BUS_Product();
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
        }
        public void Reload2()
        {
            this.cboSearch.Text = "";
            this.dataGridView1.DataSource = busPro.GetAllProductsWithImages(dtoShop.ID);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                dataGridView1.Columns[i].Width = 50;
            }
            //  dataGridView1.Columns["Image"].Visible = false;
            lblLabel.Text = "Total All:";
        }
        public void Reload()
        {
            this.cboSearch.Text = "";
            flowLayoutPanel1.Controls.Clear();
          //  GetData(busPro.GetAllProducts(dtoShop.ID));
            this.dataGridView1.DataSource = busPro.GetAllProductsWithImages(dtoShop.ID);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                dataGridView1.Columns[i].Width = 50;
            }
            //  dataGridView1.Columns["Image"].Visible = false;
            lblLabel.Text = "Total All:";
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
            lblLabel.Text = "Total Drink:";
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllFood(dtoShop.ID);
            flowLayoutPanel1.Controls.Clear();
            GetCong();
            GetData();
            lblLabel.Text = "Total Food:";
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllOtherProducts(dtoShop.ID);
            flowLayoutPanel1.Controls.Clear();
            GetCong();
            GetData();
            lblLabel.Text = "Total Others:";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertProDuct frmInsert = new frmInsertProDuct(this);
            frmInsert.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DTO_Product dtoPro = new DTO_Product();
            if (dataGridView1.SelectedRows != null)
            {
                DialogResult ret = MessageBox.Show("Do you want to delete this product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                   // MessageBox.Show(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    dtoPro = busPro.GetById(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dtoShop.ID);
                    busPro.Delete(dtoPro);
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
                switch (cboSearch.Text)
                {

                    case "ID":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchIDFiltered(txtSearch.Text, dtoShop.ID);
                        flowLayoutPanel1.Controls.Clear();
                        GetData();
                        break;
                    case "Name":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchNameFiltered(txtSearch.Text, dtoShop.ID);
                        flowLayoutPanel1.Controls.Clear();
                        GetData();
                        break;
                    case "Type":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchTypeFiltered(txtSearch.Text, dtoShop.ID);
                        flowLayoutPanel1.Controls.Clear();
                        GetData();
                        break;
                    case "Price":
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSearch.SelectedItem.ToString() == "Price")
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

            txtSearch.Clear();
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
                    dtoPro = busPro.GetById(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dtoShop.ID)
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
                dto_pro = busPro.GetById(row.Cells[0].Value.ToString(), dtoShop.ID);
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
                lblSumTotal.Text = ""+dem;
            }
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
                    dtoPro = busPro.GetById(((Button)sender).Tag.ToString(), dtoShop.ID)
                };
                frmEdit.ShowDialog();
          //  }
        }
        private void InsertClick(object sender, EventArgs e)
        {
            frmInsertProDuct frmInsert = new frmInsertProDuct(this);
            frmInsert.ShowDialog();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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

              MessageBox.Show("1234" + lblSumTotal.Text);
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
                       dtoPro = busPro.GetById(((sender as ContextMenuStrip).SourceControl as Button).Tag.ToString(), dtoShop.ID)
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
                dtoPro = busPro.GetById(((sender as ContextMenuStrip).SourceControl as Button).Tag.ToString(), dtoShop.ID);

                busPro.Delete(dtoPro);
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
                switch (cboSearch.Text)
                {

                    case "ID":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchIDFiltered(txtSearch.Text, dtoShop.ID);
                        flowLayoutPanel1.Controls.Clear();
                        GetData();
                        break;
                    case "Name":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchNameFiltered(txtSearch.Text, dtoShop.ID);
                        flowLayoutPanel1.Controls.Clear();
                        GetData();
                        break;
                    case "Type":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchTypeFiltered(txtSearch.Text, dtoShop.ID);
                        flowLayoutPanel1.Controls.Clear();
                        GetData();
                        break;
                    case "Price":
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
