//Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string.
//For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.
using System;
using System.Globalization;

namespace Challenges
{
    public class Program101
    {
        public static string MonthName(int num) => num >= 1 && num <= 12 ? CultureInfo.InvariantCulture.DateTimeFormat.GetMonthName(num) : "none";
    }
}