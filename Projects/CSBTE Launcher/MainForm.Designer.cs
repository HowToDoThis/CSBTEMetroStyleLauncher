using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;

namespace CSBTELauncher
{
    partial class MainForm : MaterialForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabSelectorMain = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControlMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.dividerRightTab1 = new MaterialSkin.Controls.MaterialDivider();
            this.panelModes = new System.Windows.Forms.Panel();
            this.labelWL2 = new MaterialSkin.Controls.MaterialLabel();
            this.labelBot = new MaterialSkin.Controls.MaterialLabel();
            this.labelMode = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.labelMapName = new MaterialSkin.Controls.MaterialLabel();
            this.buttonLaunchEditor = new MaterialSkin.Controls.MaterialFlatButton();
            this.buttonLaunchGame = new MaterialSkin.Controls.MaterialFlatButton();
            this.dividerBottom = new MaterialSkin.Controls.MaterialDivider();
            this.tabPageMap = new System.Windows.Forms.TabPage();
            this.panelMaps = new MaterialSkin.Controls.MaterialPanel();
            this.tabPageGame = new System.Windows.Forms.TabPage();
            this.flatButtonCommon = new MaterialSkin.Controls.MaterialFlatButton();
            this.flatButtonBot = new MaterialSkin.Controls.MaterialFlatButton();
            this.dividerRightTab3 = new MaterialSkin.Controls.MaterialDivider();
            this.tabControlGame = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageGameBot = new System.Windows.Forms.TabPage();
            this.checkBoxBotAmxx = new MaterialSkin.Controls.MaterialCheckBox();
            this.textFieldBotNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageGameCommon = new System.Windows.Forms.TabPage();
            this.checkBoxULBPAMMO = new MaterialSkin.Controls.MaterialCheckBox();
            this.textFieldWLC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.labelWL = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabControlSettings = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageSettingsVideo = new System.Windows.Forms.TabPage();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.labelDisplay = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.checkBoxHDR = new MaterialSkin.Controls.MaterialCheckBox();
            this.labelAA = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.labelAF = new MaterialSkin.Controls.MaterialLabel();
            this.checkBoxVSync = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldHeigth = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.textFieldWidth = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageSettingsAbout = new System.Windows.Forms.TabPage();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageSettingsLauncher = new System.Windows.Forms.TabPage();
            this.checkBoxRemoveMouseAcc = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkBoxDeleteMdmp = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkBoxLoadMap = new MaterialSkin.Controls.MaterialCheckBox();
            this.flatButtonLauncher = new MaterialSkin.Controls.MaterialFlatButton();
            this.flatButtonAbout = new MaterialSkin.Controls.MaterialFlatButton();
            this.flatButtonVideo = new MaterialSkin.Controls.MaterialFlatButton();
            this.dividerRightTab4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolStripMenuItem4 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripMenuItem3 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripMenuItem2 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripMenuItem1 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripMenuItem0 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialContextMenuStrip2 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.noLimitToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.sniperGunOnlyToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.grenadeOnlyToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.pistolOnlyToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.knifeOnlyToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.customToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialContextMenuStrip3 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolStripMenuItemCSAA16Q = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripMenuItemCSAA16 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripMenuItemCSAA8Q = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripMenuItemCSAA8 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripMenuItemMSAA8 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripMenuItemMSAA4 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripMenuItemMSAA2 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripMenuItemAA0 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialContextMenuStrip4 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolStripMenuItem6 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripMenuItem7 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripMenuItem8 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.tabControlMain.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.tabPageMap.SuspendLayout();
            this.tabPageGame.SuspendLayout();
            this.tabControlGame.SuspendLayout();
            this.tabPageGameBot.SuspendLayout();
            this.tabPageGameCommon.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPageSettingsVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageSettingsAbout.SuspendLayout();
            this.tabPageSettingsLauncher.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.materialContextMenuStrip2.SuspendLayout();
            this.materialContextMenuStrip3.SuspendLayout();
            this.materialContextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSelectorMain
            // 
            this.tabSelectorMain.BaseTabControl = this.tabControlMain;
            this.tabSelectorMain.Depth = 0;
            resources.ApplyResources(this.tabSelectorMain, "tabSelectorMain");
            this.tabSelectorMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorMain.Name = "tabSelectorMain";
            // 
            // tabControlMain
            // 
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Controls.Add(this.tabPageHome);
            this.tabControlMain.Controls.Add(this.tabPageMap);
            this.tabControlMain.Controls.Add(this.tabPageGame);
            this.tabControlMain.Controls.Add(this.tabPageSettings);
            this.tabControlMain.Depth = 0;
            this.tabControlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.dividerRightTab1);
            this.tabPageHome.Controls.Add(this.panelModes);
            this.tabPageHome.Controls.Add(this.labelWL2);
            this.tabPageHome.Controls.Add(this.labelBot);
            this.tabPageHome.Controls.Add(this.labelMode);
            this.tabPageHome.Controls.Add(this.materialLabel4);
            this.tabPageHome.Controls.Add(this.materialLabel3);
            this.tabPageHome.Controls.Add(this.materialLabel2);
            this.tabPageHome.Controls.Add(this.materialLabel1);
            this.tabPageHome.Controls.Add(this.labelMapName);
            this.tabPageHome.Controls.Add(this.buttonLaunchEditor);
            this.tabPageHome.Controls.Add(this.buttonLaunchGame);
            this.tabPageHome.Controls.Add(this.dividerBottom);
            resources.ApplyResources(this.tabPageHome, "tabPageHome");
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // dividerRightTab1
            // 
            this.dividerRightTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dividerRightTab1.Depth = 0;
            resources.ApplyResources(this.dividerRightTab1, "dividerRightTab1");
            this.dividerRightTab1.MouseState = MaterialSkin.MouseState.HOVER;
            this.dividerRightTab1.Name = "dividerRightTab1";
            this.dividerRightTab1.TabStop = false;
            // 
            // panelModes
            // 
            resources.ApplyResources(this.panelModes, "panelModes");
            this.panelModes.Name = "panelModes";
            // 
            // labelWL2
            // 
            resources.ApplyResources(this.labelWL2, "labelWL2");
            this.labelWL2.Depth = 0;
            this.labelWL2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWL2.FontSize10 = false;
            this.labelWL2.FontWeightMedium = false;
            this.labelWL2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWL2.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelWL2.Name = "labelWL2";
            // 
            // labelBot
            // 
            resources.ApplyResources(this.labelBot, "labelBot");
            this.labelBot.Depth = 0;
            this.labelBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBot.FontSize10 = false;
            this.labelBot.FontWeightMedium = false;
            this.labelBot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBot.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelBot.Name = "labelBot";
            // 
            // labelMode
            // 
            resources.ApplyResources(this.labelMode, "labelMode");
            this.labelMode.Depth = 0;
            this.labelMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMode.FontSize10 = false;
            this.labelMode.FontWeightMedium = false;
            this.labelMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMode.Name = "labelMode";
            // 
            // materialLabel4
            // 
            resources.ApplyResources(this.materialLabel4, "materialLabel4");
            this.materialLabel4.Depth = 0;
            this.materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel4.FontSize10 = false;
            this.materialLabel4.FontWeightMedium = true;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel3.FontSize10 = false;
            this.materialLabel3.FontWeightMedium = true;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.FontSize10 = false;
            this.materialLabel2.FontWeightMedium = true;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.FontSize10 = false;
            this.materialLabel1.FontWeightMedium = true;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // labelMapName
            // 
            resources.ApplyResources(this.labelMapName, "labelMapName");
            this.labelMapName.Depth = 0;
            this.labelMapName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMapName.FontSize10 = false;
            this.labelMapName.FontWeightMedium = false;
            this.labelMapName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMapName.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelMapName.Name = "labelMapName";
            // 
            // buttonLaunchEditor
            // 
            resources.ApplyResources(this.buttonLaunchEditor, "buttonLaunchEditor");
            this.buttonLaunchEditor.Clear = true;
            this.buttonLaunchEditor.Depth = 0;
            this.buttonLaunchEditor.FontWeightMedium = true;
            this.buttonLaunchEditor.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLaunchEditor.Name = "buttonLaunchEditor";
            this.buttonLaunchEditor.Primary = false;
            this.buttonLaunchEditor.UseVisualStyleBackColor = true;
            this.buttonLaunchEditor.Click += new System.EventHandler(this.buttonLaunchEditor_Click);
            // 
            // buttonLaunchGame
            // 
            resources.ApplyResources(this.buttonLaunchGame, "buttonLaunchGame");
            this.buttonLaunchGame.Clear = true;
            this.buttonLaunchGame.Depth = 0;
            this.buttonLaunchGame.FontWeightMedium = true;
            this.buttonLaunchGame.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonLaunchGame.Name = "buttonLaunchGame";
            this.buttonLaunchGame.Primary = true;
            this.buttonLaunchGame.UseVisualStyleBackColor = true;
            this.buttonLaunchGame.Click += new System.EventHandler(this.buttonLaunchGame_Click);
            // 
            // dividerBottom
            // 
            this.dividerBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dividerBottom.Depth = 0;
            resources.ApplyResources(this.dividerBottom, "dividerBottom");
            this.dividerBottom.MouseState = MaterialSkin.MouseState.HOVER;
            this.dividerBottom.Name = "dividerBottom";
            this.dividerBottom.TabStop = false;
            // 
            // tabPageMap
            // 
            this.tabPageMap.Controls.Add(this.panelMaps);
            resources.ApplyResources(this.tabPageMap, "tabPageMap");
            this.tabPageMap.Name = "tabPageMap";
            this.tabPageMap.UseVisualStyleBackColor = true;
            // 
            // panelMaps
            // 
            resources.ApplyResources(this.panelMaps, "panelMaps");
            this.panelMaps.Depth = 0;
            this.panelMaps.MouseState = MaterialSkin.MouseState.HOVER;
            this.panelMaps.Name = "panelMaps";
            // 
            // tabPageGame
            // 
            this.tabPageGame.Controls.Add(this.flatButtonCommon);
            this.tabPageGame.Controls.Add(this.flatButtonBot);
            this.tabPageGame.Controls.Add(this.dividerRightTab3);
            this.tabPageGame.Controls.Add(this.tabControlGame);
            resources.ApplyResources(this.tabPageGame, "tabPageGame");
            this.tabPageGame.Name = "tabPageGame";
            this.tabPageGame.UseVisualStyleBackColor = true;
            // 
            // flatButtonCommon
            // 
            resources.ApplyResources(this.flatButtonCommon, "flatButtonCommon");
            this.flatButtonCommon.Clear = true;
            this.flatButtonCommon.Depth = 0;
            this.flatButtonCommon.FontWeightMedium = true;
            this.flatButtonCommon.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatButtonCommon.Name = "flatButtonCommon";
            this.flatButtonCommon.Primary = false;
            this.flatButtonCommon.UseVisualStyleBackColor = true;
            this.flatButtonCommon.Click += new System.EventHandler(this.flatButtonCommon_Click);
            // 
            // flatButtonBot
            // 
            resources.ApplyResources(this.flatButtonBot, "flatButtonBot");
            this.flatButtonBot.Clear = true;
            this.flatButtonBot.Depth = 0;
            this.flatButtonBot.FontWeightMedium = true;
            this.flatButtonBot.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatButtonBot.Name = "flatButtonBot";
            this.flatButtonBot.Primary = false;
            this.flatButtonBot.UseVisualStyleBackColor = true;
            this.flatButtonBot.Click += new System.EventHandler(this.flatButtonBot_Click);
            // 
            // dividerRightTab3
            // 
            this.dividerRightTab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dividerRightTab3.Depth = 0;
            resources.ApplyResources(this.dividerRightTab3, "dividerRightTab3");
            this.dividerRightTab3.MouseState = MaterialSkin.MouseState.HOVER;
            this.dividerRightTab3.Name = "dividerRightTab3";
            // 
            // tabControlGame
            // 
            resources.ApplyResources(this.tabControlGame, "tabControlGame");
            this.tabControlGame.Controls.Add(this.tabPageGameBot);
            this.tabControlGame.Controls.Add(this.tabPage2);
            this.tabControlGame.Controls.Add(this.tabPageGameCommon);
            this.tabControlGame.Depth = 0;
            this.tabControlGame.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlGame.Multiline = true;
            this.tabControlGame.Name = "tabControlGame";
            this.tabControlGame.SelectedIndex = 0;
            // 
            // tabPageGameBot
            // 
            this.tabPageGameBot.Controls.Add(this.checkBoxBotAmxx);
            this.tabPageGameBot.Controls.Add(this.textFieldBotNum);
            this.tabPageGameBot.Controls.Add(this.materialLabel11);
            this.tabPageGameBot.Controls.Add(this.materialLabel10);
            resources.ApplyResources(this.tabPageGameBot, "tabPageGameBot");
            this.tabPageGameBot.Name = "tabPageGameBot";
            this.tabPageGameBot.UseVisualStyleBackColor = true;
            // 
            // checkBoxBotAmxx
            // 
            resources.ApplyResources(this.checkBoxBotAmxx, "checkBoxBotAmxx");
            this.checkBoxBotAmxx.Depth = 0;
            this.checkBoxBotAmxx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxBotAmxx.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxBotAmxx.Name = "checkBoxBotAmxx";
            this.checkBoxBotAmxx.RightCheck = false;
            this.checkBoxBotAmxx.Ripple = true;
            this.checkBoxBotAmxx.UseVisualStyleBackColor = true;
            this.checkBoxBotAmxx.CheckedChanged += new System.EventHandler(this.checkBoxBotAmxx_CheckedChanged);
            // 
            // textFieldBotNum
            // 
            this.textFieldBotNum.Depth = 0;
            this.textFieldBotNum.Error = true;
            this.textFieldBotNum.Hint = "number";
            resources.ApplyResources(this.textFieldBotNum, "textFieldBotNum");
            this.textFieldBotNum.MaxLength = 2;
            this.textFieldBotNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldBotNum.Name = "textFieldBotNum";
            this.textFieldBotNum.NumOnly = true;
            this.textFieldBotNum.PasswordChar = '\0';
            this.textFieldBotNum.SelectedText = "";
            this.textFieldBotNum.SelectionLength = 0;
            this.textFieldBotNum.SelectionStart = 0;
            this.textFieldBotNum.TabStop = false;
            this.textFieldBotNum.UseSystemPasswordChar = false;
            this.textFieldBotNum.TextChanged += new System.EventHandler(this.textFieldBotNum_TextChanged);
            // 
            // materialLabel11
            // 
            resources.ApplyResources(this.materialLabel11, "materialLabel11");
            this.materialLabel11.Depth = 0;
            this.materialLabel11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel11.FontSize10 = true;
            this.materialLabel11.FontWeightMedium = true;
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            // 
            // materialLabel10
            // 
            resources.ApplyResources(this.materialLabel10, "materialLabel10");
            this.materialLabel10.Depth = 0;
            this.materialLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel10.FontSize10 = true;
            this.materialLabel10.FontWeightMedium = true;
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPageGameCommon
            // 
            this.tabPageGameCommon.Controls.Add(this.checkBoxULBPAMMO);
            this.tabPageGameCommon.Controls.Add(this.textFieldWLC);
            this.tabPageGameCommon.Controls.Add(this.materialLabel5);
            this.tabPageGameCommon.Controls.Add(this.labelWL);
            this.tabPageGameCommon.Controls.Add(this.materialLabel12);
            resources.ApplyResources(this.tabPageGameCommon, "tabPageGameCommon");
            this.tabPageGameCommon.Name = "tabPageGameCommon";
            this.tabPageGameCommon.UseVisualStyleBackColor = true;
            // 
            // checkBoxULBPAMMO
            // 
            resources.ApplyResources(this.checkBoxULBPAMMO, "checkBoxULBPAMMO");
            this.checkBoxULBPAMMO.Depth = 0;
            this.checkBoxULBPAMMO.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxULBPAMMO.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxULBPAMMO.Name = "checkBoxULBPAMMO";
            this.checkBoxULBPAMMO.RightCheck = true;
            this.checkBoxULBPAMMO.Ripple = true;
            this.checkBoxULBPAMMO.UseVisualStyleBackColor = true;
            // 
            // textFieldWLC
            // 
            this.textFieldWLC.Depth = 0;
            this.textFieldWLC.Error = false;
            this.textFieldWLC.Hint = "example: rpg7, knife";
            resources.ApplyResources(this.textFieldWLC, "textFieldWLC");
            this.textFieldWLC.MaxLength = 32767;
            this.textFieldWLC.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldWLC.Name = "textFieldWLC";
            this.textFieldWLC.NumOnly = false;
            this.textFieldWLC.PasswordChar = '\0';
            this.textFieldWLC.SelectedText = "";
            this.textFieldWLC.SelectionLength = 0;
            this.textFieldWLC.SelectionStart = 0;
            this.textFieldWLC.TabStop = false;
            this.textFieldWLC.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            resources.ApplyResources(this.materialLabel5, "materialLabel5");
            this.materialLabel5.Depth = 0;
            this.materialLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel5.FontSize10 = false;
            this.materialLabel5.FontWeightMedium = true;
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            // 
            // labelWL
            // 
            this.labelWL.Depth = 0;
            this.labelWL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.labelWL, "labelWL");
            this.labelWL.FontSize10 = false;
            this.labelWL.FontWeightMedium = false;
            this.labelWL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWL.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelWL.Name = "labelWL";
            this.labelWL.Click += new System.EventHandler(this.labelWL_Click);
            // 
            // materialLabel12
            // 
            resources.ApplyResources(this.materialLabel12, "materialLabel12");
            this.materialLabel12.Depth = 0;
            this.materialLabel12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel12.FontSize10 = false;
            this.materialLabel12.FontWeightMedium = true;
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.tabControlSettings);
            this.tabPageSettings.Controls.Add(this.flatButtonLauncher);
            this.tabPageSettings.Controls.Add(this.flatButtonAbout);
            this.tabPageSettings.Controls.Add(this.flatButtonVideo);
            this.tabPageSettings.Controls.Add(this.dividerRightTab4);
            resources.ApplyResources(this.tabPageSettings, "tabPageSettings");
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tabControlSettings
            // 
            resources.ApplyResources(this.tabControlSettings, "tabControlSettings");
            this.tabControlSettings.Controls.Add(this.tabPageSettingsVideo);
            this.tabControlSettings.Controls.Add(this.tabPageSettingsAbout);
            this.tabControlSettings.Controls.Add(this.tabPageSettingsLauncher);
            this.tabControlSettings.Depth = 0;
            this.tabControlSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            // 
            // tabPageSettingsVideo
            // 
            this.tabPageSettingsVideo.Controls.Add(this.materialLabel17);
            this.tabPageSettingsVideo.Controls.Add(this.pictureBox1);
            this.tabPageSettingsVideo.Controls.Add(this.materialLabel15);
            this.tabPageSettingsVideo.Controls.Add(this.labelDisplay);
            this.tabPageSettingsVideo.Controls.Add(this.materialLabel14);
            this.tabPageSettingsVideo.Controls.Add(this.checkBoxHDR);
            this.tabPageSettingsVideo.Controls.Add(this.labelAA);
            this.tabPageSettingsVideo.Controls.Add(this.materialLabel13);
            this.tabPageSettingsVideo.Controls.Add(this.labelAF);
            this.tabPageSettingsVideo.Controls.Add(this.checkBoxVSync);
            this.tabPageSettingsVideo.Controls.Add(this.materialLabel8);
            this.tabPageSettingsVideo.Controls.Add(this.textFieldHeigth);
            this.tabPageSettingsVideo.Controls.Add(this.materialLabel7);
            this.tabPageSettingsVideo.Controls.Add(this.textFieldWidth);
            this.tabPageSettingsVideo.Controls.Add(this.materialLabel6);
            resources.ApplyResources(this.tabPageSettingsVideo, "tabPageSettingsVideo");
            this.tabPageSettingsVideo.Name = "tabPageSettingsVideo";
            this.tabPageSettingsVideo.UseVisualStyleBackColor = true;
            // 
            // materialLabel17
            // 
            resources.ApplyResources(this.materialLabel17, "materialLabel17");
            this.materialLabel17.Depth = 0;
            this.materialLabel17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel17.FontSize10 = false;
            this.materialLabel17.FontWeightMedium = false;
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSBTELauncher.Properties.Resources.help_circle;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // materialLabel15
            // 
            resources.ApplyResources(this.materialLabel15, "materialLabel15");
            this.materialLabel15.Depth = 0;
            this.materialLabel15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel15.FontSize10 = true;
            this.materialLabel15.FontWeightMedium = true;
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            // 
            // labelDisplay
            // 
            resources.ApplyResources(this.labelDisplay, "labelDisplay");
            this.labelDisplay.Depth = 0;
            this.labelDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDisplay.FontSize10 = true;
            this.labelDisplay.FontWeightMedium = false;
            this.labelDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDisplay.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Click += new System.EventHandler(this.labelDisplay_Click);
            // 
            // materialLabel14
            // 
            resources.ApplyResources(this.materialLabel14, "materialLabel14");
            this.materialLabel14.Depth = 0;
            this.materialLabel14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel14.FontSize10 = true;
            this.materialLabel14.FontWeightMedium = true;
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            // 
            // checkBoxHDR
            // 
            resources.ApplyResources(this.checkBoxHDR, "checkBoxHDR");
            this.checkBoxHDR.Depth = 0;
            this.checkBoxHDR.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxHDR.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxHDR.Name = "checkBoxHDR";
            this.checkBoxHDR.RightCheck = true;
            this.checkBoxHDR.Ripple = true;
            this.checkBoxHDR.UseVisualStyleBackColor = true;
            // 
            // labelAA
            // 
            resources.ApplyResources(this.labelAA, "labelAA");
            this.labelAA.Depth = 0;
            this.labelAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAA.FontSize10 = true;
            this.labelAA.FontWeightMedium = false;
            this.labelAA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAA.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAA.Name = "labelAA";
            this.labelAA.Click += new System.EventHandler(this.labelAA_Click);
            // 
            // materialLabel13
            // 
            resources.ApplyResources(this.materialLabel13, "materialLabel13");
            this.materialLabel13.Depth = 0;
            this.materialLabel13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel13.FontSize10 = true;
            this.materialLabel13.FontWeightMedium = true;
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            // 
            // labelAF
            // 
            resources.ApplyResources(this.labelAF, "labelAF");
            this.labelAF.Depth = 0;
            this.labelAF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAF.FontSize10 = true;
            this.labelAF.FontWeightMedium = false;
            this.labelAF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAF.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAF.Name = "labelAF";
            this.labelAF.TextChanged += new System.EventHandler(this.labelAF_TextChanged);
            this.labelAF.Click += new System.EventHandler(this.labelAF_Click);
            // 
            // checkBoxVSync
            // 
            resources.ApplyResources(this.checkBoxVSync, "checkBoxVSync");
            this.checkBoxVSync.Depth = 0;
            this.checkBoxVSync.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxVSync.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxVSync.Name = "checkBoxVSync";
            this.checkBoxVSync.RightCheck = true;
            this.checkBoxVSync.Ripple = true;
            this.checkBoxVSync.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            resources.ApplyResources(this.materialLabel8, "materialLabel8");
            this.materialLabel8.Depth = 0;
            this.materialLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel8.FontSize10 = true;
            this.materialLabel8.FontWeightMedium = true;
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            // 
            // textFieldHeigth
            // 
            this.textFieldHeigth.Depth = 0;
            this.textFieldHeigth.Error = true;
            this.textFieldHeigth.Hint = "heigth";
            resources.ApplyResources(this.textFieldHeigth, "textFieldHeigth");
            this.textFieldHeigth.MaxLength = 4;
            this.textFieldHeigth.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldHeigth.Name = "textFieldHeigth";
            this.textFieldHeigth.NumOnly = true;
            this.textFieldHeigth.PasswordChar = '\0';
            this.textFieldHeigth.SelectedText = "";
            this.textFieldHeigth.SelectionLength = 0;
            this.textFieldHeigth.SelectionStart = 0;
            this.textFieldHeigth.TabStop = false;
            this.textFieldHeigth.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            resources.ApplyResources(this.materialLabel7, "materialLabel7");
            this.materialLabel7.Depth = 0;
            this.materialLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel7.FontSize10 = true;
            this.materialLabel7.FontWeightMedium = true;
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            // 
            // textFieldWidth
            // 
            this.textFieldWidth.Depth = 0;
            this.textFieldWidth.Error = true;
            this.textFieldWidth.Hint = "width";
            resources.ApplyResources(this.textFieldWidth, "textFieldWidth");
            this.textFieldWidth.MaxLength = 4;
            this.textFieldWidth.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldWidth.Name = "textFieldWidth";
            this.textFieldWidth.NumOnly = true;
            this.textFieldWidth.PasswordChar = '\0';
            this.textFieldWidth.SelectedText = "";
            this.textFieldWidth.SelectionLength = 0;
            this.textFieldWidth.SelectionStart = 0;
            this.textFieldWidth.TabStop = false;
            this.textFieldWidth.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            resources.ApplyResources(this.materialLabel6, "materialLabel6");
            this.materialLabel6.Depth = 0;
            this.materialLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel6.FontSize10 = true;
            this.materialLabel6.FontWeightMedium = true;
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            // 
            // tabPageSettingsAbout
            // 
            this.tabPageSettingsAbout.Controls.Add(this.materialLabel16);
            this.tabPageSettingsAbout.Controls.Add(this.materialLabel9);
            resources.ApplyResources(this.tabPageSettingsAbout, "tabPageSettingsAbout");
            this.tabPageSettingsAbout.Name = "tabPageSettingsAbout";
            this.tabPageSettingsAbout.UseVisualStyleBackColor = true;
            this.tabPageSettingsAbout.Click += new System.EventHandler(this.tabPageSettingsAdvance_Click);
            // 
            // materialLabel16
            // 
            resources.ApplyResources(this.materialLabel16, "materialLabel16");
            this.materialLabel16.Depth = 0;
            this.materialLabel16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel16.FontSize10 = false;
            this.materialLabel16.FontWeightMedium = true;
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            // 
            // materialLabel9
            // 
            resources.ApplyResources(this.materialLabel9, "materialLabel9");
            this.materialLabel9.Depth = 0;
            this.materialLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel9.FontSize10 = false;
            this.materialLabel9.FontWeightMedium = false;
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Click += new System.EventHandler(this.materialLabel9_Click);
            // 
            // tabPageSettingsLauncher
            // 
            this.tabPageSettingsLauncher.Controls.Add(this.checkBoxRemoveMouseAcc);
            this.tabPageSettingsLauncher.Controls.Add(this.checkBoxDeleteMdmp);
            this.tabPageSettingsLauncher.Controls.Add(this.checkBoxLoadMap);
            resources.ApplyResources(this.tabPageSettingsLauncher, "tabPageSettingsLauncher");
            this.tabPageSettingsLauncher.Name = "tabPageSettingsLauncher";
            this.tabPageSettingsLauncher.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemoveMouseAcc
            // 
            resources.ApplyResources(this.checkBoxRemoveMouseAcc, "checkBoxRemoveMouseAcc");
            this.checkBoxRemoveMouseAcc.Depth = 0;
            this.checkBoxRemoveMouseAcc.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxRemoveMouseAcc.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxRemoveMouseAcc.Name = "checkBoxRemoveMouseAcc";
            this.checkBoxRemoveMouseAcc.RightCheck = false;
            this.checkBoxRemoveMouseAcc.Ripple = true;
            this.checkBoxRemoveMouseAcc.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleteMdmp
            // 
            resources.ApplyResources(this.checkBoxDeleteMdmp, "checkBoxDeleteMdmp");
            this.checkBoxDeleteMdmp.Depth = 0;
            this.checkBoxDeleteMdmp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxDeleteMdmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxDeleteMdmp.Name = "checkBoxDeleteMdmp";
            this.checkBoxDeleteMdmp.RightCheck = false;
            this.checkBoxDeleteMdmp.Ripple = true;
            this.checkBoxDeleteMdmp.UseVisualStyleBackColor = true;
            this.checkBoxDeleteMdmp.CheckedChanged += new System.EventHandler(this.checkBoxDeleteMdmp_CheckedChanged);
            // 
            // checkBoxLoadMap
            // 
            resources.ApplyResources(this.checkBoxLoadMap, "checkBoxLoadMap");
            this.checkBoxLoadMap.Depth = 0;
            this.checkBoxLoadMap.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxLoadMap.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxLoadMap.Name = "checkBoxLoadMap";
            this.checkBoxLoadMap.RightCheck = false;
            this.checkBoxLoadMap.Ripple = true;
            this.checkBoxLoadMap.UseVisualStyleBackColor = true;
            this.checkBoxLoadMap.CheckedChanged += new System.EventHandler(this.checkBoxLoadMap_CheckedChanged);
            // 
            // flatButtonLauncher
            // 
            resources.ApplyResources(this.flatButtonLauncher, "flatButtonLauncher");
            this.flatButtonLauncher.Clear = true;
            this.flatButtonLauncher.Depth = 0;
            this.flatButtonLauncher.FontWeightMedium = true;
            this.flatButtonLauncher.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatButtonLauncher.Name = "flatButtonLauncher";
            this.flatButtonLauncher.Primary = false;
            this.flatButtonLauncher.UseVisualStyleBackColor = true;
            this.flatButtonLauncher.Click += new System.EventHandler(this.flatButtonLauncher_Click);
            // 
            // flatButtonAbout
            // 
            resources.ApplyResources(this.flatButtonAbout, "flatButtonAbout");
            this.flatButtonAbout.Clear = true;
            this.flatButtonAbout.Depth = 0;
            this.flatButtonAbout.FontWeightMedium = true;
            this.flatButtonAbout.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatButtonAbout.Name = "flatButtonAbout";
            this.flatButtonAbout.Primary = false;
            this.flatButtonAbout.UseVisualStyleBackColor = true;
            this.flatButtonAbout.Click += new System.EventHandler(this.flatButtonAbout_Click);
            // 
            // flatButtonVideo
            // 
            resources.ApplyResources(this.flatButtonVideo, "flatButtonVideo");
            this.flatButtonVideo.Clear = true;
            this.flatButtonVideo.Depth = 0;
            this.flatButtonVideo.FontWeightMedium = true;
            this.flatButtonVideo.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatButtonVideo.Name = "flatButtonVideo";
            this.flatButtonVideo.Primary = false;
            this.flatButtonVideo.UseVisualStyleBackColor = true;
            this.flatButtonVideo.Click += new System.EventHandler(this.flatButtonVideo_Click);
            // 
            // dividerRightTab4
            // 
            this.dividerRightTab4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dividerRightTab4.Depth = 0;
            resources.ApplyResources(this.dividerRightTab4, "dividerRightTab4");
            this.dividerRightTab4.MouseState = MaterialSkin.MouseState.HOVER;
            this.dividerRightTab4.Name = "dividerRightTab4";
            this.dividerRightTab4.TabStop = false;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.materialContextMenuStrip1.Depth = 0;
            resources.ApplyResources(this.materialContextMenuStrip1, "materialContextMenuStrip1");
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem0});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem0
            // 
            resources.ApplyResources(this.toolStripMenuItem0, "toolStripMenuItem0");
            this.toolStripMenuItem0.Name = "toolStripMenuItem0";
            this.toolStripMenuItem0.Click += new System.EventHandler(this.toolStripMenuItem0_Click);
            // 
            // materialContextMenuStrip2
            // 
            this.materialContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip2.Depth = 0;
            resources.ApplyResources(this.materialContextMenuStrip2, "materialContextMenuStrip2");
            this.materialContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noLimitToolStripMenuItem,
            this.sniperGunOnlyToolStripMenuItem,
            this.grenadeOnlyToolStripMenuItem,
            this.pistolOnlyToolStripMenuItem,
            this.knifeOnlyToolStripMenuItem,
            this.customToolStripMenuItem});
            this.materialContextMenuStrip2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip2.Name = "materialContextMenuStrip2";
            // 
            // noLimitToolStripMenuItem
            // 
            resources.ApplyResources(this.noLimitToolStripMenuItem, "noLimitToolStripMenuItem");
            this.noLimitToolStripMenuItem.Name = "noLimitToolStripMenuItem";
            this.noLimitToolStripMenuItem.Click += new System.EventHandler(this.noLimitToolStripMenuItem_Click);
            // 
            // sniperGunOnlyToolStripMenuItem
            // 
            resources.ApplyResources(this.sniperGunOnlyToolStripMenuItem, "sniperGunOnlyToolStripMenuItem");
            this.sniperGunOnlyToolStripMenuItem.Name = "sniperGunOnlyToolStripMenuItem";
            this.sniperGunOnlyToolStripMenuItem.Click += new System.EventHandler(this.sniperGunOnlyToolStripMenuItem_Click);
            // 
            // grenadeOnlyToolStripMenuItem
            // 
            resources.ApplyResources(this.grenadeOnlyToolStripMenuItem, "grenadeOnlyToolStripMenuItem");
            this.grenadeOnlyToolStripMenuItem.Name = "grenadeOnlyToolStripMenuItem";
            this.grenadeOnlyToolStripMenuItem.Click += new System.EventHandler(this.grenadeOnlyToolStripMenuItem_Click);
            // 
            // pistolOnlyToolStripMenuItem
            // 
            resources.ApplyResources(this.pistolOnlyToolStripMenuItem, "pistolOnlyToolStripMenuItem");
            this.pistolOnlyToolStripMenuItem.Name = "pistolOnlyToolStripMenuItem";
            this.pistolOnlyToolStripMenuItem.Click += new System.EventHandler(this.pistolOnlyToolStripMenuItem_Click);
            // 
            // knifeOnlyToolStripMenuItem
            // 
            resources.ApplyResources(this.knifeOnlyToolStripMenuItem, "knifeOnlyToolStripMenuItem");
            this.knifeOnlyToolStripMenuItem.Name = "knifeOnlyToolStripMenuItem";
            this.knifeOnlyToolStripMenuItem.Click += new System.EventHandler(this.knifeOnlyToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            resources.ApplyResources(this.customToolStripMenuItem, "customToolStripMenuItem");
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // materialContextMenuStrip3
            // 
            this.materialContextMenuStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip3.Depth = 0;
            this.materialContextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCSAA16Q,
            this.toolStripMenuItemCSAA16,
            this.toolStripMenuItemCSAA8Q,
            this.toolStripMenuItemCSAA8,
            this.toolStripMenuItemMSAA8,
            this.toolStripMenuItemMSAA4,
            this.toolStripMenuItemMSAA2,
            this.toolStripMenuItemAA0});
            this.materialContextMenuStrip3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip3.Name = "materialContextMenuStrip3";
            resources.ApplyResources(this.materialContextMenuStrip3, "materialContextMenuStrip3");
            // 
            // toolStripMenuItemCSAA16Q
            // 
            resources.ApplyResources(this.toolStripMenuItemCSAA16Q, "toolStripMenuItemCSAA16Q");
            this.toolStripMenuItemCSAA16Q.Name = "toolStripMenuItemCSAA16Q";
            this.toolStripMenuItemCSAA16Q.Tag = "7";
            this.toolStripMenuItemCSAA16Q.Click += new System.EventHandler(this.toolStripMenuItemAA_Click);
            // 
            // toolStripMenuItemCSAA16
            // 
            resources.ApplyResources(this.toolStripMenuItemCSAA16, "toolStripMenuItemCSAA16");
            this.toolStripMenuItemCSAA16.Name = "toolStripMenuItemCSAA16";
            this.toolStripMenuItemCSAA16.Tag = "6";
            this.toolStripMenuItemCSAA16.Click += new System.EventHandler(this.toolStripMenuItemAA_Click);
            // 
            // toolStripMenuItemCSAA8Q
            // 
            resources.ApplyResources(this.toolStripMenuItemCSAA8Q, "toolStripMenuItemCSAA8Q");
            this.toolStripMenuItemCSAA8Q.Name = "toolStripMenuItemCSAA8Q";
            this.toolStripMenuItemCSAA8Q.Tag = "5";
            this.toolStripMenuItemCSAA8Q.Click += new System.EventHandler(this.toolStripMenuItemAA_Click);
            // 
            // toolStripMenuItemCSAA8
            // 
            resources.ApplyResources(this.toolStripMenuItemCSAA8, "toolStripMenuItemCSAA8");
            this.toolStripMenuItemCSAA8.Name = "toolStripMenuItemCSAA8";
            this.toolStripMenuItemCSAA8.Tag = "4";
            this.toolStripMenuItemCSAA8.Click += new System.EventHandler(this.toolStripMenuItemAA_Click);
            // 
            // toolStripMenuItemMSAA8
            // 
            resources.ApplyResources(this.toolStripMenuItemMSAA8, "toolStripMenuItemMSAA8");
            this.toolStripMenuItemMSAA8.Name = "toolStripMenuItemMSAA8";
            this.toolStripMenuItemMSAA8.Tag = "3";
            this.toolStripMenuItemMSAA8.Click += new System.EventHandler(this.toolStripMenuItemAA_Click);
            // 
            // toolStripMenuItemMSAA4
            // 
            resources.ApplyResources(this.toolStripMenuItemMSAA4, "toolStripMenuItemMSAA4");
            this.toolStripMenuItemMSAA4.Name = "toolStripMenuItemMSAA4";
            this.toolStripMenuItemMSAA4.Tag = "2";
            this.toolStripMenuItemMSAA4.Click += new System.EventHandler(this.toolStripMenuItemAA_Click);
            // 
            // toolStripMenuItemMSAA2
            // 
            resources.ApplyResources(this.toolStripMenuItemMSAA2, "toolStripMenuItemMSAA2");
            this.toolStripMenuItemMSAA2.Name = "toolStripMenuItemMSAA2";
            this.toolStripMenuItemMSAA2.Tag = "1";
            this.toolStripMenuItemMSAA2.Click += new System.EventHandler(this.toolStripMenuItemAA_Click);
            // 
            // toolStripMenuItemAA0
            // 
            resources.ApplyResources(this.toolStripMenuItemAA0, "toolStripMenuItemAA0");
            this.toolStripMenuItemAA0.Name = "toolStripMenuItemAA0";
            this.toolStripMenuItemAA0.Tag = "0";
            this.toolStripMenuItemAA0.Click += new System.EventHandler(this.toolStripMenuItemAA_Click);
            // 
            // materialContextMenuStrip4
            // 
            this.materialContextMenuStrip4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip4.Depth = 0;
            this.materialContextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.materialContextMenuStrip4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip4.Name = "materialContextMenuStrip4";
            resources.ApplyResources(this.materialContextMenuStrip4, "materialContextMenuStrip4");
            // 
            // toolStripMenuItem6
            // 
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            resources.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.tabSelectorMain);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            this.tabPageMap.ResumeLayout(false);
            this.tabPageGame.ResumeLayout(false);
            this.tabPageGame.PerformLayout();
            this.tabControlGame.ResumeLayout(false);
            this.tabPageGameBot.ResumeLayout(false);
            this.tabPageGameBot.PerformLayout();
            this.tabPageGameCommon.ResumeLayout(false);
            this.tabPageGameCommon.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageSettingsVideo.ResumeLayout(false);
            this.tabPageSettingsVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageSettingsAbout.ResumeLayout(false);
            this.tabPageSettingsAbout.PerformLayout();
            this.tabPageSettingsLauncher.ResumeLayout(false);
            this.tabPageSettingsLauncher.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.materialContextMenuStrip2.ResumeLayout(false);
            this.materialContextMenuStrip3.ResumeLayout(false);
            this.materialContextMenuStrip4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialTabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageMap;
        private System.Windows.Forms.TabPage tabPageGame;
        private System.Windows.Forms.TabPage tabPageSettings;
        private MaterialDivider dividerBottom;
        private MaterialFlatButton buttonLaunchGame;
        private MaterialFlatButton buttonLaunchEditor;
        private MaterialDivider dividerRightTab1;
        private MaterialDivider dividerRightTab4;
        private MaterialTabSelector tabSelectorMain;
        private MaterialFlatButton flatButtonVideo;
        private MaterialFlatButton flatButtonLauncher;
        private MaterialFlatButton flatButtonAbout;
        private MaterialTabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageSettingsVideo;
        private System.Windows.Forms.TabPage tabPageSettingsLauncher;
        private MaterialCheckBox checkBoxLoadMap;
        private MaterialCheckBox checkBoxDeleteMdmp;
        private MaterialPanel panelMaps;
        private MaterialLabel labelMapName;
        private MaterialLabel materialLabel2;
        private MaterialLabel materialLabel1;
        private MaterialLabel labelWL2;
        private MaterialLabel labelBot;
        private MaterialLabel labelMode;
        private MaterialLabel materialLabel4;
        private MaterialLabel materialLabel3;
        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialToolStripMenuItem toolStripMenuItem1;
        private MaterialToolStripMenuItem toolStripMenuItem2;
        private MaterialToolStripMenuItem toolStripMenuItem3;
        private MaterialToolStripMenuItem toolStripMenuItem4;
        private MaterialLabel materialLabel6;
        private MaterialSingleLineTextField textFieldHeigth;
        private MaterialLabel materialLabel7;
        private MaterialSingleLineTextField textFieldWidth;
        private System.Windows.Forms.TabPage tabPageSettingsAbout;
        private MaterialCheckBox checkBoxVSync;
        private MaterialLabel materialLabel8;
        private MaterialLabel labelAF;
        private MaterialToolStripMenuItem toolStripMenuItem0;
        private System.Windows.Forms.Panel panelModes;
        private MaterialLabel materialLabel9;
        private MaterialTabControl tabControlGame;
        private System.Windows.Forms.TabPage tabPageGameBot;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialDivider dividerRightTab3;
        private MaterialFlatButton flatButtonBot;
        private MaterialSingleLineTextField textFieldBotNum;
        private MaterialLabel materialLabel11;
        private MaterialLabel materialLabel10;
        private MaterialCheckBox checkBoxBotAmxx;
        private MaterialCheckBox checkBoxRemoveMouseAcc;
        private System.Windows.Forms.TabPage tabPageGameCommon;
        private MaterialFlatButton flatButtonCommon;
        private MaterialLabel materialLabel12;
        private MaterialLabel labelWL;
        private MaterialContextMenuStrip materialContextMenuStrip2;
        private MaterialToolStripMenuItem noLimitToolStripMenuItem;
        private MaterialToolStripMenuItem sniperGunOnlyToolStripMenuItem;
        private MaterialToolStripMenuItem grenadeOnlyToolStripMenuItem;
        private MaterialToolStripMenuItem pistolOnlyToolStripMenuItem;
        private MaterialToolStripMenuItem knifeOnlyToolStripMenuItem;
        private MaterialLabel materialLabel5;
        private MaterialSingleLineTextField textFieldWLC;
        private MaterialToolStripMenuItem customToolStripMenuItem;
        private MaterialCheckBox checkBoxULBPAMMO;
        private MaterialLabel labelAA;
        private MaterialLabel materialLabel13;
        private MaterialContextMenuStrip materialContextMenuStrip3;
        private MaterialToolStripMenuItem toolStripMenuItemMSAA4;
        private MaterialToolStripMenuItem toolStripMenuItemAA0;
        private MaterialCheckBox checkBoxHDR;
        private MaterialLabel materialLabel14;
        private MaterialContextMenuStrip materialContextMenuStrip4;
        private MaterialToolStripMenuItem toolStripMenuItem6;
        private MaterialToolStripMenuItem toolStripMenuItem7;
        private MaterialToolStripMenuItem toolStripMenuItem8;
        private MaterialLabel labelDisplay;
        private MaterialLabel materialLabel15;
        private MaterialLabel materialLabel16;
        private MaterialToolStripMenuItem toolStripMenuItemCSAA16Q;
        private MaterialToolStripMenuItem toolStripMenuItemCSAA16;
        private MaterialToolStripMenuItem toolStripMenuItemCSAA8Q;
        private MaterialToolStripMenuItem toolStripMenuItemCSAA8;
        private MaterialToolStripMenuItem toolStripMenuItemMSAA8;
        private MaterialToolStripMenuItem toolStripMenuItemMSAA2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialLabel materialLabel17;
    }
}

