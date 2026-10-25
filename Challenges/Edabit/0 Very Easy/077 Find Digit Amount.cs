//Create a function that takes a number as an argument and returns the amount of digits it has.
using System;
namespace Challenges
{
    public class Program77
    {
        public static int FindDigitAmount(int num)
        {
            int digits = 0;
            do
            {
                digits++;
                num /= 10;
            }
            while (num != 0);

            return digits;
        }
    }
}
