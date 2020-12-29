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
        BUS_UserInfo busUser = new BUS_UserInfo(ConnectionStringHelper.GetConnectionString());
        BUS_Manager busMan = new BUS_Manager(ConnectionStringHelper.GetConnectionString());
        BUS_Shop busShop = new BUS_Shop(ConnectionStringHelper.GetConnectionString());
        BUS_Workers busWr = new BUS_Workers(ConnectionStringHelper.GetConnectionString());
        frmLogin _frmLogin = new frmLogin();
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private bool checkEmail, checkShop, checkId;
        private Timer tiktoker,
            timerEmail,
            timerShop,
            timerId;

        public frmRegister()
        {
            InitializeComponent();
        }
        public frmRegister(frmLogin frm)
        {
            _frmLogin = frm;
            InitializeComponent();
            DoubleBuffered = true;
            tiktoker = new Timer();
            tiktoker.Interval = 300;
            tiktoker.Tick += Tiktoker_Tick;
            timerEmail = new Timer();
            timerEmail.Tick += TimerEmail_Tick;
            timerShop = new Timer();
            timerShop.Tick += TimerShop_Tick;
            timerId = new Timer();
            timerId.Tick += TimerId_Tick;
            timerId.Interval = timerShop.Interval = timerEmail.Interval = 200;
            tiktoker.Start();
        }

        private void TimerId_Tick(object sender, EventArgs e)
        {
            if (txtID.TextLength == 0)
            {
                checkId = false;
                errManId.SetError(txtID, cboErrMsg.Items[0].ToString());
            }
            else if (checkShop)
            {
                if (txtShopId.Visible)
                {
                    if (int.TryParse(txtShopId.Text, out int id))
                    {
                        if (busWr.GetById(txtID.Text, id) != null)
                        {
                            checkId = false;
                            errManId.SetError(txtID, cboErrMsg.Items[1].ToString());
                        }
                        else
                        {
                            checkId = true;
                            errManId.SetError(txtID, "");
                        }
                    }
                }
                else
                {
                    checkId = true;
                    errManId.SetError(txtID, "");
                }
            }
            else
            {
                checkId = false;
                errManId.SetError(txtID, "");
            }
        }

        private void TimerShop_Tick(object sender, EventArgs e)
        {
            if (txtShopId.ForeColor != Color.DimGray)
            {
                if (txtShopId.TextLength == 0)
                {
                    checkShop = false;
                    errShop.SetError(txtShopId, "");
                }
                else
                {
                    if (int.TryParse(txtShopId.Text, out int id))
                    {
                        if (busShop.GetShopById(id) == null)
                        {
                            checkShop = false;
                            errShop.SetError(txtShopId, cboErrMsg.Items[2].ToString());
                        }
                        else
                        {
                            checkShop = true;
                            errShop.SetError(txtShopId, "");
                        }
                    }
                    else
                    {
                        checkShop = false;
                        errShop.SetError(txtShopId, cboErrMsg.Items[3].ToString());
                    }
                }
            }
            else if (!txtShopId.Visible)
            {
                checkShop = true;
            }
            else
            {
                checkShop = false;
            }
        }

        private void TimerEmail_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                checkEmail = false;
                errEmail.SetError(txtEmail, cboErrMsg.Items[4].ToString());
            }
            else
            {
                if (!lblShopName.Visible && checkShop)
                {
                    if (int.TryParse(txtShopId.Text, out int id))
                    {
                        if (busWr.GetByEmail(txtEmail.Text, id) != null)
                        {
                            checkEmail = false;
                            errEmail.SetError(txtEmail, cboErrMsg.Items[5].ToString());
                            return;
                        }
                    }
                }

                if (EmailHelper.ValidateEmail(txtEmail.Text))
                {
                    checkEmail = true;
                    errEmail.SetError(txtEmail, "");
                }
                else
                {
                    checkEmail = false;
                    errEmail.SetError(txtEmail, cboErrMsg.Items[6].ToString());
                }
            }
        }

        private void Tiktoker_Tick(object sender, EventArgs e)
        {
            if (checkEmail && checkShop && checkId)
            {
                btnSignUp.Enabled = true;
            }
            else
            {
                btnSignUp.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            tiktoker.Dispose();
            timerEmail.Dispose();
            timerShop.Dispose();
            timerId.Dispose();
            Close();
            _frmLogin.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.SetError(txtConfirm, "");

                if (txtUsername.Text == "" || txtPass.Text == "" || txtConfirm.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" ||
                    txtPhone.Text == "" || txtEmail.Text == "" || (radFemale.Checked == false && radMale.Checked == false) ||
                    (lblShopName.Visible && txtShopName.ForeColor == Color.DimGray) || (!lblShopName.Visible && txtShopId.ForeColor == Color.DimGray) ||
                    txtAuthCode.ForeColor == Color.DimGray)
                {
                    if (btnBrowseImg.Text == "Tìm ảnh")
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Yêu cầu nhiều thông tin hơn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else MessageBox.Show("Please fill all info fields.", "More information is required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtPass.Text != txtConfirm.Text) errorProvider1.SetError(txtConfirm, "Xác nhận mật khẩu không đúng");
                else
                {

                    DTO_User dtoUser = new DTO_User() { Username = txtUsername.Text, PassWord = txtPass.Text };
                    if (busUser.CheckUsername(txtUsername.Text))
                    {
                        DTO_Manager dtoMan = new DTO_Manager();
                        dtoMan.Account = dtoUser;
                        dtoMan.Id = txtID.Text;
                        dtoMan.Firstname = txtFirstName.Text;
                        dtoMan.Lastname = txtLastName.Text;
                        dtoMan.Phone = txtPhone.Text;
                        dtoMan.Position = "Manager";
                        dtoMan.Email = txtEmail.Text;
                        if (radMale.Checked == true)
                        {
                            if (radMale.Text != "Nam")
                                dtoMan.Gender = radMale.Text;
                            else
                                dtoMan.Gender = "Male";

                        }
                        else
                        {
                            if (radFemale.Text != "Nữ")
                                dtoMan.Gender = radMale.Text;
                            else
                                dtoMan.Gender = "Female";
                        }

                        if (DateTime.Now.Year - datBirthdate.Value.Year < 18)
                        {
                            if (btnBrowseImg.Text == "Browse")
                            {
                                MessageBox.Show("Age must be greater than or equal to 18.", "Invalid age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("Tuổi phải lớn hơn hoặc bằng 18.", "Tuổi không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            return;
                        }
                        else
                        {
                            dtoMan.Birthdate = datBirthdate.Value;
                        }
                        dtoMan.Account = busUser.EncodePass(dtoMan);

                        if (!long.TryParse(txtPhone.Text, out long phone))
                        {
                            if (btnBrowseImg.Text == "Browse")
                            {
                                MessageBox.Show("Phone number can only contain numeric characters.", "Invalid phone number format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("Số điện thoại chỉ được chứa ký tự số.", "Định dạng số điện thoại không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            return;
                        }

                        if (this.picboxManImg.Image == null)
                        {
                            if (btnBrowseImg.Text == "Tìm ảnh")
                                MessageBox.Show("Vui lòng chọn hình ảnh.", "Chọn hình ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            else MessageBox.Show("Please choose image", "Choose image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
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
                                if (btnBrowseImg.Text == "Tìm ảnh")
                                {
                                    errorProvider1.SetError(txtShopId, "ID shop hoặc mã xác thực không chính xác.");
                                    errorProvider1.SetError(txtAuthCode, "ID shop hoặc mã xác thực không chính xác.");
                                    MessageBox.Show("ID shop hoặc mã xác thực không chính xác.", "Xác thực không chính xác", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    errorProvider1.SetError(txtShopId, "Incorrect shop ID or authentication code.");
                                    errorProvider1.SetError(txtAuthCode, "Incorrect shop ID or authentication code.");
                                    MessageBox.Show("Incorrect shop ID or authentication code.", "Incorrect authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                
                                return;
                            }
                        }
                        Reload();
                        busMan.Insert(dtoMan);
                        if (btnBrowseImg.Text == "Tìm ảnh")
                            MessageBox.Show("Bạn đã đăng ký thành công", "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show("You have registered successfully.", "Registration successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        picboxManImg.Image = null;
                        lblNoImg.Visible = true;
                    }
                    else
                    {
                        if (btnBrowseImg.Text == "Tìm ảnh")
                            MessageBox.Show("Tên đăng nhập đã tồn tại", "Nhập tên đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else MessageBox.Show("Username has already existed", "Username taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            datBirthdate.Format = DateTimePickerFormat.Custom;
            datBirthdate.CustomFormat = "dd/MM/yyyy";
            txtShopId.GotFocus += txtShop_Click;
            txtShopId.LostFocus += txtShop_Leave;
            txtShopName.GotFocus += TxtShopName_GotFocus;
            txtShopName.LostFocus += TxtShopName_LostFocus;
            txtAuthCode.GotFocus += TxtAuthCode_GotFocus;
            txtAuthCode.LostFocus += TxtAuthCode_LostFocus;
        }

        private void Reload()
        {
            txtUsername.Clear();
            txtPass.Clear();
            txtConfirm.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            radMale.Checked = false;
            radFemale.Checked = false;
            txtPhone.Clear();
            txtEmail.Clear();
            txtID.Clear();
            txtShopId.Clear();
            txtShopName.Clear();
            txtAuthCode.Clear();
            errorProvider1.SetError(txtShopId, "");
            errorProvider1.SetError(txtAuthCode, "");
            errShop.SetError(txtShopId, "");
            errEmail.SetError(txtEmail, "");
            timerEmail.Stop();
            timerShop.Stop();
            timerId.Stop();
            checkEmail = false;
            checkShop = false;
            txtShopId.Focus();
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
                if (btnBrowseImg.Text == "Tìm ảnh")
                    txtShopId.Text = "Nhập ID shop đã có hoặc .....";
                else txtShopId.Text = "Enter existing shop ID or...";
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

            timerShop.Start();
        }

        private void TxtShopName_LostFocus(object sender, EventArgs e)
        {
            if (txtShopName.TextLength == 0)
            {
                txtShopName.Font = new Font(new FontFamily("Constantia"), txtShopName.Font.Size);
                txtShopName.ForeColor = Color.DimGray;
                if (btnBrowseImg.Text == "Tìm ảnh")
                    txtShopName.Text = "Nhập tên shop mới";
                else txtShopName.Text = "Enter new shop name";
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
                    if (btnBrowseImg.Text == "Tìm ảnh")
                        txtAuthCode.Text = "Nhập mật khẩu mới";
                    else txtAuthCode.Text = "Enter new password";
                }
                else
                {
                    if (btnBrowseImg.Text == "Tìm ảnh")
                        txtAuthCode.Text = "Nhập mật khẩu";
                    txtAuthCode.Text = "Enter password";
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            timerId.Start();
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
            txtAuthCode.Location = new Point(txtShopName.Location.X, datBirthdate.Location.Y);
            txtAuthCode.Font = new Font(new FontFamily("Constantia"), txtAuthCode.Font.Size);
            txtAuthCode.ForeColor = Color.DimGray;
            if (btnBrowseImg.Text == "Tìm ảnh")
                txtAuthCode.Text = "Nhập mật khẩu";
            else txtAuthCode.Text = "Enter new password";
            txtShopName.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            lblShopId.Visible = true;
            txtShopId.Visible = true;
            lblShopName.Visible = false;
            txtShopName.Visible = false;
            txtShopName.Clear();
            lblAuthCode.Location = lblShopName.Location;
            txtAuthCode.Location = txtShopName.Location;
            txtAuthCode.ForeColor = Color.DimGray;
            if (btnBrowseImg.Text == "Tìm ảnh")
                txtAuthCode.Text = "Nhập mật khẩu";
            else txtAuthCode.Text = "Enter new password";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            timerEmail.Start();
        }
    }
}
