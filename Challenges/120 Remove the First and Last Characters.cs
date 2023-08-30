//Create a function that removes the first and last characters from a string.
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Challenges
{
    public class Program120
    {
        public static string RemoveFirstLast(string str)
        {
            return str.Length > 2 ? str.Substring(1, str.Length - 2) : str;
        }
    }
}