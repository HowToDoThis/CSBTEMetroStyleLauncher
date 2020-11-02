using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponEditor
{
    public class NSTFileParser
    {
        public Dictionary<string, Dictionary<string, string>> Keys { get; set; } = new Dictionary<string, Dictionary<string, string>>();

        public NSTFileParser(string path)
        {
            // Load File
            StreamReader s = new StreamReader(File.OpenRead(path));
            string data = s.ReadToEnd().Replace("\r", string.Empty);

            foreach (var line in data.Split('\n'))
            {
                if (!line.StartsWith("；") || !line.StartsWith(";"))
                {
                    // only collects 
                    if (line.Contains("[name]"))
                    {
                        Dictionary<string, string> values = new Dictionary<string, string>();

                        // fix a weird buggy...
                        var keyvalue = line.Replace(']', '_').Replace("_", " ").Replace('[', '\0').Split('\0');
                        string name = string.Empty;

                        // loop line for parsing data
                        foreach (var d in keyvalue)
                        {
                            int pos = d.IndexOf(' ');

                            if (pos >= 1)
                            {
                                try
                                {
                                    var key = d.Remove(pos);
                                    var value = d.Substring(pos + 1);

                                    if (d.Contains("name"))
                                        name = value;

                                    values.Add(key, value);
                                }
                                catch
                                {
                                    // skipped
                                }
                            }
                        }

                        if (!string.IsNullOrEmpty(name))
                            Keys.Add(name, values);
                    }
                }
            }
        }
    }
}
