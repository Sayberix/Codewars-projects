using System;

namespace Codewars
{
    internal class Program
    {
        // https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp
        // Напишите алгоритм, который берет массив и перемещает все нули в конец, сохраняя порядок остальных элементов.

        private static void Main(string[] args)
        {
            MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
        }

        public static int[] MoveZeroes(int[] arr)
        {
            Console.WriteLine($"[{String.Join("; ", arr)}]");
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    count++;
                }
                else
                {
                    if (count != 0)
                    {
                        arr[i - count] = arr[i];
                        for(int j = i - (count - 1); j == i - count; j++)
                            arr[j] = 0;
                        count = 0;
                        Console.WriteLine($"[{String.Join("; ", arr)}]");
                    }
                }
            }

            Console.WriteLine($"[{String.Join("; ", arr)}]");
            return arr;
        }
    }
}