using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    
    public partial class frmRegister : Form
    {
        BUS_UserInfo busUser = new BUS_UserInfo();
        BUS_Manager busMan = new BUS_Manager();
        BUS_Shop busShop = new BUS_Shop();
        frmLogin _frmLogin = new frmLogin();
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public frmRegister()
        {
            InitializeComponent();
        }
        public frmRegister(frmLogin frm)
        {
            _frmLogin = frm;
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            _frmLogin.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(txtConfirm, "");

                if (txtUsername.Text == "" || txtPass.Text == "" || txtConfirm.Text == "" || txtDayBD.Text == "" ||
                    txtMonthBD.Text == "" || txtYearBD.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" ||
                    txtPhone.Text == "" || txtEmail.Text == "" || (radFemale.Checked == false && radMale.Checked == false) ||
                    (lblShopName.Visible && txtShopName.ForeColor == Color.DimGray) || txtShopId.ForeColor == Color.DimGray ||
                    txtAuthCode.ForeColor == Color.DimGray)
                {
                    MessageBox.Show("Please fill all info fields.", "More information is required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtPass.Text != txtConfirm.Text) errorProvider1.SetError(txtConfirm, "Xác nhận mật khẩu không đúng");
                else
                {

                    DTO_User dtoUser = new DTO_User() { Username = txtUsername.Text, PassWord = txtPass.Text };
                    if (busUser.CheckUsername(txtUsername.Text))
                    {
                        DTO_Manager dtoMan = new DTO_Manager();
                        DateTime bdate = new DateTime();
                        dtoMan.Account = dtoUser;
                        dtoMan.Id = txtID.Text;
                        dtoMan.Firstname = txtFirstName.Text;
                        dtoMan.Lastname = txtLastName.Text;
                        dtoMan.Phone = txtPhone.Text;
                        dtoMan.Position = "Manager";
                        dtoMan.Email = txtEmail.Text;
                        if (radFemale.Checked) dtoMan.Gender = "Female";
                        else dtoMan.Gender = "Male";

                        string[] formats = { "dd/MM/yyyy", "d/M/yyyy" };
                        if (DateTime.TryParseExact(txtDayBD.Text + "/" + txtMonthBD.Text + "/" + txtYearBD.Text,
                            formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out bdate))
                        {
                            dtoMan.Birthdate = bdate;
                        }
                        dtoMan.Account = busUser.EncodePass(dtoMan);

                        if (this.picboxManImg.Image == null)
                        {
                            MessageBox.Show("Vui lòng chọn hình ảnh.", "Chọn hình ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            throw new Exception();
                        }
                        else
                        {
                            dtoMan.Image = ImageHelper.ImageToByteArray(this.picboxManImg.Image);
                        }

                        if (lblShopName.Visible)
                        {
                            dtoMan.Shop.ShopName = txtShopName.Text;
                            dtoMan.Shop.AuthCode = busShop.EncodeAuthCode(txtAuthCode.Text);
                            dtoMan.Shop.ID = busShop.Insert(dtoMan.Shop);
                        }
                        else
                        {
                            dtoMan.Shop.ID = int.Parse(txtShopId.Text);
                            dtoMan.Shop.AuthCode = busShop.EncodeAuthCode(txtAuthCode.Text);

                            if (!busShop.VerifyShop(dtoMan.Shop))
                            {
                                errorProvider1.SetError(txtShopId, "Incorrect shop ID or authentication code.");
                                errorProvider1.SetError(txtAuthCode, "Incorrect shop ID or authentication code.");
                                throw new Exception();
                            }
                        }

                        busMan.Insert(dtoMan);
                        MessageBox.Show("Bạn đã đăng ký thành công");
                    }
                    else MessageBox.Show("Tên đăng nhập đã tồn tại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                this.lblNoImg.Visible = false;
                this.picboxManImg.SizeMode = PictureBoxSizeMode.StretchImage;
                this.picboxManImg.Image = Image.FromFile(op.FileName);
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            lblAuthCode.Location = lblShopName.Location;
            txtAuthCode.Location = txtShopName.Location;
            btnBack.Location = lblShopId.Location;
            fpnlCreateNew.Visible = false;
            lblShopName.Visible = false;
            txtShopName.Visible = false;
            btnBack.Visible = false;
            txtShopId.GotFocus += txtShop_Click;
            txtShopId.LostFocus += txtShop_Leave;
            txtShopName.GotFocus += TxtShopName_GotFocus;
            txtShopName.LostFocus += TxtShopName_LostFocus;
            txtAuthCode.GotFocus += TxtAuthCode_GotFocus;
            txtAuthCode.LostFocus += TxtAuthCode_LostFocus;
        }

        private void txtShop_Click(object sender, EventArgs e)
        {
            if (txtShopId.ForeColor == Color.DimGray)
            {
                txtShopId.Clear();
                txtShopId.Font = new Font(new FontFamily("Century Gothic"), txtShopId.Font.Size);
                txtShopId.ForeColor = Color.Black;
                if (!lblShopName.Visible)
                {
                    fpnlCreateNew.Visible = true;
                }
            }
        }

        private void txtShop_Leave(object sender, EventArgs e)
        {
            if (lblShopName.Visible)
            {
                

            }
            else if (txtShopId.TextLength == 0)
            {
                txtShopId.Font = new Font(new FontFamily("Constantia"), txtShopId.Font.Size);
                txtShopId.ForeColor = Color.DimGray;
                fpnlCreateNew.Visible = false;
                txtShopId.Text = "Enter existing shop ID or...";
            }
        }

        private void txtShopId_TextChanged(object sender, EventArgs e)
        {
            if (txtShopId.TextLength == 0)
            {
                if (!lblShopName.Visible)
                {
                    fpnlCreateNew.Visible = true;
                }
            }
            else
            {
                fpnlCreateNew.Visible = false;
            }
        }

        private void TxtShopName_LostFocus(object sender, EventArgs e)
        {
            if (txtShopName.TextLength == 0)
            {
                txtShopName.Font = new Font(new FontFamily("Constantia"), txtShopName.Font.Size);
                txtShopName.ForeColor = Color.DimGray;
                txtShopName.Text = "Enter new shop name";
            }
        }

        private void TxtShopName_GotFocus(object sender, EventArgs e)
        {
            if (txtShopName.ForeColor == Color.DimGray)
            {
                txtShopName.Clear();
                txtShopName.Font = new Font(new FontFamily("Century Gothic"), txtShopName.Font.Size);
                txtShopName.ForeColor = Color.Black;
            }
        }

        private void TxtAuthCode_LostFocus(object sender, EventArgs e)
        {
            if (txtAuthCode.TextLength == 0)
            {
                txtAuthCode.Font = new Font(new FontFamily("Constantia"), txtAuthCode.Font.Size);
                txtAuthCode.ForeColor = Color.DimGray;
                if (lblShopName.Visible)
                {
                    txtAuthCode.Text = "Enter new password";
                }
                else
                {
                    txtAuthCode.Text = "Enter password";
                }
            }
        }

        private void TxtAuthCode_GotFocus(object sender, EventArgs e)
        {
            if (txtAuthCode.ForeColor == Color.DimGray)
            {
                txtAuthCode.Clear();
                txtAuthCode.Font = new Font(new FontFamily("Century Gothic"), txtAuthCode.Font.Size);
                txtAuthCode.ForeColor = Color.Black;
            }
        }

        private void txtAuthCode_TextChanged(object sender, EventArgs e)
        {
            if (txtAuthCode.ForeColor == Color.Black)
            {
                txtAuthCode.UseSystemPasswordChar = true;
            }
            else
            {
                txtAuthCode.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fpnlCreateNew.Visible = false;
            lblShopId.Visible = false;
            txtShopId.Visible = false;
            lblShopName.Visible = true;
            txtShopName.Visible = true;
            btnBack.Visible = true;
            lblAuthCode.Location = new Point(lblShopName.Location.X, lblBirthdate.Location.Y);
            txtAuthCode.Location = new Point(txtShopName.Location.X, txtYearBD.Location.Y);
            txtAuthCode.Font = new Font(new FontFamily("Constantia"), txtAuthCode.Font.Size);
            txtAuthCode.ForeColor = Color.DimGray;
            txtAuthCode.Text = "Enter new password";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            lblShopId.Visible = true;
            txtShopId.Visible = true;
            lblShopName.Visible = false;
            txtShopName.Visible = false;
            lblAuthCode.Location = lblShopName.Location;
            txtAuthCode.Location = txtShopName.Location;
            txtAuthCode.Text = "Enter password";
        }
    }
}
