//Create a function that takes a string and returns a string in which each character is repeated once.
using System;
using System.Text;

namespace Challenges
{
    public class Program129
    {
        public static string DoubleChar(string str)
        {
            StringBuilder result = new();
            foreach (char c in str)
            {
                result.Append(c);
                result.Append(c);
            }
            return result.ToString();
        }
    }
}