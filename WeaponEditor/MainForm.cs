using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using IniParser;
using IniParser.Model;
using System.IO;
using Microsoft.Win32;
using IniParser.Model.Configuration;
using IniParser.Parser;

namespace WeaponEditor
{
    public partial class MainForm : MetroForm
    {
        string localizedLauncherPath;
        string curSelectFormat;
        //string Allow;

        private static FileIniDataParser parser = new FileIniDataParser();
        //private static FileIniDataParser parser = new FileIniDataParser(iniDataParser);
        private static IniDataParser iniDataParser = new IniDataParser();

        private IniData Weapon;
        private IniData Launcher;
        private Main aForm = new Main();

        public MainForm(string duplicate, string language)
        {
            InitializeComponent();

            if (language != "english")
                localizedLauncherPath = "cstrike_" + language + @"\launcher.ini";
            else
                localizedLauncherPath = @"cstrike\launcher.ini";

            LoadSetting();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            curSelectFormat = SeletedAmount.Text;
            LoadList("weapons_precache");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveList();
        }

        private void SaveList()
        {
            string path = @"cstrike\addons\amxmodx\configs\weapons_precache.lst";

            if (File.Exists(path))
                File.Delete(path);

            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("true");

            foreach (WeaponButton btn in buttonWpn)
            {
                if (btn.Checked)
                    sw.WriteLine(btn.WeaponName);
            }

            sw.Flush();
            fs.Flush();
            fs.Close();
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

        private void MetroMsgBox(string message, string title)
        {
            MetroMessageBox.Show(this, message, title, 300);
        }

        private IniData TryCatch(string path)
        {
            try
            {
                parser.ReadFile(path, GetEncoding(path));
            }
            catch(Exception e)
            {
                MetroMsgBox(e.Message, path);
            }

            return parser.ReadFile(path, GetEncoding(path));
        }

        private void LoadSetting()
        {
            Weapon = TryCatch(@"cstrike\weapons.ini");
            Launcher = TryCatch(localizedLauncherPath);

            if (!File.Exists(@"cstrike\addons\amxmodx\configs\weapons_precache.default.lst"))
                File.Copy(@"cstrike\addons\amxmodx\configs\weapons_precache.lst", @"cstrike\addons\amxmodx\configs\weapons_precache.default.lst");
        }

        private void formatTotalWeapon()
        {
            SeletedAmount.Text = String.Format(curSelectFormat, totalMyWpn);
        }

        private int totalWeapons;
        private int totalMyWpn;

        List<WeaponButton> buttonWpn = new List<WeaponButton>();
        List<string> myWpn = new List<string>();

        delegate void Add(string name);
        //delegate void SetEnableMyWpn();
        delegate void WpnBteAnim(WeaponButton btn, bool check);
        delegate void FormatTotalWeapon();

        private void LoadList(object filename)
        {
            totalWeapons = 0;

            StreamReader sr;
            string line;

            // load my wpn
            string fileName = @"cstrike\addons\amxmodx\configs\" + filename.ToString() + ".lst";
            if (File.Exists(fileName))
            {
                myWpn.Clear();

                sr = new StreamReader(fileName, Encoding.Default);

                while ((line = sr.ReadLine()) != null)
                {
                    if (line == "")
                        continue;

                    string head = line.Substring(0, 1);

                    if (head == ";")
                        continue;

                    myWpn.Add(line);
                }

                sr.Close();
            }

            // load all weapon
            SuspendLayout();

            sr = new StreamReader(@"cstrike\addons\amxmodx\configs\weapons.lst", Encoding.Default);
            while ((line = sr.ReadLine()) != null)
            {
                if (line == "")
                    continue;

                string head = line.Substring(0, 1);

                if (head == ";")
                    continue;

                //Add(line);
                this.BeginInvoke(new Add(intoAdd), line);
            }

            sr.Close();

            ResumeLayout(false);

            totalMyWpn = myWpn.Count;
            formatTotalWeapon();
        }

        private void intoAdd(string name)
        {
            //iniClass.curFile = @"cstrike\weapons.ini";

            var canBuyStr = Weapon[name.ToUpper()]["CanBuy"].ToLower();
            bool canBuy = bool.Parse(canBuyStr);

            if (!canBuy)
                return;

            WeaponButton add = new WeaponButton();

            add.Location = new Point(24 + 255 * (totalWeapons % 3), 24 + 126 * (totalWeapons / 3));
            add.Name = "btnAdd";
            add.Text = "";
            //add.FontWeightMedium = true;
            add.Size = new Size(235, 102);
            add.AutoSize = false;
            add.WeaponName = name;
            add.MouseState = MouseState.HOVER;

            //iniClass.curFile = localizedLauncherIniPath;
            var weaponLabel = Launcher["Weapons"][name.ToUpper()]; weaponLabel = weaponLabel == null ? name : weaponLabel;
            add.WeaponText = weaponLabel;

            add.Click += add_Click;

            foreach (string mywpn in myWpn)
            {
                if (mywpn == name)
                    add.Checked = true;
            }

            string img = @"wpnpic\" + name + ".png";
            if (File.Exists(img))
                add.Image = Image.FromFile(img);

            WeaponsPanel.Controls.Add(add);
            buttonWpn.Add(add);

            totalWeapons++;
        }

        void add_Click(object sender, EventArgs e)
        {
            WeaponButton btn = (WeaponButton)sender;

            totalMyWpn += btn.Checked ? 1 : -1;
            formatTotalWeapon();
        }

        private void wpnBteAnim(WeaponButton btn, bool check)
        {
            if (btn.Checked != check)
                btn.Checked = check;
        }

        // Other Function
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            foreach (WeaponButton btn in buttonWpn)
            {
                btn.Checked = false;
            }

            totalMyWpn = 0;
            formatTotalWeapon();
        }

        private void ButtonAll_Click(object sender, EventArgs e)
        {
            foreach (WeaponButton btn in buttonWpn)
            {
                btn.Checked = true;
            }

            totalMyWpn = 0;
            formatTotalWeapon();
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            aForm.Show();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            LoadList("weapons_precache");
        }
    }
}
