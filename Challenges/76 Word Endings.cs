//Create a function that adds a string ending to each member in an array.
using System;
namespace Challenges
{
    public class Program76
    {
        public static string[] AddEnding(string[] arr, string ending) => arr.ForEach(num => Console.WriteLine(num + "" + ending));
        public static string AddEnding(string[] arr) => throw new NotImplementedException();
    }
}
