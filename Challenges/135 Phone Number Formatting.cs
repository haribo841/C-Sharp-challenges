//Create a function that takes an array of 10 numbers (between 0 and 9) and
//returns a string of those numbers formatted as a phone number (e.g. (555) 555-5555).
using System;

namespace Challenges
{
    public class Program135
    {
        public static string FormatPhoneNumber(int[] numbers) => "(" + numbers[0].ToString() + numbers[1].ToString() + numbers[2].ToString() + ") " + numbers[3].ToString() + numbers[4].ToString() + numbers[5].ToString() + "-" + numbers[6].ToString() + numbers[7].ToString() + numbers[8].ToString() + numbers[9].ToString();
    }
}