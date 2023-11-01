//Create a function that takes a two-digit number and determines if it's the largest of two possible digit swaps.
using System;

namespace Challenges
{
    public class Program157
    {
        public static bool LargestSwap(int num)
        {
            string a= num.ToString();
            if (a[0] == a[1]) return true;
            else if (a[0] < a[1]) return false;
            return true;
        }
    }
}