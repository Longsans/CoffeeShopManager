using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Globalization;

namespace GUI
{
    public partial class UserControlOrderProduct : UserControl
    {
        DTO_ReceiptDetails dtoDetail = new DTO_ReceiptDetails();
        List<string> strSave = new List<string>();
        List<DTO_Table> lsTable = new List<DTO_Table>();
        BUS_Product busPro = new BUS_Product(ConnectionStringHelper.GetConnectionString());
        BUS_Tables busTable = new BUS_Tables(ConnectionStringHelper.GetConnectionString());
        BUS_Receipts busReceipt = new BUS_Receipts(ConnectionStringHelper.GetConnectionString());
        BUS_Customers busCus = new BUS_Customers(ConnectionStringHelper.GetConnectionString());
        BUS_Shop busShop = new BUS_Shop(ConnectionStringHelper.GetConnectionString());
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
        DataTable a = new DataTable();
        DataTable b = new DataTable();
        DataTable c = new DataTable();
        DataTable T = new DataTable();
        public DTO_Shop dtoShop = new DTO_Shop();
        public DTO_Employee dtoEmp = new DTO_Employee();
        int shopID;
        int checkemail, checkbirth, checkmonecus;
        public bool isOrderAtTable = false;
        public bool closeFormOrderAtTable = false;
        public UserControlOrderProduct()
        {
            InitializeComponent();
        }
        public void Reload()
        {
            flowLayoutPanel1.Controls.Clear();
            T = busPro.GetAllProductsWithImages(shopID);
            GetData(T);
            a = busPro.GetAllFood(shopID);
            b = busPro.GetAllDrinks(shopID);
            c = busPro.GetAllOtherProducts(shopID);
            ReloadTable();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public int cur = 0;
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c) && c != '.' && c != ',')
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
                dto_pro = busPro.GetByIdNotDeleted((int)row["Id"], shopID);
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
                bt = new Button();
                bt.Tag = row["Name"].ToString() + "/" + row["Price"].ToString() + ""; ;
                bt.Name = row["Id"].ToString();
                bt.BackgroundImage = ImageHelper.ByteArrayToImage(dto_pro.Image);
                bt.BackgroundImageLayout = ImageLayout.Stretch;
                bt.Width = 170;
                bt.Height = 160;
                bt.Controls.Add(namelb);
                bt.Controls.Add(pricelb);
                flowLayoutPanel1.Controls.Add(bt);
                bt.Click += (s, e) =>
                {
                    OnClick(s, e);
                };

            }
        }
        public void OnClick(object sender, EventArgs e)
        {
            // ((Button)sender).Enabled = false;
            string s = ((Button)sender).Tag.ToString();
            string[] arrListStr = s.Split('/');
            Image image = ((Button)sender).Image;
            foreach (var a in strSave)
            {
                if (arrListStr[0] == a)
                {
                    ((Button)sender).Text = "X";
                    if(lblTable.Text=="Bàn")
                        MessageBox.Show("Bạn đã click vào sản phẩm từ trước","Bàn",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("You have clicked before", "Bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
            }
            r1 = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            r1.Cells[0].Value = arrListStr[0].ToString();
            r1.Cells[2].Value = "1";
            r1.Cells[4].Value = arrListStr[1].ToString();
            r1.Cells[6].Value = ((Button)sender).Name.ToString();
            dataGridView1.Rows.Add(r1);
            strSave.Add(arrListStr[0]);
        }
        private void UserControlOrderProduct_Load(object sender, EventArgs e)
        {
            cboCustomerType.SelectedIndex = 0;
            datBirthdate.Format = DateTimePickerFormat.Custom;
            datBirthdate.CustomFormat = "dd/MM/yyyy";
            if (lblHead.Text == "Đặt món")
            {
                comboBox1.Text = "Chọn loại sản phẩm";
            }
            else
            {
                comboBox1.Text = "Select type of products";
            }
            HideCus();
            lblNoneName.Visible = true;
            Timer t1 = new Timer();
            t1.Interval = 1000;
            t1.Enabled = true;
            t1.Tick += Timer_Click;
            txtID.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
        }

        public int bien = 0;
        public double giatri = 0;
        public void ResetCus()
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtID.Text = "";
            datBirthdate.Value = DateTime.Now;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                GetData(busPro.GetProductsSearchNameFiltered(txtSearchName.Text, shopID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.ToString() == "clmDown" && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                r1 = dataGridView1.Rows[e.RowIndex];
                if (r1.Cells[2].Value.ToString() != "0")
                {
                    r1.Cells[2].Value = (decimal.Parse(r1.Cells[2].Value.ToString()) - 1);
                    bien = (Int32.Parse(r1.Cells[2].Value.ToString()));

                    var giatri = decimal.Parse(r1.Cells[4].Value.ToString()) / (bien + 1);
                    r1.Cells[4].Value = giatri * bien;
                }
                if (r1.Cells[2].Value.ToString() == "0")
                {
                    for (int i = 0; i < strSave.Count; i++)
                    {
                        if (strSave[i] == r1.Cells[0].Value.ToString())
                        {
                            strSave.RemoveAt(i);
                        }
                    }
                    dataGridView1.Rows.RemoveAt(r1.Index);
                }

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name.ToString() == "clmUp" && e.RowIndex != dataGridView1.Rows.Count - 1)
            {
                r1 = dataGridView1.Rows[e.RowIndex];
                r1.Cells[2].Value = (decimal.Parse(r1.Cells[2].Value.ToString()) + 1);
                bien = (Int32.Parse(r1.Cells[2].Value.ToString()));
                var giatri = decimal.Parse(r1.Cells[4].Value.ToString()) / (bien - 1);
                r1.Cells[4].Value = giatri * bien;
            }

            else if (dataGridView1.Columns[e.ColumnIndex].Name.ToString() == "clmDelete" && e.RowIndex != dataGridView1.Rows.Count - 1)
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

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.close_window_24px1.Width;
                var h = Properties.Resources.close_window_24px1.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.close_window_24px1, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                dtoReceipt = new DTO_Receipt();
                if (dataGridView1.Rows.Count <= 1)
                {
                    if(lblTable.Text=="Bàn")
                        MessageBox.Show("Chưa đặt hàng","Đặt món",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Haven't order yet", "Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (cboCustomerType.SelectedIndex == 0)
                {
                    if (busCus.GetNullCustomer(shopID) == null)
                    {
                        var nullCus = new DTO_Customer
                        {
                            Shop = new DTO_Shop
                            {
                                ID = shopID
                            }
                        };
                        busCus.InsertNullCustomer(nullCus);
                    }
                    dtoCus = busCus.GetNullCustomer(shopID);
                }
                else
                {
                    if (cboCustomerType.SelectedIndex == 1)
                    {
                        if (EmailHelper.ValidateEmail(txtEmail.Text))
                        {
                            checkemail = 1;
                        }

                        if (string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtEmail.Text))
                        {
                            if(lblTable.Text=="Bàn")
                                MessageBox.Show("Vui lòng nhập đủ thông tin khách hàng", "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else
                                MessageBox.Show("Write profile for Customer", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (!CheckBirthdate()) return;
                    }

                    if (busCus.GetCustomerByEmail(txtEmail.Text, shopID) == null)
                    {
                        check = 0;
                    }

                    if (busCus.GetCustomerByEmail(txtEmail.Text, shopID) != null)
                    {
                        check = 1;
                    }

                    if (dataGridView1.Rows.Count <= 1)
                    {
                        if (lblTable.Text == "Bàn")
                            MessageBox.Show("Chưa đặt hàng", "Đặt món", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("Haven't order yet", "Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (check == 0 && cboCustomerType.SelectedIndex == 1  && checkemail == 1 && CheckBirthdate() && checkmonecus == 1)
                    {
                        DateTime bdate = new DateTime();
                        dtoCus.Email = txtEmail.Text;
                        dtoCus.FirstName = txtFirstName.Text;
                        dtoCus.LastName = txtLastName.Text;
                        dtoCus.Birthdate = datBirthdate.Value;
                        dtoCus.Shop.ID = shopID;
                        busCus.Insert(dtoCus);
                        dtoCus = busCus.GetCustomerByEmail(txtEmail.Text, shopID);
                    }
                }


                if (checkmonecus == 1)
                {
                    txtMoneyCus.Text = txtMoneyCus.Text.Replace(',', '.');
                    if (double.TryParse(txtMoneyCus.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double sala))
                        dtoReceipt.Cash = (decimal)sala;
                    if (double.TryParse(txtGiveCus.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double sala1))
                        dtoReceipt.Change = (decimal)sala1;
                    dtoReceipt.Customer = dtoCus;
                    dtoReceipt.Employee = dtoEmp;
                    dtoReceipt.DateOfPayMent = now;
                    int mon = lblGrandTotal.Text.IndexOf("$");
                    if (decimal.TryParse(txtDiscount.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal discount))
                    {
                        if(discount>=0 && discount<=100)
                            dtoReceipt.Discount = discount / 100;
                        else
                            dtoReceipt.Discount = 0;
                    }
                    dtoReceipt.Total = decimal.Parse(lblGrandTotal.Text.Substring(0, mon));
                    dtoReceipt.Details = "";
                    dtoReceipt.Shop = dtoShop;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        dtoDetail = new DTO_ReceiptDetails();//cai nay a

                    dto_pro = busPro.GetByIdNotDeleted(Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value), shopID);
                    dtoDetail.Product = dto_pro;
                    //dtoDetail.Product.Id = dto_pro.Id;
                    dtoDetail.Quantity = Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    dtoDetail.TotalPrice = decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    dtoReceipt.Items.Add(dtoDetail);
                    }
                }
                else
                {
                    if (lblTable.Text == "Bàn")
                        MessageBox.Show("Khách đưa thiếu tiền", "Tiền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Don't enough money to pay", "Money", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DTO_Table dtoTab = new DTO_Table();
                if (!string.IsNullOrWhiteSpace(comboBox2.Text) && comboBox2.SelectedIndex != 0)
                {
                    dtoTab.Id = Int32.Parse(comboBox2.Text);
                    dtoTab.Shop.ID = shopID;
                    busReceipt.InsertSittingReceipt(dtoReceipt, dtoTab);
                    dtoTab.Status = "Occupied";
                    busTable.Update(dtoTab);

                }
                else
                    busReceipt.InsertTakeAwayReceipt(dtoReceipt);
                ReloadTable();
                DialogResult resp;
                if (lblTable.Text == "Bàn")
                {
                    resp = MessageBox.Show("Bạn có muốn in biên lai vừa lưu không?", "In",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                    resp= MessageBox.Show("Do you want to print the receipt you just saved?", "Print receipt",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    PDFPrinter.PrintReceipt(dtoReceipt);
                }
                if(lblTable.Text=="Bàn")
                    MessageBox.Show("Đã xong");
                else
                MessageBox.Show("Done, add new receipts");
                ResetAll();
                if (isOrderAtTable) closeFormOrderAtTable = true;
            }
            catch (Exception ex)
            {
                if(lblTable.Text=="Bàn")
                    MessageBox.Show("Đã xảy ra lỗi, tab sẽ tải lại ngay bây giờ.", "Lỗi nguồn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                MessageBox.Show("An error occurred, tab will reload now.", "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reload();
                comboBox2.Items.Clear();
                lsTable.Clear();
                lsTable = busTable.GetAvailableTables(shopID);
            }
        }
        public int check = 0;
        public void ResetAll()
        {
            int to = dataGridView1.Rows.Count;
            for (int i = 0; i < to - 1; i++)
            {

                dataGridView1.Rows.RemoveAt(0);
            }
            strSave.Clear();
            ResetCus();
            txtGiveCus.Text = "";
            txtMoneyCus.Text = "";
            txtDiscount.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int resultIndex = -1;
            resultIndex = comboBox1.FindStringExact(comboBox1.Text);

            if (resultIndex == 1)
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
            else if (resultIndex == 0 || comboBox1.Text == string.Empty)
            {
                if (lblHead.Text == "Đặt món")
                {
                    comboBox1.Text = "Chọn loại sản phẩm";
                }
                else
                {
                    comboBox1.Text = "Select type of products";
                }
                flowLayoutPanel1.Controls.Clear();
                GetData(T);
            }
        }

        public double sum = 0;
        public double copysum = 0;
        public void Timer_Click(object sender, EventArgs e)
        {
            sum = 0;
           // txtDiscount.Text = txtDiscount.Text.Replace(',', '.');
            if (dataGridView1.Rows.Count > 1)
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    sum += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
            lblTotalSum.Text = sum.ToString() + "$";
            if (double.TryParse(txtDiscount.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double d))
            {
                if (d <= 100 && d >= 0)
                {
                    sum = sum - sum * (d) / 100;
                    lblGrandTotal.Text = sum.ToString() + "$";
                }
                else
                    txtDiscount.Text = "0";
            } 
            
            lblGrandTotal.Text = sum.ToString() + "$";
            copysum = sum;

            if (busCus.GetCustomerByEmail(txtEmail.Text, shopID) == null)
            {
                errorProvider2.SetError(txtEmail, "");
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                datBirthdate.Enabled = true;
                txtID.Visible = false;
                //   btnSave.Enabled = false;
                if (cboCustomerType.SelectedIndex == 1)
                {
                    if (!string.IsNullOrEmpty(txtEmail.Text))
                    {
                        if (EmailHelper.ValidateEmail(txtEmail.Text))
                        {
                            errorProvider1.SetError(txtEmail, "");
                            if (lblTable.Text == "Bàn")
                                errorProvider2.SetError(txtEmail, "Hợp lệ");
                            else errorProvider2.SetError(txtEmail, "Valid");
                            checkemail = 1;
                        }
                        else
                        {
                            if (lblTable.Text == "Bàn")
                                errorProvider1.SetError(txtEmail, "Email phải theo format 'example@example.example' và không có khoảng hở");
                            else
                                errorProvider1.SetError(txtEmail, "Email must be in the format 'example@example.example' and must not contain any whitespaces");
                            checkemail = 0;
                        }
                    }
                    else errorProvider1.SetError(txtEmail, "");

                }
                else if (cboCustomerType.SelectedIndex == 0)
                {
                    btnSave.Enabled = true;
                }
            }
            else if (busCus.GetCustomerByEmail(txtEmail.Text, shopID) != null)
            {
                errorProvider1.SetError(txtEmail, "");
                if (lblTable.Text == "Bàn")
                    errorProvider2.SetError(txtEmail, "Hợp lệ");
                else errorProvider2.SetError(txtEmail, "Valid");
                txtID.Enabled = false;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                dtoCus = busCus.GetCustomerByEmail(txtEmail.Text, shopID);
                txtID.Text = dtoCus.Id.ToString();
                txtFirstName.Text = dtoCus.FirstName;
                txtLastName.Text = dtoCus.LastName;
                datBirthdate.Value = dtoCus.Birthdate;
                datBirthdate.Enabled = false;
                txtID.Visible = true;
                 btnSave.Enabled = true;
            }
        }

        public void SetShopID(int id)
        {
            shopID = id;
            Reload();
        }
        private void txtSearchName_Click(object sender, EventArgs e)
        {
            txtSearchName.Text = null;
        }
        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                comboBox1.Enabled = false;
                if (lblHead.Text == "Đặt món")
                {
                    comboBox1.Text = "Chọn loại sản phẩm";
                }
                else
                {
                    comboBox1.Text = "Select type of products";
                }
                if (txtSearchName.Text == string.Empty)
                {
                    comboBox1.Enabled = true;
                    GetData(T);
                }
                else
                    GetData(busPro.GetProductsSearchNameFiltered(txtSearchName.Text, shopID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReloadTable()
        {
            comboBox2.Items.Clear();
            if (btnSave.Text == "Lưu") comboBox2.Items.Add("Không");
            else comboBox2.Items.Add("None");
            comboBox2.SelectedIndex = 0;
            lsTable = busTable.GetAvailableTables(shopID);
            for (int i = 0; i < lsTable.Count; i++)
            {
                comboBox2.Items.Add(lsTable[i].Id.ToString());
            }
        }

        private bool CheckBirthdate()
        {
            datBirthdate.CustomFormat = "dd/MM/yyyy";
            DateTime now = DateTime.Now;
            if ((DateTime.Now.Year-datBirthdate.Value.Year)>=1 )
            {
                errorProvider1.SetError(datBirthdate, "");
                return true;
            }
            else
            {
                if (lblTable.Text == "Bàn")
                    errorProvider1.SetError(datBirthdate, "Ngày không hợp lệ (Khách hàng phải lớn hơn 1 tuổi)");
                else errorProvider1.SetError(datBirthdate, "Wrong date ?");
                errorProvider2.SetError(datBirthdate, "");
                return false;
            }
        }
        public void HideCus()
        {
            lblEmail.Visible = false;
            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblID.Visible = false;
            lblBirthday.Visible = false;
            txtEmail.Visible = false;
            txtID.Visible = false;
            txtFirstName.Visible = false;
            txtLastName.Visible = false;
            datBirthdate.Visible = false;
            lblNoneName.Visible = true;
        }
        public void ShowCus()
        {
            lblEmail.Visible = true;
            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            lblID.Visible = true;
            lblBirthday.Visible = true;
            txtEmail.Visible = true;
            txtID.Visible = true;
            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            datBirthdate.Visible = true;
            lblNoneName.Visible = false;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resultIndex = -1;
            resultIndex = cboCustomerType.FindStringExact(cboCustomerType.Text);
            if (resultIndex == 0)
            {
                HideCus();
                btnSave.Enabled = true;
            }
            else if (resultIndex == 1)
            {
                ResetCus();
                ShowCus();
            }
        }
        public int checkprice = 0;

        private void txtMoneycus_TextChanged(object sender, EventArgs e)
        {
            int countdoc = 0;
            string sums = null;
           // txtMoneyCus.Text = txtMoneyCus.Text.Replace(',', '.');
            if (txtMoneyCus.Text == string.Empty||txtMoneyCus.Text=="")
            {
                if(lblTable.Text=="Bàn")
                    errorProvider1.SetError(txtMoneyCus, "Vui lòng nhập giá");
                else
                errorProvider1.SetError(txtMoneyCus, "Please provide price");
                errorProvider2.SetError(txtMoneyCus, "");
                checkprice = 0;
            }
            else
            {
                double sum11 = 0;
               // txtCopyPrice.Text = sums;
                if (double.TryParse(txtMoneyCus.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture,out sum11))
                {
                    if (lblTable.Text == "Bàn")
                        errorProvider2.SetError(txtMoneyCus, "Hợp lệ");
                    else errorProvider2.SetError(txtMoneyCus, "Correct");
                    errorProvider1.SetError(txtMoneyCus, "");
                    checkmonecus = 1;
                }
                else
                {
                    if (lblTable.Text == "Bàn")
                        errorProvider1.SetError(txtMoneyCus, "Sai định dạng");
                    else errorProvider1.SetError(txtMoneyCus, "Wrong format");
                    errorProvider2.SetError(txtMoneyCus, "");
                    txtGiveCus.Text = "";

                    checkmonecus = 0;
                }
            }
            if (checkmonecus == 1&& double.TryParse(txtMoneyCus.Text.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out double d))
            {
                if (copysum <= d)
                {
                    errorProvider1.SetError(txtMoneyCus, "");
                    txtGiveCus.Text = "";
                    checkmonecus = 1;
                    txtGiveCus.Text = (d-copysum).ToString();
                }
                else
                {
                    if(lblTable.Text=="Bàn")
                        errorProvider1.SetError(txtMoneyCus, "Không so sánh được");
                    else
                    errorProvider1.SetError(txtMoneyCus, "Can't compare");
                    errorProvider2.SetError(txtMoneyCus, "");
                    txtGiveCus.Text = "";

                    checkmonecus = 0;
                }
            }
        }

        private void lblGrandTotal_TextChanged(object sender, EventArgs e)
        {
            if (txtMoneyCus.Text != "")
            {
                if (double.Parse(sum.ToString()) > double.Parse(txtMoneyCus.Text))
                {
                    if (lblTable.Text == "Bàn")
                        errorProvider1.SetError(txtMoneyCus, "Không hợp lệ");
                    else errorProvider1.SetError(txtMoneyCus, "Wrong");
                    errorProvider2.SetError(txtMoneyCus, "");
                    checkmonecus = 0;
                    txtGiveCus.Text = "";
                }
                else if(double.Parse(sum.ToString()) == double.Parse(txtMoneyCus.Text))
                {
                    errorProvider1.SetError(txtMoneyCus, "");
                    checkmonecus = 1;
                    txtGiveCus.Text = "0";
                }
                else
                {
                    errorProvider1.SetError(txtMoneyCus, "");
                    if (lblTable.Text == "Bàn")
                        errorProvider2.SetError(txtMoneyCus, "Có thể so sánh");
                    else
                        errorProvider2.SetError(txtMoneyCus, "Can compare");
                    checkmonecus = 1;
                    txtGiveCus.Text = (double.Parse(txtMoneyCus.Text) - double.Parse(sum.ToString())).ToString();
                }
            }

        }
        public void SetTable(int id)
        {
            comboBox2.Text = id.ToString();
        }
    }
}
