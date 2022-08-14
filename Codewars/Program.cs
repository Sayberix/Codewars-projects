using System;

namespace Codewars
{
    internal class Program
    {
        // Банкоматы позволяют использовать 4- или 6-значные PIN-коды, а PIN-коды не могут содержать ничего, кроме ровно 4 или ровно 6 цифр.
        // Если функции передана допустимая строка PIN-кода, верните true, иначе верните false.
        private static void Main(string[] args)
        {
            Console.WriteLine(ValidatePin(""));
        }

        public static bool ValidatePin(string pin)
        {
            bool validate = true;
            int length = pin.Length;
            if (length == 4 || length == 6)
            {
                for (int i = 0; i < length; i++)
                {
                    if (!Char.IsDigit(pin[i]))
                    {
                        validate = false;
                        break;
                    }
                }
            }
            else
                validate = false;
            return (validate);
        }
    }
}