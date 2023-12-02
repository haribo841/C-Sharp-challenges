//Create a function that takes an array of numbers. Return the largest number in the array.
using System;
namespace Challenges
{
    public class Program67
    {
        public static int FindLargestNum(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new InvalidOperationException("Array is empty.");
            }

            int largest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            return largest;
        }
    }
}
