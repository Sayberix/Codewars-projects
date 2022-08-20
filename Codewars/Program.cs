using System;

namespace Codewars
{
    internal class Program
    {
        // Если мы перечислим все натуральные числа до 10, кратные 3 или 5, мы получим 3, 5, 6 и 9. Сумма этих кратных равна 23.
        // Завершите решение так, чтобы оно возвращало сумму всех чисел, кратных 3 или 5, меньше переданного числа.
        // Кроме того, если число отрицательное, верните 0 (для языков, в которых они есть).
        // Примечание. Если число кратно и 3 и 5, считайте его только один раз.

        private static void Main(string[] args)
        {
            Console.WriteLine(Solution(10));
        }

        public static int Solution(int value)
        {
            if (value < 0) return (0);
            else
            {
                int sum = 0;
                for (int i = 3; i < value; i += 3)
                {
                    sum += i;
                }
                for (int j = 5; j < value; j += 5)
                {
                    sum += j;
                }
                // другой вариант
                /*
                for (int i = 1; i < value; i++)
                {
                    if(i % 3 == 0 || i % 5 == 0)
                        sum += i;
                }*/
                return sum;
            }
        }
    }
}