//Create a function that takes an array of numbers and returns a new array, sorted in ascending order (smallest to biggest).
//Sort the numbers array in ascending order.
//If the function's argument is null, an empty array, or undefined; return an empty array.
//Return a new array of sorted numbers.
using System;
using System.Globalization;
namespace Challenges
{
    public class Program111
    {
        public static int[] SortNumsAscending(int[] arr)
        {
            int[] a = new int[arr.Length];
            a = arr.OrderByDescending(x => x).ToArray();
            Array.Reverse(a);
            return a;
        }
    }
}