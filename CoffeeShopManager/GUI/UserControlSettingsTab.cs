using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;

namespace GUI
{
    public partial class UserControlSettingsTab : UserControl
    {
        public UserControlSettingsTab()
        {
            InitializeComponent();
        }

        private void btnBrowse_MouseUp(object sender, MouseEventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var ret = fbd.ShowDialog();
                if (ret == DialogResult.OK && string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Properties.Settings.Default.ReceiptSaveFileLocation = fbd.SelectedPath;
                    txtSavePath.Text = fbd.SelectedPath;
                }
            }
        }

        private void UserControlSettingsTab_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ReceiptSaveFileLocation == string.Empty)
            {
                txtSavePath.Text = "(Default: Desktop)";
            }
            else
            {
                txtSavePath.Text = Properties.Settings.Default.ReceiptSaveFileLocation;
            }

            var changeLanguage = new ChangeLanguage();
            if (cboLang.SelectedIndex == 0)
            {
                changeLanguage.UpdateConfig("language", "vi-VN");
            }
            else
            {
                changeLanguage.UpdateConfig("language", "eng");
            }
            var language = ConfigurationManager.AppSettings["language"];
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            this.Controls.Clear();
            this.InitializeComponent();
        }
    }
}
