using System;
using System.Collections.Generic;

namespace Codewars
{
    internal class Program
    {
        // https://www.codewars.com/kata/55c45be3b2079eccff00010f/csharp
        // Ваша задача — отсортировать заданную строку. Каждое слово в строке будет содержать одно число.
        // Это число и есть позиция, которую должно занимать слово в результате.
        // Примечание. Цифры могут быть от 1 до 9. Таким образом, первым словом будет 1 (а не 0).
        // Если входная строка пуста, вернуть пустую строку. Слова во входной строке будут содержать только допустимые последовательные числа.
        // "is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
        // "4of Fo1r pe6ople g3ood th5e the2"  -->  "Fo1r the2 g3ood 4of th5e pe6ople"
        // ""  -->  ""

        private static void Main(string[] args)
        {
            Order("is2 Thi1s T4est 3a");
        }

        public static void Order(string words)
        {
            if (words is null)
                throw new NotImplementedException(null);
            else
            {
                int length = words.Length;
                List<wordList> myList = new List<wordList>();
                string word = null;
                for (int i = 0; i < length; i++)
                {
                    word = String.Concat(word, words[i]);
                    Console.WriteLine(word + ", " + words[i]);
                    if (words[i].Equals(' '))
                    {
                        myList.Add(new wordList { word = word, number = FindNumber(word) });
                        word = null;
                    }
                }

                string FindNumber(string wordInFunction)
                {
                    for (int i = 0; i < wordInFunction.Length; i++)
                    {
                        if (Char.IsDigit(wordInFunction[i]))
                            return (Convert.ToString(wordInFunction[i]));
                    }
                    return null;
                }
                Console.WriteLine("\nCapacity: {0}", myList.Capacity);
                Console.WriteLine(myList[0].word + " " + myList[0].number);
                Console.WriteLine(myList[1].word + " " + myList[1].number);
                Console.WriteLine(myList[2].word + " " + myList[2].number);

                //throw new NotImplementedException("mama");
            }
        }
    }

    internal class wordList
    {
        public string word { get; set; }
        public string number { get; set; }
    }
}