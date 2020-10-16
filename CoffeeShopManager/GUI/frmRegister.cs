using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (txtEmail.Text == "" || txtPass.Text == "" || txtConfirm.Text == "" || txtDayBD.Text == "" ||
                txtMonthBD.Text == "" || txtYearBD.Text == "" || txtFirstName.Text == "" || txtLastName.Text == ""||
                txtPhone.Text == "" || (radFemale.Checked == false && radMale.Checked == false))
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            else if (txtPass.Text != txtConfirm.Text) errorProvider1.SetError(txtConfirm, "Xác nhận mật khẩu không đúng");
            else
            {

                DTO_User dtoUser = new DTO_User() { Email = txtEmail.Text, PassWord = txtPass.Text };
                if (busUser.CheckUsername(txtEmail.Text))
                {
                    DTO_Manager dtoMan = new DTO_Manager();
                    DateTime tmp = new DateTime();
                    dtoMan.Account = dtoUser;
                    dtoMan.Firstname = txtFirstName.Text;
                    dtoMan.Lastname = txtLastName.Text;
                    dtoMan.Phone = txtLastName.Text;
                    dtoMan.Position = "Manager";
                    if (radFemale.Checked) dtoMan.Gender = "Female";
                    else dtoMan.Gender = "Male";
                    if (DateTime.TryParse(txtDayBD.Text + "/" + txtMonthBD.Text + "/" + txtYearBD.Text, out tmp))
                    {
                        dtoMan.Birthdate = tmp;
                    }
                    dtoMan.Account = busUser.EncodePass(dtoMan);
                    busMan.Insert(dtoMan);
                    MessageBox.Show("Bạn đã đăng ký thành công");

                }
                else MessageBox.Show("Tên đăng nhập đã tồn tại");
            }
            
        }
    }
}
