using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace LSRVersionManager
{
    public class Version
    {
        public string exeName;
        public GameArgs whitelistArgs;
        public GameArgs args;
        public string cleanName;
        public string number;
        public string dateModified;
        public string path;
        public bool isDemo = false;

        public Version(string gamePath)
        {
            string[] exeNames = { "_msr.exe", "LEGOSRally.exe", "StuntRally.exe" };

            var flags0351 = ~GameArgs.None;
            var flags0381 = GameArgs.Files | GameArgs.Freeform | GameArgs.IGTest | GameArgs.NoIntroVideo | GameArgs.XAFToXBF;

            foreach (var exe in exeNames)
            {
                if(File.Exists(Path.Combine(gamePath, exe)))
                {
                    FileInfo fileInfo = new FileInfo(Path.Combine(gamePath, exe));
                    FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(gamePath, exe)); //TODO check file exists
                    path = gamePath;
                    this.number = fileVersionInfo.ProductVersion.Replace(", ", ".");
                    this.dateModified = fileInfo.LastWriteTime.ToString("F");
                    this.exeName = exe;
                    this.cleanName = "LEGO Stunt Rally";
                    if(this.exeName == "LEGOSRally.exe")
                    {
                        this.isDemo = true;
                        this.cleanName += " Japanese DEMO";
                        this.whitelistArgs = flags0381 & ~GameArgs.XAFToXBF | GameArgs.Res_Files | GameArgs.NoRes;
                        break;
                    }
                    else if(this.exeName == "StuntRally.exe")
                    {
                        this.isDemo = true;
                        this.cleanName += " English DEMO";
                        this.whitelistArgs = GameArgs.Freeform;
                        break;
                    }
                    this.cleanName += $" {this.number}";
                    if(this.number == "0.3.5.1")
                    {
                        this.whitelistArgs = flags0351;
                    }
                    else if (this.number == "0.3.8.1" || this.number == "0.3.7.7")
                    {
                        this.whitelistArgs = flags0381;
                    }
                    else
                    {
                        this.whitelistArgs = flags0351;
                    }
                    break;
                }
            }
        }
    }
}
