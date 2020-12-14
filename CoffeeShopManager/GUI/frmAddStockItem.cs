using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmAddStockItem : Form
    {
        public DTO_Shop Shop = new DTO_Shop();
        public UserControlStock ucStock { get; set; }
        BUS_StockItems busStock = new BUS_StockItems();
        BUS_Suppliers busSup = new BUS_Suppliers();
        string addSup = "Enter new supplier",
            existingSup = "Enter existing supplier";
        Icon checkIcon,
            errorIcon;
        List<ErrorProvider> errs = new List<ErrorProvider>();
        Timer tiktoker = new Timer(),
            timerItemId = new Timer(),
            timerSupId = new Timer(),
            timerSupEmail = new Timer();
        Point prevPoint;
        bool dragging;

        public frmAddStockItem()
        {
            StartPosition = FormStartPosition.Manual;
            AcceptButton = btnAdd;
            InitializeComponent();
        }

        private void frmAddStockItem_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; ++i)
            {
                var newErr = new ErrorProvider();
                errs.Add(newErr);
            }

            this.FormClosing += FrmAddStockItem_FormClosing;
            errs[0].SetIconPadding(txtItemName, 5);
            errs[1].SetIconPadding(txtSupId, 5);
            errs[2].SetIconPadding(txtEmail, 5);
            lblEnterSup.Location = lblAddSup.Location;
            checkIcon = new Icon(GUI.Properties.Resources.check1, errs[0].Icon.Size);
            errorIcon = new Icon(GUI.Properties.Resources.cancel, errs[0].Icon.Size);
            txtId.Text = busStock.GetNextItemId(Shop.ID).ToString();
            txtSupId.GotFocus += TxtSupId_GotFocus;
            txtSupId.LostFocus += TxtSupId_LostFocus;
            tiktoker.Interval = timerItemId.Interval = timerSupId.Interval = timerSupEmail.Interval = 200;
            tiktoker.Tick += Tiktoker_Tick;
            timerItemId.Tick += TimerItemId_Tick;
            timerSupId.Tick += TimerSupId_Tick;
            timerSupEmail.Tick += TimerSupEmail_Tick;
            tiktoker.Start();
        }

        private void FrmAddStockItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            tiktoker.Dispose();
            timerItemId.Dispose();
            timerSupId.Dispose();
            timerSupEmail.Dispose();
        }

        private void TimerSupEmail_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (busSup.GetByEmail(txtEmail.Text, Shop.ID) != null)
                {
                    errs[2].Icon = errorIcon;
                    errs[2].SetError(txtEmail, "A supplier with such email already exists");
                }
                else
                {
                    if (EmailHelper.ValidateEmail(txtEmail.Text))
                    {
                        errs[2].Icon = checkIcon;
                        errs[2].SetError(txtEmail, "Valid");
                    }
                    else
                    {
                        errs[2].Icon = errorIcon;
                        errs[2].SetError(txtEmail, "Email must be in the format 'example@example.example' and must not contain any whitespaces");
                    }
                }
            }
            else
            {
                errs[2].Icon = errorIcon;
                errs[2].SetError(txtEmail, "Please fill all info fields");
            }
        }

        private void TimerSupId_Tick(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(txtSupId.Text) || txtSupId.ForeColor == Color.DimGray))
            {
                if (lblEnterSup.Visible)
                {
                    if (busSup.GetById(txtSupId.Text, Shop.ID) != null)
                    {
                        errs[1].Icon = errorIcon;
                        errs[1].SetError(txtSupId, "A supplier with such ID already exists");
                    }
                    else
                    {
                        errs[1].Icon = checkIcon;
                        errs[1].SetError(txtSupId, "Valid");
                    }
                }
                else if (lblAddSup.Visible)
                {
                    if (busSup.GetById(txtSupId.Text, Shop.ID) == null)
                    {
                        errs[1].Icon = errorIcon;
                        errs[1].SetError(txtSupId, "A supplier with such ID does not exist");
                    }
                    else
                    {
                        errs[1].Icon = checkIcon;
                        errs[1].SetError(txtSupId, "Valid");
                    }
                }
            }
            else
            {
                errs[1].Icon = errorIcon;
                errs[1].SetError(txtSupId, "Please fill all info fields");
            }
        }

        private void TimerItemId_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                errs[0].Icon = checkIcon;
                errs[0].SetError(txtItemName, "Valid");
            }
            else
            {
                errs[0].Icon = errorIcon;
                errs[0].SetError(txtItemName, "Please fill all info fields");
            }
        }

        private void Tiktoker_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtItemName.Text) || txtSupId.ForeColor == Color.DimGray ||
                lblEnterSup.Visible && (string.IsNullOrWhiteSpace(txtSupName.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text)))
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;

                for (int i = 0; i < errs.Count; ++i)
                {
                    if (!lblEnterSup.Visible && i == errs.Count - 1)
                    {
                        break;
                    }
                    if (errs[i].Icon != checkIcon)
                    {
                        btnAdd.Enabled = false;
                    }
                }
            }
        }

        private void TxtSupId_LostFocus(object sender, EventArgs e)
        {
            if (txtSupId.ForeColor == SystemColors.WindowText && txtSupId.TextLength == 0)
            {
                if (lblAddSup.Visible)
                {
                    txtSupId.Text = existingSup;
                }
                else if (lblEnterSup.Visible)
                {
                    txtSupId.Text = addSup;
                }
                txtSupId.ForeColor = Color.DimGray;
            }
        }

        private void TxtSupId_GotFocus(object sender, EventArgs e)
        {
            if (txtSupId.ForeColor == Color.DimGray)
            {
                txtSupId.Clear();
                txtSupId.ForeColor = SystemColors.WindowText;
            }
        }

        private void lblAddSup_MouseDown(object sender, MouseEventArgs e)
        {
            ((Label)sender).ForeColor = SystemColors.Highlight;
        }

        private void lblAddSup_MouseUp(object sender, MouseEventArgs e)
        {
            lblAddSup.Focus();
            lblAddSup.ForeColor = SystemColors.ControlText;
            lblAddSup.Visible = false;
            lblEnterSup.Visible = true;
            lblSupName.Visible = true;
            txtSupName.Visible = true;
            lblEmail.Visible = true;
            txtEmail.Visible = true;
            lblPhone.Visible = true;
            txtPhone.Visible = true;
            if (txtSupId.TextLength > 0 && txtSupId.ForeColor == SystemColors.WindowText)
            {
                txtSupId.ForeColor = Color.DimGray;
                txtSupId.Text = addSup;
            }
        }

        private void lblEnterSup_MouseUp(object sender, MouseEventArgs e)
        {
            lblEnterSup.Focus();
            lblEnterSup.ForeColor = SystemColors.ControlText;
            lblEnterSup.Visible = false;
            lblAddSup.Visible = true;
            lblSupName.Visible = false;
            txtSupName.Visible = false;
            lblEmail.Visible = false;
            txtEmail.Visible = false;
            lblPhone.Visible = false;
            txtPhone.Visible = false;
            if (txtSupId.TextLength > 0 && txtSupId.ForeColor == SystemColors.WindowText)
            {
                txtSupId.ForeColor = Color.DimGray;
                txtSupId.Text = existingSup;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEnterSup_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.FromArgb(139, 89, 50);
        }


        private void lblEnterSup_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = SystemColors.ControlText;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var item = new DTO_StockItem
            {
                Name = txtItemName.Text,
                Shop = this.Shop,
                Supplier = new DTO_Supplier
                {
                    Id = txtSupId.Text,
                    Shop = this.Shop
                }
            };

            if (lblEnterSup.Visible)
            {
                item.Supplier.Name = txtSupName.Text;
                item.Supplier.Email = txtEmail.Text;
                item.Supplier.Phone = txtPhone.Text;
                busSup.Insert(item.Supplier);
            }

            busStock.Insert(item);
            ucStock.ReloadGridView();
            ClearTextboxes();
            MessageBox.Show("New stock item added.", "Insert successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearTextboxes()
        {
            txtId.Text = busStock.GetNextItemId(Shop.ID).ToString();
            txtItemName.Clear();
            txtSupName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtSupId.ForeColor = Color.DimGray;
            timerItemId.Stop();
            timerSupId.Stop();
            timerSupEmail.Stop();
            errs[0].SetError(txtItemName, "");
            errs[1].SetError(txtSupId, "");
            errs[2].SetError(txtEmail, "");

            if (lblAddSup.Visible)
            {
                txtSupId.Text = addSup;
            }
            else if (lblEnterSup.Visible)
            {
                txtSupId.Text = existingSup;
            }
        }

        private void txtSupId_TextChanged(object sender, EventArgs e)
        {
            if (txtSupId.ForeColor != Color.DimGray)
            {
                timerSupId.Start();
            }
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            prevPoint = Cursor.Position;
        }

        private void txtItemName_Validating(object sender, CancelEventArgs e)
        {
            timerItemId.Start();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            timerSupEmail.Start();
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point(this.Location.X + Cursor.Position.X - prevPoint.X, this.Location.Y + Cursor.Position.Y - prevPoint.Y);
                prevPoint = Cursor.Position;
            }
        }
    }
}
