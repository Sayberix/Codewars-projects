using System;

namespace Codewars
{
    internal class Program
    {
        // Банкоматы позволяют использовать 4- или 6-значные PIN-коды, а PIN-коды не могут содержать ничего, кроме ровно 4 или ровно 6 цифр.
        // Если функции передана допустимая строка PIN-кода, верните true, иначе верните false.
        private static void Main(string[] args)
        {
            Console.WriteLine(ValidatePin("-123"));
        }

        public static bool ValidatePin(string pin)
        {
            bool validate = false, check = true;
            int length = pin.Length, intPin = 0;
            if (length == 4 || length == 6)
            {
                if (int.TryParse(pin, out intPin))
                {
                    for (int i = 0; i < length; i++)
                    {
                        int n = Convert.ToInt32(pin[i]);
                        if (n >= 0 || n <= 9 || ! "-".Equals(pin[i]) || ! " ".Equals(pin[i]))
                        {
                        }
                        else
                        {
                            Console.WriteLine(n);
                            check = false;
                            break;
                        }
                    }
                }
                else
                    check = false;
                if (check)
                    validate = true;
            }
            return (validate);
        }
    }
}