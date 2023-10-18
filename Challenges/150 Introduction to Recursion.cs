//The recursive function for this challenge should return the factorial of an inputted integer.
using System;

namespace Challenges
{
    public class Program150
    {
        public static int factorial(int num) => num > 1 ? num * factorial(--num) : +1;
    }
}