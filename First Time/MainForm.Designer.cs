namespace First_Time
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Agree = new MetroFramework.Controls.MetroCheckBox();
            this.Statement = new MetroFramework.Controls.MetroTextBox();
            this.LaunchButton = new MetroFramework.Controls.MetroButton();
            this.LanguageComboBox = new MetroFramework.Controls.MetroComboBox();
            this.LanguageLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // Agree
            // 
            this.Agree.AutoSize = true;
            this.Agree.DisplayFocus = true;
            this.Agree.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.Agree.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.Agree.Location = new System.Drawing.Point(23, 338);
            this.Agree.Name = "Agree";
            this.Agree.Size = new System.Drawing.Size(410, 50);
            this.Agree.TabIndex = 1;
            this.Agree.Text = "I have read the above statement and agreed.\r\n我已经阅读以上申明并且同意。";
            this.Agree.UseSelectable = true;
            // 
            // Statement
            // 
            // 
            // 
            // 
            this.Statement.CustomButton.Image = null;
            this.Statement.CustomButton.Location = new System.Drawing.Point(436, 1);
            this.Statement.CustomButton.Name = "";
            this.Statement.CustomButton.Size = new System.Drawing.Size(267, 267);
            this.Statement.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Statement.CustomButton.TabIndex = 1;
            this.Statement.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Statement.CustomButton.UseSelectable = true;
            this.Statement.CustomButton.Visible = false;
            this.Statement.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Statement.Lines = new string[] {
        "顺序 (Arrangement) ：中文, English",
        "",
        "---------------------中文---------------------",
        "",
        "版权所有：BTE TEAM|15minutes(KR)|百度csoldjb吧|Neko喵 (对于 MetroStyleLauncher)",
        "本游戏完全免费，请勿使用本游戏进行任何形式的盈利",
        "声明：BTE TEAM|csoldjb吧对非贴吧免费获取的游戏版本不提供任何技术支持。",
        "",
        "------------------特别声明----------------",
        "1.EC精英社所谓“CS破茧”“CS神器时代”均为盗版游戏，BTE TEAM|csoldjb吧不对此类游戏提供技术支持并强烈谴责盗版游戏的行为",
        "",
        "2.Wilson（真名：刘澄）恶意申请原CS:BTE游戏著作权并加密游戏后利用著作权在淘宝盈利（淘宝店铺：洋葱数码商城|淘宝名：丨低调奢华有内涵|B站ID：进口柚" +
            "柚子|贴吧ID:liu1340567980)，欺诈玩家称其能开发生化模式Z或缔造者模式，现在此揭露刘澄：一个完全的插件小白，靠网上东拼西凑代码做一些非常简单的功" +
            "能，或直接搬运CS:SME在外网的更新加入游戏。",
        "",
        "但由于其持有原CS:BTE版权，BTE TEAM无法进行维权。我们只能在此发布声明，希望广大网友擦亮眼睛，不要被无耻小人刘澄骗走你的金钱与信任！",
        "",
        "3.CS:SME所使用的素材均为热心网友整理而来，仅供学习、交流与欣赏，请于下载后24小时内删除！",
        "",
        "---------------------English---------------------",
        "",
        "Copyright : SME TEAM | BTE TEAM | Baidu csoldjbBar | FB CSBTE Official | NekoMeow" +
            " (For MetroStyleLauncher)",
        "This game & software is completely free, please do not use this game for any form" +
            " of profit.",
        "Declaration : There is no technical support for the free version of the game that" +
            " is not available from Official SME TEAM | BTE TEAM | csoldjbBar | CSBTE Officia" +
            "l | NekoMeow.",
        "",
        "------------------Special Declaration----------------",
        resources.GetString("Statement.Lines"),
        "",
        resources.GetString("Statement.Lines1"),
        "",
        resources.GetString("Statement.Lines2"),
        "",
        "3. The materials used by SME are compiled by enthusiastic users. They are only fo" +
            "r learning, communication and appreciation. Please delete them within 24 hours a" +
            "fter download!",
        "",
        "------------------------------------------"};
            this.Statement.Location = new System.Drawing.Point(23, 63);
            this.Statement.MaxLength = 32767;
            this.Statement.Multiline = true;
            this.Statement.Name = "Statement";
            this.Statement.PasswordChar = '\0';
            this.Statement.ReadOnly = true;
            this.Statement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Statement.SelectedText = "";
            this.Statement.SelectionLength = 0;
            this.Statement.SelectionStart = 0;
            this.Statement.ShortcutsEnabled = true;
            this.Statement.Size = new System.Drawing.Size(704, 269);
            this.Statement.TabIndex = 2;
            this.Statement.Text = resources.GetString("Statement.Text");
            this.Statement.UseSelectable = true;
            this.Statement.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Statement.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LaunchButton
            // 
            this.LaunchButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.LaunchButton.Location = new System.Drawing.Point(608, 435);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(119, 42);
            this.LaunchButton.TabIndex = 3;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseCustomBackColor = true;
            this.LaunchButton.UseSelectable = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.ItemHeight = 23;
            this.LanguageComboBox.Items.AddRange(new object[] {
            "简体中文",
            "繁体中文",
            "English"});
            this.LanguageComboBox.Location = new System.Drawing.Point(118, 391);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(121, 29);
            this.LanguageComboBox.TabIndex = 5;
            this.LanguageComboBox.UseSelectable = true;
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LanguageLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LanguageLabel.Location = new System.Drawing.Point(23, 391);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(89, 25);
            this.LanguageLabel.TabIndex = 6;
            this.LanguageLabel.Text = "Language";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 423);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Language";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.Statement);
            this.Controls.Add(this.Agree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "Settings For First Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroCheckBox Agree;
        private MetroFramework.Controls.MetroTextBox Statement;
        private MetroFramework.Controls.MetroButton LaunchButton;
        private MetroFramework.Controls.MetroComboBox LanguageComboBox;
        private MetroFramework.Controls.MetroLabel LanguageLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

