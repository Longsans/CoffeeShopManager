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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            _frmLogin.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtConfirm, "");
            if (txtUsername.Text == "" || txtPass.Text == "" || txtConfirm.Text == "" || txtDayBD.Text == "" ||
                txtMonthBD.Text == "" || txtYearBD.Text == "" || txtFirstName.Text == "" || txtLastName.Text == ""||
                txtPhone.Text == "" || txtEmail.Text == "" || (radFemale.Checked == false && radMale.Checked == false))
                MessageBox.Show("Vui lòng nhập đủ thông tin");
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
                    dtoMan.Shop.ID = 1;
                    dtoMan.Account = busUser.EncodePass(dtoMan);
                    if (this.picboxManImg.Image == null)
                    {
                        MessageBox.Show("Vui lòng chọn hình ảnh.", "Chọn hình ảnh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        dtoMan.Image = ImageHelper.ImageToByteArray(this.picboxManImg.Image);
                        busMan.Insert(dtoMan);
                        MessageBox.Show("Bạn đã đăng ký thành công");
                    }
                }
                else MessageBox.Show("Tên đăng nhập đã tồn tại");
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
    }
}
