//Create a function that removes the first and last characters from a string.
using System;

namespace Challenges
{
    public class Program120
    {
        public static string RemoveFirstLast(string str)
        {
            char[] chars = new char[str.Length];
            for (int i = 1; i < chars.Length-1; i++)
            {
                chars[i] = str[i];
            }
            string s = new string(chars);
            return s;
        }
    }
}