//Create a function that takes a number as an argument and returns the amount of digits it has.
using System;
namespace Challenges
{
    public class Program77
    {
        public static int FindDigitAmount(int num) => num == 0 ? 1 : (int)Math.Floor(Math.Log10(Math.Abs(num)) + 1);
    }
}
