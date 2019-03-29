using System;
using System.Windows.Forms;


namespace CSBTE_MyWpnEditor
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string lang = "english";
            if (args.Length > 0)
                lang = args[0];

            MainForm mainForm = new MainForm(lang);
            Application.Run(mainForm);
        }
    }
}
