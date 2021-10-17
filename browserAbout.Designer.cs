namespace Fast_Arrow_1._5
{
    partial class browserAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(browserAbout));
            this.pAbout = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lAbout = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.PictureBox();
            this.pSettings = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.lFastPagesSections = new System.Windows.Forms.Label();
            this.lFastPages = new System.Windows.Forms.Label();
            this.lStartUp = new System.Windows.Forms.Label();
            this.lHome = new System.Windows.Forms.Label();
            this.lEngines = new System.Windows.Forms.Label();
            this.lSearch = new System.Windows.Forms.Label();
            this.lThemes = new System.Windows.Forms.Label();
            this.lTheme = new System.Windows.Forms.Label();
            this.lSettingsReset = new System.Windows.Forms.Label();
            this.listHistoryBrowse = new System.Windows.Forms.ListBox();
            this.listHirstoySearch = new System.Windows.Forms.ListBox();
            this.lHistorySearch = new System.Windows.Forms.Label();
            this.tCFPurl4 = new System.Windows.Forms.TextBox();
            this.tCFPurl3 = new System.Windows.Forms.TextBox();
            this.tCFPurl2 = new System.Windows.Forms.TextBox();
            this.tCFPName4 = new System.Windows.Forms.TextBox();
            this.tCFPName3 = new System.Windows.Forms.TextBox();
            this.tCFPName2 = new System.Windows.Forms.TextBox();
            this.tCFPurl1 = new System.Windows.Forms.TextBox();
            this.tCFPName1 = new System.Windows.Forms.TextBox();
            this.tHomeURL = new System.Windows.Forms.TextBox();
            this.scrollStartUp = new System.Windows.Forms.HScrollBar();
            this.scrollSearch = new System.Windows.Forms.HScrollBar();
            this.scrollTheme = new System.Windows.Forms.HScrollBar();
            this.pAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).BeginInit();
            this.pSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pAbout
            // 
            this.pAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pAbout.BackgroundImage = global::Fast_Arrow_Cr.Properties.Resources.metal;
            this.pAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pAbout.Controls.Add(this.flowLayoutPanel1);
            this.pAbout.Controls.Add(this.lAbout);
            this.pAbout.Controls.Add(this.lTitle);
            this.pAbout.Controls.Add(this.bClose);
            this.pAbout.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pAbout.Location = new System.Drawing.Point(0, 0);
            this.pAbout.Name = "pAbout";
            this.pAbout.Size = new System.Drawing.Size(800, 225);
            this.pAbout.TabIndex = 0;
            this.pAbout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pAbout_MouseDown);
            this.pAbout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pAbout_MouseMove);
            this.pAbout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pAbout_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 225);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 225);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lAbout
            // 
            this.lAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lAbout.AutoSize = true;
            this.lAbout.BackColor = System.Drawing.Color.Transparent;
            this.lAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lAbout.Location = new System.Drawing.Point(12, 37);
            this.lAbout.Name = "lAbout";
            this.lAbout.Size = new System.Drawing.Size(248, 150);
            this.lAbout.TabIndex = 1;
            this.lAbout.Text = "Name: Fast Arrow\r\nVersion: Cr Build21 - Betria\r\nGUI: Panel 1.0.1\r\nChromium: 94.0." +
    "4606.71\r\nPhase: Core\r\n2021";
            this.lAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lTitle
            // 
            this.lTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lTitle.AutoSize = true;
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lTitle.Location = new System.Drawing.Point(368, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lTitle.Size = new System.Drawing.Size(64, 25);
            this.lTitle.TabIndex = 12;
            this.lTitle.Text = "About";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lTitle.Click += new System.EventHandler(this.lTitle_Click);
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.BackColor = System.Drawing.Color.Transparent;
            this.bClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bClose.Image = ((System.Drawing.Image)(resources.GetObject("bClose.Image")));
            this.bClose.Location = new System.Drawing.Point(755, 0);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(45, 45);
            this.bClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bClose.TabIndex = 13;
            this.bClose.TabStop = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // pSettings
            // 
            this.pSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSettings.BackColor = System.Drawing.Color.Transparent;
            this.pSettings.Controls.Add(this.vScrollBar1);
            this.pSettings.Controls.Add(this.tCFPurl4);
            this.pSettings.Controls.Add(this.tCFPurl3);
            this.pSettings.Controls.Add(this.tCFPurl2);
            this.pSettings.Controls.Add(this.tCFPName4);
            this.pSettings.Controls.Add(this.tCFPName3);
            this.pSettings.Controls.Add(this.tCFPName2);
            this.pSettings.Controls.Add(this.tCFPurl1);
            this.pSettings.Controls.Add(this.tCFPName1);
            this.pSettings.Controls.Add(this.lFastPagesSections);
            this.pSettings.Controls.Add(this.lFastPages);
            this.pSettings.Controls.Add(this.tHomeURL);
            this.pSettings.Controls.Add(this.lStartUp);
            this.pSettings.Controls.Add(this.lHome);
            this.pSettings.Controls.Add(this.scrollStartUp);
            this.pSettings.Controls.Add(this.lEngines);
            this.pSettings.Controls.Add(this.lSearch);
            this.pSettings.Controls.Add(this.scrollSearch);
            this.pSettings.Controls.Add(this.lThemes);
            this.pSettings.Controls.Add(this.lTheme);
            this.pSettings.Controls.Add(this.scrollTheme);
            this.pSettings.Controls.Add(this.lSettingsReset);
            this.pSettings.Location = new System.Drawing.Point(0, 225);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(454, 325);
            this.pSettings.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(213, 45);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(39, 271);
            this.vScrollBar1.TabIndex = 35;
            this.vScrollBar1.Visible = false;
            // 
            // lFastPagesSections
            // 
            this.lFastPagesSections.AutoSize = true;
            this.lFastPagesSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lFastPagesSections.Location = new System.Drawing.Point(248, 195);
            this.lFastPagesSections.Name = "lFastPagesSections";
            this.lFastPagesSections.Size = new System.Drawing.Size(169, 20);
            this.lFastPagesSections.TabIndex = 26;
            this.lFastPagesSections.Text = "      Name       |       URL";
            this.lFastPagesSections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lFastPages
            // 
            this.lFastPages.AutoSize = true;
            this.lFastPages.BackColor = System.Drawing.Color.Transparent;
            this.lFastPages.Cursor = System.Windows.Forms.Cursors.Default;
            this.lFastPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lFastPages.Location = new System.Drawing.Point(247, 170);
            this.lFastPages.Name = "lFastPages";
            this.lFastPages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lFastPages.Size = new System.Drawing.Size(111, 25);
            this.lFastPages.TabIndex = 25;
            this.lFastPages.Text = "Fast Pages";
            this.lFastPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lStartUp
            // 
            this.lStartUp.AutoSize = true;
            this.lStartUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStartUp.Location = new System.Drawing.Point(248, 113);
            this.lStartUp.Name = "lStartUp";
            this.lStartUp.Size = new System.Drawing.Size(190, 40);
            this.lStartUp.TabIndex = 23;
            this.lStartUp.Text = "1 - Home page at start up\r\n2 - Last page at start up";
            this.lStartUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lHome
            // 
            this.lHome.AutoSize = true;
            this.lHome.BackColor = System.Drawing.Color.Transparent;
            this.lHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lHome.Location = new System.Drawing.Point(247, 45);
            this.lHome.Name = "lHome";
            this.lHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lHome.Size = new System.Drawing.Size(64, 25);
            this.lHome.TabIndex = 22;
            this.lHome.Text = "Home";
            this.lHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lEngines
            // 
            this.lEngines.AutoSize = true;
            this.lEngines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lEngines.Location = new System.Drawing.Point(5, 192);
            this.lEngines.Name = "lEngines";
            this.lEngines.Size = new System.Drawing.Size(205, 40);
            this.lEngines.TabIndex = 19;
            this.lEngines.Text = "1 - Google 2 - DuckDuckGo\r\n3 - Bing 4 - Wikipedia";
            this.lEngines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.BackColor = System.Drawing.Color.Transparent;
            this.lSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.lSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lSearch.Location = new System.Drawing.Point(4, 147);
            this.lSearch.Name = "lSearch";
            this.lSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lSearch.Size = new System.Drawing.Size(75, 25);
            this.lSearch.TabIndex = 18;
            this.lSearch.Text = "Search";
            this.lSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lThemes
            // 
            this.lThemes.AutoSize = true;
            this.lThemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lThemes.Location = new System.Drawing.Point(5, 90);
            this.lThemes.Name = "lThemes";
            this.lThemes.Size = new System.Drawing.Size(168, 40);
            this.lThemes.TabIndex = 16;
            this.lThemes.Text = "1 - Cyan 2 - Teal 3 - Air\r\n4 - Metal";
            this.lThemes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lTheme
            // 
            this.lTheme.AutoSize = true;
            this.lTheme.BackColor = System.Drawing.Color.Transparent;
            this.lTheme.Cursor = System.Windows.Forms.Cursors.Default;
            this.lTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lTheme.Location = new System.Drawing.Point(4, 45);
            this.lTheme.Name = "lTheme";
            this.lTheme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lTheme.Size = new System.Drawing.Size(74, 25);
            this.lTheme.TabIndex = 15;
            this.lTheme.Text = "Theme";
            this.lTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lSettingsReset
            // 
            this.lSettingsReset.AutoSize = true;
            this.lSettingsReset.BackColor = System.Drawing.Color.Transparent;
            this.lSettingsReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lSettingsReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lSettingsReset.Location = new System.Drawing.Point(158, 9);
            this.lSettingsReset.Name = "lSettingsReset";
            this.lSettingsReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lSettingsReset.Size = new System.Drawing.Size(138, 25);
            this.lSettingsReset.TabIndex = 13;
            this.lSettingsReset.Text = "Reset Settings";
            this.lSettingsReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lSettingsReset.Click += new System.EventHandler(this.lSettingsReset_Click);
            // 
            // listHistoryBrowse
            // 
            this.listHistoryBrowse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listHistoryBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listHistoryBrowse.Enabled = false;
            this.listHistoryBrowse.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.listHistoryBrowse.Location = new System.Drawing.Point(454, 264);
            this.listHistoryBrowse.Name = "listHistoryBrowse";
            this.listHistoryBrowse.Size = new System.Drawing.Size(173, 288);
            this.listHistoryBrowse.TabIndex = 12;
            // 
            // listHirstoySearch
            // 
            this.listHirstoySearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listHirstoySearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listHirstoySearch.Enabled = false;
            this.listHirstoySearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.listHirstoySearch.Location = new System.Drawing.Point(627, 264);
            this.listHirstoySearch.Name = "listHirstoySearch";
            this.listHirstoySearch.Size = new System.Drawing.Size(173, 288);
            this.listHirstoySearch.TabIndex = 13;
            // 
            // lHistorySearch
            // 
            this.lHistorySearch.AutoSize = true;
            this.lHistorySearch.BackColor = System.Drawing.Color.Transparent;
            this.lHistorySearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.lHistorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lHistorySearch.Location = new System.Drawing.Point(594, 234);
            this.lHistorySearch.Name = "lHistorySearch";
            this.lHistorySearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lHistorySearch.Size = new System.Drawing.Size(72, 25);
            this.lHistorySearch.TabIndex = 36;
            this.lHistorySearch.Text = "History";
            this.lHistorySearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tCFPurl4
            // 
            this.tCFPurl4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Fast_Arrow_Cr.Properties.Settings.Default, "cfpURL4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tCFPurl4.Location = new System.Drawing.Point(352, 296);
            this.tCFPurl4.Name = "tCFPurl4";
            this.tCFPurl4.Size = new System.Drawing.Size(93, 20);
            this.tCFPurl4.TabIndex = 34;
            this.tCFPurl4.Text = global::Fast_Arrow_Cr.Properties.Settings.Default.cfpURL4;
            // 
            // tCFPurl3
            // 
            this.tCFPurl3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Fast_Arrow_Cr.Properties.Settings.Default, "cfpURL3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tCFPurl3.Location = new System.Drawing.Point(352, 270);
            this.tCFPurl3.Name = "tCFPurl3";
            this.tCFPurl3.Size = new System.Drawing.Size(93, 20);
            this.tCFPurl3.TabIndex = 32;
            this.tCFPurl3.Text = global::Fast_Arrow_Cr.Properties.Settings.Default.cfpURL3;
            // 
            // tCFPurl2
            // 
            this.tCFPurl2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Fast_Arrow_Cr.Properties.Settings.Default, "cfpURL2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tCFPurl2.Location = new System.Drawing.Point(352, 244);
            this.tCFPurl2.Name = "tCFPurl2";
            this.tCFPurl2.Size = new System.Drawing.Size(93, 20);
            this.tCFPurl2.TabIndex = 30;
            this.tCFPurl2.Text = global::Fast_Arrow_Cr.Properties.Settings.Default.cfpURL2;
            // 
            // tCFPName4
            // 
            this.tCFPName4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Fast_Arrow_Cr.Properties.Settings.Default, "cfpName4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tCFPName4.Location = new System.Drawing.Point(252, 296);
            this.tCFPName4.Name = "tCFPName4";
            this.tCFPName4.Size = new System.Drawing.Size(93, 20);
            this.tCFPName4.TabIndex = 33;
            this.tCFPName4.Text = global::Fast_Arrow_Cr.Properties.Settings.Default.cfpName4;
            // 
            // tCFPName3
            // 
            this.tCFPName3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Fast_Arrow_Cr.Properties.Settings.Default, "cfpName3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tCFPName3.Location = new System.Drawing.Point(252, 270);
            this.tCFPName3.Name = "tCFPName3";
            this.tCFPName3.Size = new System.Drawing.Size(93, 20);
            this.tCFPName3.TabIndex = 31;
            this.tCFPName3.Text = global::Fast_Arrow_Cr.Properties.Settings.Default.cfpName3;
            // 
            // tCFPName2
            // 
            this.tCFPName2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Fast_Arrow_Cr.Properties.Settings.Default, "cfpName2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tCFPName2.Location = new System.Drawing.Point(252, 244);
            this.tCFPName2.Name = "tCFPName2";
            this.tCFPName2.Size = new System.Drawing.Size(93, 20);
            this.tCFPName2.TabIndex = 29;
            this.tCFPName2.Text = global::Fast_Arrow_Cr.Properties.Settings.Default.cfpName2;
            // 
            // tCFPurl1
            // 
            this.tCFPurl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Fast_Arrow_Cr.Properties.Settings.Default, "cfpURL1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tCFPurl1.Location = new System.Drawing.Point(352, 218);
            this.tCFPurl1.Name = "tCFPurl1";
            this.tCFPurl1.Size = new System.Drawing.Size(93, 20);
            this.tCFPurl1.TabIndex = 28;
            this.tCFPurl1.Text = global::Fast_Arrow_Cr.Properties.Settings.Default.cfpURL1;
            // 
            // tCFPName1
            // 
            this.tCFPName1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Fast_Arrow_Cr.Properties.Settings.Default, "cfpName1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tCFPName1.Location = new System.Drawing.Point(252, 218);
            this.tCFPName1.Name = "tCFPName1";
            this.tCFPName1.Size = new System.Drawing.Size(93, 20);
            this.tCFPName1.TabIndex = 27;
            this.tCFPName1.Text = global::Fast_Arrow_Cr.Properties.Settings.Default.cfpName1;
            // 
            // tHomeURL
            // 
            this.tHomeURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Fast_Arrow_Cr.Properties.Settings.Default, "homePage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tHomeURL.Location = new System.Drawing.Point(252, 70);
            this.tHomeURL.Name = "tHomeURL";
            this.tHomeURL.Size = new System.Drawing.Size(180, 20);
            this.tHomeURL.TabIndex = 24;
            this.tHomeURL.Text = global::Fast_Arrow_Cr.Properties.Settings.Default.homePage;
            // 
            // scrollStartUp
            // 
            this.scrollStartUp.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Fast_Arrow_Cr.Properties.Settings.Default, "startupPage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.scrollStartUp.LargeChange = 1;
            this.scrollStartUp.Location = new System.Drawing.Point(252, 93);
            this.scrollStartUp.Maximum = 2;
            this.scrollStartUp.Minimum = 1;
            this.scrollStartUp.Name = "scrollStartUp";
            this.scrollStartUp.Size = new System.Drawing.Size(180, 20);
            this.scrollStartUp.TabIndex = 21;
            this.scrollStartUp.Value = global::Fast_Arrow_Cr.Properties.Settings.Default.startupPage;
            // 
            // scrollSearch
            // 
            this.scrollSearch.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Fast_Arrow_Cr.Properties.Settings.Default, "searchEngine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.scrollSearch.LargeChange = 1;
            this.scrollSearch.Location = new System.Drawing.Point(9, 172);
            this.scrollSearch.Maximum = 4;
            this.scrollSearch.Minimum = 1;
            this.scrollSearch.Name = "scrollSearch";
            this.scrollSearch.Size = new System.Drawing.Size(201, 20);
            this.scrollSearch.TabIndex = 17;
            this.scrollSearch.Value = global::Fast_Arrow_Cr.Properties.Settings.Default.searchEngine;
            // 
            // scrollTheme
            // 
            this.scrollTheme.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Fast_Arrow_Cr.Properties.Settings.Default, "browserTheme", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.scrollTheme.LargeChange = 1;
            this.scrollTheme.Location = new System.Drawing.Point(9, 70);
            this.scrollTheme.Maximum = 4;
            this.scrollTheme.Minimum = 1;
            this.scrollTheme.Name = "scrollTheme";
            this.scrollTheme.Size = new System.Drawing.Size(164, 20);
            this.scrollTheme.TabIndex = 14;
            this.scrollTheme.Value = global::Fast_Arrow_Cr.Properties.Settings.Default.browserTheme;
            this.scrollTheme.ValueChanged += new System.EventHandler(this.saveSettings);
            // 
            // browserAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.ControlBox = false;
            this.Controls.Add(this.lHistorySearch);
            this.Controls.Add(this.listHirstoySearch);
            this.Controls.Add(this.listHistoryBrowse);
            this.Controls.Add(this.pSettings);
            this.Controls.Add(this.pAbout);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "browserAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.pAbout.ResumeLayout(false);
            this.pAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).EndInit();
            this.pSettings.ResumeLayout(false);
            this.pSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pAbout;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.PictureBox bClose;
        private System.Windows.Forms.Label lAbout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pSettings;
        private System.Windows.Forms.Label lSettingsReset;
        private System.Windows.Forms.Label lTheme;
        private System.Windows.Forms.HScrollBar scrollTheme;
        private System.Windows.Forms.Label lEngines;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.HScrollBar scrollSearch;
        private System.Windows.Forms.Label lThemes;
        private System.Windows.Forms.Label lStartUp;
        private System.Windows.Forms.Label lHome;
        private System.Windows.Forms.HScrollBar scrollStartUp;
        private System.Windows.Forms.TextBox tHomeURL;
        private System.Windows.Forms.Label lFastPages;
        private System.Windows.Forms.Label lFastPagesSections;
        private System.Windows.Forms.TextBox tCFPurl4;
        private System.Windows.Forms.TextBox tCFPurl3;
        private System.Windows.Forms.TextBox tCFPurl2;
        private System.Windows.Forms.TextBox tCFPName4;
        private System.Windows.Forms.TextBox tCFPName3;
        private System.Windows.Forms.TextBox tCFPName2;
        private System.Windows.Forms.TextBox tCFPurl1;
        private System.Windows.Forms.TextBox tCFPName1;
        public System.Windows.Forms.ListBox listHistoryBrowse;
        public System.Windows.Forms.ListBox listHirstoySearch;
        private System.Windows.Forms.Label lHistorySearch;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}