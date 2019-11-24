using System.IO;
using System.Net;

namespace Preloader
{
    public class Globals
    {
        public static string AssetEndpoint = "http://45.77.236.84:81/asset/";
        public static string FingerPrint = "";
        public static string CurrentDirectory = Directory.GetCurrentDirectory();
    }

    public class Functions
    {
        public static void DownloadAsset(string URI, string Dest)
        {
            using (WebClient wc = new WebClient())
            {
                if (File.Exists(Dest)) return;
                wc.Headers.Add("authorization", "unsecure");
                wc.Headers.Add("user-agent", "Ballista-" + Globals.FingerPrint);
                wc.DownloadFile(Globals.AssetEndpoint + URI, Dest);
            }
            return;
        }
    }
}
