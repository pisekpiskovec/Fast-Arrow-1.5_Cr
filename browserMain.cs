using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using Fast_Arrow_Cr.Properties;
using System.Net;
using System.Diagnostics;

namespace Fast_Arrow_1._5
{
    public partial class browserMain : Form
    {
        private browserSettings browSettings = new browserSettings();
        private browserAbout browAbout = new browserAbout();

        private string Title;

        private const int cGrip = 16;

        public browserMain()
        {
            InitializeComponent();

            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToScreen(pos);
                if(pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        public ChromiumWebBrowser facr;

        private void Form1_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
            settings.UserAgent = "Mozilla/5.0 (Windows NT 11.0; Win64; x64; rv:88.0) Gecko/20100101 Firefox/90.0";
            //Initializace
            Cef.Initialize(settings);
            if (Settings.Default.startupPage == 1) facr = new ChromiumWebBrowser(Settings.Default.homePage);
            else if (Settings.Default.startupPage == 2) facr = new ChromiumWebBrowser(Settings.Default.lastVisitedPage);
            else facr = new ChromiumWebBrowser("https://duckduckgo.com/?t=fa");
            this.pContainer.Controls.Add(facr);
            //facr.Dock = DockStyle.Fill;
            facr.AddressChanged += Chrome_AddressChanged;
            facr.TitleChanged += SitesTitleChanged;

            if (!facr.CanGoBack)
                bBackOld.Enabled = false;

            if (!facr.CanGoForward)
                bForwardOld.Enabled = false;

            WebClient webClient = new WebClient();
            try
            {
                if (!webClient.DownloadString("https://pastebin.com/raw/7pW1AfDg").Contains(Settings.Default.browserBuildVersion))
                {
                    MessageBox.Show("There's update avaible. Please install it.", "Update avaible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
            }
        }

        public void browserLoadFromDiferentWindow(string url)
        {
            facr.Load(url);
        }

        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tURL.Text = e.Address;
                browAbout.listHistoryBrowse.Items.Add(e.Address);
                Settings.Default.lastVisitedPage = (e.Address);
            }));
        }

        public void BGo_Click(object sender, EventArgs e)
        {
            facr.Load(tURL.Text);
        }

        private void BRefresh_Click(object sender, EventArgs e)
        {
            facr.Refresh();
        }

        private void BForward_Click(object sender, EventArgs e)
        {
            if (facr.CanGoForward)
                facr.Forward();
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            if (facr.CanGoBack)
                facr.Back();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
            Settings.Default.Save();
        }

        private void TSearch_Enter(object sender, EventArgs e)
        {
            if (tSearch.Text == "Search")
                tSearch.Text = "";
        }

        private void TSearch_Leave(object sender, EventArgs e)
        {
            if (tSearch.Text == "")
                tSearch.Text = "Search";
        }

        public void BSearch_Click(object sender, EventArgs e)
        {
            Search(tSearch.Text);
        }

        public void Search(string text)
        {
            #region Google

            if (Settings.Default.searchEngine == 1)
            {
                if (text != "Search")
                {
                    facr.Load("https://google.com/search?q=" + text);
                }
                else if (text == "")
                {
                    tSearch.Text = "Search";
                    facr.Load("https://google.com/");
                }
            }

            #endregion Google

            #region DDG

            if (Settings.Default.searchEngine == 2)
            {
                if (text != "Search")
                {
                    facr.Load("https://duckduckgo.com/?q=" + text);
                }
                else if (text == "")
                {
                    tSearch.Text = "Search";
                    facr.Load("https://duckduckgo.com/");
                }
            }

            #endregion DDG

            #region Bing

            if (Settings.Default.searchEngine == 3)
            {
                if (text != "Search")
                {
                    facr.Load("https://bing.com/search?q=" + text);
                }
                else if (text == "")
                {
                    tSearch.Text = "Search";
                    facr.Load("https://bing.com/");
                }
            }

            #endregion Bing

            #region Wiki

            if (Settings.Default.searchEngine == 4)
            {
                if (text != "Search")
                {
                    facr.Load("https://en.wikipedia.org/w/index.php?search=" + text);
                }
                else if (text == "")
                {
                    tSearch.Text = "Search";
                    facr.Load("https://wikipedia.org/");
                }
            }

            #endregion Wiki

            if (text != "Search")
                {
                browAbout.listHirstoySearch.Items.Add(text);
            }
        }

        private void LSettings_Click(object sender, EventArgs e)
        {
            browAbout.ShowDialog();
            //browSettings.ShowDialog();
        }

        public void timerSettings_Tick(object sender, EventArgs e)
        {
            #region Themes

            if(Settings.Default.browserTheme == 1)
            {
                pSettings.BackgroundImage = null;
                pURL.BackgroundImage = null;
                pSettings.BackColor = Settings.Default.panelColorCyan;
                pURL.BackColor = Settings.Default.panelColorCyan;
                BackColor = System.Drawing.Color.White;
            }
            else if(Settings.Default.browserTheme == 2)
            {
                pSettings.BackgroundImage = null;
                pURL.BackgroundImage = null;
                pSettings.BackColor = Settings.Default.panelColorTeal;
                pURL.BackColor = Settings.Default.panelColorTeal;
                BackColor = System.Drawing.Color.White;
            }
            else if(Settings.Default.browserTheme == 3)
            {
                pSettings.BackgroundImage = Resources.air;
                pURL.BackgroundImage = Resources.air;
                BackColor = System.Drawing.Color.White;
            }
            else if(Settings.Default.browserTheme == 4)
            {
                pSettings.BackgroundImage = Resources.metal;
                pURL.BackgroundImage = Resources.metal;
                BackColor = System.Drawing.Color.DimGray;
            }

            #endregion Themes

            #region Custom Fast Pages

            if(Settings.Default.cfpName1 == "") { customFastPage1ToolStripMenuItem.Text = "Custom Fast Page 1"; } else customFastPage1ToolStripMenuItem.Text = Settings.Default.cfpName1;
            if (Settings.Default.cfpName2 == "") { customFastPage2ToolStripMenuItem.Text = "Custom Fast Page 2"; } else customFastPage2ToolStripMenuItem.Text = Settings.Default.cfpName2;
            if (Settings.Default.cfpName3 == "") { customFastPage3ToolStripMenuItem.Text = "Custom Fast Page 3"; } else customFastPage3ToolStripMenuItem.Text = Settings.Default.cfpName3;
            if (Settings.Default.cfpName4 == "") { customFastPage4ToolStripMenuItem.Text = "Custom Fast Page 4"; } else customFastPage4ToolStripMenuItem.Text = Settings.Default.cfpName4;

            #endregion Custom Fast Pages

            #region Easter Egg Loading

            //if (Settings.Default.easterEggUrl != "") { facr.Load(Settings.Default.easterEggUrl); Settings.Default.easterEggUrl = ""; }

            #endregion Easter Egg Loading
        }

        private void TURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                facr.Load(tURL.Text);

                e.Handled = true;
            }
        }

        private void TURL_Enter(object sender, System.EventArgs e)
        {
            if (!String.IsNullOrEmpty(tURL.Text))
            {
                tURL.SelectionStart = 0;
                tURL.SelectionLength = tURL.Text.Length;
            }
        }

        private void TSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search(tSearch.Text);

                e.Handled = true;
            }
        }

        private void TimerNavigation_Tick(object sender, EventArgs e)
        {
            #region Navigace vpřed a vzad

            //Zamikání
            if (!facr.CanGoBack)
            {bBackOld.Enabled = false;}

            if (!facr.CanGoForward)
            {bForwardOld.Enabled = false; }

            //Odemikání
            if (facr.CanGoBack)
                bBackOld.Enabled = true;

            if (facr.CanGoForward)
                bForwardOld.Enabled = true;

            #endregion Navigace vpřed a vzad

            #region Nabítka "Menu" → Odemykání

            if (Settings.Default.homePage != "") homeToolStripMenuItem.Enabled = true;
            else homeToolStripMenuItem.Enabled = false;

            #endregion Nabítka "Menu" → Odemykání
        }

        private void browserKeyNavigation(object sender, KeyEventArgs e)
        {
            //Back
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Left)
            {
                if (facr.CanGoBack)
                    facr.Back();
            }

            //Forward
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Right)
            {
                if (facr.CanGoForward)
                    facr.Forward();
            }

            //Refresh #1
            if (e.KeyCode == Keys.F5)
            {
                facr.Refresh();
            }

            //URL
            if (e.KeyCode == Keys.F6)
            {
                tURL.Focus();
            }

            //Refresh #2
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                facr.Refresh();
            }

            //Close window
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.W)
            {
                this.Close();
            }
        }

        private void bGoogle_Click(object sender, EventArgs e)
        {
            facr.Load("https://www.google.com/");
        }

        private void BYouTube_Click(object sender, EventArgs e)
        {
            facr.Load("https://www.youtube.com/");
        }

        private void BWikipedia_Click(object sender, EventArgs e)
        {
            facr.Load("https://www.wikipedia.org/");
        }

        private void BWeather_Click(object sender, EventArgs e)
        {
            facr.Load("https://weather.com/weather/today");
        }

        private void SitesTitleChanged(object sender, TitleChangedEventArgs args)
        {
            Title = args.Title;
            Invoke(new Action(() => lMenu.Text = Title));
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bMaxi_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal") this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void ChromiumVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facr.Load("chrome://version");
        }

        private void LMenu_Click(object sender, EventArgs e)
        {
            cmsMenu.Show();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void PSettings_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void PSettings_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void PSettings_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void PSettings_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal") this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facr.Load(Settings.Default.homePage);
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Default.searchEngine == 1) facr.Load("google.com/");
            else if (Settings.Default.searchEngine == 2) facr.Load("duck.com/");
            else if (Settings.Default.searchEngine == 3) facr.Load("bing.com/");
            else if (Settings.Default.searchEngine == 4) facr.Load("wikipedia.org/");
        }

        private void TranslateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facr.Load("translate.google.com/");
        }

        private void CustomFastPage1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Default.cfpURL1 != "") { facr.Load(Settings.Default.cfpURL1); }
        }

        private void CustomFastPage2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Default.cfpURL2 != "") { facr.Load(Settings.Default.cfpURL2); }
        }

        private void CustomFastPage3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Default.cfpURL3 != "") { facr.Load(Settings.Default.cfpURL3); }
        }

        private void CustomFastPage4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.Default.cfpURL4 != "") { facr.Load(Settings.Default.cfpURL4); }
        }

        private void LegacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browSettings.ShowDialog();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browAbout.ShowDialog();
        }

        public void eEgg(int eggNum)
        {
            if (eggNum == 1) { facr.Load("https://pointerpointer.com/"); }
            else if (eggNum == 2) { browserLoadFromDiferentWindow("https://www.bouncingdvdlogo.com/"); }
            else if (eggNum == 3) { browserLoadFromDiferentWindow("https://trypap.com/"); }
            else if (eggNum == 4) { browserLoadFromDiferentWindow("http://endless.horse/"); }
            else if (eggNum == 5) { browserLoadFromDiferentWindow("https://jcw87.github.io/c2-sans-fight/"); }
            }

        private void LetsTryLuckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Settings.Default.easterEgg = rnd.Next(1, 5);

            eEgg(Settings.Default.easterEgg);
        }

        private void LetsTryLuckCurrentNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            randomGIFCurrentNumberToolStripMenuItem.Text = "`Random GIF` Number: " + Settings.Default.easterGif;
        }

        private void randomGIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Settings.Default.easterGif = rnd.Next(0, 7953);

            facr.Load("https://z0r.de/" + Settings.Default.easterGif);
        }
    }
}