//Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.
using System;

namespace Challenges
{
    public class Program9
    {
        public static bool LessThan100(int a, int b) => a + b < 100;
    }
}
/*
        public bool lessThan100(int a, int b) => a + b < 100;

        public bool Body(int a, int b)
        {
            return a + b < 100;
        }

        public bool lessThan100GE(int a, int b) => a + b >= 100;

        public bool BodyGE(int a, int b)
        {
            return a + b >= 100;
        }
*/