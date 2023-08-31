//Create a function that takes an array of numbers and returns only the even values.
using System;

namespace Challenges
{
    public class Program133
    {
        public static int[] NoOdds(int[] arr)
        {
            int evenCount = 0;
            // Count the number of even values
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) evenCount++;
            }
            // Create a new array for even values
            int[] evenValues = new int[evenCount];
            int index = 0;
            // Populate the new array with even values
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenValues[index] = arr[i];
                    index++;
                }
            }
            return evenValues;
        }
    }
}