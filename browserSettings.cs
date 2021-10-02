using Fast_Arrow_Cr.Properties;
using System;
using System.Windows.Forms;

namespace Fast_Arrow_1._5
{
    public partial class browserSettings : Form
    {
        public browserSettings()
        {
            InitializeComponent();
        }

        private void browserSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Settings.Default.cfpName1 == "" && Settings.Default.cfpURL1 != "") { Settings.Default.cfpURL1 = ""; MessageBox.Show("You must enter a page title in Custom Fast Page 1.", "Error"); }
            if (Settings.Default.cfpURL1 == "" && Settings.Default.cfpName1 != "") { Settings.Default.cfpName1 = ""; MessageBox.Show("You must enter a page URL in Custom Fast Page 1.", "Error"); }

            if (Settings.Default.cfpName2 == "" && Settings.Default.cfpURL2 != "") { Settings.Default.cfpURL2 = ""; MessageBox.Show("You must enter a page title in Custom Fast Page 2.", "Error"); }
            if (Settings.Default.cfpURL2 == "" && Settings.Default.cfpName2 != "") { Settings.Default.cfpName2 = ""; MessageBox.Show("You must enter a page URL in Custom Fast Page 2.", "Error"); }

            if (Settings.Default.cfpName3 == "" && Settings.Default.cfpURL3 != "") { Settings.Default.cfpURL3 = ""; MessageBox.Show("You must enter a page title in Custom Fast Page 3.", "Error"); }
            if (Settings.Default.cfpURL3 == "" && Settings.Default.cfpName3 != "") { Settings.Default.cfpName3 = ""; MessageBox.Show("You must enter a page URL in Custom Fast Page 3.", "Error"); }

            if (Settings.Default.cfpName4 == "" && Settings.Default.cfpURL4 != "") { Settings.Default.cfpURL4 = ""; MessageBox.Show("You must enter a page title in Custom Fast Page 4.", "Error"); }
            if (Settings.Default.cfpURL4 == "" && Settings.Default.cfpName4 != "") { Settings.Default.cfpName4 = ""; MessageBox.Show("You must enter a page URL in Custom Fast Page 4.", "Error"); }

            Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.homePage = tHomeURL.Text;
            Settings.Default.Save();
        }

        private void RadioGoogle_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.searchEngine = 1;
        }

        private void RadioDuck_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.searchEngine = 2;
        }

        private void RadioBing_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.searchEngine = 3;
        }

        private void RadioWiki_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.searchEngine = 4;
        }

        private void BResetSettings_Click(object sender, EventArgs e)
        {
            //msgBox
            string message = "This process will delete your Custom Fast Pages. Do you want to continue?"; string caption = "Reset Custom Fast Pages?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult;

            dialogResult = MessageBox.Show(message, caption, buttons);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                //new settings
                Settings.Default.browserTheme = 4;
                Settings.Default.homePage = "duck.com/?t=fa";
                Settings.Default.searchEngine = 2;
                Settings.Default.startupPage = 1;

                //custom fast pages
                tCFPName1.Text = "";
                tCFPName2.Text = "";
                tCFPName3.Text = "";
                tCFPName4.Text = "";
                tCFPurl1.Text = "";
                tCFPurl2.Text = "";
                tCFPurl3.Text = "";
                tCFPurl4.Text = "";

                Settings.Default.Save();
            }
        }

        private void saveSettings(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }

        private void TCFPName1_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.cfpName1 = tCFPName1.Text;
            Settings.Default.Save();
        }

        private void TCFPName2_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.cfpName2 = tCFPName2.Text;
            Settings.Default.Save();
        }

        private void TCFPName3_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.cfpName3 = tCFPName3.Text;
            Settings.Default.Save();
        }

        private void TCFPName4_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.cfpName4 = tCFPName4.Text;
            Settings.Default.Save();
        }

        private void TCFPurl1_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.cfpURL1 = tCFPurl1.Text;
            Settings.Default.Save();
        }

        private void TCFPurl2_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.cfpURL2 = tCFPurl2.Text;
            Settings.Default.Save();
        }

        private void TCFPurl3_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.cfpURL3 = tCFPurl3.Text;
            Settings.Default.Save();
        }

        private void TCFPurl4_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.cfpURL4 = tCFPurl4.Text;
            Settings.Default.Save();
        }

        private void ListHistoryBrowse_SelectedIndexChanged(object sender, EventArgs e)
        {
            browserMain browMain = new browserMain();
            //browMain.browserLoadFromDiferentWindow(listHistoryBrowse.SelectedItem.ToString());
        }
    }
}