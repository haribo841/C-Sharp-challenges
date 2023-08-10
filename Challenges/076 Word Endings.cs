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
            Parallel.ForEach(Partitioner.Create(0, arr.Length), range =>
            {
                for (int i = range.Item1; i < range.Item2; i++)
                {
                    result[i] = arr[i] + ending;
                }
            });
            return result;
        }
    }
}