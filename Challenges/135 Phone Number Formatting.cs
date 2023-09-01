//Create a function that takes an array of 10 numbers (between 0 and 9) and
//returns a string of those numbers formatted as a phone number (e.g. (555) 555-5555).
using System;
using System.Text;

namespace Challenges
{
    public class Program135
    {
        public static string FormatPhoneNumber(int[] numbers)
        {
            StringBuilder sb = new StringBuilder(13);

            sb.Append("(");
            sb.Append(numbers[0]);
            sb.Append(numbers[1]);
            sb.Append(numbers[2]);
            sb.Append(") ");
            sb.Append(numbers[3]);
            sb.Append(numbers[4]);
            sb.Append(numbers[5]);
            sb.Append("-");
            sb.Append(numbers[6]);
            sb.Append(numbers[7]);
            sb.Append(numbers[8]);
            sb.Append(numbers[9]);

            return sb.ToString();
        }
    }
}