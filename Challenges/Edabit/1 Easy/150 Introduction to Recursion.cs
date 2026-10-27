//The recursive function for this challenge should return the factorial of an inputted integer.
using System;

namespace Challenges
{
    public static class Program150
    {
        public static int Factorial(int num) => num > 1 ? num * Factorial(num - 1) : 1;
    }
}
