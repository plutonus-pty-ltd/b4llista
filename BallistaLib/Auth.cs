using Newtonsoft.Json.Linq;
using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace BallistaLib
{
    public class Auth
    {
        public static void RegisterAuth()
        {
            JObject AuthObj = JObject.Parse(Functions.MakeApiRequest("auth/" + Globals.FingerPrint));

            if ((int)AuthObj["Error"] != -1)
            {
                Error Err = Globals.Errors.Find(delegate (Error i) { return i.ErrorCode == (int)AuthObj["Error"]; });
                Environment.Exit(1);
            }

            Globals.APIKey = (string)AuthObj["Token"];
            return;
        }
    }

    public class FingerPrint
    {
        public static string GetMachineGuid()
        {
            string location = @"SOFTWARE\Microsoft\Cryptography";
            string name = "MachineGuid";

            using (RegistryKey localMachineX64View =
                RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey rk = localMachineX64View.OpenSubKey(location))
                {
                    if (rk == null)
                        throw new KeyNotFoundException(
                            string.Format("Key Not Found: {0}", location));

                    object machineGuid = rk.GetValue(name);
                    if (machineGuid == null)
                        throw new IndexOutOfRangeException(
                            string.Format("Index Not Found: {0}", name));

                    return machineGuid.ToString();
                }
            }
        }
    }
}
