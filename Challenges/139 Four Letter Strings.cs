//Create a function that takes an array of strings and returns the words that are exactly four letters.
using System;

namespace Challenges
{
    public class Program139
    {
        public static string[] IsFourLetters(string[] arr)
        {
            string[] result = Array.Empty<string>(); // Initialize an empty array to store results

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 4)
                {
                    Array.Resize(ref result, result.Length + 1); // Resize the result array
                    result[^1] = arr[i]; // Add the four-letter word to the result array
                }
            }
            return result;
        }
    }
}