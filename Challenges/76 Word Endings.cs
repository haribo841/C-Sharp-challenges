//Create a function that adds a string ending to each member in an array.
using System;
namespace Challenges
{
    public class Program76
    {
        public static string[] AddEnding(string[] arr, string ending)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += ending;
            }
            return arr;
        }
    }
}
