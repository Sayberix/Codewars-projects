using System;

namespace Codewars
{
    internal class Program
    {
        // Задача подсчета к-ва пролетов мяча. Подробные условия задачи: https://www.codewars.com/kata/5544c7a5cb454edb3c000047/train/csharp

        private static void Main(string[] args)
        {
            Console.Write($"мяч пролетит мимо мамы {bouncingBall(3, 0.66, 1.5)} раз");
        }

        public static int bouncingBall(double h, double bounce, double window)
        {
            int resault = 0;
            // Условия выполнения корректности входных параметров
            if (h > 0 && (bounce > 0 && bounce < 1) && window < h)
            {
                // Счетчик пролетов мяча вверх и вниз
                int count = 1;
                while(h > window)
                {
                    h *= bounce;
                    if (h > window)
                        count += 2;
                }
                resault = count;
            }
            else
                return -1;
            return resault;
        }
    }
}