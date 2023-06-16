//Create a function that converts a date formatted as MM/DD/YYYY to YYYYDDMM.
using System;

namespace Challenges
{
    public class Program125
    {
        public static string FormatDate(string date)
        {
            string year = date.Substring(6);
            string day = date.Substring(3, 2);
            string month = date[..2];
            return year+day+month;
        }
    }
}