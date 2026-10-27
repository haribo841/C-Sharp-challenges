//Create a function that takes an array of numbers between 1 and 10 (excluding one number) and returns the missing number.
using System;

namespace Challenges
{
    public static class Program156
    {
        public static int MissingNum(int[] arr)
        {
            int[] completeSequence = Enumerable.Range(1, 10).ToArray(); // Complete sequence from 1 to 10
            var missingNumbers = completeSequence.Except(arr); // Find the missing number(s)

            return missingNumbers.FirstOrDefault(); // Return the first missing number found
        }
    }
}
