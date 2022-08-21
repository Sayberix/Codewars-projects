using System;

namespace Codewars
{
    internal class Program
    {
        // Пузырьковая сортировка


        private static void Main(string[] args)
        {
            int[] array = new int[] { 3, 1, 4, 1, 5, 9, 2, 6 };

            BubbleSortOnce(array);
            /*Console.WriteLine($"[{String.Join(" ", BubbleSortOnce(array))}]");
            Console.WriteLine($"[{String.Join(";", array)}]");*/

        }

        public static int[] BubbleSortOnce(int[] input)
        {
            int length = input.Length;
            int[] array = new int[length];
            Array.Copy(input, array, length);
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if(array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

    }
}