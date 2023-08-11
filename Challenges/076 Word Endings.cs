//Create a function that adds a string ending to each member in an array.
using System;
using System.Collections.Concurrent;
using System.Linq;
namespace Challenges
{
    public class Program76
    {
        public static string[] AddEnding(string[] arr, string ending)
        {
            string[] result = new string[arr.Length];
            int maxLength = 0;

            // Find the maximum length of strings in the input array
            foreach (string str in arr)
            {
                if (str.Length > maxLength)
                    maxLength = str.Length;
            }

            // Pre-allocate memory for the result strings
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = new string(' ', arr[i].Length + ending.Length);
            }

            // Append the ending to each string
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i] + ending;
            }

            return result;
        }
    }
}