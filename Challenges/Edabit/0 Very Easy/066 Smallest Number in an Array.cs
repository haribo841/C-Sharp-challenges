//Create a function that takes an array of numbers and returns the smallest number in the set.
using System;
namespace Challenges
{
    public class Program66
    {
        public static double FindSmallestNum(double[] arr)
        {
            if (arr.Length == 0)
            {
                throw new InvalidOperationException("Array is empty.");
            }

            double smallest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            return smallest;
        }
    }
}