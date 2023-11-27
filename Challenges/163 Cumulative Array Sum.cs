//Create a function that takes an array of numbers and returns an array where each number is the sum of itself + all previous numbers in the array.
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Challenges
{
    public class Program163
    {
        public static double[] CumulativeSum(double[] arr)
        {
            if (arr.Length == 0 ) return arr;
            for (int i = 1; i <= arr.Length - 1; i++) {
                arr[i] += arr[--i];
            }
            return arr;
        }
    }
}