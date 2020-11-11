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
        public DTO_Shop dtoShop { get; set; }
        PictureBox pic;
        Label pricelb;
        Label namelb;
        Button bt;
        DTO_Product dto_pro;
     
        public UserControlProductTab()
        {
            InitializeComponent();
        }

        private void UserControlProductTab_Load(object sender, EventArgs e)
        {
            Reload();
            pictureBox1.BackColor = Color.FromArgb(62,62,66);
        }

        public void Reload()
        {
            this.cboSearch.Text = "";
            flowLayoutPanel1.Controls.Clear();
            GetData(busPro.GetAllProducts(dtoShop.ID));
            this.dataGridView1.DataSource = busPro.GetAllProducts(dtoShop.ID);
            lblLabel.Text = "Total All:";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Reload();
            lblLabel.Text = "Total All:";
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllDrinks(dtoShop.ID);
            flowLayoutPanel1.Controls.Clear();
            GetData(busPro.GetAllDrinks(dtoShop.ID));
            lblLabel.Text = "Total Drink:";
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllFood(dtoShop.ID);
            flowLayoutPanel1.Controls.Clear();
            GetData(busPro.GetAllFood(dtoShop.ID));
            lblLabel.Text = "Total Food:";
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllOtherProducts(dtoShop.ID);
            flowLayoutPanel1.Controls.Clear();
            GetData(busPro.GetAllOtherProducts(dtoShop.ID));
            lblLabel.Text = "Total Others:";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsertProDuct frmInsert = new frmInsertProDuct(this);
            frmInsert.ShowDialog();
            Reload();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DTO_Product dtoPro = new DTO_Product();
            if (dataGridView1.SelectedRows != null && !dataGridView1.Rows[dataGridView1.RowCount - 1].Selected)
            {
                DialogResult ret = MessageBox.Show("Do you want to delete this product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                   // MessageBox.Show(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    dtoPro = busPro.GetById(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dtoShop.ID);
                    busPro.Delete(dtoPro);
                    Reload();
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
                        GetData(busPro.GetProductsSearchIDFiltered(txtSearch.Text,dtoShop.ID));
                        break;
                    case "Name":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchNameFiltered(txtSearch.Text, dtoShop.ID);
                        flowLayoutPanel1.Controls.Clear();
                        GetData(busPro.GetProductsSearchNameFiltered(txtSearch.Text,dtoShop.ID));
                        break;
                    case "Type":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchTypeFiltered(txtSearch.Text, dtoShop.ID);
                        flowLayoutPanel1.Controls.Clear();
                        GetData(busPro.GetProductsSearchTypeFiltered(txtSearch.Text,dtoShop.ID));
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
                                GetData(busPro.GetProductsSearchPriceFiltered(Int32.Parse(txtPriceSearchLower.Text), Int32.Parse(txtPriceSearchUpper.Text),
                                dtoShop.ID));
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
            if (dataGridView1.SelectedRows != null && !dataGridView1.Rows[dataGridView1.RowCount - 1].Selected)
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
        private void GetData(DataTable c)
        {
            dto_pro = new DTO_Product();
            int dem = 0;
            btnImageadd.Tag = "add";
            btnImageadd.Visible = true;
            bt = btnImageadd;
            bt.Width = 146;
            bt.Height = 150;
            flowLayoutPanel1.Controls.Add(bt);
            bt.Click += new EventHandler(ClickCong);

            foreach (DataRow row in c.Rows)
            {
                dem++;
                pic = new PictureBox();
                pricelb = new Label();
                namelb = new Label();
                Label prlabel = new Label();
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                dto_pro = busPro.GetByName(row["Name"].ToString(),1);
                pic.Width = 146;
                pic.Height = 150;
                pic.Image = ImageHelper.ByteArrayToImage(dto_pro.Image);
                pic.Tag = row["Id"];

                pricelb.Text = row["Price"].ToString() +"$";
                pricelb.BackColor = Color.FromArgb(255,121,121);
                pricelb.Width = 20;
                pricelb.TextAlign = ContentAlignment.MiddleRight;
                pricelb.Dock = DockStyle.Bottom;
                pic.BorderStyle = BorderStyle.FixedSingle;
               // pic.Controls.Add(pricelb);
             

                namelb.Text = row["Name"].ToString();
                namelb.BackColor = Color.FromArgb(46, 134, 222);
                namelb.TextAlign = ContentAlignment.MiddleLeft;
                namelb.Dock = DockStyle.Top;
              //  pic.Controls.Add(namelb);
                namelb.Tag = row["Name"].ToString();

                //flowLayoutPanel1.Controls.Add(pic);

                pic.DoubleClick += new EventHandler(OnClick);
                //pic.MouseClic+=
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
                // bt.MouseUp += editToolStripMenuItem;
                //   bt.ContextMenuStrip. += new EventHandler(OnClick);
                //  bt.ContextMenuStrip = contextMenuStrip1;
                //   contextMenuStrip1.Items.Add("solo", null,new EventHandler(OnClick));

                //    MessageBox.Show("111");
                ContextMenuStrip menu = new ContextMenuStrip();
                ContextMenuStrip menuflw = new ContextMenuStrip();
                menu.Items.Add("Delete");
                menuflw.Items.Add("Add");
               // menu.ItemClicked += new ToolStripItemClickedEventHandler(editToolStripMenuItem);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(deleteToolStripMenuItem);
                menuflw.ItemClicked += new ToolStripItemClickedEventHandler(InsertClick);
               // menu.Items[0].MouseDown += new MouseEventHandler(editToolStripMenuItem);
               

              //  menu.Items[1].MouseDown += new MouseEventHandler(deleteToolStripMenuItem);
                bt.ContextMenuStrip = menu;
                flowLayoutPanel1.ContextMenuStrip = menuflw;
                flowLayoutPanel1.Controls.Add(bt);



                //  bt.ContextMenuStrip.Click += editToolStripMenuItem_Click;
                //     bt.ContextMenuStrip.Click+= new EventHandler(editToolStripMenuItem_Click);
                //  bt.ContextMenuStrip.Click+=new EventHandler (editToolStripMenuItem);

                //  MessageBox.Show("222");

                //   bt.ContextMenuStrip.Tag = row["Id"];
                //   bt.Click += new EventHandler(editToolStripMenuItem_Click);
                //  bt.MouseClick += new EventHandler(OnClick);
                //  MessageBox.Show("" + pic.Tag.ToString());
                //  bt.ContextMenuStrip.Click += new EventHandler(OnClick);
                lblSumTotal.Text = ""+dem;
            }
        }
        public void ClickCong(object sender,EventArgs e)
        {
            if (((Button)sender).Tag.ToString() == "add")
            {
                frmInsertProDuct frmInsert = new frmInsertProDuct(this);
                frmInsert.ShowDialog();
                // Reload();
            }
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
            Button btn;
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
                frmEdit.ShowDialog();
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
            }
                
            
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
         //   GetData();
        }
    }
}
