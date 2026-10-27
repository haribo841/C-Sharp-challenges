//Create a function that takes a two-digit number and determines if it's the largest of two possible digit swaps.
using System;

namespace Challenges
{
    public static class Program157
    {
        public static bool LargestSwap(int num)
        {
            int reverse = 0;
            int originalNum = num;

            while (num != 0)
            {
                int rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }

            return originalNum >= reverse;
        }
    }
}
