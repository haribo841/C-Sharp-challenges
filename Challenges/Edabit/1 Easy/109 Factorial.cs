//Create a function that takes an integer and returns the factorial of that integer.
//That is, the integer multiplied by all positive lower integers.
using System;

namespace Challenges
{
    public class Program109
    {
        public static int Factorial(int num)
        {
            if (num < 0) throw new ArgumentException("Factorial is not defined for negative numbers.");
            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}