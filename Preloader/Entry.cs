using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preloader
{
    class Entry
    {
        public static void Main()
        {
            if (!Directory.Exists(Globals.CurrentDirectory + "bin"))
            {
                Directory.CreateDirectory(Globals.CurrentDirectory + "bin");
            }
            Globals.FingerPrint = Auth.GetMachineGuid();
            Functions.DownloadAsset("Newtonsoft.Json.dll", Globals.CurrentDirectory + "bin\\Newtonsoft.Json.dll");
            Functions.DownloadAsset("B4llista.exe", Globals.CurrentDirectory + "bin\\Ballista.exe");
            Process.Start(Globals.CurrentDirectory + "bin\\Ballista.exe");
            Environment.Exit(1);
        }
    }
}
