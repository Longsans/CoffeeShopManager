using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Thanhtoan : Form
    {
        UserControlOrderProduct _ucOrd;
        int checkprice = 0;
        public Thanhtoan()
        {
            InitializeComponent();
        }
        public Thanhtoan(UserControlOrderProduct order)
        {
            _ucOrd = order;
            InitializeComponent();

        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c) && c != '.' && c != ',')
                    return false;
            }
            return true;
        }

        private void txtMoneycus_TextChanged(object sender, EventArgs e)
        {
            int countdoc = 0;
            string sums = null;
            if (txtMoneycus.Text == string.Empty)
            {
                errorProvider1.SetError(txtMoneycus, "Please provide Price");
                errorProvider2.SetError(txtMoneycus, "");
                checkprice = 0;
            }
            else
            {
                string s = txtMoneycus.Text.ToString();

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '.' || s[i] == ',')
                    {
                        countdoc++;
                        sums += '.';
                    }
                    else
                        sums += s[i];
                }
                txtCopyPrice.Text = sums;
                if (IsNumber(txtMoneycus.Text) == true && countdoc <= 1)
                {
                    errorProvider2.SetError(txtMoneycus, "Correct");
                    errorProvider1.SetError(txtMoneycus, "");
                    checkprice = 1;
                }
                else
                {
                    errorProvider1.SetError(txtMoneycus, "Wrong format");
                    errorProvider2.SetError(txtMoneycus, "");
                    checkprice = 0;
                }
                if (s[s.Length - 1] == '.' || s[s.Length - 1] == ',')
                {
                    errorProvider1.SetError(txtMoneycus, "Wrong format");
                    errorProvider2.SetError(txtMoneycus, "");
                    checkprice = 0;
                }
            }
            if (decimal.Parse(txtTotal.Text) > decimal.Parse(txtMoneycus.Text) && checkprice == 1)
            {
                errorProvider2.SetError(txtMoneycus, "Correct");
                errorProvider1.SetError(txtMoneycus, "");
                checkprice = 1;
            }
            else
            {
                errorProvider1.SetError(txtMoneycus, "Wrong compare");
                errorProvider2.SetError(txtMoneycus, "");
                checkprice = 0;
            }
            if (checkprice == 1)
            {
                btnSaveEnd.Enabled = true;
            }
            else
                btnSaveEnd.Enabled = false;
        }
    }
}
