//Create a function that adds a string ending to each member in an array.
using System;
using System.Linq;
namespace Challenges
{
    public class Program76
    {
        public static string[] AddEnding(string[] arr, string ending) => Array.ConvertAll(arr, item => item + ending);
    }
}