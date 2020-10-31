using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace WeaponEditor
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
                    return defaultValue;

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
    }
}
