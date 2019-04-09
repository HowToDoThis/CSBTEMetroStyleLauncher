using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

using MaterialSkin;
using System.IO;
using System.Threading;
using IniParser;
using IniParser.Model;

namespace CSBTE_MyWpnEditor
{
    public partial class MainForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        const int CS_DropSHADOW = 0x20000;
        const int GCL_STYLE = (-26);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        string localizedLauncherIniPath;
        bool enableMyWpn;

        private String curSelectFormat;
        private Settings mainformSetting = new Settings();

        List<string> profileName = new List<string>();
        List<string> profileNameTranslate = new List<string>();
        private int curProfile;

        List<ToolStripMenuItem> profileItem = new List<ToolStripMenuItem>();

        private Thread threadReloadMyWpn;
        private Thread threadSave;

        private static FileIniDataParser parser = new FileIniDataParser();
        private IniData weaponIni;
        private IniData launcherIni;

        public MainForm(string language)
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo300, Accent.Pink200, TextShade.WHITE);

            localizedLauncherIniPath = ((language == "english") ? "cstrike" : "cstrike_" + language) + @"\launcher.ini";

            loadSettings();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);

            curSelectFormat = curselectToolStripMenuItem.Text;

            Thread th;
            th = new Thread(new ParameterizedThreadStart(loadList));
            th.Start(profileName[curProfile]);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
            
            saveList();
            saveListFinal();
        }

        private string makeSaveString(List<string> data)
        {
            string result = "";
            int count = data.Count();

            for (int i = 0; i < count; i++)
            {
                result += data[i] + ((i != count - 1) ? "|" : "");
            }

            return result;
        }

        private void saveSettings()
        {
            mainformSetting.curProfile = curProfile;
            mainformSetting.profileName = makeSaveString(profileName);
            mainformSetting.profileNameTranslate = makeSaveString(profileNameTranslate);

            mainformSetting.Save();
        }

        private void loadSettings()
        {
            weaponIni = parser.ReadFile(@"cstrike\weapons.ini", Encoding.UTF8);
            launcherIni = parser.ReadFile(localizedLauncherIniPath, Encoding.UTF8);

            curProfile = 0;

            curProfile = mainformSetting.curProfile;
            profileName = mainformSetting.profileName.Split('|').ToList();
            profileNameTranslate = mainformSetting.profileNameTranslate.Split('|').ToList();
            profileNameTranslate[0] = materialContextMenuStrip2.Items[3].Text;

            if (profileName.Count == 0)
            {
                profileName.Add("weapons_precache.default");
                profileNameTranslate.Add(materialContextMenuStrip2.Items[3].Text);
            }

            profileName[0] = "weapons_precache.default";

            int profileCount = profileName.Count;

            if (curProfile >= profileCount - 1)
                curProfile = 0;

            if (!File.Exists(@"cstrike\addons\amxmodx\configs\weapons_precache.default.lst"))
                File.Copy(@"cstrike\addons\amxmodx\configs\weapons_precache.lst", @"cstrike\addons\amxmodx\configs\weapons_precache.default.lst");

            profileItem.Add(materialToolStripMenuItem1);

            for (int i = 1; i < profileName.Count; i++)
                addProfileItem(i);

            if (curProfile == 0)
                this.Text = materialContextMenuStrip2.Items[3].Text;                
            else
                this.Text = materialContextMenuStrip2.Items[3 + curProfile].Text;

            profileItem[curProfile].Text = "* " + profileNameTranslate[curProfile];

            int itemCout = materialContextMenuStrip2.Items.Count;
            materialContextMenuStrip2.Items[itemCout - 1].Enabled = (curProfile != 0);
            materialContextMenuStrip2.Items[itemCout - 2].Enabled = (curProfile != 0);
        }

        void addProfileItem(int id)
        {
            ToolStripMenuItem add = new ToolStripMenuItem();

            add.Name = "btnAdd";
            add.Text = profileNameTranslate[id];
            add.Tag = id;
            add.Font = new Font("Roboto + WenQuanYi Micro Medium", 15);
            add.Click += selectProfile;
            materialContextMenuStrip2.Items.Insert(materialContextMenuStrip2.Items.Count - 3, add);
            profileItem.Add(add);
        }

        void selectProfile()
        {
            for (int i = 0; i < profileItem.Count; i++)
            {
                if (i == curProfile)
                    profileItem[i].Text = "* " + profileNameTranslate[i];
                else
                    profileItem[i].Text = profileNameTranslate[i];
            }

            int itemCout = materialContextMenuStrip2.Items.Count;
            materialContextMenuStrip2.Items[itemCout - 1].Enabled = (curProfile != 0);
            materialContextMenuStrip2.Items[itemCout - 2].Enabled = (curProfile != 0);

            this.Text = profileNameTranslate[curProfile];
            this.Refresh();

            threadReloadMyWpn = new Thread(new ParameterizedThreadStart(loadMyWpn));
            threadReloadMyWpn.Start(profileName[curProfile]);
        }

        void selectProfile(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;

            int newProfile;

            if (btn.Tag.ToString() == "0")
                newProfile = 0;
            else
                newProfile = (int)btn.Tag;

            if (newProfile == curProfile)
                return;

            saveList();

            curProfile = newProfile;

            selectProfile();
        }

        private void saveCur(object sender, EventArgs e)
        {
            threadSave = new Thread(new ThreadStart(saveList));
            threadSave.Start();   
        }

        private void addProfile(object sender, EventArgs e)
        {
            openNewFile(newFile);
        }

        private void addProfileCopy(object sender, EventArgs e)
        {
            openNewFile(newFileCopy);
        }

        private void renameCur(object sender, EventArgs e)
        {
            openNewFile(renameFile, profileNameTranslate[curProfile]);
        }

        void newProfile(string nameTranslate, bool copyCur)
        {
            int count = profileName.Count;

            int num = 1;
            string path = @"cstrike\addons\amxmodx\configs\";
            string newFile = path + "weapons_precache." + num.ToString() + ".lst";

            while (File.Exists(newFile))
            {
                num++;
                newFile = path + "weapons_precache." + num.ToString() + ".lst";
            }
            
            profileName.Add("weapons_precache." + num.ToString());
            profileNameTranslate.Add(nameTranslate);
            addProfileItem(count);

            File.Copy(path + profileName[curProfile] + ".lst", newFile);

            if (copyCur)
            {
                FileStream fs = new FileStream(path + profileName[count] + ".lst", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine("true");

                sw.Flush();
                fs.Flush();
                fs.Close();
            }

            curProfile = count;
            selectProfile();

            saveSettings();
        }

        void newFile(object sender, InputForm.CloseEventArgs e)
        {
            if (e.status == InputForm.CloseType.OK)
            {
                newProfile(e.text, false);
            }
        }

        void newFileCopy(object sender, InputForm.CloseEventArgs e)
        {
            if (e.status == InputForm.CloseType.OK)
            {
                newProfile(e.text, true);
            }         
        }

        void renameFile(object sender, InputForm.CloseEventArgs e)
        {
            if (e.status == InputForm.CloseType.OK)
            {
                profileNameTranslate[curProfile] = e.text;
                profileItem[curProfile].Text = "* " + e.text;
                this.Text = e.text;
                this.Refresh();
            }
        }



        private void deleteCur(object sender, EventArgs e)
        {
            profileItem[curProfile].Dispose();
            profileItem.RemoveAt(curProfile);
            profileName.RemoveAt(curProfile);
            profileNameTranslate.RemoveAt(curProfile);

            curProfile = 0;
            selectProfile();
        }
        
        private void formatTotalWeapon()
        {
            curselectToolStripMenuItem.Text = String.Format(curSelectFormat, totalMyWpn);
        }

        private void saveListFinal()
        {
            string path = @"cstrike\addons\amxmodx\configs\weapons_precache.lst";
            string path2 = @"cstrike\addons\amxmodx\configs\" + profileName[curProfile] + ".lst";

            File.Copy(path2, path, true);
        }

        private void saveList()
        {
            string path = @"cstrike\addons\amxmodx\configs\" + profileName[curProfile] + ".lst";

            if (File.Exists(path))
                File.Delete(path);

            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(enableMyWpn ? "true" : "false");

            foreach (WeaponButton btn in buttonWpn)
            {
                if (btn.Checked)
                    sw.WriteLine(btn.WeaponRealName);
            }

            sw.Flush();
            fs.Flush();
            fs.Close();
        }

        private int totalWeapons;
        private int totalMyWpn;

        List<WeaponButton> buttonWpn = new List<WeaponButton>();
        List<string> myWpn = new List<string>();

        delegate void Add(string name);
        delegate void SetEnableMyWpn();
        delegate void WpnBteAnim(WeaponButton btn, bool check);
        delegate void FormatTotalWeapon();

        private void loadMyWpn(object filename)
        {
            StreamReader sr;
            string line;

            string fileName = @"cstrike\addons\amxmodx\configs\" + filename.ToString() + ".lst";
            if (File.Exists(fileName))
            {
                myWpn.Clear();

                sr = new StreamReader(fileName, Encoding.Default);
                enableMyWpn = (sr.ReadLine() != "false");

                this.BeginInvoke(new SetEnableMyWpn(intoSetEnableMyWpn));

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

            foreach (WeaponButton btn in buttonWpn)
            {
                bool result = false;

                foreach (string mywpn in myWpn)
                {
                    if (mywpn == btn.WeaponRealName)
                    {
                        result = true;
                    }
                }
                this.BeginInvoke(new WpnBteAnim(wpnBteAnim), new object[] { btn, result });
            }

            totalMyWpn = myWpn.Count;
            this.BeginInvoke(new FormatTotalWeapon(formatTotalWeapon));
        }

        private void wpnBteAnim(WeaponButton btn, bool check)
        {
            if (btn.Checked != check)
                btn.Checked = check;
        }

        private void loadList(object filename)
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
                enableMyWpn = (sr.ReadLine() != "false");

                this.BeginInvoke(new SetEnableMyWpn(intoSetEnableMyWpn));

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

        private void intoSetEnableMyWpn()
        {
            checkEnableMyWpn();
        }

        private void intoAdd(string name)
        {
            //iniClass.curFile = @"cstrike\weapons.ini";

            var canBuyStr = weaponIni[name.ToUpper()]["CanBuy"].ToLower();
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
            add.Depth = 0;
            add.WeaponRealName = name;
            add.MouseState = MaterialSkin.MouseState.HOVER;

            //iniClass.curFile = localizedLauncherIniPath;
            var weaponLabel = launcherIni["Weapons"][name.ToUpper()]; weaponLabel = weaponLabel == null ? name : weaponLabel;
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

            panel1.Controls.Add(add);
            buttonWpn.Add(add);

            totalWeapons++;
        }

        void add_Click(object sender, EventArgs e)
        {
            WeaponButton btn = (WeaponButton)sender;

            totalMyWpn += btn.Checked ? 1 : -1;
            formatTotalWeapon();
        }


        private void checkEnableMyWpn()
        {
            enableMyWpnToolStripMenuItem.Visible = !enableMyWpn;
            loadAllWeaponsToolStripMenuItem.Visible = enableMyWpn;
            materialContextMenuStrip1.Size = new Size(enableMyWpn ? 360 : 220, 76);
        }

        private void loadAllWeaponsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableMyWpn = false;
        }

        private void enableMyWpnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableMyWpn = true;
        }

        private void materialContextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            checkEnableMyWpn();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (WeaponButton btn in buttonWpn)
            {
                btn.Checked = false;
            }

            totalMyWpn = 0;
            formatTotalWeapon();
        }



        private void materialRaisedButton1_MouseUp(object sender, MouseEventArgs e)
        {
            materialContextMenuStrip1.Show(materialActionBarButton1, new Point(-materialContextMenuStrip1.Size.Width + materialActionBarButton1.Size.Width, materialActionBarButton1.Size.Height + 3));
        }

        private void materialActionBarButton3_Click(object sender, EventArgs e)
        {
            materialContextMenuStrip2.Show(materialActionBarButton3, new Point(-materialContextMenuStrip2.Size.Width + materialActionBarButton3.Size.Width, materialActionBarButton3.Size.Height + 3));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            var hoverBrush = new SolidBrush(Color.FromArgb(120, Color.Black));

            g.FillRectangle(hoverBrush, 0, 0, this.Size.Width, this.Size.Height);
        }

        private void openNewFile(InputForm.CloseResultHandler resultHandler, string name = null)
        {
            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer { Interval = 300, Enabled = true };

            animationTimer.Tick += (_sender, args) =>
            {
                System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)_sender;
                timer.Enabled = false;

                InputForm form1;
                if (name != null)
                    form1 = new InputForm(name);
                else
                    form1 = new InputForm();

                form1.Load += new EventHandler(f_BlackForm);
                form1.FormClosed += new FormClosedEventHandler(f_BlackFormClose);
                form1.FormClose += new InputForm.CloseResultHandler(resultHandler);
                form1.ShowDialog();

                timer.Dispose();
            };
        }

        private void openAbout()
        {
            System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer { Interval = 300, Enabled = true };

            animationTimer.Tick += (_sender, args) =>
            {
                System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)_sender;
                timer.Enabled = false;

                AboutForm aboutForm = new AboutForm();
                aboutForm.Load += new EventHandler(f_BlackForm);
                aboutForm.FormClosed += new FormClosedEventHandler(f_BlackFormClose);

                aboutForm.ShowDialog();

                timer.Dispose();
            };
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAbout();
        }


        void f_BlackForm(object sender, EventArgs e)
        {
            Bitmap _bitMap = new Bitmap(this.Size.Width, this.Size.Height);
            Graphics g = Graphics.FromImage(_bitMap);

            g.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);

            pictureBox1.Image = _bitMap;
            g.Dispose();

            pictureBox1.Visible = true;
            pictureBox1.Dock = DockStyle.Fill;
        }

        void f_BlackFormClose(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Dock = DockStyle.None;
            pictureBox1.Visible = false;
        }
    }
}
