//Create a function that takes 3 numbers: a, b, c and returns true if the last digit of a * b = the last digit of c.
using System;

namespace Challenges
{
    public class Program146
    {
        public static bool LastDig(int a, int b, int c) => a % 10 * b % 10 % 10 == c % 10;
    }
}