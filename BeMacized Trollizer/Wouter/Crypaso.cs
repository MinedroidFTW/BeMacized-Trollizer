using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeMacized_Trollizer.Wouter
{
    public static class Crypaso
    {
        public static string[] numbersEN = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        public static string[] numbersNL = { "nul", "een", "twee", "drie", "vier", "vijf", "zes", "zeven", "acht", "negen" };
        public static string[] numbersDU = { "null", "ein", "zwei", "drei", "vier", "funf", "sechs", "sieben", "acht", "neun" };
        public static string[] numbersFR = { "zéro", "un", "doix", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf" };
        public static string[] numbersES = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
        public static int CrypasoCoded(string input, string lang)
        {
            int inputnr = 0;
            try
            {
                Convert.ToInt32(input);
            }
            catch
            {
                return input.Length;
            }
            int endresult = 0;
            foreach (char c in input)
            {
                inputnr = Convert.ToInt32(c.ToString());
                switch (lang)
                {
                    case "EN":
                        endresult += numbersEN[inputnr].Length;
                        break;
                    case "NL":
                        endresult += numbersNL[inputnr].Length;
                        break;
                    case "DU":
                        endresult += numbersDU[inputnr].Length;
                        break;
                    case "FR":
                        endresult += numbersFR[inputnr].Length;
                        break;
                    case "ES":
                        endresult += numbersES[inputnr].Length;
                        break;
                    default:
                        return inputnr;
                }
            }
            return endresult;
        }
    }
}
