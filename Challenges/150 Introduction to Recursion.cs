//The recursive function for this challenge should return the factorial of an inputted integer.
using System;

namespace Challenges
{
    public class Program150
    {
        public static int Factorial(int num) => num > 1 ? num * Factorial(--num) : +1;
    }
}
/*
 * {
    if (num < 0)
    {
        throw new ArgumentException("Factorial is not defined for negative numbers.");
    }

    int result = 1;
    for (int i = 2; i <= num; i++)
    {
        result *= i;
    }
    return result;
}*/