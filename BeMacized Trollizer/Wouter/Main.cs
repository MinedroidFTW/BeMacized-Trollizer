using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Security.Cryptography;

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

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
