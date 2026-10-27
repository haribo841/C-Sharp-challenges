//Create a function that removes the first and last characters from a string.
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Challenges
{
    public static class Program120
    {
        public static string RemoveFirstLast(string str) => str.Length > 2 ? str[1..^1] : str;
    }
}
