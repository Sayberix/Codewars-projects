using System;

namespace Codewars
{
    internal class Program
    {
        // Напишите функцию, которая принимает строку скобок и определяет, допустим ли порядок скобок.
        // Функция должна возвращать значение true, если строка действительна и false - недействительная.
        // "()"              =>  true
        // ")(()))"          =>  false
        // "("               =>  false
        // "(())((()())())"  =>  true

        private static void Main(string[] args)
        {
            Console.WriteLine(ValidParentheses("(c(b(a)))(d)"));    //   hi(hi))(   ())(()  (c(b(a)))(d)
        }

        public static bool ValidParentheses(string input)
        {
            //Console.WriteLine(${ })
            bool resault = false;
            if (input is not null)
            {
                int countLit = input.Length;
                if (countLit > 0)
                {
                    int leftParentheses = 0, rightParentheses = 0;
                    bool controlFlag = true;
                    for (int i = 0; i < countLit; i++)
                    {
                        if (input[i].Equals('('))
                        {
                            leftParentheses++;
                        }
                        else
                        {
                            if (input[i].Equals(')'))
                            {
                                rightParentheses++;
                                if (rightParentheses > leftParentheses)
                                {
                                    controlFlag = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (controlFlag == true && leftParentheses == rightParentheses && (leftParentheses + rightParentheses > 0))
                        resault = true;
                }
                return resault;
            }
            else
                return resault;
        }
    }
}