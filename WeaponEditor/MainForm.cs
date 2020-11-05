using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WeaponEditor
{
    public partial class MainForm : MetroForm
    {
        private string curSelectFormat;

        #region Form
        public MainForm()
        {
            string[] args = Environment.GetCommandLineArgs();

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
        #endregion

        private void SaveList()
        {
            string path = @"cstrike/addons/amxmodx/configs/LCSMMyWpn.ini";

            StreamWriter sw;
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
                    string iType = (string)btn.Tag;
                    switch (iType)
                    {
                        // PRIMARY
                        case "0":
                            pri += $"{btn.WeaponName}, ";
                            break;

                        // SECONDARY
                        case "1":
                            sec += $"{btn.WeaponName}, ";
                            break;

                        // MELEE
                        case "2":
                            kni += $"{btn.WeaponName}, ";
                            break;

                        // Grenade
                        case "3":
                            gre += $"{btn.WeaponName}, ";
                            break;

                        default:
                            errmsg += $"{btn.WeaponName}, ";
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
        }

        // Because Egg using NST Style, Need Fix This
        NSTFileParser Weapon;

        private void LoadSetting()
        {
            Weapon = new NSTFileParser("cstrike/addons/amxmodx/configs/liuchengsima.ini");
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

            try
            {
                var test = Weapon.Keys[name]["iType"];
            }
            catch
            {
                MessageBox.Show("武器 : " + name + " 缺少类型信息, 请添加[iType]x来修复此问题\nx为号码0-4", "武器 : " + name);
                Close();
            }

            // model name
            var mName = Weapon.Keys[name]["model"];

            // picture path
            // TODO: Fix
            string img = @"cstrike/gfx/egg/" + mName + ".tga";

            if (!File.Exists(img))
                img = @"cstrike/gfx/egg/" + mName + ".png";
            if (!File.Exists(img))
                img = @"cstrike/gfx/egg/" + mName + ".jpg";

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
                WeaponName = mName,
                Tag = Weapon.Keys[name]["iType"],
                Image = bitmap
            };

            add.WeaponText = name;
            add.Click += Add_Click;

            foreach (string mywpn in myWpn)
            {
                if (mywpn == add.WeaponName)
                {
                    // Fix this method...
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

        #region Other Function
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
        #endregion
    }
}
