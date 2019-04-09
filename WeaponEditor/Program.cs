using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace WeaponEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string language = RegistryHelper.GetRegKeyValue(Registry.CurrentUser, @"SOFTWARE\Valve\Steam", "Language", "english");
            string duplicate = "false";

            if (args.Length > 0)
                duplicate = args[0];
            if (args.Length > 1)
                language = args[1];

            Application.Run(new MainForm(duplicate, language));
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
    }
}
