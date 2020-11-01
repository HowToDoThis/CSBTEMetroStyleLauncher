using MetroFramework.Forms;
using Pfim;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WeaponEditor
{
    public partial class MainForm : MetroForm
    {
        private readonly string localizedLauncherPath;
        private string curSelectFormat;

        //private static readonly FileIniDataParser parser = new FileIniDataParser();
        //private static FileIniDataParser parser = new FileIniDataParser(iniDataParser);
        //private static readonly IniDataParser iniDataParser = new IniDataParser();

        //private IniData Weapon;
        //private IniData Launcher;
        private readonly Main aForm = new Main();

        public MainForm()
        {
            string[] args = Environment.GetCommandLineArgs();

            /*
            if (args.Contains("AllowDuplicate"))
            {
                parser.Parser.Configuration.AllowDuplicateSections = true;
                parser.Parser.Configuration.AllowDuplicateKeys = true;
            }
            */

            InitializeComponent();
            LoadSetting();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            curSelectFormat = SeletedAmount.Text;
            LoadList("LCSMMyWpn");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveList();
        }

        private void SaveList()
        {
            StreamWriter sw = null;
            string path = @"cstrike/addons/amxmodx/configs/LCSMMyWpn.ini";

            if (!File.Exists(path))
            {
                sw = new StreamWriter(File.Create(path));
                sw.WriteLine("// LCSM");
                sw.WriteLine();
                sw.WriteLine("[Option]");
                sw.WriteLine("ENABLE = 1");
                sw.WriteLine();
                sw.WriteLine("[Weapon]");
                sw.Flush();
                sw.Close();
            }

            // format to 4 lines
            string pri = "PRIMARY = ";
            string sec = "SECONDARY = ";
            string kni = "MELEE = ";
            string gre = "GRENADE = ";

            // And error msg... if got?
            string errmsg = string.Empty;

            foreach (var btn in buttonWpn)
            {
                if (btn.Checked)
                {
                    string wpnName = (string)btn.Tag;
                    // get name and add to section...
                    switch (wpnName)
                    {
                        // Grenade
                        case "cake3":
                        case "heartbomb":
                        case "pumpkin":
                        case "mooncake":
                        case "holybomb":
                            gre += $"{wpnName}, ";
                            break;

                        // MELEE
                        case "dragontail":
                        case "skullaxe":
                        case "dualsword":
                        case "summonknife":
                        case "y20s1sword":
                            kni += $"{wpnName}, ";
                            break;

                        // SECONDARY
                        case "usp":
                        case "anaconda":
                        case "infinitysr":
                        case "luger_sliver":
                        case "m79_gold":
                        case "voidpistol":
                        case "gunkata":
                            sec += $"{wpnName}, ";
                            break;

                        // PRIMARY
                        case "ak47_60r":
                        case "lockongun":
                        case "y20s2scard":
                        case "laserfist":
                        case "magicsg":
                        case "pianogun":
                        case "svdex":
                        case "at4ex":
                        case "cartblue":
                        case "cartred":
                        case "m134_xmas":
                        case "m134ex":
                        case "m1887_gold":
                        case "m249ex":
                        case "m95":
                        case "mg3_xmas":
                        case "mp5_tiger":
                        case "p90":
                        case "sfgun":
                        case "sfsmg":
                        case "skull5":
                        case "sl8_gold":
                        case "sl8ex":
                        case "tar21":
                        case "thompson":
                        case "trg42_gold":
                        case "wa2000_gold":
                        case "watergun":
                        case "xm1014":
                        case "xm2010":
                            pri += $"{wpnName}, ";
                            break;

                        default:
                            errmsg += $"{wpnName}, ";
                            break;
                    }
                }
            }

            if (!string.IsNullOrEmpty(errmsg))
                MessageBox.Show($"武器: {errmsg.Substring(errmsg.LastIndexOf(',') - 1)}\n都是不支持武器。请自行添加到文件里。");

            // Overwrite it
            var test = new StreamReader(File.Open(path, FileMode.OpenOrCreate));
            var data = test.ReadToEnd();
            test.Close();

            // delete file.
            File.Delete(path);


            int pos = data.IndexOf("PRIMARY");
            var header = data.Remove(pos);
            sw = new StreamWriter(File.OpenWrite(path));
            sw.Write(header);

            sw.WriteLine(pri);
            sw.WriteLine(sec);
            sw.WriteLine(kni);
            sw.WriteLine(gre);

            sw.Flush();
            sw.Close();

            /*
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
            */
        }

        /*
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
        */

        // Because Egg using NST Style, Need Fix This
        NSTFileParser Weapon;

        private void LoadSetting()
        {
            Weapon = new NSTFileParser("cstrike/addons/amxmodx/configs/liuchengsima.ini");

            //Weapon = TryCatch(@"cstrike\weapons.ini");
            //Launcher = TryCatch(localizedLauncherPath);

            //if (!File.Exists(@"cstrike\addons\amxmodx\configs\weapons_precache.default.lst"))
                //File.Copy(@"cstrike\addons\amxmodx\configs\weapons_precache.lst", @"cstrike\addons\amxmodx\configs\weapons_precache.default.lst");
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
            myWpn.Clear();
            buttonWpn.Clear();

            StreamReader sr;
            string line;

            // load my wpn
            string fileName = @"cstrike/addons/amxmodx/configs/" + filename.ToString() + ".ini";
            if (File.Exists(fileName))
            {
                sr = new StreamReader(File.OpenRead(fileName));

                while ((line = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        if (line.Contains("PRIMARY") || line.Contains("SECONDARY") || line.Contains("MELEE") || line.Contains("GRENADE"))
                        {
                            // xxx = xxxx
                            //     ^ ^
                            //     ^ ^ <- the added pos will become here
                            //     ^ <- return this pos, so add more 2 to start it
                            line = line.Substring(line.IndexOf('=') + 2);

                            // remove space and split with ','
                            var data = line.Replace(" ", string.Empty).Split(',');

                            foreach (var d in data)
                            {
                                if (!string.IsNullOrEmpty(d))
                                    myWpn.Add(d);
                            }
                        }
                    }
                }

                sr.Close();
            }

            // load all weapon
            SuspendLayout();

            foreach (var key in Weapon.Keys)
            {
                Add(key.Key);
            }

            // Set Checked at here

            ResumeLayout(false);

            totalMyWpn = myWpn.Count;
            FormatTotalWeapon();
        }

        private void Add(string name)
        {
            try
            {
                var str = Weapon.Keys[name]["buy"];
                if (str != "1")
                    return;
            }
            catch
            {
                MessageBox.Show("武器 : " + name + " 缺少购买信息, 请添加[buy]1来修复此问题", "武器 : " + name);
                Close();
            }

            // model name
            var mName = Weapon.Keys[name]["model"];

            // picture path
            // TODO: Fix
            string img = @"wpnpic\" + mName + ".tga";

            if (!File.Exists(img))
                img = @"wpnpic\" + mName + ".png";
            if (!File.Exists(img))
                img = @"wpnpic\" + mName + ".jpg";

            Image bitmap = null;

            if (img.EndsWith(".tga"))
            {
                using (var image = Pfim.Pfim.FromFile(img))
                {
                    PixelFormat format;
                    switch (image.Format)
                    {
                        case Pfim.ImageFormat.Rgb24:
                            format = PixelFormat.Format24bppRgb;
                            break;

                        case Pfim.ImageFormat.Rgba32:
                            format = PixelFormat.Format32bppArgb;
                            break;

                        case Pfim.ImageFormat.R5g5b5:
                            format = PixelFormat.Format16bppRgb555;
                            break;

                        case Pfim.ImageFormat.R5g6b5:
                            format = PixelFormat.Format16bppRgb565;
                            break;

                        case Pfim.ImageFormat.R5g5b5a1:
                            format = PixelFormat.Format16bppArgb1555;
                            break;

                        case Pfim.ImageFormat.Rgb8:
                            format = PixelFormat.Format8bppIndexed;
                            break;

                        default:
                            var msg = $"{image.Format} is not recognized for Bitmap on Windows Forms. " +
                                       "You'd need to write a conversion function to convert the data to known format";
                            var caption = "Unrecognized format";
                            MessageBox.Show(msg, caption, MessageBoxButtons.OK);
                            return;
                    }

                    var handle = GCHandle.Alloc(image.Data, GCHandleType.Pinned);
                    var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(image.Data, 0);
                    bitmap = new Bitmap(image.Width, image.Height, image.Stride, format, ptr);

                    if (format == PixelFormat.Format8bppIndexed)
                    {
                        var palette = bitmap.Palette;
                        for (int i = 0; i < 256; i++)
                        {
                            palette.Entries[i] = Color.FromArgb((byte)i, (byte)i, (byte)i);
                        }
                        bitmap.Palette = palette;
                    }
                }
            }
            else if (img.EndsWith(".png") || img.EndsWith(".jpg"))
            {
                if (File.Exists(img))
                    bitmap = Image.FromFile(img);
            }

            WeaponButton add = new WeaponButton
            {
                Location = new Point(24 + 255 * (totalWeapons % 3), 24 + 126 * (totalWeapons / 3)),
                Name = "btnAdd",
                Text = "",
                Size = new Size(235, 102),
                AutoSize = false,
                WeaponName = name,
                Tag = mName,
                Image = bitmap
            };

            add.WeaponText = name;
            add.Click += Add_Click;

            foreach (string mywpn in myWpn)
            {
                if (mywpn == (string)add.Tag)
                {
                    add.Checked = true;
                    break; // Fix this method...
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
