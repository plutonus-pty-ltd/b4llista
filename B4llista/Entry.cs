using System;
using System.Threading;
using System.Windows.Forms;

namespace B4llista
{
    public class Entry
    {
        [STAThread]
        public static void Main()
        {
            bool valid;
            Globals.Mutex = new Mutex(true, "Ballista", out valid);
            Globals.Mutex.WaitOne();
            if (!valid) Environment.Exit(1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Globals.FingerPrint = FingerPrint.GetMachineGuid();
            Auth.RegisterAuth();
            while (Globals.APIKey == "") { }
            MessageBox.Show(Globals.APIKey);
        }
    }
}
