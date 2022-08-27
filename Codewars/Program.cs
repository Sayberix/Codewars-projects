using System;

namespace Codewars
{
    internal class Program
    {
        // https://www.codewars.com/kata/52685f7382004e774f0001f7/train/csharp
        // Напишите функцию, которая принимает неотрицательное целое число (секунды) в качестве входных данных и возвращает время
        // в удобочитаемом формате(HH:MM:SS)
        // HH= часы, дополненные до 2 цифр, диапазон: 00–99
        // MM= минуты, дополненные до 2 цифр, диапазон: 00–59
        // SS= секунды, дополненные до 2 цифр, диапазон: 00–59
        // Максимальное время никогда не превышает 359999 ( 99:59:59)
        // Assert.AreEqual("00:00:00", TimeFormat.GetReadableTime(0));
        // Assert.AreEqual("00:00:05", TimeFormat.GetReadableTime(5));
        // Assert.AreEqual("00:01:00", TimeFormat.GetReadableTime(60));
        // Assert.AreEqual("23:59:59", TimeFormat.GetReadableTime(86399));
        // Assert.AreEqual("99:59:59", TimeFormat.GetReadableTime(359999));


        private static void Main(string[] args)
        {
            Console.WriteLine($"{GetReadableTime(212)}");
        }

        public static string GetReadableTime(int seconds)
        {


        }

    }
}

