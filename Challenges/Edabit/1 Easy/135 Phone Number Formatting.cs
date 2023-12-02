//Create a function that takes an array of 10 numbers (between 0 and 9) and
//returns a string of those numbers formatted as a phone number (e.g. (555) 555-5555).
using System;
using System.Text;

namespace Challenges
{
    public class Program135
    {
        public static string FormatPhoneNumber(int[] numbers) =>
           $"({numbers[0]}{numbers[1]}{numbers[2]}) " +
           $"{numbers[3]}{numbers[4]}{numbers[5]}-" +
           $"{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
    }
}