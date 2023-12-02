//Create a function that takes an array of numbers between 1 and 10 (excluding one number) and returns the missing number.
using System;

namespace Challenges
{
    public class Program156
    {
        public static int MissingNum(int[] arr)
        {
            int[] completeSequence = Enumerable.Range(1, 10).ToArray(); // Complete sequence from 1 to 10
            var missingNumbers = completeSequence.Except(arr); // Find the missing number(s)

            return missingNumbers.FirstOrDefault(); // Return the first missing number found
        }
    }
}

/*
 *         {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr.Contains(i)) continue;
            return i;
        }
        return 10;
    }
*
*        {
            Array.Sort(arr); // Sort the array in ascending order

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    return i + 1; // If the number at index i is not i+1, i+1 is the missing number
                }
            }

            return arr.Length + 1; // If no missing number found, return the next number in the sequence
        }
*
    {
        int n = arr.Length + 1; // One number is missing, so the length is one less than the complete sequence
        int totalSum = n * (n + 1) / 2; // Sum of the complete sequence from 1 to n

        int arrSum = 0;
        foreach (int num in arr)
        {
            arrSum += num; // Sum of the elements in the given array
        }

        return totalSum - arrSum; // Finding the missing number
    }
 */