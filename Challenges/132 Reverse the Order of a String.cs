//Create a function that takes a string as its argument and returns the string in reversed order.
using System;

namespace Challenges
{
    public class Program132
    {
        public static string Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            char[] result = new char[str.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                result[i] = chars[chars.Length-i-1];
            }
            return new string(result);
        }
    }
}