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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Globals.FingerPrint = FingerPrint.GetMachineGuid();
            Auth.RegisterAuth();
            while (Globals.APIKey == "") { }
            MessageBox.Show(Globals.APIKey);
        }
    }
}
