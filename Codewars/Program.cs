using System;

namespace Codewars
{
    internal class Program
    {
        // https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1/train/csharp
        // Учитывая m x n массив, вернуть элементы массива, расположенные от самых внешних элементов до среднего элемента, перемещаясь по часовой стрелке.
        // array =  [[1,2,3],
        //           [4,5,6],
        //           [7,8,9]]
        // snail(array) #=> [1,2,3,6,9,8,7,4,5]

        private static void Main(string[] args)
        {
            int[][] array = new int [][]
            {
                new int[] { 1, 2, 3},
                new int[] { 4, 5, 6},
                new int[] { 7, 8, 9}
            };

            Snail(array);
        }

        public static int[] Snail(int[][] array)
        {
            bool reverseIterating = true;
            int[] resault = new int[array.Length * array[0].Length];
            IteratingOverElements(array, reverseIterating);

            return resault;
        }

        public static void IteratingOverElements(int[][] array, bool reverse)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");

                }
                break;
            }
            //Console.Write($"[{String.Join(" ", array[3][3])}]");
        }
    }
}