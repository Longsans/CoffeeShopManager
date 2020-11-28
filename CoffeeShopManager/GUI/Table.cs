using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Table : UserControl
    {
        string stt;
        public Table()
        {
            InitializeComponent();
        }
        public void SetID(int id)
        {
            lblTable.Text = id.ToString();
        }
        public void SetStatus(string status)
        {
            lblStatus.Text = status;
            if (status == "Available")
                BackColor = Color.FromArgb(186, 243, 157);
            else if (status == "Occupied")
                BackColor = Color.FromArgb(248, 246, 158);
            else BackColor = Color.FromArgb(254, 238, 238);

        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDetailTable = new Form();
            TextBox t = new TextBox();
            frmDetailTable.Controls.Add(t);
            Button btn = new Button();
            frmDetailTable.Controls.Add(btn);
            btn.Click += Btn_Click;
            stt = t.Text;
            frmDetailTable.ShowDialog();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            SetStatus("Ocupied");
        }
    }
}
