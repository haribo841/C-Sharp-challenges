//Given an array of integers, return the difference between the largest and smallest integers in the array.
using System;
using System.Linq;
namespace Challenges
{
    public class Program54
    {
        public static int Diff(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Input array is empty or null.");
            }

            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max - min;
        }
    }
}