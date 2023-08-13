//Create a function that takes a base number and an exponent number and returns the calculation.
using System;
namespace Challenges
{
    public class Program104
    {
        public static long CalculateExponent(long number, long exponent)
        {
            if (exponent < 0)
                throw new ArgumentException("Exponent must be non-negative.");
            if (exponent == 0)
                return 1;
            long result = 1;
            while (exponent > 0)
            {
                if ((exponent & 1) == 1) // Check if exponent is odd
                    result *= number;

                number *= number;
                exponent >>= 1; // Divide exponent by 2
            }
            return result;
        }
    }
}
/*
{
    if (exponent < 0)
        throw new ArgumentException("Exponent must be non-negative.");
    if (exponent == 0)
        return 1;
    if (exponent == 1)
        return number;

    long halfPower = CalculateExponent(number, exponent / 2);
    long result = halfPower * halfPower;

    if (exponent % 2 == 1)
        result *= number;

    return result;
}
*/