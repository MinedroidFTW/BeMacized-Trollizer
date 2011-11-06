using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
