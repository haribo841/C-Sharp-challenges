//Create a function that takes an array and returns the difference between the biggest and smallest numbers.
using System;
namespace Challenges
{
    public class Program71
    {
        public static int DifferenceMaxMin(int[] arr)
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
