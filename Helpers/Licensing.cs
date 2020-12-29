using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;

namespace YTR.Helpers
{
    public static class Licensing
    {
        public static string HID()
        {

            string hardwareID = GenHID();

            try
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("YouTubeCalculatorHID", true);
                if (key == null)
                {
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("YouTubeCalculatorHID");
                    key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("YouTubeCalculatorHID", true);
                    key.SetValue("YouTubeCalculatorHID", hardwareID);
                }
                else
                {
                    hardwareID = key.GetValue("YouTubeCalculatorHID").ToString();
                    key.Close();
                }
            }
            catch { }

            return hardwareID;
        }
        private static string GenHID()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            string hardwareID = "";
            string sMacAddress = "";
            string userID = Environment.UserName;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            hardwareID = ("" + sMacAddress + "" + userID).GetHashCode().ToString();
            Console.WriteLine(hardwareID);

            return hardwareID;
        }

        public struct LicenseResponse
        {
            public string Message;
            public Color color;
            public bool IsValid;
        };
        public struct TrialResponse
        {
            public string Message;
            public bool Success;
        };

        public static LicenseResponse CheckLicense(Http request, string TID)
        {
            LicenseResponse resp = new LicenseResponse();

            string HID = Licensing.HID();

            string rs = null;
            string url = "https://healzer.com/YTR/check.php?tid=" + TID + "&hid=" + HID;
            try
            {
                List<string> headers = new List<string>
                {   
                    "Accept-Language: en-gb,en;q=0.8,de;q=0.5,fr;q=0.3",
                    "Accept-Encoding: gzip, deflate"
                };

                rs = request.GET(
                        url,
                        "",
                        new System.Net.CookieContainer(),
                        headers,
                        null,
                        Http.HttpAccept.ACCEPT_ALL
                        );


            }
            catch (Exception)
            {
                resp.Message = "Unable to connect to server.";
                resp.color = Color.Red;
                resp.IsValid = false;
                return resp;
            }

            if (rs == null || rs.Length == 0)
            {
                resp.Message = "Unable to connect to server.";
                resp.color = Color.Red;
                resp.IsValid = false;
                return resp;
            }
            else if (rs.Contains("License already in use"))
            {
                resp.Message = "License is already in use.";
                resp.color = Color.Red;
                resp.IsValid = false;
                return resp;
            }
            else if (rs.Contains("Transaction ID not found"))
            {
                resp.Message = "Invalid License ID.";
                resp.color = Color.Red;
                resp.IsValid = false;
                return resp;
            }

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] raw_input = Encoding.UTF32.GetBytes(HID);
            byte[] raw_output = md5.ComputeHash(raw_input);
            string md5_hid = "";
            foreach (byte myByte in raw_output)
                md5_hid += myByte.ToString("X2");

            if (rs.Equals(md5_hid, StringComparison.InvariantCultureIgnoreCase))
            {
                MyPropertyManager.SetProperty("TID", TID);

                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("YTRLicense");
                    key.SetValue("tid", TID);
                    key.Close();
                }
                catch { }

                resp.Message = "Success.";
                resp.color = Color.Green;
                resp.IsValid = true;
                return resp;
            }
            else
            {
                MyPropertyManager.SetProperty("TID", "");

                try
                {
                    Microsoft.Win32.RegistryKey key;
                    key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("YTRLicense", true);
                    if (key == null)
                    {
                        key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("YTRLicense");
                        key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("YTRLicense", true);
                    }
                    if (key.GetValue("tid") != null)
                    {
                        key.DeleteValue("tid");
                        key.Close();
                    }
                }
                catch { }

                resp.Message = "Invalid License ID.";
                resp.color = Color.Red;
                resp.IsValid = false;
                return resp;
            }
        }

    }
}
