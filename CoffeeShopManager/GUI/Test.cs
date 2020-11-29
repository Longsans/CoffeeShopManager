using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class Test : Form
    {
        DTO_ReceiptDetails dtoDetail = new DTO_ReceiptDetails();
        List<string> strSave = new List<string>();
        List<DTO_Table> lsTable = new List<DTO_Table>();
        BUS_Product busPro = new BUS_Product();
        BUS_Tables busTable = new BUS_Tables();
        BUS_Receipts busReceipt = new BUS_Receipts();
        BUS_Customers busCus = new BUS_Customers();
        DTO_Receipt dtoReceipt = new DTO_Receipt();
        DTO_Customer dtoCus = new DTO_Customer();
        DTO_Product dto_pro;
        PictureBox pic;
        Label pricelb;
        Label namelb;
        Button bt;
        DataRow[] RowSave;
        DataGridViewRow r1;
        int abc = 0;
        DataTable a, b, c,T;
        DTO_Shop dtoShop = new DTO_Shop();
        
        public Test()
        {
            InitializeComponent();
        }
        public void Reload()
        {

            flowLayoutPanel1.Controls.Clear();
            //  GetData(busPro.GetAllProducts(dtoShop.ID));
            //  dataGridView1.Columns["Image"].Visible = false;
        }
       public int cur = 0;
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void GetData(DataTable table)
        {

            dto_pro = new DTO_Product();
            foreach (DataRow row in table.Rows)
            {
                pic = new PictureBox();
                pricelb = new Label();
                namelb = new Label();
                Label prlabel = new Label();
                /* pic.BackgroundImageLayout = ImageLayout.Stretch;
                 pic.SizeMode = PictureBoxSizeMode.StretchImage;
                 dto_pro = busPro.GetById(row["Id"].ToString(), 1);
                 pic.Width = 146;
                 pic.Height = 150;
                 pic.Image = ImageHelper.ByteArrayToImage(dto_pro.Image);
                 pic.Tag = row["Id"];*/
                dto_pro = busPro.GetById(row["Id"].ToString(), 1);

                pricelb.Text = row["Price"].ToString() + "$";
                pricelb.BackColor = Color.FromArgb(255, 121, 121);
                pricelb.Width = 20;
                pricelb.TextAlign = ContentAlignment.MiddleRight;
                pricelb.Dock = DockStyle.Bottom;
                pic.BorderStyle = BorderStyle.FixedSingle;


                namelb.Text = row["Name"].ToString();
                namelb.BackColor = Color.FromArgb(46, 134, 222);
                namelb.TextAlign = ContentAlignment.MiddleLeft;
                namelb.Dock = DockStyle.Top;

                namelb.Tag = row["Name"].ToString();



                // pic.DoubleClick += new EventHandler(OnClick);
                bt = new Button();
                bt.Tag = row["Name"].ToString()+"/"+ row["Price"].ToString() + ""; ;
                bt.Name = row["Id"].ToString();
                bt.BackgroundImage = ImageHelper.ByteArrayToImage(dto_pro.Image);
                bt.BackgroundImageLayout = ImageLayout.Stretch;
                bt.Width = 146;
                bt.Height = 150;
                bt.Controls.Add(namelb);
                bt.Controls.Add(pricelb);
                flowLayoutPanel1.Controls.Add(bt);
                bt.Click += (s, e) =>
                {
                    // if(cur!=1)
                    OnClick(s,e);
                };
                
            }
        }

        public void OnClick(object sender, EventArgs e)
        {
            // ((Button)sender).Enabled = false;
            string s = ((Button)sender).Tag.ToString();
            string[] arrListStr = s.Split('/');
            Image image= ((Button)sender).Image;


            foreach (var a in strSave)
            {
                if (arrListStr[0] == a)
                {
                    // bt.Image = DenTrang(bt.Image);
                    ((Button)sender).Text = "X";
                    MessageBox.Show("You have clicked before");
                   
                    return;
                }
            }
          

                r1 = (DataGridViewRow)dataGridView1.Rows[0].Clone();
              //  MessageBox.Show(arrListStr[0] + "-0-" + arrListStr[1]);
                r1.Cells[0].Value = arrListStr[0].ToString();
                r1.Cells[2].Value = "1";
                int vitri = 0;
                vitri = arrListStr[1].IndexOf(".");
                r1.Cells[4].Value = arrListStr[1].Substring(0, vitri).ToString();
            r1.Cells[6].Value = ((Button)sender).Name.ToString();
                dataGridView1.Rows.Add(r1);
            // ((Button)sender).Text = "done";
                strSave.Add(arrListStr[0]);
                ((Button)sender).Text = "X";

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {
            dtoShop.ID = 1;
            Reload();
            T = busPro.GetAllProductsWithImages(1);
            GetData(T);
             a = busPro.GetAllFood(1);
             b = busPro.GetAllDrinks(1);
             c = busPro.GetAllOtherProducts(1);
            lsTable = busTable.GetAvailableTables(1);
            for(int i=0;i<lsTable.Count;i++)
            {
                comboBox2.Items.Add(lsTable[i].Id.ToString());
            }
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Timer t1 = new Timer();
            t1.Interval = 1000;
            t1.Enabled = true;
            t1.Tick += Timer_Click;
            txtID.Enabled = false;
            txtFirstName.Enabled = false ;
            txtLastName.Enabled =false;
          //  dtoCus = busCus.GetCustomerByEmail(txtEmail.Text, 1);

        }
        public double sum = 0;
        public void ResetCus()
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDayBD.Text = "";
            txtMonthBD.Text = "";
            txtYearBD.Text = "";
        }
        public void Timer_Click(object sender, EventArgs e)
        {
            sum = 0;

            if (dataGridView1.Rows.Count>1)
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                      sum += Int32.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
               // if (i < dataGridView1.Rows.Count - 1)
                   // itemcode += ", ";
            }
            lblTotalSum.Text = sum.ToString();
            if(txtDiscount.Text!=""&&IsNumber(txtDiscount.Text))
            {
                sum = sum-sum*(double.Parse(txtDiscount.Text))/100;
                lblGrandTotal.Text = sum.ToString();
            }
            lblGrandTotal.Text = sum.ToString();
            if (busCus.GetCustomerByEmail(txtEmail.Text.ToString(), 1) == null)
            {
                errorProvider1.SetError(txtEmail, "Doesn't have customer này, vui lòng nhập thông tin");
                errorProvider2.SetError(txtEmail, "");
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                btnAddCus.Visible = true;
                txtDayBD.Enabled = true;
                txtMonthBD.Enabled = true;
                txtYearBD.Enabled = true;
                txtID.Visible = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
                errorProvider2.SetError(txtEmail, "Correct");
                txtID.Enabled = false;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                dtoCus = busCus.GetCustomerByEmail(txtEmail.Text, 1);
                txtID.Text = dtoCus.Id.ToString();
                txtFirstName.Text = dtoCus.FirstName;
                txtLastName.Text = dtoCus.LastName;
                txtDayBD.Text = dtoCus.Birthdate.Day.ToString();
                txtMonthBD.Text = dtoCus.Birthdate.Month.ToString();
                txtYearBD.Text = dtoCus.Birthdate.Year.ToString();
                btnAddCus.Visible = false;
                txtDayBD.Enabled = false;
                txtMonthBD.Enabled = false;
                txtYearBD.Enabled = false;
                txtID.Visible = true;
            }

        }
        public int bien = 0;
        public double giatri = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  MessageBox.Show("-"+dataGridView1.Columns[e.ColumnIndex].Name.ToString());
                r1 = new DataGridViewRow();
                if (dataGridView1.Columns[e.ColumnIndex].Name.ToString() == "clmDown")
                {
                    r1 = dataGridView1.Rows[e.RowIndex];
                    if (r1.Cells[2].Value.ToString() != "0")
                    {
                        r1.Cells[2].Value = (Int32.Parse(r1.Cells[2].Value.ToString()) - 1);
                        bien = (Int32.Parse(r1.Cells[2].Value.ToString()));

                        giatri = float.Parse(r1.Cells[4].Value.ToString()) / (bien + 1);
                        r1.Cells[4].Value = giatri * bien;
                    }
                    if (r1.Cells[2].Value.ToString() == "0")
                    {
                        for(int i=0;i<strSave.Count;i++)
                        {
                            if (strSave[i] == r1.Cells[0].Value.ToString())
                            {
                                strSave.RemoveAt(i);
                            }
                        }
                        dataGridView1.Rows.RemoveAt(r1.Index);
                    }

                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name.ToString() == "clmUp")
                {
                    r1 = dataGridView1.Rows[e.RowIndex];
                    r1.Cells[2].Value = (Int32.Parse(r1.Cells[2].Value.ToString()) + 1);
                    bien = (Int32.Parse(r1.Cells[2].Value.ToString()));
                    //  MessageBox.Show(""+ Int32.Parse(r1.Cells[4].Value.ToString()));
                    giatri = float.Parse(r1.Cells[4].Value.ToString()) / (bien - 1);
                    r1.Cells[4].Value = giatri * bien;
                    //  MessageBox.Show(row.Cells[2].Value.ToString());
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name.ToString() == "clmDelete")
                {
                    for (int i = 0; i < strSave.Count; i++)
                    {
                        if (strSave[i] == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
                        {
                            strSave.RemoveAt(dataGridView1.Rows[e.RowIndex].Index);
                        break;
                        }
                    }
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows[e.RowIndex].Index);
                }    
        }
        public Bitmap DenTrang(Image anh)
        {
            Bitmap kq = new Bitmap(anh.Width, anh.Height);
            Bitmap anhtam = new Bitmap(anh);
            Color c;
            Byte rgb;
            for (int cot = 0; cot < anhtam.Width; cot++)
                for (int hang = 0; hang < anhtam.Height; hang++)
                {
                    c = anhtam.GetPixel(cot, hang);
                    rgb = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);
                    kq.SetPixel(cot, hang, Color.FromArgb(rgb, rgb, rgb));
                }
            return kq;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            lblSelect.Visible = false;
            Refresh();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //Image SomeImage = Image.FromFile("icon8_delete_bin_16.png");
            //I supposed your button column is at index 0
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                //var w = Properties.Resources.icons8_delete_bin_16.Width;
                var w = Properties.Resources.grid_view_24px.Width;
               // var h = Properties.Resources.icons8_delete_bin_16.Height;
                var h = Properties.Resources.grid_view_24px.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.grid_view_24px, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void lblTotalSum_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 1)
            {
                MessageBox.Show("Chua order mon");
                return;
            }
          //  if (busCus.GetCustomerByEmail(txtEmail.Text, dtoShop.ID) == null)
          //  {
                if (txtEmail.Text == ""||txtFirstName.Text==""||txtLastName.Text==""||txtDayBD.Text==""||txtMonthBD.Text==""||txtYearBD.Text=="")
                {
                    MessageBox.Show("Nhap day du thong tin customer");
                    return;
                }
            //}
            DateTime now = DateTime.Now;
            dtoReceipt.Customer = dtoCus;
            dtoReceipt.DateOfPayMent = now;
            dtoReceipt.Total = Int32.Parse(lblGrandTotal.Text);
            dtoReceipt.Details = "";
            dtoReceipt.Shop.ID = 1;
            //  dataGridView1.Rows[i].Cells[4].Value.ToString()
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dtoDetail = new DTO_ReceiptDetails();//cai nay a

                dto_pro = new DTO_Product
                {
                    Id = dataGridView1.Rows[i].Cells[6].Value.ToString()
                };
                dtoDetail.Product = dto_pro;
                //dtoDetail.Product.Id = dto_pro.Id;
                dtoDetail.Quantity = Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                dtoDetail.TotalPrice = decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                MessageBox.Show(dtoDetail.TotalPrice.ToString());
                dtoReceipt.Items.Add(dtoDetail);
            }
            busReceipt.InsertTakeAwayReceipt(dtoReceipt);
        }
        //ddinh lam chi 
        private void btnAddCus_Click(object sender, EventArgs e)
        {
            string[] formats = { "dd/MM/yyyy", "d/M/yyyy" };
            DateTime bdate = new DateTime();
            dtoCus.Email = txtEmail.Text;
            dtoCus.Id = Int32.Parse(txtID.Text);
            dtoCus.FirstName = txtFirstName.Text;
            dtoCus.LastName = txtLastName.Text;
            if (DateTime.TryParseExact(txtDayBD.Text + "/" + txtMonthBD.Text + "/" + txtYearBD.Text,
                     formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out bdate))
            {
                dtoCus.Birthdate = new DateTime(bdate.Year, bdate.Month, bdate.Day);
            }
            dtoCus.ShopID = dtoShop.ID;
            busCus.Insert(dtoCus);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            
        }
        public void ResetAll()
        {
            MessageBox.Show(dataGridView1.Rows.Count.ToString());
            int to = dataGridView1.Rows.Count;
            for(int i=0;i<to-1;i++)
            {

                dataGridView1.Rows.RemoveAt(0);
            }
            strSave.Clear();
            ResetCus();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Test_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                lblSelect.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                GetData(busPro.GetProductsSearchNameFiltered(txtSearchName.Text, 1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resultIndex = -1;
            resultIndex=comboBox1.FindStringExact(comboBox1.Text);
            if(resultIndex==1)
            {
                flowLayoutPanel1.Controls.Clear();
                GetData(a);
            }
            else if (resultIndex == 2)
            {
                flowLayoutPanel1.Controls.Clear();
                GetData(b);
            }
            else if (resultIndex == 3)
            {
                flowLayoutPanel1.Controls.Clear();
                GetData(c);
            }
            else if (resultIndex == 0)
            {
                flowLayoutPanel1.Controls.Clear();
                GetData(T);
            }
        }
    }
}
