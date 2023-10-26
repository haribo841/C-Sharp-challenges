//Create a function that takes three integer arguments (a, b, c) and returns the amount of integers which are of equal value.
using System;

namespace Challenges
{
    public class Program154
    {
        public static int Equal(int a, int b, int c)
        {
            if (a == b && b == c) return 3;
            if (a == b || b == c || a == c) return 2;
            return 0;
        }
    }
}