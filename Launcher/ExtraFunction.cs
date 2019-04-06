using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Launcher
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
            LoadMap = true;
        }

        public bool LoadMap;
        public string LastMap;
        public string EditorName;
        public string ExtraCmd;

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
            string args = "-game cstrike" + ExtraCmd + " +maxplayers 32";

            if (!LoadMap)
            {
                Launch(file, args);
                return;
            }

            string sourceFile = @"cstrike\resource\maploading\loadingbg_" + LastMap + ".tga";
            string destFile = @"cstrike\resource\maploading\loadingbg.tga";

            if (File.Exists(sourceFile))
                File.Copy(sourceFile, destFile, true);

            args += " +map " + LastMap + ".bsp";

            Launch(file, args);
        }

        public void LaunchEditor()
        {
            Launch(EditorName, ExtraCmd);
        }
    }

    class GameMode
    {
        public string StringEnable;
        public string StringDisable;
        public string StringName;

        public GameMode()
        {
            StringEnable = "";
            StringDisable = "";
            StringName = "";
        }
    }
}
