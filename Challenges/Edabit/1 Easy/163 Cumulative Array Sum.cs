//Create a function that takes an array of numbers and returns an array where each number is the sum of itself + all previous numbers in the array.
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Challenges
{
    public static class Program163
    {
        public static double[] CumulativeSum(double[] arr)
        {
            if (arr.Length == 0)
            {
                return new double[0];
            }

            double[] cumulative = new double[arr.Length];
            cumulative[0] = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                cumulative[i] = cumulative[i - 1] + arr[i];
            }

            return cumulative;
        }
    }
}
