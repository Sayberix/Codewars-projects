using System;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определение нарцистического числа
            int n = 465;    // Исходное значение, для которого будем искать нарцистическое число
            int nn = n;

            int degree = 0;

            while (n != 0)
            {
                n /= 10;
                degree++;
            }

            double sumNarc = 0;
            for (int i = 0; i < degree; i++)
            {
                sumNarc += Math.Pow(nn % 10, degree);
                nn /= 10;
            }
            Console.WriteLine(sumNarc);
        }
    }
}
