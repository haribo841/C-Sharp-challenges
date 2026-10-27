//Create a function that adds a string ending to each member in an array.
using System;
using System.Collections.Concurrent;
using System.Linq;
namespace Challenges
{
    public static class Program76
    {
        public static string[] AddEnding(string[] arr, string ending)
        {
            return arr.Select(word => word + ending).ToArray();
        }
    }
}
