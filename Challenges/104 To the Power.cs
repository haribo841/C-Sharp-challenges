//Create a function that takes a base number and an exponent number and returns the calculation.
//using System;
namespace Challenges
{
    public class Program104
    {
        public static long CalculateExponent(long number, long exponent)
        {
            long j = number;
            for (int i = 1; i < exponent; i++)
            {
                j *= number;
            }
            return j;
        }
    }
}