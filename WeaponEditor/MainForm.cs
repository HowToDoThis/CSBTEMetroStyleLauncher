using IniParser;
using IniParser.Model;
using IniParser.Parser;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeaponEditor
{
    public partial class MainForm : MetroForm
    {
        private readonly string localizedLauncherPath;
        private string curSelectFormat;

        private static readonly FileIniDataParser parser = new FileIniDataParser();
        //private static FileIniDataParser parser = new FileIniDataParser(iniDataParser);
        private static readonly IniDataParser iniDataParser = new IniDataParser();

        private IniData Weapon;
        private IniData Launcher;
        private readonly Main aForm = new Main();

        public MainForm()
        {
            string[] args = Environment.GetCommandLineArgs();
            string language = RegistryHelper.GetRegKeyValue(Registry.CurrentUser, @"SOFTWARE\Valve\Steam", "Language", "english");

            if (language == "english")
                localizedLauncherPath = @"cstrike\launcher.ini";
            else
                localizedLauncherPath = "cstrike_" + language + @"\launcher.ini";

            if (args.Contains("AllowDuplicate"))
            {
                parser.Parser.Configuration.AllowDuplicateSections = true;
                parser.Parser.Configuration.AllowDuplicateKeys = true;
            }

            InitializeComponent();
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
            sw.Close();
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

        private IniData TryCatch(string path)
        {
            try
            {
                parser.ReadFile(path, GetEncoding(path));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, path);
                Environment.Exit(-1);
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

        private void FormatTotalWeapon()
        {
            SeletedAmount.Text = string.Format(curSelectFormat, totalMyWpn);
        }

        private int totalWeapons;
        private int totalMyWpn;
        private readonly List<WeaponButton> buttonWpn = new List<WeaponButton>();
        private readonly List<string> myWpn = new List<string>();

        private void LoadList(object filename)
        {
            totalWeapons = 0;

            // load my wpn
            string fileName = @"cstrike\addons\amxmodx\configs\" + filename.ToString() + ".lst";
            if (File.Exists(fileName))
            {
                myWpn.Clear();

                var datas = new StreamReader(fileName).ReadToEnd();
                foreach (var line in datas.Replace("\r", string.Empty).Split('\n'))
                {
                    if (!line.StartsWith("true"))
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            var head = line[0];
                            if (head != ';')
                                myWpn.Add(line);
                        }
                    }
                }
            }

            // load all weapon
            SuspendLayout();

            var data = new StreamReader(@"cstrike\addons\amxmodx\configs\weapons.lst").ReadToEnd();
            foreach (var line in data.Replace("\r", string.Empty).Split('\n'))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    var head = line[0];
                    if (head != ';')
                        Add(line);
                }
            }

            ResumeLayout(false);

            totalMyWpn = myWpn.Count;
            FormatTotalWeapon();
        }

        private void Add(string name)
        {
            try
            {
                if (!bool.Parse(Weapon[name.ToUpper()]["CanBuy"].ToLower()))
                    return;
            }
            catch
            {
                MetroMessageBox.Show(this, "Weapon Name : " + name.ToUpper() + " Missing CanBuy, Please Fix It.", "Weapon Name : " + name.ToUpper());
                Close();
            }

            // picture path
            string img = @"wpnpic\" + name + ".png";
            var weaponLabel = Launcher["Weapons"][name.ToUpper()];

            WeaponButton add = new WeaponButton
            {
                Location = new Point(24 + 255 * (totalWeapons % 3), 24 + 126 * (totalWeapons / 3)),
                Name = "btnAdd",
                Text = "",
                Size = new Size(235, 102),
                AutoSize = false,
                WeaponName = name,
                Image = File.Exists(img) ? Image.FromFile(img) : null,
                WeaponText = weaponLabel ?? name,
            };

            add.Click += Add_Click;

            foreach (string mywpn in myWpn)
            {
                if (mywpn == name)
                {
                    add.Checked = true;
                    break;
                }
            }

            WeaponsPanel.Controls.Add(add);
            buttonWpn.Add(add);

            totalWeapons++;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            WeaponButton btn = (WeaponButton)sender;

            totalMyWpn += btn.Checked ? 1 : -1;
            FormatTotalWeapon();
        }

        // Other Function
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            foreach (WeaponButton btn in buttonWpn)
            {
                btn.Checked = false;
            }

            totalMyWpn = 0;
            FormatTotalWeapon();
        }

        private void ButtonAll_Click(object sender, EventArgs e)
        {
            totalMyWpn = 0;
            
            foreach (WeaponButton btn in buttonWpn)
            {
                btn.Checked = true;
                totalMyWpn++;
            }

            FormatTotalWeapon();
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            aForm.Show();
        }
    }
}
