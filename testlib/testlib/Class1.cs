using System;
namespace datelib
{
    public class dateclass
    {
        public static TimeSpan CalculateDateDifference(DateTime date1, DateTime date2)
        {
            return date2 - date1;
        }

        // Функция для определения, является ли год високосным
        public static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        // Функция для нахождения времени суток по заданному времени
        public static string GetTimeOfDay(DateTime time)
        {
            int hour = time.Hour;

            if (hour >= 0 && hour < 6)
                return "Ночь";
            else if (hour >= 6 && hour < 12)
                return "Утро";
            else if (hour >= 12 && hour < 18)
                return "День";
            else
                return "Вечер";
        }

        // Функция для форматирования даты и времени
        public static string FormatDateTime(DateTime dateTime, string format = "yyyy-MM-dd HH:mm:ss")
        {
            return dateTime.ToString(format);
        }
    }
}