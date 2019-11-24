using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net;

namespace PlutoLib
{
    public class Globals
    {
        public static string BaseEndpoint = "http://45.77.236.84:81/";
        public static string FingerPrint = "";
        public static string APIKey = "";

        public static string XSRFToken;
        public static string Cookie;
        public static JObject Items;

        public static WebClient WebClient;

        public static List<Error> Errors = new List<Error>()
        {
            new Error()
            {
                ErrorCode = -1,
                ErrorMessage = "OK"
            },
            new Error()
            {
                ErrorCode = 4000,
                ErrorMessage = "Access to this resource is denied."
            },
            new Error()
            {
                ErrorCode = 4001,
                ErrorMessage = "Invalid authorization token."
            },
            new Error()
            {
                ErrorCode = 4002,
                ErrorMessage = "Ballista is currently down for maintainence."
            },
            new Error()
            {
                ErrorCode = 4003,
                ErrorMessage = "Suspicious request."
            },
            new Error()
            {
                ErrorCode = 4004,
                ErrorMessage = "Authorization failed."
            },
            new Error()
            {
                ErrorCode = 4005,
                ErrorMessage = "Unknown account holder."
            }
        };
    }

    public class Error
    {
        public int ErrorCode { get; set; } = -1;
        public string ErrorMessage { get; set; } = "Unknown error.";
    }

    public class Functions
    {
        public static void RefreshWebClient()
        {
            if(Globals.WebClient != null) Globals.WebClient.Dispose();
            Globals.WebClient = new WebClient();
        }

        public static string MakeApiRequest(string URI)
        {
            return Globals.WebClient.DownloadString(Globals.BaseEndpoint + URI);
        }
    }
}
