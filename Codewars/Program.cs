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
            Console.WriteLine($"{Rgb(212, 53, 16)}");
        }

        public static string Rgb(int r, int g, int b)
        {
            Console.WriteLine(Convert.ToString(r) + " " + Convert.ToString(g) + " " + Convert.ToString(b));
            int[] array = new int[3] { r, g, b };
            string[] resaultArray = new string[3] { "00", "00", "00" };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 15 && array[i] < 256)
                {
                    resaultArray[i] = array[i].ToString("X");
                }
                else
                {
                    if (array[i] > 0 && array[i] < 16)
                    {
                        resaultArray[i] = string.Concat("0",array[i].ToString("X"));
                    }
                    else
                    {
                        if (array[i] > 255)
                        {
                            resaultArray[i] = "FF";
                        }
                    }
                }
            }
            return string.Join("", resaultArray);
        }
    }
}

/*
 using System;

public class Kata
{
  public static string Rgb(int r, int g, int b) 
  {
      r = Math.Max(Math.Min(255, r), 0);
      g = Math.Max(Math.Min(255, g), 0);
      b = Math.Max(Math.Min(255, b), 0);
      return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
  }
}

using System;

public class Kata
{
        public static string Rgb(int r, int g, int b)
        {
            return limitValue(r) + limitValue(g) + limitValue(b);
        }

        public static string limitValue(int n)
        {
            if (n < 0) n = 0;
            if (n > 255) n = 255;
            return n.ToString("X2");
        }
}
 
 
 
 
 */