using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Preloader
{
    public class Globals
    {
        public static string AssetEndpoint = "http://45.77.236.84:81/asset/";
        public static string FingerPrint = "";
        public static string CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
    }

    public class Functions
    {
        public static void DownloadAsset(string URI, string Dest)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("authorization", "unsecure");
                wc.Headers.Add("user-agent", "Ballista-" + Globals.FingerPrint);
                wc.DownloadFile(Globals.AssetEndpoint + URI, Dest);
            }
            return;
        }
    }
}
