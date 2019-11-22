using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace B4llista
{
    public class Entry
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Globals.FingerPrint = FingerPrint.GetMachineGuid();
            Auth.RegisterAuth();
            while (Globals.APIKey == "") { }
            Functions.DownloadAsset("PlutoLib.dll", Path.Combine(Globals.CurrentDirectory, "bin") + "/PlutoLib.dll");
            Functions.DownloadAsset("B4llistaUI.exe", Path.Combine(Globals.CurrentDirectory, "bin") + "/BallistaMBinary.exe");
            Functions.DownloadAsset("Bunifu_UI_v1.5.3.dll", Path.Combine(Globals.CurrentDirectory, "bin") + "/Bunifu_UI_v1.5.3.dll");

            Process.Start(Path.Combine(Globals.CurrentDirectory, "bin") + "/bootstrap.exe");
            Process.Start("BallistaMBinary.exe");
        }
    }
}
