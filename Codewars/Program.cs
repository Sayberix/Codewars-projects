using System;

namespace Codewars
{
    internal class Program
    {
        // https://www.codewars.com/kata/513e08acc600c94f01000001/train/csharp
        // Функция rgb неполная. Завершите его, чтобы передача десятичных значений RGB приводила к возврату шестнадцатеричного представления. Допустимые десятичные значения для RGB: 0–255. Любые значения, выпадающие из этого диапазона, должны быть округлены до ближайшего допустимого значения.
        // Примечание.Ваш ответ всегда должен состоять из 6 символов, сокращение с 3 здесь не сработает.
        // Ниже приведены примеры ожидаемых выходных значений:
        // Rgb(255, 255, 255) # returns FFFFFF
        // Rgb(255, 255, 300) # returns FFFFFF
        // Rgb(0,0,0) # returns 000000
        // Rgb(148, 0, 211) # returns 9400D3

        private static void Main(string[] args)
        {
            Console.WriteLine($"{Rgb(148, 0, 211)}");
        }

        public static string Rgb(int r, int g, int b)
        {
            string HEX = string.Concat(r.ToString("X"), g.ToString("X"), b.ToString("X"));
            return HEX;
        }
    }
}