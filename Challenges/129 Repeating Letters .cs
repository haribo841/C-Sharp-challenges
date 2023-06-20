//Create a function that takes a string and returns a string in which each character is repeated once.
using System;

namespace Challenges
{
    public class Program129
    {
        public static string DoubleChar(string str)
        {
            char[] chars = new char[str.Length * 2];
            char[] chars2 = str.ToCharArray();
            for (int i = 0; i < chars2.Length; i++)
            {
                chars[i * 2] = chars2[i];
                chars[i * 2 + 1] = chars2[i];
            }
                return new string(chars);
        }
    }
}