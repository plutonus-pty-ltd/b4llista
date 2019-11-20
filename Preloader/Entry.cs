using System;
using System.Diagnostics;
using System.IO;

namespace Preloader
{
    class Entry
    {
        public static void Main()
        {
            if (!Directory.Exists(Path.Combine(Globals.CurrentDirectory, "bin")))
            {
                Directory.CreateDirectory(Path.Combine(Globals.CurrentDirectory, "bin"));
            }
            Globals.FingerPrint = Auth.GetMachineGuid();
            Functions.DownloadAsset("Newtonsoft.Json.dll", Path.Combine(Globals.CurrentDirectory, "bin") + "/Newtonsoft.Json.dll");
            Functions.DownloadAsset("B4llista.exe", Path.Combine(Globals.CurrentDirectory, "bin") + "/B4llista.exe");
            Process.Start(Path.Combine(Globals.CurrentDirectory, "bin") + "/B4llista.exe");
            Environment.Exit(1);
        }
    }
}
