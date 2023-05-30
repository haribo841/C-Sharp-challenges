//Create a function that takes the month and year (as integers) and returns the number of days in that month.
using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenges
{
    public class Program97
    {
        public static int Days(int month, int year) => DateTime.DaysInMonth(year, month);
    }
}
