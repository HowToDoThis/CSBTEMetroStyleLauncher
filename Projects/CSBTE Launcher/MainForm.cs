using System;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

using MaterialSkin;
using MaterialSkin.Controls;
using IniParser;
using IniParser.Model;

namespace CSBTELauncher
{
    public partial class MainForm
    {
        private LauncherSettingsManager launcherSettingsManager;
        private readonly MaterialSkinManager materialSkinManager;

        private Settings mainformSetting = new Settings();

        private string gameLanguage;
        private string localizedGamePath;

        const int CS_DropSHADOW = 0x20000;
        const int GCL_STYLE = (-26);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        private string mapLoadDisable = "Not Load";
        private string[] botDiff = { "Easy", "Medium", "Hard", "Expert" };
        private string botNone = "None";

        private static FileIniDataParser parser = new FileIniDataParser();
    
        private IniData launcherIni;
        private IniData wpnIni;
    
        public MainForm()
        {
            launcherSettingsManager = LauncherSettingsManager.Instance;

            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo300, Accent.Pink200, TextShade.WHITE);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadReg();
            LoadSettings();

            Init();

            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
        }

        private void LoadSettings()
        {
            localizedGamePath = gameLanguage == "english" ? "cstrike" : "cstrike_" + gameLanguage;
            var launcherConfigPath = localizedGamePath + @"\launcher.ini";

            if (!File.Exists(launcherConfigPath))
            {
                launcherConfigPath = @"cstrike\launcher.ini";
                MessageBox.Show(launcherConfigPath + " not found. \nusing cstrike\\launcher.ini");
            }

            if (!File.Exists(launcherConfigPath))
            {
                MessageBox.Show(launcherConfigPath + " not found. \nexit.");
                Close();

                return;
            }

            launcherIni = parser.ReadFile(launcherConfigPath, Encoding.UTF8);

            mapLoadDisable = launcherIni["Launcher"]["MapLoadDisable"]; mapLoadDisable = mapLoadDisable == null ? "Not Load" : mapLoadDisable;
            botDiff[0] = launcherIni["Launcher"]["Easy"]; botDiff[0] = botDiff[0] == null ? "Easy" : botDiff[0];
            botDiff[1] = launcherIni["Launcher"]["Medium"]; botDiff[1] = botDiff[1] == null ? "Medium" : botDiff[1];
            botDiff[2] = launcherIni["Launcher"]["Hard"]; botDiff[2] = botDiff[2] == null ? "Hard" : botDiff[2];
            botDiff[3] = launcherIni["Launcher"]["Expert"]; botDiff[3] = botDiff[3] == null ? "Expert" : botDiff[3];
            botNone = launcherIni["Launcher"]["None"]; botNone = botNone == null ? "None" : botNone;

            checkBoxLoadMap.Checked = mainformSetting.loadMap;
            checkBoxDeleteMdmp.Checked = mainformSetting.deleteMdmp;
            //checkBoxFxaa.Checked = maiformSetting.fxaa;
            checkBoxVSync.Checked = mainformSetting.vsync;
            checkBoxRemoveMouseAcc.Checked = mainformSetting.removeMA;
            //checkBoxWindowNB.Checked = mainformSetting.windowNoBoard;
            checkBoxHDR.Checked = mainformSetting.HDR;

            if (mainformSetting.windowed == 0)
                labelDisplay.Text = toolStripMenuItem6.Text;
            else if (mainformSetting.windowed == 0)
                labelDisplay.Text = toolStripMenuItem7.Text;
            else
                labelDisplay.Text = toolStripMenuItem8.Text;


            if (mainformSetting.af == 0)
                labelAF.Text = toolStripMenuItem0.Text;
            else
                labelAF.Text = mainformSetting.af.ToString() + "X";


            switch (mainformSetting.AA)
            {
                case 0: labelAA.Text = toolStripMenuItemAA0.Text; break;
                case 1: labelAA.Text = toolStripMenuItemMSAA2.Text; break;
                case 2: labelAA.Text = toolStripMenuItemMSAA4.Text; break;
                case 3: labelAA.Text = toolStripMenuItemMSAA8.Text; break;
                case 4: labelAA.Text = toolStripMenuItemCSAA8.Text; break;
                case 5: labelAA.Text = toolStripMenuItemCSAA8Q.Text; break;
                case 6: labelAA.Text = toolStripMenuItemCSAA16.Text; break;
                case 7: labelAA.Text = toolStripMenuItemCSAA16Q.Text; break;
            }

            /*if (mainformSetting.csaa)
                labelAA.Text = toolStripMenuItemAA2.Text;
            else if (mainformSetting.msaa)
                labelAA.Text = toolStripMenuItemMSAA4.Text;
            else
                labelAA.Text = toolStripMenuItemAA3.Text;*/

            launcherSettingsManager.loadMap = mainformSetting.loadMap;
            launcherSettingsManager.editorName = mainformSetting.editorName;
            launcherSettingsManager.lastMap = mainformSetting.lastMap;


            var lastMapLabel = launcherIni["Maps"][mainformSetting.lastMap]; lastMapLabel = lastMapLabel == null ? mainformSetting.lastMap : lastMapLabel;
            labelMapName.Text = checkBoxLoadMap.Checked ? lastMapLabel : mapLoadDisable;

            switch (mainformSetting.weaponLimit)
            {
                case "No": labelWL.Text = labelWL2.Text = noLimitToolStripMenuItem.Text; break;
                case "Sniper": labelWL.Text = labelWL2.Text = sniperGunOnlyToolStripMenuItem.Text; break;
                case "Grenade": labelWL.Text = labelWL2.Text = grenadeOnlyToolStripMenuItem.Text; break;
                case "Pistol": labelWL.Text = labelWL2.Text = pistolOnlyToolStripMenuItem.Text; break;
                case "Knife": labelWL.Text = labelWL2.Text = knifeOnlyToolStripMenuItem.Text; break;
                case "Custom": labelWL.Text = labelWL2.Text = customToolStripMenuItem.Text; break;
                default: mainformSetting.weaponLimit = "No"; labelWL.Text = labelWL2.Text = noLimitToolStripMenuItem.Text; break;
            }

            wpnIni = parser.ReadFile(@"cstrike\addons\amxmodx\configs\bte_wpn_config.ini", Encoding.UTF8);
            textFieldWLC.Text = wpnIni["Base"]["WeaponLimitCustom"];
        
            checkWLC(mainformSetting.weaponLimit == "Custom");

            this.Update();
        }

        private void SaveSettings()
        {
            mainformSetting.loadMap = checkBoxLoadMap.Checked;
            mainformSetting.editorName = launcherSettingsManager.editorName;
            mainformSetting.lastMap = launcherSettingsManager.lastMap;
            mainformSetting.deleteMdmp = checkBoxDeleteMdmp.Checked;
            //maiformSetting.fxaa = checkBoxFxaa.Checked;
            mainformSetting.vsync = checkBoxVSync.Checked;
            mainformSetting.botAmxxControl = checkBoxBotAmxx.Checked;
            mainformSetting.removeMA = checkBoxRemoveMouseAcc.Checked;
            //mainformSetting.windowNoBoard = checkBoxWindowNB.Checked;
            mainformSetting.HDR = checkBoxHDR.Checked;

            wpnIni["Base"]["WeaponLimit"] = mainformSetting.weaponLimit;
            wpnIni["Base"]["WeaponLimitCustom"] = textFieldWLC.Text;

            parser.WriteFile(@"cstrike\addons\amxmodx\configs\bte_wpn_config.ini", wpnIni);

            mainformSetting.Save();

            writeUserCfg();
            writeServerCfg();
        }

        // TODO 读地图耗时较多

        private void Init()
        {
//#if !DEBUG
            DeleteMdmp();
            ModeInit();
            MapInit();
//#endif
            BotInit();

        }

        private void writeServerCfg()
        {
            string path = @"cstrike\addons\amxmodx\configs\bte_launcher.cfg";

            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(@"hostname ""Counter-Strike: BreakThrough Edition Server""");

            if (checkBoxBotAmxx.Checked)
            {
                sw.WriteLine("bot_quota " + mainformSetting.botNum.ToString());
                sw.WriteLine("bot_difficulty " + mainformSetting.botDiff.ToString());
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
                MessageBox.Show("userconfig.cfg not found.\nsome setting cannot save.", "Error");
                return;
            }

            // 先在新的文件中写入要写的内容
            FileStream fs = new FileStream(pathNew, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("// #region Launcher write");
            sw.WriteLine("// lines below will be overwriten");
            sw.WriteLine("gl_vsync " + (checkBoxVSync.Checked ? "1" : "0"));
            //sw.WriteLine("gl_fxaa " + (checkBoxFxaa.Checked ? "1" : "0"));
            sw.WriteLine("gl_ansio " + (mainformSetting.af.ToString()));
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

        private void WriteReg()
        {
            var root = Registry.CurrentUser;
            var hlKey = @"SOFTWARE\Valve\Half-Life\Settings";

            if (IsNumeric(textFieldWidth.Text))
                RegistryHelper.SetRegKeyValue(root, hlKey, "ScreenWidth", Convert.ToInt32(textFieldWidth.Text), RegistryValueKind.DWord);

            if (IsNumeric(textFieldHeigth.Text))
                RegistryHelper.SetRegKeyValue(root, hlKey, "ScreenHeight", Convert.ToInt32(textFieldHeigth.Text), RegistryValueKind.DWord);

            RegistryHelper.SetRegKeyValue(root, hlKey, "ScreenWindowed", (mainformSetting.windowed >= 1) ? 1 : 0, RegistryValueKind.DWord);

            RegistryHelper.SetRegKeyValue(root, hlKey, "ScreenBPP", 32, RegistryValueKind.DWord);
            RegistryHelper.SetRegKeyValue(root, hlKey, "EngineD3D", 0, RegistryValueKind.DWord);
            RegistryHelper.SetRegKeyValue(root, hlKey, "CrashInitializingVideoMode", 0, RegistryValueKind.DWord);
            RegistryHelper.SetRegKeyValue(root, hlKey, "EngineDLL", "hw.dll", RegistryValueKind.String);
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

            textFieldWidth.Text = width;
            textFieldHeigth.Text = height;
            //checkBoxRunInWindow.Checked = (windowed == "1");
            //checkBoxWindowNB.Enabled = checkBoxRunInWindow.Checked;

            if (width == "0" || height == "0")
            {
                textFieldWidth.Text = "1024";
                textFieldHeigth.Text = "768";

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
                    MessageBox.Show("language not found.\nset language to english.", "Warning");
                    RegistryHelper.SetRegKeyValue(root, steamKey, "Language", "english", RegistryValueKind.String);
                    gameLanguage = "english";
                }
            }
        }

        private void DeleteMdmp()
        {
            if (!mainformSetting.deleteMdmp)
                return;

            DirectoryInfo Dir = new DirectoryInfo(@".");
            foreach (FileInfo f in Dir.GetFiles("*." + "mdmp"))
            {
                string file = f.ToString();
                File.Delete(file);
            }
        }

        MaterialRadioButton[] radioButtonBotDiff = new MaterialRadioButton[4];
        bool botBtnInit = false;

        private void BotInit()
        {
            checkBoxBotAmxx.Checked = mainformSetting.botAmxxControl;
            textFieldBotNum.Text = mainformSetting.botNum.ToString();

            SuspendLayout();

            for (int i = 0; i < 4; i++)
            {
                radioButtonBotDiff[i] = new MaterialRadioButton();

                radioButtonBotDiff[i].Location = new System.Drawing.Point(135, 62 + 30 * i);
                radioButtonBotDiff[i].Name = "btnAdd";
                radioButtonBotDiff[i].TabIndex = i;
                radioButtonBotDiff[i].Text = botDiff[i];
                radioButtonBotDiff[i].Tag = i;
                radioButtonBotDiff[i].AutoSize = true;
                radioButtonBotDiff[i].Depth = 0;
                radioButtonBotDiff[i].MouseState = MaterialSkin.MouseState.HOVER;

                if (i == mainformSetting.botDiff)
                    radioButtonBotDiff[i].Checked = true;

                radioButtonBotDiff[i].Click += new System.EventHandler(this.buttonBotDiff_Click);

                tabPageGameBot.Controls.Add(radioButtonBotDiff[i]);
            }

            ResumeLayout(false);

            botBtnInit = true;
            botPanelCheck();

            botTextRebuild();
        }

        private void buttonBotDiff_Click(object sender, EventArgs e)
        {
            MaterialRadioButton btn = (MaterialRadioButton)sender;

            int id = (int)btn.Tag;
            mainformSetting.botDiff = id;

            botTextRebuild();

            /*for (int i = 0; i < 4; i++)
            {
                if (i != id)
                    radioButtonBotDiff[i].Checked = false;
            }*/
        }


        int totalModes;

        GameMode[] gameMode = new GameMode[20];

        private void ModeInit()
        {
            totalModes = 0;

            // 从 ini 读取 添加按钮
            SuspendLayout();

            string modeList = launcherIni["ChangeMod"]["Modes"];
            string[] sMode = modeList.Split(',');

            foreach (string i in sMode)
            {               
                string[] sMode2 = launcherIni["ChangeMod"]["Mode_" + i].Split('#');
                string[] sMode3 = sMode2[1].Split('|');

                gameMode[totalModes] = new GameMode();
                gameMode[totalModes].stringDisable = @"cstrike\addons\amxmodx\configs\" + sMode3[0];
                gameMode[totalModes].stringEnable = @"cstrike\addons\amxmodx\configs\" + sMode3[1];
                gameMode[totalModes].stringName = sMode2[0];

                AddMode(sMode2[0]);
            }

            ResumeLayout(false);

            // 找到现在的模式

            DirectoryInfo Dir = new DirectoryInfo(@"cstrike\addons\amxmodx\configs");

            foreach (FileInfo f in Dir.GetFiles("plugins-*." + "ini"))
            {
                string file = @"cstrike\addons\amxmodx\configs\" + f.ToString();

                for (int i = 0; i < totalModes; i++)
                {
                    if (gameMode[i].stringEnable == file)
                        labelMode.Text = gameMode[i].stringName;
                }
            }
        }

        // TODO 根据文本长度更改 panel 宽度

        private void AddMode(string name)
        {
            MaterialFlatButton btnAdd = new MaterialFlatButton();

            btnAdd.Location = new System.Drawing.Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.TabIndex = 0;
            btnAdd.Text = name;
            btnAdd.Tag = totalModes;
            btnAdd.AutoSize = true;
            btnAdd.Depth = 0;
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Primary = false;

            btnAdd.Click += new System.EventHandler(this.ButtonMode_Click);

            panelModes.Controls.Add(btnAdd);

            btnAdd.Location = new System.Drawing.Point(panelModes.Size.Width - btnAdd.Size.Width - 24, totalModes * 38 + 8);

            totalModes++;
        }

        private void ButtonMode_Click(object sender, EventArgs e)
        {
            MaterialFlatButton btn = (MaterialFlatButton)sender;

            labelMode.Text = btn.Text;

            int targetMode = (int)btn.Tag;

            for (int i = 0; i < totalModes; i++)
            {
                //FileInfo fi;

                if (targetMode == i)
                {
                    if (File.Exists(gameMode[i].stringDisable))
                    {
                        File.Copy(gameMode[i].stringDisable, gameMode[i].stringEnable, true);
                        File.Delete(gameMode[i].stringDisable);
                        /*fi = new FileInfo(gameMode[i].stringDisable);
                        fi.MoveTo(gameMode[i].stringEnable);*/
                    }
                }
                else
                {
                    if (File.Exists(gameMode[i].stringEnable))
                    {
                        File.Copy(gameMode[i].stringEnable, gameMode[i].stringDisable, true);
                        File.Delete(gameMode[i].stringEnable);                        
                        /*fi = new FileInfo(gameMode[i].stringEnable);
                        fi.MoveTo(gameMode[i].stringDisable);*/
                    }
                }
            }
        }


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

                    AddMap(file, 158/*file.Length * 11 + 8*/);
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
            var label = launcherIni["Maps"][name]; label = label == null ? name : label;

            MaterialFlatButton btnAdd = new MaterialFlatButton();
            btnAdd.Location = new System.Drawing.Point(totalMaps / 7 * width + 28, totalMaps % 7 * 38 + 25);
            btnAdd.Name = "btnAdd";
            btnAdd.TabIndex = 0;
            btnAdd.Text = label;
            btnAdd.Tag = name;
            btnAdd.AutoSize = true;
            btnAdd.Depth = 0;
            btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btnAdd.Primary = false;

            btnAdd.Click += new System.EventHandler(this.ButtonMap_Click);

            panelMaps.Controls.Add(btnAdd);

            totalMaps++;
        }

        private string lastMapLabel;

        private void ButtonMap_Click(object sender, EventArgs e)
        {
            MaterialFlatButton btn = (MaterialFlatButton)sender;

            checkBoxLoadMap.Checked = true;

            launcherSettingsManager.lastMap = btn.Tag.ToString();
            lastMapLabel = labelMapName.Text = btn.Text;
            labelMapName.Text = checkBoxLoadMap.Checked ? lastMapLabel : mapLoadDisable;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            SaveSettings();
            WriteReg();

            base.OnClosing(e);
        }

        private void buttonLaunchEditor_Click(object sender, EventArgs e)
        {
            launcherSettingsManager.extraCmd = gameLanguage;
            launcherSettingsManager.LaunchEditor();

        }

        private void buttonLaunchGame_Click(object sender, EventArgs e)
        {
            launcherSettingsManager.extraCmd = checkBoxRemoveMouseAcc.Checked ? " -noforcemaccel -noforcemparms -noforcemspd" : "";
            launcherSettingsManager.extraCmd += (mainformSetting.windowed == 2) ? " -noborder" : "";
            //launcherSettingsManager.extraCmd += (mainformSetting.csaa) ? ("") : ((mainformSetting.msaa) ? " -nocsaa" : " -nomsaa -nocsaa");

            switch (mainformSetting.AA)
            {
                case 0: launcherSettingsManager.extraCmd += " -nomsaa -nocsaa"; break;
                case 1: launcherSettingsManager.extraCmd += " -msaa 2"; break;
                case 2: launcherSettingsManager.extraCmd += " -msaa 4"; break;
                case 3: launcherSettingsManager.extraCmd += " -msaa 8"; break;
                case 4: launcherSettingsManager.extraCmd += " -csaa 8"; break;
                case 5: launcherSettingsManager.extraCmd += " -csaa 8Q"; break;
                case 6: launcherSettingsManager.extraCmd += " -csaa 16"; break;
                case 7: launcherSettingsManager.extraCmd += " -csaa 16Q"; break;
            }

            
            
            launcherSettingsManager.extraCmd += checkBoxHDR.Checked ? "" : " -nohdr";
            launcherSettingsManager.LaunchGame();
            Close();
        }

        private void checkBoxLoadMap_CheckedChanged(object sender, EventArgs e)
        {
            launcherSettingsManager.loadMap = this.checkBoxLoadMap.Checked;

            labelMapName.Text = checkBoxLoadMap.Checked ? lastMapLabel : mapLoadDisable;
        }

        private void flatButtonVideo_Click(object sender, EventArgs e)
        {
            this.tabControlSettings.SelectedIndex = 0;
        }

        private void flatButtonAbout_Click(object sender, EventArgs e)
        {
            this.tabControlSettings.SelectedIndex = 1;
        }

        private void flatButtonLauncher_Click(object sender, EventArgs e)
        {
            this.tabControlSettings.SelectedIndex = 2;
        }

        private void checkBoxFxaa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPageSettingsAdvance_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxDeleteMdmp_CheckedChanged(object sender, EventArgs e)
        {
            mainformSetting.deleteMdmp = checkBoxDeleteMdmp.Checked;
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

        private void labelAF_Click(object sender, EventArgs e)
        {
            materialContextMenuStrip1.Show(labelAF, new Point(0, -materialContextMenuStrip1.Size.Height - 8));
        }

        private void labelAF_TextChanged(object sender, EventArgs e)
        {
            switch (labelAF.Text)
            {
                //case toolStripMenuItem0.Text: mainformSetting.af = 0; break;
                case "2X": mainformSetting.af = 2; break;
                case "4X": mainformSetting.af = 4; break;
                case "8X": mainformSetting.af = 8; break;
                case "16X": mainformSetting.af = 16; break;
                default: { labelAF.Text = toolStripMenuItem0.Text; mainformSetting.af = 0; break; }
            }
        }

        private void toolStripMenuItem0_Click(object sender, EventArgs e)
        {
            labelAF.Text = toolStripMenuItem0.Text;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            labelAF.Text = "2X";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            labelAF.Text = "4X";
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            labelAF.Text = "8X";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            labelAF.Text = "16X";
        }

        private void botPanelCheck()
        {
            if (!botBtnInit)
                return;

            bool enable = checkBoxBotAmxx.Checked;

            foreach (MaterialRadioButton btn in radioButtonBotDiff)
                btn.Enabled = enable;

            textFieldBotNum.Enabled = enable;

            botTextRebuild();
        }

        private void botTextRebuild()
        {
            bool enable = checkBoxBotAmxx.Checked;
            labelBot.Text = enable ? labelBot.Text = botDiff[mainformSetting.botDiff] + " " + textFieldBotNum.Text : botNone;
        }

        private void checkBoxBotAmxx_CheckedChanged(object sender, EventArgs e)
        {
            botPanelCheck();
        }

        private void textFieldBotNum_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(textFieldBotNum.Text))
                return;

            if (Convert.ToInt32(textFieldBotNum.Text) > 32)
                textFieldBotNum.Error = true;
            else
                textFieldBotNum.Error = false;

            if (!textFieldBotNum.Error)
            {                
                mainformSetting.botNum = Convert.ToInt32(textFieldBotNum.Text);
                botTextRebuild();
            }
        }

        private void flatButtonBot_Click(object sender, EventArgs e)
        {
            tabControlGame.SelectedIndex = 0;
        }

        private void flatButtonCommon_Click(object sender, EventArgs e)
        {
            tabControlGame.SelectedIndex = 2;
        }

        private void labelWL_Click(object sender, EventArgs e)
        {
            materialContextMenuStrip2.Show(labelWL, new Point(-25, 30));
        }

        private void noLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelWL.Text = labelWL2.Text = noLimitToolStripMenuItem.Text;
            mainformSetting.weaponLimit = "No";
            checkWLC(false);
        }

        private void sniperGunOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelWL.Text = labelWL2.Text = sniperGunOnlyToolStripMenuItem.Text;
            mainformSetting.weaponLimit = "Sniper";
            checkWLC(false);
        }

        private void grenadeOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelWL.Text = labelWL2.Text = grenadeOnlyToolStripMenuItem.Text;
            mainformSetting.weaponLimit = "Grenade";
            checkWLC(false);
        }

        private void pistolOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelWL.Text = labelWL2.Text = pistolOnlyToolStripMenuItem.Text;
            mainformSetting.weaponLimit = "Pistol";
            checkWLC(false);
        }

        private void knifeOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelWL.Text = labelWL2.Text = knifeOnlyToolStripMenuItem.Text;
            mainformSetting.weaponLimit = "Knife";
            checkWLC(false);
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelWL.Text = labelWL2.Text = customToolStripMenuItem.Text;
            mainformSetting.weaponLimit = "Custom";
            checkWLC(true);
        }

        private void checkWLC(bool enable)
        {
            materialLabel5.Visible = textFieldWLC.Visible = enable;
        }

        private void checkBoxRunInWindow_CheckedChanged(object sender, EventArgs e)
        {
             //checkBoxWindowNB.Enabled = checkBoxRunInWindow.Checked;
        }

        private void labelAA_Click(object sender, EventArgs e)
        {
            materialContextMenuStrip3.Show(new Point(9999, 9999));
            materialContextMenuStrip3.Show(labelAA, new Point(0, -materialContextMenuStrip3.Size.Height - 8));
        }

        private void toolStripMenuItemAA_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            labelAA.Text = item.Text;
            mainformSetting.AA = Convert.ToInt32(item.Tag.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            //materialLabel17.Location = new Point(pb.Location.X, pb.Location.Y - 28);
            //materialLabel17.Visible = !materialLabel17.Visible;
            if (pb.Tag == null)
            {
                pb.Tag = (object)labelAA.Text;
                labelAA.Text = materialLabel17.Text;
            }
            else
            {
                labelAA.Text = pb.Tag.ToString();
                pb.Tag = null;
            }
        }


       /* private void toolStripMenuItemAA1_Click(object sender, EventArgs e)
        {
            labelAA.Text = toolStripMenuItemMSAA4.Text;
            mainformSetting.msaa = true;
            mainformSetting.csaa = false;
        }

        private void toolStripMenuItemAA2_Click(object sender, EventArgs e)
        {
            labelAA.Text = toolStripMenuItemAA2.Text;
            mainformSetting.msaa = true;
            mainformSetting.csaa = true;
        }

        private void toolStripMenuItemAA3_Click(object sender, EventArgs e)
        {
            labelAA.Text = toolStripMenuItemAA3.Text;
            mainformSetting.msaa = false;
            mainformSetting.csaa = false;
        }*/

        private void labelDisplay_Click(object sender, EventArgs e)
        {
            materialContextMenuStrip4.Show(labelDisplay, new Point(0, 26));
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = toolStripMenuItem6.Text;
            mainformSetting.windowed = 0;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = toolStripMenuItem7.Text;
            mainformSetting.windowed = 1;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = toolStripMenuItem8.Text;
            mainformSetting.windowed = 2;
        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IgnaceMaes/MaterialSkin");
        }





        /*private void TextFieldAF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        
        private void TextFieldAF_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                if (!IsNumeric(TextFieldAF.Text))
                {
                    this.TextFieldAF.Error = true;
                    return;
                }

                int AF = Convert.ToInt32(TextFieldAF.Text);
                if (AF == 2 || AF == 4 || AF == 8 || AF == 16)
                {
                    SendKeys.Send("{TAB}");
                    e.Handled = true;
                }
            }
        }

        private void TextFieldAF_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(TextFieldAF.Text))
            {
                this.TextFieldAF.Error = true;
                return;
            }

            int AF = Convert.ToInt32(this.TextFieldAF.Text);
            this.TextFieldAF.Error = (AF == 2 || AF == 4 || AF == 8 || AF == 16) ? false : true;
        }*/
    }
}
