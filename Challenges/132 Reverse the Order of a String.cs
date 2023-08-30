//Create a function that takes a string as its argument and returns the string in reversed order.
using System;
using System.Text;

namespace Challenges
{
    public class Program132
    {
        public static string Reverse(string str)
        {
            StringBuilder reversed = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }
            return reversed.ToString();
        }
    }
}