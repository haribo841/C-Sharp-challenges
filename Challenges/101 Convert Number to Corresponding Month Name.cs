//Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string.
//For example, if you're given 3 as input, your function should return "March", because March is the 3rd month.
using System;

namespace Challenges
{
    public class Program101
    {
        public static string MonthName(int num) => num switch
        {
            int n when n == 1 => "January",
            int n when n == 2 => "February",
            int n when n == 3 => "March",
            int n when n == 4 => "April",
            int n when n == 5 => "May",
            int n when n == 6 => "June",
            int n when n == 7 => "July",
            int n when n == 8 => "August",
            int n when n == 9 => "September",
            int n when n == 10 => "October",
            int n when n == 11 => "November",
            int n when n == 12 => "December",
            _ => "none"
        };
    }
}