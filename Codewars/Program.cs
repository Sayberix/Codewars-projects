using System;

namespace Codewars
{
    internal class Program
    {
        // https://www.codewars.com/kata/54b724efac3d5402db00065e/train/csharp
        // Вы должны написать простой декодер азбуки Морзе.

        private static void Main(string[] args)
        {
            Console.Write(MorseCodeDecode(".... . -.--   .--- ..- -.. ."));
        }

        /*
        public static string Decode(string morseCode)
        {
            Console.WriteLine(morseCode);
                int length = morseCode.Length;
                int [] array = new int [length];
                for(int i = 0; i < length; i++)
                  {
                    array[i] = System.Convert.ToInt32(morseCode[i]);
                  }
            byte[] buffer = Encoding.ASCII.GetBytes(morseCode);
            buffer = Encoding.Convert(Encoding.ASCII, Encoding.Default, buffer);
            string result = Encoding.Default.GetString(buffer);
            //Console.WriteLine();

            byte[] bytes2 = BitConverter.GetBytes(i);
            string s2 = Encoding.ASCII.GetString(bytes);
            //string word = char.ConvertFromUtf32(array);
            //Console.WriteLine(word);
            return MorseCode.Get(result);
        }*/

        public static string MorseCodeDecode(string cod)
        {
            string resault = "", letter = "";
            for (int i = 0; i < cod.Length; i++)
            {
                if (cod[i].Equals(' '))
                {
                    resault = String.Concat(resault, MorseCodeLetter(Convert.ToString(letter)));
                    letter = "";
                }
                else
                if (cod[i].Equals('.') || cod[i].Equals('-'))
                    letter = String.Concat(letter, cod[i]);
                else
                if (cod[i].Equals("   "))
                    resault = String.Concat(resault, " ");
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