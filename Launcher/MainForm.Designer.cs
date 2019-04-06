namespace Launcher
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.PageHome = new MetroFramework.Controls.MetroTabPage();
            this.LaunchEditor = new MetroFramework.Controls.MetroButton();
            this.NewEditor = new MetroFramework.Controls.MetroCheckBox();
            this.OldEditor = new MetroFramework.Controls.MetroCheckBox();
            this.PanelModes = new MetroFramework.Controls.MetroPanel();
            this.LaunchGame = new MetroFramework.Controls.MetroButton();
            this.Divider2 = new MetroFramework.Controls.MetroLabel();
            this.Divider1 = new MetroFramework.Controls.MetroLabel();
            this.HomeBot = new MetroFramework.Controls.MetroLabel();
            this.HomeMap = new MetroFramework.Controls.MetroLabel();
            this.HomeMode = new MetroFramework.Controls.MetroLabel();
            this.TitleBot = new MetroFramework.Controls.MetroLabel();
            this.TitleMap = new MetroFramework.Controls.MetroLabel();
            this.TitleMode = new MetroFramework.Controls.MetroLabel();
            this.PageMap = new MetroFramework.Controls.MetroTabPage();
            this.PanelMaps = new MetroFramework.Controls.MetroPanel();
            this.PageBot = new MetroFramework.Controls.MetroTabPage();
            this.PanelBotDifficulty = new MetroFramework.Controls.MetroPanel();
            this.BotSYPB = new MetroFramework.Controls.MetroCheckBox();
            this.TitleControl = new MetroFramework.Controls.MetroLabel();
            this.BotZ = new MetroFramework.Controls.MetroCheckBox();
            this.BotQuota = new MetroFramework.Controls.MetroTextBox();
            this.TitleDifficulty = new MetroFramework.Controls.MetroLabel();
            this.TitleNumber = new MetroFramework.Controls.MetroLabel();
            this.PageVideo = new MetroFramework.Controls.MetroTabPage();
            this.PanelAF = new MetroFramework.Controls.MetroPanel();
            this.VideoAF8 = new MetroFramework.Controls.MetroRadioButton();
            this.VideoAF6 = new MetroFramework.Controls.MetroRadioButton();
            this.VideoAF4 = new MetroFramework.Controls.MetroRadioButton();
            this.VideoAF2 = new MetroFramework.Controls.MetroRadioButton();
            this.VideoAFOff = new MetroFramework.Controls.MetroRadioButton();
            this.PanelDisplayMode = new MetroFramework.Controls.MetroPanel();
            this.VideoFullScreen = new MetroFramework.Controls.MetroRadioButton();
            this.VideoWindowed = new MetroFramework.Controls.MetroRadioButton();
            this.VideoWindowedBorderless = new MetroFramework.Controls.MetroRadioButton();
            this.PanelAA = new MetroFramework.Controls.MetroPanel();
            this.VideoMSAA8 = new MetroFramework.Controls.MetroRadioButton();
            this.VideoMSAA4 = new MetroFramework.Controls.MetroRadioButton();
            this.VideoMSAA2 = new MetroFramework.Controls.MetroRadioButton();
            this.VideoAAOff = new MetroFramework.Controls.MetroRadioButton();
            this.TitleAF = new MetroFramework.Controls.MetroLabel();
            this.TitleAA = new MetroFramework.Controls.MetroLabel();
            this.VideoVSync = new MetroFramework.Controls.MetroCheckBox();
            this.VideoHDR = new MetroFramework.Controls.MetroCheckBox();
            this.TitleAdvance = new MetroFramework.Controls.MetroLabel();
            this.TitleDisplay = new MetroFramework.Controls.MetroLabel();
            this.VideoY = new MetroFramework.Controls.MetroTextBox();
            this.MultiplySymbol = new MetroFramework.Controls.MetroLabel();
            this.VideoX = new MetroFramework.Controls.MetroTextBox();
            this.TitleResolution = new MetroFramework.Controls.MetroLabel();
            this.PageOther = new MetroFramework.Controls.MetroTabPage();
            this.OtherDeleteMDMP = new MetroFramework.Controls.MetroButton();
            this.OtherRMA = new MetroFramework.Controls.MetroCheckBox();
            this.OtherLoadMap = new MetroFramework.Controls.MetroCheckBox();
            this.PageAbout = new MetroFramework.Controls.MetroTabPage();
            this.AboutCopyright = new MetroFramework.Controls.MetroLabel();
            this.AboutIniLink = new MetroFramework.Controls.MetroLink();
            this.AboutMetroLink = new MetroFramework.Controls.MetroLink();
            this.AboutNekoMeow = new MetroFramework.Controls.MetroLabel();
            this.AboutNN = new MetroFramework.Controls.MetroLabel();
            this.AboutIni = new MetroFramework.Controls.MetroLabel();
            this.AboutMetro = new MetroFramework.Controls.MetroLabel();
            this.AboutThanks = new MetroFramework.Controls.MetroLabel();
            this.TabControl.SuspendLayout();
            this.PageHome.SuspendLayout();
            this.PageMap.SuspendLayout();
            this.PageBot.SuspendLayout();
            this.PageVideo.SuspendLayout();
            this.PanelAF.SuspendLayout();
            this.PanelDisplayMode.SuspendLayout();
            this.PanelAA.SuspendLayout();
            this.PageOther.SuspendLayout();
            this.PageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.PageHome);
            this.TabControl.Controls.Add(this.PageMap);
            this.TabControl.Controls.Add(this.PageBot);
            this.TabControl.Controls.Add(this.PageVideo);
            this.TabControl.Controls.Add(this.PageOther);
            this.TabControl.Controls.Add(this.PageAbout);
            resources.ApplyResources(this.TabControl, "TabControl");
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.UseSelectable = true;
            // 
            // PageHome
            // 
            this.PageHome.Controls.Add(this.LaunchEditor);
            this.PageHome.Controls.Add(this.NewEditor);
            this.PageHome.Controls.Add(this.OldEditor);
            this.PageHome.Controls.Add(this.PanelModes);
            this.PageHome.Controls.Add(this.LaunchGame);
            this.PageHome.Controls.Add(this.Divider2);
            this.PageHome.Controls.Add(this.Divider1);
            this.PageHome.Controls.Add(this.HomeBot);
            this.PageHome.Controls.Add(this.HomeMap);
            this.PageHome.Controls.Add(this.HomeMode);
            this.PageHome.Controls.Add(this.TitleBot);
            this.PageHome.Controls.Add(this.TitleMap);
            this.PageHome.Controls.Add(this.TitleMode);
            this.PageHome.HorizontalScrollbarBarColor = true;
            this.PageHome.HorizontalScrollbarHighlightOnWheel = false;
            this.PageHome.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PageHome, "PageHome");
            this.PageHome.Name = "PageHome";
            this.PageHome.VerticalScrollbarBarColor = true;
            this.PageHome.VerticalScrollbarHighlightOnWheel = false;
            this.PageHome.VerticalScrollbarSize = 10;
            // 
            // LaunchEditor
            // 
            this.LaunchEditor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.LaunchEditor, "LaunchEditor");
            this.LaunchEditor.Name = "LaunchEditor";
            this.LaunchEditor.UseCustomBackColor = true;
            this.LaunchEditor.UseSelectable = true;
            this.LaunchEditor.UseStyleColors = true;
            this.LaunchEditor.Click += new System.EventHandler(this.LaunchEditor_Click);
            // 
            // NewEditor
            // 
            resources.ApplyResources(this.NewEditor, "NewEditor");
            this.NewEditor.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.NewEditor.Name = "NewEditor";
            this.NewEditor.UseSelectable = true;
            this.NewEditor.CheckedChanged += new System.EventHandler(this.NewEditor_CheckedChanged);
            // 
            // OldEditor
            // 
            resources.ApplyResources(this.OldEditor, "OldEditor");
            this.OldEditor.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.OldEditor.Name = "OldEditor";
            this.OldEditor.UseSelectable = true;
            this.OldEditor.CheckedChanged += new System.EventHandler(this.OldEditor_CheckedChanged);
            // 
            // PanelModes
            // 
            resources.ApplyResources(this.PanelModes, "PanelModes");
            this.PanelModes.HorizontalScrollbar = true;
            this.PanelModes.HorizontalScrollbarBarColor = true;
            this.PanelModes.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelModes.HorizontalScrollbarSize = 5;
            this.PanelModes.Name = "PanelModes";
            this.PanelModes.VerticalScrollbar = true;
            this.PanelModes.VerticalScrollbarBarColor = true;
            this.PanelModes.VerticalScrollbarHighlightOnWheel = false;
            this.PanelModes.VerticalScrollbarSize = 5;
            // 
            // LaunchGame
            // 
            this.LaunchGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.LaunchGame, "LaunchGame");
            this.LaunchGame.Name = "LaunchGame";
            this.LaunchGame.UseCustomBackColor = true;
            this.LaunchGame.UseSelectable = true;
            this.LaunchGame.UseStyleColors = true;
            this.LaunchGame.Click += new System.EventHandler(this.LaunchGame_Click);
            // 
            // Divider2
            // 
            this.Divider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider2.FontSize = MetroFramework.MetroLabelSize.Tall;
            resources.ApplyResources(this.Divider2, "Divider2");
            this.Divider2.Name = "Divider2";
            // 
            // Divider1
            // 
            this.Divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider1.FontSize = MetroFramework.MetroLabelSize.Tall;
            resources.ApplyResources(this.Divider1, "Divider1");
            this.Divider1.Name = "Divider1";
            // 
            // HomeBot
            // 
            resources.ApplyResources(this.HomeBot, "HomeBot");
            this.HomeBot.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.HomeBot.Name = "HomeBot";
            this.HomeBot.Click += new System.EventHandler(this.HomeBot_Click);
            // 
            // HomeMap
            // 
            resources.ApplyResources(this.HomeMap, "HomeMap");
            this.HomeMap.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.HomeMap.Name = "HomeMap";
            this.HomeMap.Click += new System.EventHandler(this.HomeMap_Click);
            // 
            // HomeMode
            // 
            resources.ApplyResources(this.HomeMode, "HomeMode");
            this.HomeMode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.HomeMode.Name = "HomeMode";
            // 
            // TitleBot
            // 
            resources.ApplyResources(this.TitleBot, "TitleBot");
            this.TitleBot.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TitleBot.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleBot.Name = "TitleBot";
            // 
            // TitleMap
            // 
            resources.ApplyResources(this.TitleMap, "TitleMap");
            this.TitleMap.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TitleMap.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleMap.Name = "TitleMap";
            // 
            // TitleMode
            // 
            resources.ApplyResources(this.TitleMode, "TitleMode");
            this.TitleMode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TitleMode.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleMode.Name = "TitleMode";
            // 
            // PageMap
            // 
            this.PageMap.Controls.Add(this.PanelMaps);
            this.PageMap.HorizontalScrollbarBarColor = true;
            this.PageMap.HorizontalScrollbarHighlightOnWheel = false;
            this.PageMap.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PageMap, "PageMap");
            this.PageMap.Name = "PageMap";
            this.PageMap.VerticalScrollbarBarColor = true;
            this.PageMap.VerticalScrollbarHighlightOnWheel = false;
            this.PageMap.VerticalScrollbarSize = 10;
            // 
            // PanelMaps
            // 
            this.PanelMaps.HorizontalScrollbarBarColor = true;
            this.PanelMaps.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelMaps.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PanelMaps, "PanelMaps");
            this.PanelMaps.Name = "PanelMaps";
            this.PanelMaps.VerticalScrollbarBarColor = true;
            this.PanelMaps.VerticalScrollbarHighlightOnWheel = false;
            this.PanelMaps.VerticalScrollbarSize = 10;
            // 
            // PageBot
            // 
            this.PageBot.Controls.Add(this.PanelBotDifficulty);
            this.PageBot.Controls.Add(this.BotSYPB);
            this.PageBot.Controls.Add(this.TitleControl);
            this.PageBot.Controls.Add(this.BotZ);
            this.PageBot.Controls.Add(this.BotQuota);
            this.PageBot.Controls.Add(this.TitleDifficulty);
            this.PageBot.Controls.Add(this.TitleNumber);
            this.PageBot.HorizontalScrollbarBarColor = true;
            this.PageBot.HorizontalScrollbarHighlightOnWheel = false;
            this.PageBot.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PageBot, "PageBot");
            this.PageBot.Name = "PageBot";
            this.PageBot.VerticalScrollbarBarColor = true;
            this.PageBot.VerticalScrollbarHighlightOnWheel = false;
            this.PageBot.VerticalScrollbarSize = 10;
            // 
            // PanelBotDifficulty
            // 
            this.PanelBotDifficulty.HorizontalScrollbarBarColor = true;
            this.PanelBotDifficulty.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelBotDifficulty.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PanelBotDifficulty, "PanelBotDifficulty");
            this.PanelBotDifficulty.Name = "PanelBotDifficulty";
            this.PanelBotDifficulty.VerticalScrollbarBarColor = true;
            this.PanelBotDifficulty.VerticalScrollbarHighlightOnWheel = false;
            this.PanelBotDifficulty.VerticalScrollbarSize = 10;
            // 
            // BotSYPB
            // 
            resources.ApplyResources(this.BotSYPB, "BotSYPB");
            this.BotSYPB.Name = "BotSYPB";
            this.BotSYPB.UseSelectable = true;
            this.BotSYPB.CheckedChanged += new System.EventHandler(this.BotSYPB_CheckedChanged);
            // 
            // TitleControl
            // 
            resources.ApplyResources(this.TitleControl, "TitleControl");
            this.TitleControl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TitleControl.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleControl.Name = "TitleControl";
            // 
            // BotZ
            // 
            resources.ApplyResources(this.BotZ, "BotZ");
            this.BotZ.Name = "BotZ";
            this.BotZ.UseSelectable = true;
            this.BotZ.CheckedChanged += new System.EventHandler(this.BotZ_CheckedChanged);
            // 
            // BotQuota
            // 
            // 
            // 
            // 
            this.BotQuota.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.BotQuota.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.BotQuota.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.BotQuota.CustomButton.Name = "";
            this.BotQuota.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.BotQuota.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BotQuota.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.BotQuota.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BotQuota.CustomButton.UseSelectable = true;
            this.BotQuota.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.BotQuota.Lines = new string[0];
            resources.ApplyResources(this.BotQuota, "BotQuota");
            this.BotQuota.MaxLength = 32767;
            this.BotQuota.Name = "BotQuota";
            this.BotQuota.PasswordChar = '\0';
            this.BotQuota.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BotQuota.SelectedText = "";
            this.BotQuota.SelectionLength = 0;
            this.BotQuota.SelectionStart = 0;
            this.BotQuota.ShortcutsEnabled = true;
            this.BotQuota.UseSelectable = true;
            this.BotQuota.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BotQuota.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.BotQuota.TextChanged += new System.EventHandler(this.BotQuota_TextChanged);
            // 
            // TitleDifficulty
            // 
            resources.ApplyResources(this.TitleDifficulty, "TitleDifficulty");
            this.TitleDifficulty.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TitleDifficulty.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleDifficulty.Name = "TitleDifficulty";
            // 
            // TitleNumber
            // 
            resources.ApplyResources(this.TitleNumber, "TitleNumber");
            this.TitleNumber.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TitleNumber.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleNumber.Name = "TitleNumber";
            // 
            // PageVideo
            // 
            this.PageVideo.Controls.Add(this.PanelAF);
            this.PageVideo.Controls.Add(this.PanelDisplayMode);
            this.PageVideo.Controls.Add(this.PanelAA);
            this.PageVideo.Controls.Add(this.TitleAF);
            this.PageVideo.Controls.Add(this.TitleAA);
            this.PageVideo.Controls.Add(this.VideoVSync);
            this.PageVideo.Controls.Add(this.VideoHDR);
            this.PageVideo.Controls.Add(this.TitleAdvance);
            this.PageVideo.Controls.Add(this.TitleDisplay);
            this.PageVideo.Controls.Add(this.VideoY);
            this.PageVideo.Controls.Add(this.MultiplySymbol);
            this.PageVideo.Controls.Add(this.VideoX);
            this.PageVideo.Controls.Add(this.TitleResolution);
            this.PageVideo.HorizontalScrollbarBarColor = true;
            this.PageVideo.HorizontalScrollbarHighlightOnWheel = false;
            this.PageVideo.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PageVideo, "PageVideo");
            this.PageVideo.Name = "PageVideo";
            this.PageVideo.VerticalScrollbarBarColor = true;
            this.PageVideo.VerticalScrollbarHighlightOnWheel = false;
            this.PageVideo.VerticalScrollbarSize = 10;
            // 
            // PanelAF
            // 
            this.PanelAF.Controls.Add(this.VideoAF8);
            this.PanelAF.Controls.Add(this.VideoAF6);
            this.PanelAF.Controls.Add(this.VideoAF4);
            this.PanelAF.Controls.Add(this.VideoAF2);
            this.PanelAF.Controls.Add(this.VideoAFOff);
            this.PanelAF.HorizontalScrollbarBarColor = true;
            this.PanelAF.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelAF.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PanelAF, "PanelAF");
            this.PanelAF.Name = "PanelAF";
            this.PanelAF.VerticalScrollbarBarColor = true;
            this.PanelAF.VerticalScrollbarHighlightOnWheel = false;
            this.PanelAF.VerticalScrollbarSize = 10;
            // 
            // VideoAF8
            // 
            resources.ApplyResources(this.VideoAF8, "VideoAF8");
            this.VideoAF8.Name = "VideoAF8";
            this.VideoAF8.UseSelectable = true;
            this.VideoAF8.CheckedChanged += new System.EventHandler(this.VideoAF8_CheckedChanged);
            // 
            // VideoAF6
            // 
            resources.ApplyResources(this.VideoAF6, "VideoAF6");
            this.VideoAF6.Name = "VideoAF6";
            this.VideoAF6.UseSelectable = true;
            this.VideoAF6.CheckedChanged += new System.EventHandler(this.VideoAF6_CheckedChanged);
            // 
            // VideoAF4
            // 
            resources.ApplyResources(this.VideoAF4, "VideoAF4");
            this.VideoAF4.Name = "VideoAF4";
            this.VideoAF4.UseSelectable = true;
            this.VideoAF4.CheckedChanged += new System.EventHandler(this.VideoAF4_CheckedChanged);
            // 
            // VideoAF2
            // 
            resources.ApplyResources(this.VideoAF2, "VideoAF2");
            this.VideoAF2.Name = "VideoAF2";
            this.VideoAF2.UseSelectable = true;
            this.VideoAF2.CheckedChanged += new System.EventHandler(this.VideoAF2_CheckedChanged);
            // 
            // VideoAFOff
            // 
            resources.ApplyResources(this.VideoAFOff, "VideoAFOff");
            this.VideoAFOff.Name = "VideoAFOff";
            this.VideoAFOff.UseSelectable = true;
            this.VideoAFOff.CheckedChanged += new System.EventHandler(this.VideoAFOff_CheckedChanged);
            // 
            // PanelDisplayMode
            // 
            this.PanelDisplayMode.Controls.Add(this.VideoFullScreen);
            this.PanelDisplayMode.Controls.Add(this.VideoWindowed);
            this.PanelDisplayMode.Controls.Add(this.VideoWindowedBorderless);
            this.PanelDisplayMode.HorizontalScrollbarBarColor = true;
            this.PanelDisplayMode.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelDisplayMode.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PanelDisplayMode, "PanelDisplayMode");
            this.PanelDisplayMode.Name = "PanelDisplayMode";
            this.PanelDisplayMode.VerticalScrollbarBarColor = true;
            this.PanelDisplayMode.VerticalScrollbarHighlightOnWheel = false;
            this.PanelDisplayMode.VerticalScrollbarSize = 10;
            // 
            // VideoFullScreen
            // 
            resources.ApplyResources(this.VideoFullScreen, "VideoFullScreen");
            this.VideoFullScreen.Name = "VideoFullScreen";
            this.VideoFullScreen.UseSelectable = true;
            this.VideoFullScreen.CheckedChanged += new System.EventHandler(this.VideoFullScreen_CheckedChanged);
            // 
            // VideoWindowed
            // 
            resources.ApplyResources(this.VideoWindowed, "VideoWindowed");
            this.VideoWindowed.Name = "VideoWindowed";
            this.VideoWindowed.UseSelectable = true;
            this.VideoWindowed.CheckedChanged += new System.EventHandler(this.VideoWindowed_CheckedChanged);
            // 
            // VideoWindowedBorderless
            // 
            resources.ApplyResources(this.VideoWindowedBorderless, "VideoWindowedBorderless");
            this.VideoWindowedBorderless.Name = "VideoWindowedBorderless";
            this.VideoWindowedBorderless.UseSelectable = true;
            this.VideoWindowedBorderless.CheckedChanged += new System.EventHandler(this.VideoWindowedBorderless_CheckedChanged);
            // 
            // PanelAA
            // 
            this.PanelAA.Controls.Add(this.VideoMSAA8);
            this.PanelAA.Controls.Add(this.VideoMSAA4);
            this.PanelAA.Controls.Add(this.VideoMSAA2);
            this.PanelAA.Controls.Add(this.VideoAAOff);
            this.PanelAA.HorizontalScrollbarBarColor = true;
            this.PanelAA.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelAA.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PanelAA, "PanelAA");
            this.PanelAA.Name = "PanelAA";
            this.PanelAA.VerticalScrollbarBarColor = true;
            this.PanelAA.VerticalScrollbarHighlightOnWheel = false;
            this.PanelAA.VerticalScrollbarSize = 10;
            // 
            // VideoMSAA8
            // 
            resources.ApplyResources(this.VideoMSAA8, "VideoMSAA8");
            this.VideoMSAA8.Name = "VideoMSAA8";
            this.VideoMSAA8.UseSelectable = true;
            this.VideoMSAA8.CheckedChanged += new System.EventHandler(this.VideoMSAA8_CheckedChanged);
            // 
            // VideoMSAA4
            // 
            resources.ApplyResources(this.VideoMSAA4, "VideoMSAA4");
            this.VideoMSAA4.Name = "VideoMSAA4";
            this.VideoMSAA4.UseSelectable = true;
            this.VideoMSAA4.CheckedChanged += new System.EventHandler(this.VideoMSAA4_CheckedChanged);
            // 
            // VideoMSAA2
            // 
            resources.ApplyResources(this.VideoMSAA2, "VideoMSAA2");
            this.VideoMSAA2.Name = "VideoMSAA2";
            this.VideoMSAA2.UseSelectable = true;
            this.VideoMSAA2.CheckedChanged += new System.EventHandler(this.VideoMSAA2_CheckedChanged);
            // 
            // VideoAAOff
            // 
            resources.ApplyResources(this.VideoAAOff, "VideoAAOff");
            this.VideoAAOff.Name = "VideoAAOff";
            this.VideoAAOff.UseSelectable = true;
            this.VideoAAOff.CheckedChanged += new System.EventHandler(this.VideoAAOff_CheckedChanged);
            // 
            // TitleAF
            // 
            resources.ApplyResources(this.TitleAF, "TitleAF");
            this.TitleAF.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleAF.Name = "TitleAF";
            // 
            // TitleAA
            // 
            resources.ApplyResources(this.TitleAA, "TitleAA");
            this.TitleAA.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleAA.Name = "TitleAA";
            // 
            // VideoVSync
            // 
            resources.ApplyResources(this.VideoVSync, "VideoVSync");
            this.VideoVSync.Name = "VideoVSync";
            this.VideoVSync.UseSelectable = true;
            // 
            // VideoHDR
            // 
            resources.ApplyResources(this.VideoHDR, "VideoHDR");
            this.VideoHDR.Name = "VideoHDR";
            this.VideoHDR.UseSelectable = true;
            // 
            // TitleAdvance
            // 
            resources.ApplyResources(this.TitleAdvance, "TitleAdvance");
            this.TitleAdvance.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TitleAdvance.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleAdvance.Name = "TitleAdvance";
            // 
            // TitleDisplay
            // 
            resources.ApplyResources(this.TitleDisplay, "TitleDisplay");
            this.TitleDisplay.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TitleDisplay.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleDisplay.Name = "TitleDisplay";
            // 
            // VideoY
            // 
            // 
            // 
            // 
            this.VideoY.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.VideoY.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.VideoY.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.VideoY.CustomButton.Name = "";
            this.VideoY.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.VideoY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VideoY.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.VideoY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VideoY.CustomButton.UseSelectable = true;
            this.VideoY.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.VideoY.Lines = new string[0];
            resources.ApplyResources(this.VideoY, "VideoY");
            this.VideoY.MaxLength = 32767;
            this.VideoY.Name = "VideoY";
            this.VideoY.PasswordChar = '\0';
            this.VideoY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VideoY.SelectedText = "";
            this.VideoY.SelectionLength = 0;
            this.VideoY.SelectionStart = 0;
            this.VideoY.ShortcutsEnabled = true;
            this.VideoY.UseSelectable = true;
            this.VideoY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VideoY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MultiplySymbol
            // 
            resources.ApplyResources(this.MultiplySymbol, "MultiplySymbol");
            this.MultiplySymbol.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MultiplySymbol.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MultiplySymbol.Name = "MultiplySymbol";
            // 
            // VideoX
            // 
            // 
            // 
            // 
            this.VideoX.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.VideoX.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.VideoX.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.VideoX.CustomButton.Name = "";
            this.VideoX.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.VideoX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VideoX.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.VideoX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VideoX.CustomButton.UseSelectable = true;
            this.VideoX.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.VideoX.Lines = new string[0];
            resources.ApplyResources(this.VideoX, "VideoX");
            this.VideoX.MaxLength = 32767;
            this.VideoX.Name = "VideoX";
            this.VideoX.PasswordChar = '\0';
            this.VideoX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VideoX.SelectedText = "";
            this.VideoX.SelectionLength = 0;
            this.VideoX.SelectionStart = 0;
            this.VideoX.ShortcutsEnabled = true;
            this.VideoX.UseSelectable = true;
            this.VideoX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VideoX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TitleResolution
            // 
            resources.ApplyResources(this.TitleResolution, "TitleResolution");
            this.TitleResolution.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TitleResolution.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TitleResolution.Name = "TitleResolution";
            // 
            // PageOther
            // 
            this.PageOther.Controls.Add(this.OtherDeleteMDMP);
            this.PageOther.Controls.Add(this.OtherRMA);
            this.PageOther.Controls.Add(this.OtherLoadMap);
            this.PageOther.HorizontalScrollbarBarColor = true;
            this.PageOther.HorizontalScrollbarHighlightOnWheel = false;
            this.PageOther.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PageOther, "PageOther");
            this.PageOther.Name = "PageOther";
            this.PageOther.VerticalScrollbarBarColor = true;
            this.PageOther.VerticalScrollbarHighlightOnWheel = false;
            this.PageOther.VerticalScrollbarSize = 10;
            // 
            // OtherDeleteMDMP
            // 
            this.OtherDeleteMDMP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OtherDeleteMDMP.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            resources.ApplyResources(this.OtherDeleteMDMP, "OtherDeleteMDMP");
            this.OtherDeleteMDMP.Name = "OtherDeleteMDMP";
            this.OtherDeleteMDMP.Style = MetroFramework.MetroColorStyle.Red;
            this.OtherDeleteMDMP.UseCustomBackColor = true;
            this.OtherDeleteMDMP.UseSelectable = true;
            this.OtherDeleteMDMP.UseStyleColors = true;
            this.OtherDeleteMDMP.Click += new System.EventHandler(this.OtherDeleteMDMP_Click);
            // 
            // OtherRMA
            // 
            resources.ApplyResources(this.OtherRMA, "OtherRMA");
            this.OtherRMA.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.OtherRMA.Name = "OtherRMA";
            this.OtherRMA.UseSelectable = true;
            // 
            // OtherLoadMap
            // 
            resources.ApplyResources(this.OtherLoadMap, "OtherLoadMap");
            this.OtherLoadMap.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.OtherLoadMap.Name = "OtherLoadMap";
            this.OtherLoadMap.UseSelectable = true;
            this.OtherLoadMap.CheckedChanged += new System.EventHandler(this.OtherLoadMap_CheckedChanged);
            // 
            // PageAbout
            // 
            this.PageAbout.Controls.Add(this.AboutCopyright);
            this.PageAbout.Controls.Add(this.AboutIniLink);
            this.PageAbout.Controls.Add(this.AboutMetroLink);
            this.PageAbout.Controls.Add(this.AboutNekoMeow);
            this.PageAbout.Controls.Add(this.AboutNN);
            this.PageAbout.Controls.Add(this.AboutIni);
            this.PageAbout.Controls.Add(this.AboutMetro);
            this.PageAbout.Controls.Add(this.AboutThanks);
            this.PageAbout.HorizontalScrollbarBarColor = true;
            this.PageAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.PageAbout.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.PageAbout, "PageAbout");
            this.PageAbout.Name = "PageAbout";
            this.PageAbout.VerticalScrollbarBarColor = true;
            this.PageAbout.VerticalScrollbarHighlightOnWheel = false;
            this.PageAbout.VerticalScrollbarSize = 10;
            // 
            // AboutCopyright
            // 
            resources.ApplyResources(this.AboutCopyright, "AboutCopyright");
            this.AboutCopyright.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.AboutCopyright.Name = "AboutCopyright";
            // 
            // AboutIniLink
            // 
            resources.ApplyResources(this.AboutIniLink, "AboutIniLink");
            this.AboutIniLink.Name = "AboutIniLink";
            this.AboutIniLink.UseSelectable = true;
            this.AboutIniLink.Click += new System.EventHandler(this.AboutIniLink_Click);
            // 
            // AboutMetroLink
            // 
            resources.ApplyResources(this.AboutMetroLink, "AboutMetroLink");
            this.AboutMetroLink.Name = "AboutMetroLink";
            this.AboutMetroLink.UseSelectable = true;
            this.AboutMetroLink.Click += new System.EventHandler(this.AboutMetroLink_Click);
            // 
            // AboutNekoMeow
            // 
            resources.ApplyResources(this.AboutNekoMeow, "AboutNekoMeow");
            this.AboutNekoMeow.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.AboutNekoMeow.Name = "AboutNekoMeow";
            // 
            // AboutNN
            // 
            resources.ApplyResources(this.AboutNN, "AboutNN");
            this.AboutNN.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.AboutNN.Name = "AboutNN";
            // 
            // AboutIni
            // 
            resources.ApplyResources(this.AboutIni, "AboutIni");
            this.AboutIni.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.AboutIni.Name = "AboutIni";
            // 
            // AboutMetro
            // 
            resources.ApplyResources(this.AboutMetro, "AboutMetro");
            this.AboutMetro.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.AboutMetro.Name = "AboutMetro";
            // 
            // AboutThanks
            // 
            resources.ApplyResources(this.AboutThanks, "AboutThanks");
            this.AboutThanks.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.AboutThanks.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.AboutThanks.Name = "AboutThanks";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.TabControl.ResumeLayout(false);
            this.PageHome.ResumeLayout(false);
            this.PageHome.PerformLayout();
            this.PageMap.ResumeLayout(false);
            this.PageBot.ResumeLayout(false);
            this.PageBot.PerformLayout();
            this.PageVideo.ResumeLayout(false);
            this.PageVideo.PerformLayout();
            this.PanelAF.ResumeLayout(false);
            this.PanelAF.PerformLayout();
            this.PanelDisplayMode.ResumeLayout(false);
            this.PanelDisplayMode.PerformLayout();
            this.PanelAA.ResumeLayout(false);
            this.PanelAA.PerformLayout();
            this.PageOther.ResumeLayout(false);
            this.PageOther.PerformLayout();
            this.PageAbout.ResumeLayout(false);
            this.PageAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage PageHome;
        private MetroFramework.Controls.MetroTabPage PageMap;
        private MetroFramework.Controls.MetroLabel HomeBot;
        private MetroFramework.Controls.MetroLabel HomeMap;
        private MetroFramework.Controls.MetroLabel HomeMode;
        private MetroFramework.Controls.MetroLabel TitleBot;
        private MetroFramework.Controls.MetroLabel TitleMap;
        private MetroFramework.Controls.MetroLabel TitleMode;
        private MetroFramework.Controls.MetroLabel Divider1;
        private MetroFramework.Controls.MetroButton LaunchGame;
        private MetroFramework.Controls.MetroLabel Divider2;
        private MetroFramework.Controls.MetroPanel PanelModes;
        private MetroFramework.Controls.MetroButton LaunchEditor;
        private MetroFramework.Controls.MetroCheckBox NewEditor;
        private MetroFramework.Controls.MetroCheckBox OldEditor;
        private MetroFramework.Controls.MetroTabPage PageBot;
        private MetroFramework.Controls.MetroTabPage PageVideo;
        private MetroFramework.Controls.MetroTabPage PageOther;
        private MetroFramework.Controls.MetroTabPage PageAbout;
        private MetroFramework.Controls.MetroPanel PanelMaps;
        private MetroFramework.Controls.MetroCheckBox BotSYPB;
        private MetroFramework.Controls.MetroLabel TitleControl;
        private MetroFramework.Controls.MetroCheckBox BotZ;
        private MetroFramework.Controls.MetroTextBox BotQuota;
        private MetroFramework.Controls.MetroLabel TitleDifficulty;
        private MetroFramework.Controls.MetroLabel TitleNumber;
        private MetroFramework.Controls.MetroRadioButton VideoAF8;
        private MetroFramework.Controls.MetroRadioButton VideoAFOff;
        private MetroFramework.Controls.MetroRadioButton VideoAF2;
        private MetroFramework.Controls.MetroRadioButton VideoAF4;
        private MetroFramework.Controls.MetroRadioButton VideoAF6;
        private MetroFramework.Controls.MetroLabel TitleAF;
        private MetroFramework.Controls.MetroRadioButton VideoAAOff;
        private MetroFramework.Controls.MetroRadioButton VideoMSAA2;
        private MetroFramework.Controls.MetroRadioButton VideoMSAA4;
        private MetroFramework.Controls.MetroRadioButton VideoMSAA8;
        private MetroFramework.Controls.MetroLabel TitleAA;
        private MetroFramework.Controls.MetroCheckBox VideoVSync;
        private MetroFramework.Controls.MetroCheckBox VideoHDR;
        private MetroFramework.Controls.MetroLabel TitleAdvance;
        private MetroFramework.Controls.MetroLabel TitleDisplay;
        private MetroFramework.Controls.MetroTextBox VideoY;
        private MetroFramework.Controls.MetroLabel MultiplySymbol;
        private MetroFramework.Controls.MetroTextBox VideoX;
        private MetroFramework.Controls.MetroLabel TitleResolution;
        private MetroFramework.Controls.MetroButton OtherDeleteMDMP;
        private MetroFramework.Controls.MetroCheckBox OtherRMA;
        private MetroFramework.Controls.MetroCheckBox OtherLoadMap;
        private MetroFramework.Controls.MetroLabel AboutCopyright;
        private MetroFramework.Controls.MetroLink AboutIniLink;
        private MetroFramework.Controls.MetroLink AboutMetroLink;
        private MetroFramework.Controls.MetroLabel AboutNekoMeow;
        private MetroFramework.Controls.MetroLabel AboutNN;
        private MetroFramework.Controls.MetroLabel AboutIni;
        private MetroFramework.Controls.MetroLabel AboutMetro;
        private MetroFramework.Controls.MetroLabel AboutThanks;
        private MetroFramework.Controls.MetroPanel PanelAF;
        private MetroFramework.Controls.MetroPanel PanelDisplayMode;
        private MetroFramework.Controls.MetroPanel PanelAA;
        private MetroFramework.Controls.MetroPanel PanelBotDifficulty;
        private MetroFramework.Controls.MetroRadioButton VideoFullScreen;
        private MetroFramework.Controls.MetroRadioButton VideoWindowed;
        private MetroFramework.Controls.MetroRadioButton VideoWindowedBorderless;
    }
}

