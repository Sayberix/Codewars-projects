using System;

namespace Codewars
{
    internal class Program
    {
        // https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp
        // Напишите алгоритм, который берет массив и перемещает все нули в конец, сохраняя порядок остальных элементов.

        private static void Main(string[] args)
        {
            MoveZeroes(new int[] { 1, 2, 0, 0, 1, 0, 1, 0, 3, 0, 1 });
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
                        for(int j = i - count + 1; j <= i; j++)
                            arr[j] = 0;
                        count = 0;
                        i =- count;
                    }
                }
            }

            Console.WriteLine($"[{String.Join("; ", arr)}]");
            return arr;
        }
    }
}

/*
 
using System.Linq;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
     return arr.OrderBy(x => x==0).ToArray();
  }
}

using System.Linq;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    return arr.Where(x=>x!=0).Concat(arr.Where(x=>x==0)).ToArray();
  }
}


public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    // This solution makes use of C#'s behaviour with unassigned ints in arrays: They are 0 by default.
    // So we basically only have to create a new array with the same size, and write non-zero values
    // in their usual order. Simple.
    int[] zeroesAtEnd = new int[arr.Length];
    int currIndex = -1;
    foreach (int num in arr)
    {
      if (num != 0)
      {
        currIndex++;
        zeroesAtEnd[currIndex] = num;
      }
    }
    return zeroesAtEnd;
  }
}
*/