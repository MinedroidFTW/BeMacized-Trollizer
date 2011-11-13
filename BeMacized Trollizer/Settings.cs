using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;

namespace BeMacized_Trollizer
{
    public static class Settings
    {
        // variables
        public static bool internetconnection = false;
        public static bool canuseprintscreen = true;
        public static bool uptodate = true;

        // methods

        // Main settings loader
        public static void LoadSettings()
        {
            Checkconnection();
        }

        // Other
        public static void Checkconnection()
        {
            string response = "thispageworks";
            string url = "http://data.bemacizedgaming.com/con.txt";
            WebClient wc = new WebClient();
            if (wc.DownloadString(url) == response)
            {
                internetconnection = true;
            }
        }
        public static bool CheckUpdate()
        {
            WebClient wc = new WebClient();
            string updatestr = wc.DownloadString("http://data.bemacizedgaming.com/version.ini");
            updatestr = updatestr.Replace(".", "");
            int version = Convert.ToInt32(updatestr);
            int programversion = Convert.ToInt32(Application.ProductVersion.Replace(".", ""));
            if (version > programversion)
            {
                uptodate = false;
            }
            return uptodate;
        }
    }
}
