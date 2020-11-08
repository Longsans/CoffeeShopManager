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
        }

        public void Reload()
        {
            this.cboSearch.Text = "";
            this.dataGridView1.DataSource = busPro.GetAllProducts();
            flowLayoutPanel1.Controls.Clear();
            GetData();
            this.dataGridView1.DataSource = busPro.GetAllProducts(dtoShop.ID);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            Reload();
            GetData();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllDrinks(dtoShop.ID);
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllFood(dtoShop.ID);
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = busPro.GetAllOtherProducts(dtoShop.ID);
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
                        break;
                    case "Name":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchNameFiltered(txtSearch.Text, dtoShop.ID);
                        break;
                    case "Type":
                        this.dataGridView1.DataSource = busPro.GetProductsSearchTypeFiltered(txtSearch.Text, dtoShop.ID);
                        break;
                    case "Price":
                        if (int.Parse(txtPriceSearchLower.Text) > 0 && int.Parse(txtPriceSearchUpper.Text) > 0)
                        {
                            if (int.Parse(txtPriceSearchLower.Text) <= int.Parse(txtPriceSearchUpper.Text))
                            {
                                this.dataGridView1.DataSource = busPro.GetProductsSearchPriceFiltered(
                                Int32.Parse(txtPriceSearchLower.Text), Int32.Parse(txtPriceSearchUpper.Text),
                                dtoShop.ID);
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
        private void GetData()
        {
            dto_pro = new DTO_Product();
            foreach(DataRow row in busPro.GetAllProducts().Rows)
            {
              //  MessageBox.Show("1" + row["Name"].ToString());
                pic = new PictureBox();
                pricelb = new Label();
                namelb = new Label();
                Label prlabel = new Label();
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                dto_pro = busPro.GetByName(row["Name"].ToString());
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
                bt.ContextMenuStrip = contextMenuStrip1;
             //   bt.ContextMenuStrip.Tag = row["Id"];
               //   bt.Click += new EventHandler(editToolStripMenuItem_Click);
              //  bt.MouseClick += new EventHandler(OnClick);
            }
        }
        public void OnClick(object sender,EventArgs e)
        {
            //Button clickedButton = (Button)sender;
            //Process.Start((string)clickedButton.Tag);
            //MessageBox.Show(clickedButton.Tag.ToString());
            //MessageBox.Show(((PictureBox)sender).Tag.ToString());
            if (dataGridView1.SelectedRows != null && !dataGridView1.Rows[dataGridView1.RowCount - 1].Selected)
            {
                frmEditProduct frmEdit = new frmEditProduct(this)
                {
                   // dtoPro = busPro.GetByName(namelb.Text)
                    dtoPro=busPro.GetById((int)((Button)sender).Tag)
                };
                frmEdit.ShowDialog();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            flowLayoutPanel1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            flowLayoutPanel1.Visible = true;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reload();
            frmEditProduct frmEdit = new frmEditProduct(this)
            {
                // dtoPro = busPro.GetByName(namelb.Text)
                dtoPro = busPro.GetById((int)((ContextMenuStrip)sender).Tag)

            };
            frmEdit.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DTO_Product dtoPro = new DTO_Product();
            if (dataGridView1.SelectedRows != null && !dataGridView1.Rows[dataGridView1.RowCount - 1].Selected)
            {
                DialogResult ret = MessageBox.Show("Do you want to delete this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                    // MessageBox.Show(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    dtoPro = busPro.GetById((int)((Button)sender).Tag);
                    busPro.Delete(dtoPro);
                    Reload();
                }
            }
        }
    }
}
