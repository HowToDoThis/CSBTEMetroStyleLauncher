using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using IniParser;
using IniParser.Model;
using Microsoft.Win32;
using MetroFramework;
using MetroFramework.Controls;

namespace Launcher
{
    public partial class Main : MetroForm
    {
        private LauncherSettingsManager LauncherSettings;
        private Setting Setting = new Setting();

        private string gameLanguage;
        private string localizedGamePath;

        private string MapLoadDisable = "Not Load. (Setting in Other > Load Map)";
        private string[] BotDifficulty = { "Easy", "Medium", "Hard", "Expert", };
        private string BotNone = "";

        private static FileIniDataParser parser = new FileIniDataParser();
        private IniData Launcher;
        private IniData Weapon;

        public Main()
        {
            LauncherSettings = LauncherSettingsManager.Instance;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ReadReg();
            LoadSettings();
            Initialize();
            BlackMagic();
        }

        private void BlackMagic()
        {
            // Some Test Function //
            if (File.Exists("WeaponEditor.exe"))
            {
                NewEditor.Checked = true;
            }
            else
            {
                NewEditor.Visible = false;
                OldEditor.CheckState = CheckState.Indeterminate;
            }

            // Sypb and Zbot
            string value = ";win32 addons/sypb/dlls/sypb.dll";
            using (StreamReader streamReader = new StreamReader("cstrike\\addons\\metamod\\plugins.ini"))
            {
                while (!streamReader.EndOfStream)
                {
                    string text = streamReader.ReadLine();
                    if (!string.IsNullOrEmpty(text) && text.IndexOf(value, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        BotZ.Checked = true;
                        BotSYPB.Visible = false;
                    }
                }
            }
        }

        public bool IsNumeric(string str)
        {
            if (str == null || str.Length == 0)
                return false;

            ASCIIEncoding ascii = new ASCIIEncoding();
            byte[] bytestr = ascii.GetBytes(str);

            foreach (byte c in bytestr)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private void ReadReg()
        {
            var root = Registry.CurrentUser;
            var hlKey = @"SOFTWARE\Valve\Half-Life\Settings";

            string width = RegistryHelper.GetRegKeyValue(root, hlKey, "ScreenWidth", "0");
            string height = RegistryHelper.GetRegKeyValue(root, hlKey, "ScreenHeight", "0");
            string windowed = RegistryHelper.GetRegKeyValue(root, hlKey, "ScreenWindowed", "0");
            string key = RegistryHelper.GetRegKeyValue(root, hlKey, "ValveKey", "0");

            if (key == "0")
                RegistryHelper.SetRegKeyValue(root, hlKey, "ValveKey", "55WNH-GSPH7-Q8QQT-AMIYV-3Y5BB", RegistryValueKind.String);

            VideoX.Text = width;
            VideoY.Text = height;

            Setting.DisplayMode = Convert.ToInt32(windowed);

            if (width == "0" || height == "0")
            {
                VideoX.Text = "1024";
                VideoY.Text = "768";

                WriteReg();
            }

            var steamKey = @"SOFTWARE\Valve\Steam";
            gameLanguage = RegistryHelper.GetRegKeyValue(root, steamKey, "Language", null);

            if (gameLanguage == null)
            {
                string sysLang = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
                if (sysLang == "zh-CN")
                {
                    RegistryHelper.SetRegKeyValue(root, steamKey, "Language", "schinese", RegistryValueKind.String);
                    gameLanguage = "schinese";
                }
                else if (sysLang == "Zh-TW")
                {
                    RegistryHelper.SetRegKeyValue(root, steamKey, "Language", "tchinese", RegistryValueKind.String);
                    gameLanguage = "tchinese";
                }
                else if (sysLang == "en-US")
                {
                    RegistryHelper.SetRegKeyValue(root, steamKey, "Language", "english", RegistryValueKind.String);
                    gameLanguage = "english";
                }
                else
                {
                    MetroMessageBox.Show(this, "Language not found.\nSet language to English.", "Warning");
                    RegistryHelper.SetRegKeyValue(root, steamKey, "Language", "english", RegistryValueKind.String);
                    gameLanguage = RegistryHelper.GetRegKeyValue(root, steamKey, "Language", null);
                }
            }
        }

        private void WriteReg()
        {
            var root = Registry.CurrentUser;
            var hlKey = @"SOFTWARE\Valve\Half-Life\Settings";

            if (IsNumeric(VideoX.Text))
                RegistryHelper.SetRegKeyValue(root, hlKey, "ScreenWidth", Convert.ToInt32(VideoX.Text), RegistryValueKind.DWord);

            if (IsNumeric(VideoY.Text))
                RegistryHelper.SetRegKeyValue(root, hlKey, "ScreenHeight", Convert.ToInt32(VideoY.Text), RegistryValueKind.DWord);

            RegistryHelper.SetRegKeyValue(root, hlKey, "ScreenWindowed", (Setting.DisplayMode >= 1) ? 1 : 0, RegistryValueKind.DWord);

            RegistryHelper.SetRegKeyValue(root, hlKey, "ScreenBPP", 32, RegistryValueKind.DWord);
            RegistryHelper.SetRegKeyValue(root, hlKey, "EngineD3D", 0, RegistryValueKind.DWord);
            RegistryHelper.SetRegKeyValue(root, hlKey, "CrashInitializingVideoMode", 0, RegistryValueKind.DWord);
            RegistryHelper.SetRegKeyValue(root, hlKey, "EngineDLL", "hw.dll", RegistryValueKind.String);
        }

        private IniData ReadIniFile(string path)
        {
            return parser.ReadFile(path, GetEncoding(path));
        }

        // https://stackoverflow.com/questions/3825390/effective-way-to-find-any-files-encoding
        // Thanks To 2Toad
        // Based on This Code and Modify
        private static Encoding GetEncoding(string path)
        {
            // First Read File
            var bom = new byte[4];
            using (var file = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf)
                return Encoding.UTF8;
            else
                return Encoding.Default;
        }

        private void LoadSettings()
        {
            localizedGamePath = gameLanguage == "english" ? "cstrike" : "cstrike_" + gameLanguage;
            var LauncherPath = localizedGamePath + @"\launcher.ini";

            // First Try
            if (!File.Exists(LauncherPath))
            {
                MetroMessageBox.Show(this, LauncherPath + " not found.\nUsing Default.", LauncherPath);
                LauncherPath = @"cstrike\launcher.ini";
            }

            // Second Try = Close
            if (!File.Exists(LauncherPath))
            {
                MetroMessageBox.Show(this, LauncherPath + " not found.\nExitting...", LauncherPath);
                Close();

                return;
            }

            Launcher = ReadIniFile(LauncherPath);

            MapLoadDisable = Launcher["Launcher"]["MapLoadDisable"]; MapLoadDisable = MapLoadDisable == null ? "Not Load" : MapLoadDisable;
            BotDifficulty[0] = Launcher["Launcher"]["Easy"]; BotDifficulty[0] = BotDifficulty[0] == null ? "Easy" : BotDifficulty[0];
            BotDifficulty[1] = Launcher["Launcher"]["Medium"]; BotDifficulty[1] = BotDifficulty[1] == null ? "Medium" : BotDifficulty[1];
            BotDifficulty[2] = Launcher["Launcher"]["Hard"]; BotDifficulty[2] = BotDifficulty[2] == null ? "Hard" : BotDifficulty[2];
            BotDifficulty[3] = Launcher["Launcher"]["Expert"]; BotDifficulty[3] = BotDifficulty[3] == null ? "Expert" : BotDifficulty[3];
            BotNone = Launcher["Launcher"]["None"]; BotNone = BotNone == null ? "None" : BotNone;

            OtherLoadMap.Checked = Setting.LoadMap;
            OtherRMA.Checked = Setting.RMA;
            VideoHDR.Checked = Setting.HDR;
            VideoVSync.Checked = Setting.VSync;

            LauncherSettings.LoadMap = Setting.LoadMap;
            LauncherSettings.LastMap = Setting.LastMap;

            switch (Setting.DisplayMode)
            {
                case 0: VideoFullScreen.Checked = true; break;
                case 1: VideoWindowed.Checked = true; break;
                case 2: VideoWindowedBorderless.Checked = true; break;
            }

            switch (Setting.AA)
            {
                case 0: VideoAAOff.Checked = true; break;
                case 1: VideoMSAA2.Checked = true; break;
                case 2: VideoMSAA4.Checked = true; break;
                case 3: VideoMSAA8.Checked = true; break;
            }

            switch (Setting.AF)
            {
                case 0: VideoAFOff.Checked = true; break;
                case 1: VideoAF2.Checked = true; break;
                case 2: VideoAF4.Checked = true; break;
                case 3: VideoAF6.Checked = true; break;
                case 4: VideoAF8.Checked = true; break;
            }

            var lastMapLabel = Launcher["Maps"][Setting.LastMap]; lastMapLabel = lastMapLabel == null ? Setting.LastMap : lastMapLabel;
            HomeMap.Text = OtherLoadMap.Checked ? lastMapLabel : MapLoadDisable;

            Weapon = ReadIniFile(@"cstrike\addons\amxmodx\configs\bte_wpn_config.ini");
            this.Update();
        }

        private void Initialize()
        {
            ModeInit();
            MapInit();
            BotInit();
        }

        #region GameMode

        int totalModes;
        GameMode[] gameMode = new GameMode[2333];
        private void ModeInit()
        {
            totalModes = 0;
            SuspendLayout();

            string modeList = Launcher["ChangeMod"]["Modes"];
            string[] sMode = modeList.Split(',');

            foreach (string i in sMode)
            {
                string[] sMode2 = Launcher["ChangeMod"]["Mode_" + i].Split('#');
                string[] sMode3 = sMode2[1].Split('|');

                gameMode[totalModes] = new GameMode();
                gameMode[totalModes].StringDisable = @"cstrike\addons\amxmodx\configs\" + sMode3[0];
                gameMode[totalModes].StringEnable = @"cstrike\addons\amxmodx\configs\" + sMode3[1];
                gameMode[totalModes].StringName = sMode2[0];

                AddMode(sMode2[0]);
            }

            ResumeLayout(false);

            DirectoryInfo Dir = new DirectoryInfo(@"cstrike\addons\amxmodx\configs");
            foreach (FileInfo f in Dir.GetFiles("plugins-*." + "ini"))
            {
                string file = @"cstrike\addons\amxmodx\configs\" + f.ToString();

                for (int i = 0; i < totalModes; i++)
                {
                    if (gameMode[i].StringEnable == file)
                        HomeMode.Text = gameMode[i].StringName;
                }
            }
        }

        // TODO 根据文本长度更改 panel 宽度
        private void AddMode(string name)
        {
            MetroButton btnAdd = new MetroButton();

            btnAdd.Location = new System.Drawing.Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.TabIndex = 0;
            btnAdd.Text = name;
            btnAdd.Tag = totalModes;
            btnAdd.AutoSize = true;
            btnAdd.UseCustomBackColor = true;
            btnAdd.BackColor = Color.White;
            btnAdd.Click += new System.EventHandler(this.ButtonMode_Click);
            btnAdd.FontWeight = MetroButtonWeight.Regular;

            PanelModes.Controls.Add(btnAdd);
            btnAdd.Location = new System.Drawing.Point(PanelModes.Size.Width - btnAdd.Size.Width - 24, totalModes * 38 + 8);

            totalModes++;
        }

        private void ButtonMode_Click(object sender, EventArgs e)
        {
            MetroButton btn = (MetroButton)sender;

            HomeMode.Text = btn.Text;

            int targetMode = (int)btn.Tag;

            for (int i = 0; i < totalModes; i++)
            {
                if (targetMode == i)
                {
                    if (File.Exists(gameMode[i].StringDisable))
                    {
                        File.Copy(gameMode[i].StringDisable, gameMode[i].StringEnable, true);
                        File.Delete(gameMode[i].StringDisable);
                    }
                }
                else
                {
                    if (File.Exists(gameMode[i].StringEnable))
                    {
                        File.Copy(gameMode[i].StringEnable, gameMode[i].StringDisable, true);
                        File.Delete(gameMode[i].StringEnable);
                    }
                }
            }
        }

        #endregion

        #region Map

        int totalMaps;
        private void MapInit()
        {
            totalMaps = 0;
            SuspendLayout();

            DirectoryInfo Dir = new DirectoryInfo(@"cstrike\maps");
            try
            {
                foreach (FileInfo f in Dir.GetFiles("*." + "bsp"))
                {
                    string file = f.ToString();
                    file = file.Substring(0, file.Length - 4);

                    AddMap(file, 158);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }

            ResumeLayout(false);
        }

        // TODO 根据文本长度更改间隔
        private void AddMap(string name, int width)
        {
            var label = Launcher["Maps"][name]; label = label == null ? name : label;

            MetroButton btnAdd = new MetroButton();
            btnAdd.Location = new System.Drawing.Point(totalMaps / 7 * width + 28, totalMaps % 7 * 38 + 25);
            btnAdd.Name = "btnAdd";
            btnAdd.TabIndex = 0;
            btnAdd.Text = label;
            btnAdd.Tag = name;
            btnAdd.AutoSize = true;
            btnAdd.UseCustomBackColor = true;
            btnAdd.BackColor = Color.White;
            btnAdd.FontWeight = MetroButtonWeight.Regular;

            btnAdd.Click += new System.EventHandler(this.ButtonMap_Click);

            PanelMaps.Controls.Add(btnAdd);

            totalMaps++;
        }

        private string lastMapLabel;
        private void ButtonMap_Click(object sender, EventArgs e)
        {
            MetroButton btn = (MetroButton)sender;

            OtherLoadMap.Checked = true;

            LauncherSettings.LastMap = btn.Tag.ToString();
            lastMapLabel = HomeMap.Text = btn.Text;
            HomeMap.Text = OtherLoadMap.Checked ? lastMapLabel : MapLoadDisable;
        }

        #endregion

        #region Bot

        MetroRadioButton[] radioButtonBotDiff = new MetroRadioButton[4];
        bool botBtnInit = false;
        private void BotInit()
        {
            BotZ.Checked = Setting.BotSwitch;
            BotQuota.Text = Setting.BotQuota.ToString();
            SuspendLayout();

            for (int i = 0; i < 4; i++)
            {
                radioButtonBotDiff[i] = new MetroRadioButton();

                radioButtonBotDiff[i].Location = new System.Drawing.Point(0, 0 + 30 * i);
                radioButtonBotDiff[i].Name = "btnAdd";
                radioButtonBotDiff[i].TabIndex = i;
                radioButtonBotDiff[i].Text = BotDifficulty[i];
                radioButtonBotDiff[i].Tag = i;
                radioButtonBotDiff[i].AutoSize = true;

                if (i == Setting.BotDifficulty)
                    radioButtonBotDiff[i].Checked = true;

                radioButtonBotDiff[i].Click += new System.EventHandler(this.buttonBotDiff_Click);

                PanelBotDifficulty.Controls.Add(radioButtonBotDiff[i]);
            }

            ResumeLayout(false);

            botBtnInit = true;
            botPanelCheck();
            botTextRebuild();
        }

        private void buttonBotDiff_Click(object sender, EventArgs e)
        {
            MetroRadioButton btn = (MetroRadioButton)sender;

            int id = (int)btn.Tag;
            Setting.BotDifficulty = id;

            botTextRebuild();
        }

        private void botPanelCheck()
        {
            if (!botBtnInit)
                return;

            bool enable = BotZ.Checked || BotSYPB.Checked;

            foreach (MetroRadioButton btn in radioButtonBotDiff)
                btn.Enabled = enable;

            BotQuota.Enabled = enable;

            botTextRebuild();
        }

        private void botTextRebuild()
        {
            bool enable = BotZ.Checked || BotSYPB.Checked;
            HomeBot.Text = BotZ.Checked ? "ZBOT " : BotSYPB.Checked ? "SYPB " : BotNone;
            HomeBot.Text += BotDifficulty[Setting.BotDifficulty] + " " + BotQuota.Text;
            //HomeBot.Text = enable ? BotDifficulty[Setting.BotDifficulty] + " " + BotQuota.Text + " " : BotNone;
        }

        private void BotZ_CheckedChanged(object sender, EventArgs e)
        {
            if (BotZ.Checked)
                BotSYPB.Checked = !BotZ.Checked;
            botPanelCheck();
        }

        private void BotSYPB_CheckedChanged(object sender, EventArgs e)
        {
            if (BotSYPB.Checked)
                BotZ.Checked = !BotSYPB.Checked;
            botPanelCheck();
        }

        #endregion

        #region Home

        private void OldEditor_CheckedChanged(object sender, EventArgs e)
        {
            if (OldEditor.Checked)
                NewEditor.Checked = !OldEditor.Checked;
        }

        private void NewEditor_CheckedChanged(object sender, EventArgs e)
        {
            if (NewEditor.Checked)
                OldEditor.Checked = !NewEditor.Checked;
        }

        private void LaunchEditor_Click(object sender, EventArgs e)
        {
            LauncherSettings.ExtraCmd = gameLanguage;
            LauncherSettings.EditorName = OldEditor.Checked ? "CSBTEMyWpnEditor.exe" : NewEditor.Checked ? "WeaponEditor.exe" : "CSBTEMyWpnEditor.exe";
            LauncherSettings.LaunchEditor();
        }

        private void LaunchGame_Click(object sender, EventArgs e)
        {
            LauncherSettings.ExtraCmd = OtherRMA.Checked ? " -noforcemaccel -noforcemparms -noforcemspd" : "";
            LauncherSettings.ExtraCmd += (Setting.DisplayMode == 2) ? " -noborder" : "";

            switch (Setting.AA)
            {
                case 0: LauncherSettings.ExtraCmd += " -nomsaa -nocsaa"; break;
                case 1: LauncherSettings.ExtraCmd += " -msaa 2"; break;
                case 2: LauncherSettings.ExtraCmd += " -msaa 4"; break;
                case 3: LauncherSettings.ExtraCmd += " -msaa 8"; break;
            }

            LauncherSettings.ExtraCmd += VideoHDR.Checked ? "" : " -nohdr";
            LauncherSettings.LaunchGame();
            Close();
        }

        #endregion

        #region Video
        private void BotQuota_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(BotQuota.Text))
                return;

            if (Convert.ToInt32(BotQuota.Text) > 32)
                BotQuota.WithError = true;
            else
                BotQuota.WithError = false;

            if (!BotQuota.WithError)
            {
                Setting.BotQuota = Convert.ToInt32(BotQuota.Text);
                botTextRebuild();
            }
        }

        private void VideoFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoFullScreen.Checked)
                VideoWindowed.Checked = VideoWindowedBorderless.Checked = !VideoFullScreen.Checked;
            Setting.DisplayMode = 0;
        }

        private void VideoWindowed_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoWindowed.Checked)
                VideoFullScreen.Checked = VideoWindowedBorderless.Checked = !VideoWindowed.Checked;
            Setting.DisplayMode = 1;
        }

        private void VideoWindowedBorderless_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoWindowedBorderless.Checked)
                VideoFullScreen.Checked = VideoWindowed.Checked = !VideoWindowedBorderless.Checked;
            Setting.DisplayMode = 2;
        }
        #endregion

        private void OtherDeleteMDMP_Click(object sender, EventArgs e)
        {
            DirectoryInfo Dir = new DirectoryInfo(@".");
            foreach (FileInfo f in Dir.GetFiles("*." + "mdmp"))
            {
                string file = f.ToString();
                File.Delete(file);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
            WriteReg();

            base.OnClosing(e);
        }

        private void SaveSettings()
        {
            Setting.LoadMap = OtherLoadMap.Checked;
            Setting.LastMap = LauncherSettings.LastMap;
            Setting.VSync = VideoVSync.Checked;
            Setting.BotSwitch = BotSYPB.Checked || BotZ.Checked;
            Setting.RMA = OtherRMA.Checked;
            Setting.HDR = VideoHDR.Checked;

            switch (Setting.DisplayMode)
            {
                case 0: Setting.AA = 0; break;
                case 1: Setting.AA = 1; break;
                case 2: Setting.AA = 2; break;
            }

            switch (Setting.AA)
            {
                case 0: Setting.AA = 0; break;
                case 1: Setting.AA = 1; break;
                case 2: Setting.AA = 2; break;
                case 3: Setting.AA = 3; break;
            }

            switch (Setting.AF)
            {
                case 0: Setting.AF = 0; break;
                case 1: Setting.AF = 1; break;
                case 2: Setting.AF = 2; break;
                case 3: Setting.AF = 3; break;
                case 4: Setting.AF = 4; break;
            }

            parser.WriteFile(@"cstrike\addons\amxmodx\configs\bte_wpn_config.ini", Weapon);

            Setting.Save();

            writeUserCfg();
            writeServerCfg();
        }

        private void writeServerCfg()
        {
            string path = @"cstrike\addons\amxmodx\configs\bte_launcher.cfg";

            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(@"hostname ""CS:BTE Server""");

            if (BotZ.Checked)
            {
                sw.WriteLine("bot_quota " + Setting.BotQuota.ToString());
                sw.WriteLine("bot_difficulty " + Setting.BotDifficulty.ToString());
            }

            if (BotSYPB.Checked)
            {
                sw.WriteLine("sypb_quota " + Setting.BotQuota.ToString());
                sw.WriteLine("sypb_difficulty " + Setting.BotDifficulty.ToString());
                sw.WriteLine("sypb_lockzbot 1");
            }

            sw.Flush();
            fs.Flush();
            fs.Close();
        }

        private void writeUserCfg()
        {
            string path = localizedGamePath + @"\userconfig.cfg";
            string pathNew = localizedGamePath + @"\_userconfig.cfg";

            if (!File.Exists(path))
            {
                path = @"cstrike\userconfig.cfg";
                pathNew = @"cstrike\_userconfig.cfg";
            }

            if (!File.Exists(path))
            {
                MetroMessageBox.Show(this, path + " not found.\nSome setting unable to save.", "Error");
                return;
            }

            // 先在新的文件中写入要写的内容
            FileStream fs = new FileStream(pathNew, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("// #region Launcher write");
            sw.WriteLine("// lines below will be overwriten");
            sw.WriteLine("gl_vsync " + (VideoVSync.Checked ? "1" : "0"));
            sw.WriteLine("gl_ansio " + (Setting.AF.ToString()));
            sw.WriteLine("// #endregion");

            // 读旧文件
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string line;
            bool skipline = false;
            while ((line = sr.ReadLine()) != null)
            {
                // 跳过指定区域文件
                if (line == @"// #region Launcher write")
                {
                    skipline = true;
                    continue;
                }

                if (line == @"// #endregion")
                {
                    skipline = false;
                    continue;
                }

                if (!skipline)
                {
                    sw.WriteLine(line);
                }
            }

            sr.Close();
            sw.Flush();
            fs.Flush();
            fs.Close();

            // 掩盖旧文件 并删除临时文件
            File.Copy(pathNew, path, true);
            File.Delete(pathNew);
        }

        private void OtherLoadMap_CheckedChanged(object sender, EventArgs e)
        {
            Setting.LoadMap = this.OtherLoadMap.Checked;

            HomeMap.Text = OtherLoadMap.Checked ? lastMapLabel : MapLoadDisable;
        }

        #region Panel AA

        private void VideoMSAA8_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoMSAA8.Checked)
                VideoAAOff.Checked = VideoMSAA2.Checked = VideoMSAA4.Checked = !VideoMSAA8.Checked;
            Setting.AA = 3;
        }

        private void VideoMSAA4_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoMSAA4.Checked)
                VideoAAOff.Checked = VideoMSAA2.Checked = VideoMSAA8.Checked = !VideoMSAA4.Checked;
            Setting.AA = 2;
        }

        private void VideoMSAA2_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoMSAA2.Checked)
                VideoAAOff.Checked = VideoMSAA8.Checked = VideoMSAA4.Checked = !VideoMSAA2.Checked;
            Setting.AA = 1;
        }

        private void VideoAAOff_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoAAOff.Checked)
                VideoMSAA8.Checked = VideoMSAA2.Checked = VideoMSAA4.Checked = !VideoAAOff.Checked;
            Setting.AA = 0;
        }

        #endregion

        #region Panel AF

        private void VideoAF8_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoAF8.Checked)
                VideoAFOff.Checked = VideoAF2.Checked = VideoAF4.Checked = VideoAF6.Checked = !VideoAF8.Checked;
            Setting.AF = 4;
        }

        private void VideoAF6_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoAF6.Checked)
                VideoAFOff.Checked = VideoAF2.Checked = VideoAF4.Checked = VideoAF8.Checked = !VideoAF6.Checked;
            Setting.AF = 3;
        }

        private void VideoAF4_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoAF4.Checked)
                VideoAFOff.Checked = VideoAF2.Checked = VideoAF8.Checked = VideoAF6.Checked = !VideoAF4.Checked;
            Setting.AF = 2;
        }

        private void VideoAF2_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoAF2.Checked)
                VideoAFOff.Checked = VideoAF8.Checked = VideoAF4.Checked = VideoAF6.Checked = !VideoAF2.Checked;
            Setting.AF = 1;
        }

        private void VideoAFOff_CheckedChanged(object sender, EventArgs e)
        {
            if (VideoAFOff.Checked)
                VideoAF8.Checked = VideoAF2.Checked = VideoAF4.Checked = VideoAF6.Checked = !VideoAFOff.Checked;
            Setting.AF = 0;
        }

        #endregion

        #region Link
        private void AboutMetroLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/dennismagno/metroframework-modern-ui/");
        }

        private void AboutIniLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/rickyah/ini-parser/");
        }
        #endregion

        private void HomeMap_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = PageMap;
        }

        private void HomeBot_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = PageBot;
        }
    }
}
