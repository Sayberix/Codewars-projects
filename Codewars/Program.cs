using System;

namespace Codewars
{
    internal class Program
    {
        // https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1/train/csharp
        // Учитывая n x n массив, вернуть элементы массива, расположенные от самых внешних элементов до среднего элемента, перемещаясь по часовой стрелке.
        // array =  [[1,2,3],
        //          [4,5,6],
        //          [7,8,9]]
        // snail(array) #=> [1,2,3,6,9,8,7,4,5]

        private static void Main(string[] args)
        {
            //int[,] array =  { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } } ;
            int[][] array =
            {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };
            Snail(array);
        }

        public static int[] Snail(int[][] array)
        {

            int[] resault = new int[array.GetLength(0) * array.GetLength(1)];

            return resault;
        }

        public static void IteratingOverElements(int [][] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {

                }
        }
    }
}