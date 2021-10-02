using Fast_Arrow_Cr.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fast_Arrow_1._5
{
    public partial class browserAbout : Form
    {
        public browserAbout()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveSettings(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }

        private void lSettingsReset_Click(object sender, EventArgs e)
        {
            //msgBox
            string message = "This process will delete your Custom Fast Pages. Do you want to continue?"; string caption = "Reset Custom Fast Pages?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult;

            dialogResult = MessageBox.Show(message, caption, buttons);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
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

        #region window movement

        private bool mouseDown;
        private Point lastLocation;

        private void pAbout_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pAbout_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pAbout_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion window movement

        private void lTitle_Click(object sender, EventArgs e)
        {
            browserMain browMain = new browserMain();
            Random rnd = new Random();
            Settings.Default.easterEgg = rnd.Next(1, 1);

            browMain.eEgg(rnd.Next(1, 1));
        }
    }
}