using System;

namespace Codewars
{
    internal class Program
    {
        // https://www.codewars.com/kata/54b724efac3d5402db00065e/train/csharp
        // Вы должны написать простой декодер азбуки Морзе.

        private static void Main(string[] args)
        {
            //Console.Write(MorseCodeDecode(".... . -.--   .--- ..- -.. ."));
            Console.Write(MorseCodeDecode(" . "));     //
        }

        public static string MorseCodeDecode(string cod)
        {
            int countSpaceBefore = 0, countSpaceAfter = 0;
            for (int i = 0; i < cod.Length; i++)
            {
                if (cod[i].Equals(' '))
                    countSpaceBefore++;
                else
                    break;
            }
            for (int i = cod.Length-1; i >= 0; i--)
            {
                if (cod[i].Equals(' '))
                    countSpaceAfter++;
                else
                    break;
            }
            string resault = "", letter = "";
            for (int i = countSpaceBefore; i < cod.Length - countSpaceAfter; i++)
            {
                if (cod[i].Equals(' '))
                {
                    if (letter != "")
                    {
                        resault = String.Concat(resault, MorseCodeLetter(Convert.ToString(letter)));
                        letter = "";
                    }
                    else
                    {
                        resault = String.Concat(resault, " ");
                        i += 1;
                    }
                }
                else
                {
                    if (cod[i].Equals('.') || cod[i].Equals('-'))
                    {
                        letter = String.Concat(letter, cod[i]);
                    }
                }
            }
            resault = String.Concat(resault, MorseCodeLetter(Convert.ToString(letter)));
            return resault;
        }

        public static string MorseCodeLetter(string cod)
        {
            string resault;
            switch (cod)
            {
                case "-.-.--": resault = "!"; break;
                case ".-..-.": resault = "\""; break;
                case "...-..-": resault = "$"; break;
                case ".-...": resault = "&"; break;
                case ".----.": resault = "\'"; break;
                case "-.--.": resault = "("; break;
                case "-.--.-": resault = ")"; break;
                case ".-.-.": resault = "+"; break;
                case "--..--": resault = ";"; break;
                case "-....-": resault = "-"; break;
                case ".-.-.-": resault = "."; break;
                case "-..-.": resault = "/"; break;
                case "-----": resault = "0"; break;
                case ".----": resault = "1"; break;
                case "..---": resault = "2"; break;
                case "...--": resault = "3"; break;
                case "....-": resault = "4"; break;
                case ".....": resault = "5"; break;
                case "-....": resault = "6"; break;
                case "--...": resault = "7"; break;
                case "---..": resault = "8"; break;
                case "----.": resault = "9"; break;
                case "---...": resault = ":"; break;
                case "-.-.-.": resault = ";"; break;
                case "-...-": resault = "="; break;
                case "..--..": resault = "?"; break;
                case ".--.-.": resault = "@"; break;
                case ".-": resault = "A"; break;
                case "-...": resault = "B"; break;
                case "-.-.": resault = "C"; break;
                case "-..": resault = "D"; break;
                case ".": resault = "E"; break;
                case "..-.": resault = "F"; break;
                case "--.": resault = "G"; break;
                case "....": resault = "H"; break;
                case "..": resault = "I"; break;
                case ".---": resault = "J"; break;
                case "-.-": resault = "K"; break;
                case ".-..": resault = "L"; break;
                case "--": resault = "M"; break;
                case "-.": resault = "N"; break;
                case "---": resault = "O"; break;
                case ".--.": resault = "P"; break;
                case "--.-": resault = "Q"; break;
                case ".-.": resault = "R"; break;
                case "...": resault = "S"; break;
                case "-": resault = "T"; break;
                case "..-": resault = "U"; break;
                case "...-": resault = "V"; break;
                case ".--": resault = "W"; break;
                case "-..-": resault = "X"; break;
                case "-.--": resault = "Y"; break;
                case "--..": resault = "Z"; break;
                case "..--.-": resault = "_"; break;
                case "...---...": resault = "SOS"; break;
                default:
                    resault = "-1"; break;
            }
            return resault;
        }
    }
}