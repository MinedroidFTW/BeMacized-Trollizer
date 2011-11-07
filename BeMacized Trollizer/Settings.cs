using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace BeMacized_Trollizer
{
    public static class Settings
    {
        // variables
        public static bool internetconnection = false;
        public static bool canuseprintscreen = true;

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
    }
}
