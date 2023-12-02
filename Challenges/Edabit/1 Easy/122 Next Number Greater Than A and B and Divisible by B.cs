//You are given two numbers a and b.
//Create a function that returns the next number greater than a and b and divisible by b.
using System;

namespace Challenges
{
    public class Program122
    {
        public static int DivisibleByB(int a, int b)
        {
            int c = b;
            while (c <= a || c % b != 0)
            {
                c += b;
            }
            return c;
        }
    }
}