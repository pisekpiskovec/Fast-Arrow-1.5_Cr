namespace Fast_Arrow_1._5
{
    partial class browserMain
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(browserMain));
            this.tURL = new System.Windows.Forms.TextBox();
            this.pContainer = new System.Windows.Forms.Panel();
            this.timerSettings = new System.Windows.Forms.Timer(this.components);
            this.timerNavigation = new System.Windows.Forms.Timer(this.components);
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fastPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikipediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weatherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customFastPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.devToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromiumVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.randomGIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomGIFCurrentNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letsTryLuckToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pURL = new System.Windows.Forms.PictureBox();
            this.bSearchOld = new System.Windows.Forms.PictureBox();
            this.bGoOld = new System.Windows.Forms.PictureBox();
            this.bForwardOld = new System.Windows.Forms.PictureBox();
            this.bBackOld = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lMenu = new System.Windows.Forms.Label();
            this.bCloseOld = new System.Windows.Forms.PictureBox();
            this.lSettings = new System.Windows.Forms.Label();
            this.tSearch = new System.Windows.Forms.TextBox();
            this.bMaxiOld = new System.Windows.Forms.PictureBox();
            this.pSettings = new System.Windows.Forms.PictureBox();
            this.customFastPage1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customFastPage2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customFastPage3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customFastPage4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pURL)).BeginInit();
            this.pURL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSearchOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGoOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bForwardOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBackOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCloseOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMaxiOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSettings)).BeginInit();
            this.pSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tURL
            // 
            this.tURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tURL.BackColor = System.Drawing.Color.White;
            this.tURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tURL.Font = new System.Drawing.Font("Arial", 12F);
            this.tURL.ForeColor = System.Drawing.Color.Black;
            this.tURL.Location = new System.Drawing.Point(153, 12);
            this.tURL.Multiline = true;
            this.tURL.Name = "tURL";
            this.tURL.Size = new System.Drawing.Size(795, 20);
            this.tURL.TabIndex = 3;
            this.tURL.Text = "URL";
            this.tURL.WordWrap = false;
            this.tURL.Enter += new System.EventHandler(this.TURL_Enter);
            this.tURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TURL_KeyPress);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.Location = new System.Drawing.Point(1, 91);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1261, 550);
            this.pContainer.TabIndex = 25;
            // 
            // timerSettings
            // 
            this.timerSettings.Enabled = true;
            this.timerSettings.Tick += new System.EventHandler(this.timerSettings_Tick);
            // 
            // timerNavigation
            // 
            this.timerNavigation.Enabled = true;
            this.timerNavigation.Tick += new System.EventHandler(this.TimerNavigation_Tick);
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fastPagesToolStripMenuItem,
            this.customFastPagesToolStripMenuItem,
            this.toolStripSeparator1,
            this.devToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsMenu.ShowImageMargin = false;
            this.cmsMenu.Size = new System.Drawing.Size(150, 98);
            // 
            // fastPagesToolStripMenuItem
            // 
            this.fastPagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.googleToolStripMenuItem,
            this.youTubeToolStripMenuItem,
            this.wikipediaToolStripMenuItem,
            this.translateToolStripMenuItem,
            this.weatherToolStripMenuItem});
            this.fastPagesToolStripMenuItem.Name = "fastPagesToolStripMenuItem";
            this.fastPagesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.fastPagesToolStripMenuItem.Text = "Fast Pages";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.SearchToolStripMenuItem_Click);
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.googleToolStripMenuItem.Text = "Google";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.bGoogle_Click);
            // 
            // youTubeToolStripMenuItem
            // 
            this.youTubeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.youTubeToolStripMenuItem.Text = "YouTube";
            this.youTubeToolStripMenuItem.Click += new System.EventHandler(this.BYouTube_Click);
            // 
            // wikipediaToolStripMenuItem
            // 
            this.wikipediaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.wikipediaToolStripMenuItem.Name = "wikipediaToolStripMenuItem";
            this.wikipediaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.wikipediaToolStripMenuItem.Text = "Wikipedia";
            this.wikipediaToolStripMenuItem.Click += new System.EventHandler(this.BWikipedia_Click);
            // 
            // translateToolStripMenuItem
            // 
            this.translateToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.translateToolStripMenuItem.Name = "translateToolStripMenuItem";
            this.translateToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.translateToolStripMenuItem.Text = "Translate";
            this.translateToolStripMenuItem.Click += new System.EventHandler(this.TranslateToolStripMenuItem_Click);
            // 
            // weatherToolStripMenuItem
            // 
            this.weatherToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.weatherToolStripMenuItem.Name = "weatherToolStripMenuItem";
            this.weatherToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.weatherToolStripMenuItem.Text = "Weather";
            this.weatherToolStripMenuItem.Click += new System.EventHandler(this.BWeather_Click);
            // 
            // customFastPagesToolStripMenuItem
            // 
            this.customFastPagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customFastPage1ToolStripMenuItem,
            this.customFastPage2ToolStripMenuItem,
            this.customFastPage3ToolStripMenuItem,
            this.customFastPage4ToolStripMenuItem});
            this.customFastPagesToolStripMenuItem.Name = "customFastPagesToolStripMenuItem";
            this.customFastPagesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.customFastPagesToolStripMenuItem.Text = "Custom Fast Pages";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // devToolStripMenuItem
            // 
            this.devToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chromiumVersionToolStripMenuItem,
            this.toolStripSeparator2,
            this.randomGIFToolStripMenuItem,
            this.randomGIFCurrentNumberToolStripMenuItem});
            this.devToolStripMenuItem.Name = "devToolStripMenuItem";
            this.devToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.devToolStripMenuItem.Text = "Dev";
            // 
            // chromiumVersionToolStripMenuItem
            // 
            this.chromiumVersionToolStripMenuItem.Name = "chromiumVersionToolStripMenuItem";
            this.chromiumVersionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.chromiumVersionToolStripMenuItem.Text = "ChromiumVersion";
            this.chromiumVersionToolStripMenuItem.Click += new System.EventHandler(this.ChromiumVersionToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // randomGIFToolStripMenuItem
            // 
            this.randomGIFToolStripMenuItem.Name = "randomGIFToolStripMenuItem";
            this.randomGIFToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.randomGIFToolStripMenuItem.Text = "Random GIF";
            this.randomGIFToolStripMenuItem.Click += new System.EventHandler(this.randomGIFToolStripMenuItem_Click);
            // 
            // randomGIFCurrentNumberToolStripMenuItem
            // 
            this.randomGIFCurrentNumberToolStripMenuItem.Name = "randomGIFCurrentNumberToolStripMenuItem";
            this.randomGIFCurrentNumberToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.randomGIFCurrentNumberToolStripMenuItem.Text = "`Random GIF` Number:";
            this.randomGIFCurrentNumberToolStripMenuItem.Click += new System.EventHandler(this.LetsTryLuckCurrentNumberToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legacyToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.letsTryLuckToolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // legacyToolStripMenuItem
            // 
            this.legacyToolStripMenuItem.Name = "legacyToolStripMenuItem";
            this.legacyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.legacyToolStripMenuItem.Text = "Legacy";
            this.legacyToolStripMenuItem.Click += new System.EventHandler(this.LegacyToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // letsTryLuckToolStripMenuItem1
            // 
            this.letsTryLuckToolStripMenuItem1.Name = "letsTryLuckToolStripMenuItem1";
            this.letsTryLuckToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.letsTryLuckToolStripMenuItem1.Text = "Let\'s Try Luck";
            this.letsTryLuckToolStripMenuItem1.Click += new System.EventHandler(this.LetsTryLuckToolStripMenuItem_Click);
            // 
            // pURL
            // 
            this.pURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pURL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pURL.Controls.Add(this.tURL);
            this.pURL.Controls.Add(this.bSearchOld);
            this.pURL.Controls.Add(this.bGoOld);
            this.pURL.Controls.Add(this.bForwardOld);
            this.pURL.Controls.Add(this.bBackOld);
            this.pURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.pURL.Location = new System.Drawing.Point(0, 45);
            this.pURL.Name = "pURL";
            this.pURL.Size = new System.Drawing.Size(1263, 45);
            this.pURL.TabIndex = 1;
            this.pURL.TabStop = false;
            // 
            // bSearchOld
            // 
            this.bSearchOld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearchOld.BackColor = System.Drawing.Color.Transparent;
            this.bSearchOld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSearchOld.Image = ((System.Drawing.Image)(resources.GetObject("bSearchOld.Image")));
            this.bSearchOld.Location = new System.Drawing.Point(1217, 0);
            this.bSearchOld.Name = "bSearchOld";
            this.bSearchOld.Size = new System.Drawing.Size(45, 45);
            this.bSearchOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bSearchOld.TabIndex = 10;
            this.bSearchOld.TabStop = false;
            this.bSearchOld.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // bGoOld
            // 
            this.bGoOld.BackColor = System.Drawing.Color.Transparent;
            this.bGoOld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGoOld.Image = ((System.Drawing.Image)(resources.GetObject("bGoOld.Image")));
            this.bGoOld.Location = new System.Drawing.Point(102, 0);
            this.bGoOld.Name = "bGoOld";
            this.bGoOld.Size = new System.Drawing.Size(45, 45);
            this.bGoOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bGoOld.TabIndex = 9;
            this.bGoOld.TabStop = false;
            this.bGoOld.Click += new System.EventHandler(this.BGo_Click);
            // 
            // bForwardOld
            // 
            this.bForwardOld.BackColor = System.Drawing.Color.Transparent;
            this.bForwardOld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bForwardOld.Image = ((System.Drawing.Image)(resources.GetObject("bForwardOld.Image")));
            this.bForwardOld.Location = new System.Drawing.Point(51, 0);
            this.bForwardOld.Name = "bForwardOld";
            this.bForwardOld.Size = new System.Drawing.Size(45, 45);
            this.bForwardOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bForwardOld.TabIndex = 8;
            this.bForwardOld.TabStop = false;
            this.bForwardOld.Click += new System.EventHandler(this.BForward_Click);
            // 
            // bBackOld
            // 
            this.bBackOld.BackColor = System.Drawing.Color.Transparent;
            this.bBackOld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBackOld.Image = ((System.Drawing.Image)(resources.GetObject("bBackOld.Image")));
            this.bBackOld.Location = new System.Drawing.Point(0, 0);
            this.bBackOld.Name = "bBackOld";
            this.bBackOld.Size = new System.Drawing.Size(45, 45);
            this.bBackOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bBackOld.TabIndex = 7;
            this.bBackOld.TabStop = false;
            this.bBackOld.Click += new System.EventHandler(this.BBack_Click);
            // 
            // lMenu
            // 
            this.lMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lMenu.AutoEllipsis = true;
            this.lMenu.BackColor = System.Drawing.Color.Transparent;
            this.lMenu.ContextMenuStrip = this.cmsMenu;
            this.lMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lMenu.Location = new System.Drawing.Point(12, 10);
            this.lMenu.Name = "lMenu";
            this.lMenu.Size = new System.Drawing.Size(509, 25);
            this.lMenu.TabIndex = 1;
            this.lMenu.Text = "Menu";
            this.lMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.lMenu, "Menu");
            this.lMenu.Click += new System.EventHandler(this.LMenu_Click);
            // 
            // bCloseOld
            // 
            this.bCloseOld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCloseOld.BackColor = System.Drawing.Color.Transparent;
            this.bCloseOld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCloseOld.Image = ((System.Drawing.Image)(resources.GetObject("bCloseOld.Image")));
            this.bCloseOld.Location = new System.Drawing.Point(1217, 0);
            this.bCloseOld.Name = "bCloseOld";
            this.bCloseOld.Size = new System.Drawing.Size(45, 45);
            this.bCloseOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bCloseOld.TabIndex = 11;
            this.bCloseOld.TabStop = false;
            this.toolTip.SetToolTip(this.bCloseOld, "Close");
            this.bCloseOld.Click += new System.EventHandler(this.bClose_Click);
            // 
            // lSettings
            // 
            this.lSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lSettings.AutoSize = true;
            this.lSettings.BackColor = System.Drawing.Color.Transparent;
            this.lSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lSettings.Location = new System.Drawing.Point(527, 10);
            this.lSettings.Name = "lSettings";
            this.lSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lSettings.Size = new System.Drawing.Size(208, 25);
            this.lSettings.TabIndex = 2;
            this.lSettings.Text = "Fast Arrow: Cr Build21";
            this.lSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.lSettings, "Settings");
            this.lSettings.Click += new System.EventHandler(this.LSettings_Click);
            // 
            // tSearch
            // 
            this.tSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tSearch.BackColor = System.Drawing.Color.White;
            this.tSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.tSearch.ForeColor = System.Drawing.Color.Black;
            this.tSearch.Location = new System.Drawing.Point(954, 57);
            this.tSearch.Multiline = true;
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(257, 20);
            this.tSearch.TabIndex = 26;
            this.tSearch.Text = "Search";
            this.tSearch.WordWrap = false;
            this.tSearch.Enter += new System.EventHandler(this.TSearch_Enter);
            this.tSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TSearch_KeyPress);
            this.tSearch.Leave += new System.EventHandler(this.TSearch_Leave);
            // 
            // bMaxiOld
            // 
            this.bMaxiOld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMaxiOld.BackColor = System.Drawing.Color.Transparent;
            this.bMaxiOld.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMaxiOld.Image = ((System.Drawing.Image)(resources.GetObject("bMaxiOld.Image")));
            this.bMaxiOld.Location = new System.Drawing.Point(1166, 0);
            this.bMaxiOld.Name = "bMaxiOld";
            this.bMaxiOld.Size = new System.Drawing.Size(45, 45);
            this.bMaxiOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bMaxiOld.TabIndex = 12;
            this.bMaxiOld.TabStop = false;
            this.bMaxiOld.Click += new System.EventHandler(this.bMaxi_Click);
            // 
            // pSettings
            // 
            this.pSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pSettings.Controls.Add(this.lSettings);
            this.pSettings.Controls.Add(this.bMaxiOld);
            this.pSettings.Controls.Add(this.bCloseOld);
            this.pSettings.Controls.Add(this.lMenu);
            this.pSettings.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSettings.Location = new System.Drawing.Point(0, 0);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(1263, 45);
            this.pSettings.TabIndex = 0;
            this.pSettings.TabStop = false;
            this.pSettings.DoubleClick += new System.EventHandler(this.PSettings_DoubleClick);
            this.pSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PSettings_MouseDown);
            this.pSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PSettings_MouseMove);
            this.pSettings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PSettings_MouseUp);
            // 
            // customFastPage1ToolStripMenuItem
            // 
            this.customFastPage1ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.customFastPage1ToolStripMenuItem.Name = "customFastPage1ToolStripMenuItem";
            this.customFastPage1ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.customFastPage1ToolStripMenuItem.Text = global::Fast_Arrow_Cr.Properties.Settings.Default.cfpName1;
            this.customFastPage1ToolStripMenuItem.Click += new System.EventHandler(this.CustomFastPage1ToolStripMenuItem_Click);
            // 
            // customFastPage2ToolStripMenuItem
            // 
            this.customFastPage2ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.customFastPage2ToolStripMenuItem.Name = "customFastPage2ToolStripMenuItem";
            this.customFastPage2ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.customFastPage2ToolStripMenuItem.Text = global::Fast_Arrow_Cr.Properties.Settings.Default.cfpName2;
            this.customFastPage2ToolStripMenuItem.Click += new System.EventHandler(this.CustomFastPage2ToolStripMenuItem_Click);
            // 
            // customFastPage3ToolStripMenuItem
            // 
            this.customFastPage3ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.customFastPage3ToolStripMenuItem.Name = "customFastPage3ToolStripMenuItem";
            this.customFastPage3ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.customFastPage3ToolStripMenuItem.Text = global::Fast_Arrow_Cr.Properties.Settings.Default.cfpURL3;
            this.customFastPage3ToolStripMenuItem.Click += new System.EventHandler(this.CustomFastPage3ToolStripMenuItem_Click);
            // 
            // customFastPage4ToolStripMenuItem
            // 
            this.customFastPage4ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.customFastPage4ToolStripMenuItem.Name = "customFastPage4ToolStripMenuItem";
            this.customFastPage4ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.customFastPage4ToolStripMenuItem.Text = global::Fast_Arrow_Cr.Properties.Settings.Default.cfpName4;
            this.customFastPage4ToolStripMenuItem.Click += new System.EventHandler(this.CustomFastPage4ToolStripMenuItem_Click);
            // 
            // browserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 642);
            this.Controls.Add(this.tSearch);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pURL);
            this.Controls.Add(this.pSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(777, 200);
            this.Name = "browserMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Arrow: Cr Build21 - Betria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.browserKeyNavigation);
            this.cmsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pURL)).EndInit();
            this.pURL.ResumeLayout(false);
            this.pURL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSearchOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bGoOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bForwardOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBackOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCloseOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMaxiOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSettings)).EndInit();
            this.pSettings.ResumeLayout(false);
            this.pSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pContainer;
        public System.Windows.Forms.Timer timerSettings;
        public System.Windows.Forms.TextBox tURL;
        public System.Windows.Forms.Timer timerNavigation;
        private System.Windows.Forms.PictureBox pURL;
        private System.Windows.Forms.PictureBox bSearchOld;
        private System.Windows.Forms.PictureBox bGoOld;
        private System.Windows.Forms.PictureBox bForwardOld;
        private System.Windows.Forms.PictureBox bBackOld;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem fastPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wikipediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weatherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customFastPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chromiumVersionToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem customFastPage1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customFastPage2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customFastPage3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customFastPage4ToolStripMenuItem;
        public System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.Label lMenu;
        private System.Windows.Forms.PictureBox bCloseOld;
        private System.Windows.Forms.PictureBox bMaxiOld;
        private System.Windows.Forms.Label lSettings;
        private System.Windows.Forms.PictureBox pSettings;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem randomGIFCurrentNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letsTryLuckToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem randomGIFToolStripMenuItem;
    }
}

