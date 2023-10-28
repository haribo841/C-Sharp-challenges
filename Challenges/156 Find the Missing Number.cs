//Create a function that takes an array of numbers between 1 and 10 (excluding one number) and returns the missing number.
using System;

namespace Challenges
{
    public class Program156
    {
        public static int MissingNum(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr.Contains(i)) continue;
                return i;
            }
            return 10;
        }
    }
}