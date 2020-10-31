using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Win32;

namespace First_Time
{
    public partial class MainForm : MetroForm
    {
        private int language;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            var root = Registry.CurrentUser;
            var hlKey = @"SOFTWARE\Valve\Half-Life\Settings";
            var steamKey = @"SOFTWARE\Valve\Steam";
            var finallanguage = "english";

            if (LanguageComboBox.SelectedIndex >= 0)
            {
                switch (language)
                {
                    case 0:
                        finallanguage = "schinese";
                        break;
                    case 1:
                        finallanguage = "tchinese";
                        break;
                    case 2:
                        finallanguage = "english";
                        break;
                }
            }
            else
            {
                MetroMessageBox.Show(this, "You Have Not Selected A Language.\n你还没选择一个语言。");
            }

            if (Agree.Checked == true)
            {
                RegistryHelper.SetRegKeyValue(root, hlKey, "ValveKey", "55WNH-GSPH7-Q8QQT-AMIYV-3Y5BB", RegistryValueKind.String);
                RegistryHelper.SetRegKeyValue(root, hlKey, "ScreenWidth", "1024", RegistryValueKind.DWord);
                RegistryHelper.SetRegKeyValue(root, hlKey, "ScreenHeight", "768", RegistryValueKind.DWord);
                RegistryHelper.SetRegKeyValue(root, hlKey, "ScreenWindowed", "0", RegistryValueKind.DWord);

                RegistryHelper.SetRegKeyValue(root, steamKey, "Language", finallanguage, RegistryValueKind.String);
            }
            else
            {
                MetroMessageBox.Show(this, "You Have Not Agree Statement.\n你还没有同意上述申明。");
            }
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            language = LanguageComboBox.SelectedIndex;
            metroLabel1.Text = language.ToString();
        }
    }
}
