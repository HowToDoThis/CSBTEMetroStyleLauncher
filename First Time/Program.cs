using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace First_Time
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public static class RegistryHelper
    {
        public static string GetRegKeyValue(RegistryKey root, string subkey, string name, string defaultValue)
        {
            try
            {
                var key = root.OpenSubKey(subkey);
                if (key == null)
                {
                    return defaultValue;
                }
                var value = key.GetValue(name, defaultValue).ToString();
                key.Close();

                return value;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }

            return defaultValue;
        }

        public static void SetRegKeyValue(RegistryKey root, string subkey, string name, object value, RegistryValueKind kind)
        {
            try
            {
                var key = root.OpenSubKey(subkey, true);
                if (key == null)
                {
                    key = root.CreateSubKey(subkey);
                }
                key.SetValue(name, value, kind);
                key.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }

    }
}
