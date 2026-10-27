//Create a function that takes three integer arguments (a, b, c) and returns the amount of integers which are of equal value.
using System;

namespace Challenges
{
    public static class Program154
    {
        public static int Equal(int a, int b, int c)
        {
            var arr = new int[] { a, b, c };
            int distinctCount = arr.Distinct().Count();

            if (distinctCount == arr.Length)
                return 0;
            else
                return arr.Length - (distinctCount - 1);
        }
    }
}
