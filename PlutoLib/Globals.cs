using Newtonsoft.Json.Linq;
using System.Net;

namespace PlutoLib
{
    public class Globals
    {
        public static string XSRFToken;
        public static string Cookie;
        public static JObject Items;

        public static WebClient WebClient;
    }

    public class Functions
    {
        public static void RefreshWebClient()
        {
            if(Globals.WebClient != null) Globals.WebClient.Dispose();
            Globals.WebClient = new WebClient();
        }
    }
}
