using System;

namespace Codewars
{
    internal class Program
    {
        // Вам дадут слово. Ваша задача — вернуть средний символ слова. Если длина слова нечетная, вернуть средний символ.
        // Если длина слова четная, верните средние 2 символа.
        // Примеры:
        // Kata.getMiddle("test") should return "es"
        // Kata.getMiddle("testing") should return "t"

        private static void Main(string[] args)
        {
            /*
            if (5 % 2 == 1)
                Console.WriteLine("Верно");
            else
                Console.WriteLine("не Верно");*/
            Console.WriteLine(GetMiddle("Лена"));
        }
        
        public static string GetMiddle(string s)
        {
            double length = s.Length;
            int pos = (int)Math.Ceiling(length / 2) - 1;
            if (length % 2 == 0)
            {
                return (string.Concat(Convert.ToString(s[pos]), Convert.ToString(s[pos + 1])));
            }
            else
            {
                return Convert.ToString(s[pos]);
            }
        }
    }
}