using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BeMacized_Trollizer.Wouter
{
    public static class Main
    {
        public static string GenPassword(int chars)
        {
            Random rand = new Random(BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0));
            string endresult = "";
            while (chars > 0)
            {
                int method = rand.Next(1, 7);
                if (method <= 2)
                {
                    int charnumber = rand.Next(33, 126);
                    char c = Convert.ToChar(charnumber);
                    endresult += c;
                }
                if (method > 2)
                {
                    int charnumber = rand.Next(161, 879);
                    char c = Convert.ToChar(charnumber);
                    endresult += c;
                }
                chars--;
            }
            return endresult;
        }
        public static string GenMD5(string input, bool useweb)
        {
            if (Settings.internetconnection && useweb)
            {
                WebClient wc = new WebClient();
                return wc.DownloadString("http://data.bemacizedgaming.com/md5.php?string=" + input);
            }
            else
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    return GetMd5Hash(md5Hash, input);
                }
            }
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public static void StartSpam(string text, int times, bool usefast)
        {
            while (times > 0)
            {
                if (!usefast)
                {
                    times--;
                    SendKeys.SendWait(text + "{ENTER}");
                    System.Threading.Thread.Sleep(50);
                    SendKeys.SendWait("{ENTER}");
                    System.Threading.Thread.Sleep(50);
                    SendKeys.SendWait("{ENTER}");
                    System.Threading.Thread.Sleep(50);
                }
                else
                {
                    times--;
                    SendKeys.SendWait(text + "{ENTER}");
                }
            }
        }
    }
}
