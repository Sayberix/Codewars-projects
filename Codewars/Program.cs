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
            Console.WriteLine($"'{Order("4of Fo1r pe6ople g3ood th5e the2")}'");
        }

        public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words))
                return words;
            int length = words.Length;
            List<wordList> myList = new List<wordList>();
            string word = null;
            
            for (int i = 0; i < length; i++)
            {
                if (!words[i].Equals(' '))
                    word = String.Concat(word, words[i]);
                if (words[i].Equals(' ') || i == length - 1)
                {
                    myList.Add(new wordList { word = word, number = Convert.ToInt32(FindNumber(word)) });
                    word = null;
                }
            }

            // Поиск цифры в слове
            string FindNumber(string wordInFunction)
            {
                for (int i = 0; i < wordInFunction.Length; i++)
                {
                    if (Char.IsDigit(wordInFunction[i]))
                        return (Convert.ToString(wordInFunction[i]));
                }
                return null;
            }

            myList.Sort(delegate (wordList numb1, wordList numb2)
            { return numb1.number.CompareTo(numb2.number); }
                );

            foreach (wordList w in myList)
            {
                if (!(w.number == myList.Count))
                    word = String.Concat(word, w.word, " ");
                else
                    word = String.Concat(word, w.word);
            }
            //Console.WriteLine($"{myList.Count}");
            return word;
        }
    }

    internal class wordList
    {
        public string word { get; set; }
        public int number { get; set; }

        /* public override string ToString()
         {
             return "Number: " + number + "   Name: " + word;
         }*/
    }
}