//Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.
using System;
namespace Challenges
{
    public class Program103
    {
        public static int GetAbsSum(int[] arr)
        {
            int y = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                y += Program49.Absolute(arr[i]);
            }
            return y;
        }
    }
}