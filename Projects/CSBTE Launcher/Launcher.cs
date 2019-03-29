using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CSBTELauncher
{
    class LauncherSettingsManager
    {
        private static LauncherSettingsManager instance;

        public static LauncherSettingsManager Instance
        {
            get { return instance ?? (instance = new LauncherSettingsManager()); }
        }
        
        public LauncherSettingsManager()
        {
            loadMap = true;
        }

        public bool loadMap;
        public string lastMap;
        public string editorName;
        public string extraCmd;


        private void Launch(string file, string args)
        {
            try
            {
                Process myprocess = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo(file, args);
                myprocess.StartInfo = startInfo;
                myprocess.StartInfo.UseShellExecute = false;
                myprocess.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public void LaunchGame()
        {
            string file = "hl.exe";
            string args = "-game cstrike" + extraCmd + " +maxplayers 32";

            if (!loadMap)
            {
                Launch(file, args);
                return;
            }           

            string sourceFile = @"cstrike\resource\maploading\loadingbg_" + lastMap + ".tga";
            string destFile = @"cstrike\resource\maploading\loadingbg.tga";

            if (File.Exists(sourceFile))
                File.Copy(sourceFile, destFile, true);

            args += " +map " + lastMap + ".bsp";

            Launch(file, args);
        }

        public void LaunchEditor()
        {
            Launch("CSBTEMyWpnEditor.exe", extraCmd);
        }
    }

    class GameMode
    {
        public string stringEnable;
        public string stringDisable;
        public string stringName;

        public GameMode()
        {
            stringEnable = "";
            stringDisable = "";
            stringName = "";
        }
    }
}
