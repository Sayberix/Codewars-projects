using System;

namespace Codewars
{
    internal class Program
    {
        // Пузырьковая сортировка


        private static void Main(string[] args)
        {
            int[] array = new int[] { 3, 16, 11, 23, 17, 21, 4, 5, 18, 20, 15, 22, 13, 10, 1, 9, 2, 8, 7, 19, 12, 14, 6 };

            BubbleSortOnce(array);
            /*Console.WriteLine($"[{String.Join(" ", BubbleSortOnce(array))}]");
            Console.WriteLine($"[{String.Join(";", array)}]");*/

        }

        public static void BubbleSortOnce(int[] input)
        {
            int length = input.Length;
            int[] array = new int[length];
            Array.Copy(input, array, length);
            int passes = 0;
            int changes = 0;
            for (int i = 0; i < length; i++)
            {
                passes++;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        changes++;
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.Write(passes + " " + changes);
            //return array;
        }

    }
}