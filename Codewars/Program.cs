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
            Console.WriteLine($"{GetReadableTime(1750)}");
        }

        public static string GetReadableTime(int seconds)
        {
            string[] array = new string[3] { "00", "00", "00" };
            
            array[0] = Convert.ToString(seconds / 60 / 60);
            array[1] = Convert.ToString(seconds / 60 % 60);
            array[2] = Convert.ToString(seconds % 60 % 60 % 60);
            for (int i = 0; i < 3; i++)
            {
                if (array[i].Length == 1)
                {
                    array[i] = string.Concat("0", array[i]);
                }
            }
            return string.Concat("", array[0], ":", array[1], ":", array[2], "");
        }
    }
}

/*
public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
    }
}

using System;

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        var t = TimeSpan.FromSeconds(seconds);
        return string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
    }
}

using System;
public static class TimeFormat
{
    public static string GetReadableTime(int s) => String.Format("{0:D2}:{1:D2}:{2:D2}", s / 3600, s / 60 % 60, s % 60);
}

using System;

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
      int sec = (seconds % 60);
      int min = ((seconds-sec)/60)%60;
      int hour = (seconds-sec-(60*min))/(60*60);

      return (hour.ToString("00")+":"+min.ToString("00")+":"+sec.ToString("00"));
    }
}
*/