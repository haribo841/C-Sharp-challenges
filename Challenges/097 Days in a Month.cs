//Create a function that takes the month and year (as integers) and returns the number of days in that month.
using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenges
{
    public class Program97
    {
        public static int Days(int month, int year)
        {
            int i = year % 4 == 0 && year!=1800 && month == 2 ? 29 : 28;
            if (month is 1 or 3 or 5 or 7 or 8 or 10 or 12) { i = 31; }
            else if (month is 4 or 6 or 9 or 11) { i = 30; }
            return i;
        }
    }
}
