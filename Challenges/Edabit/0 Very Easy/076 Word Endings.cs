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
                result[i] = new string(' ', maxLength + ending.Length);
            }

            // Process the strings in parallel
            Parallel.For(0, arr.Length, i =>
            {
                result[i] = arr[i] + ending;
            });

            return result;
        }
    }
}

/* public static string[] AddEndingParallelWithPreallocation(string[] arr, string ending)
    {
        string[] result = new string[arr.Length];
        int maxLength = 0;

        // Find the maximum length of strings in the input array
        foreach (string str in arr)
        {
            if (str.Length > maxLength)
                maxLength = str.Length;
        }

        // Process the strings in parallel and pre-allocate memory for the result strings
        Parallel.For(0, arr.Length, i =>
        {
            result[i] = new string(' ', maxLength + ending.Length);
            result[i] = arr[i] + ending;
        });

        return result;
    }

 {
        string[] result = new string[arr.Length];
        int maxLength = 0;

        // Find the maximum length of strings in the input array
        Parallel.For(0, arr.Length, i =>
        {
            int length = arr[i].Length + ending.Length;
            if (length > maxLength)
            {
                System.Threading.Interlocked.Exchange(ref maxLength, length);
            }
        });

        // Process the strings in parallel and pre-allocate memory for the result strings
        Parallel.For(0, arr.Length, i =>
        {
            result[i] = new string(' ', maxLength);
            result[i] = arr[i] + ending;
        });

        return result;
    } */