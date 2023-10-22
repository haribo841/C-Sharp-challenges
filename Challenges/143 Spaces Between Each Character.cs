//Create a function that takes a string and returns a string with spaces in between all of the characters.
using System;
using System.Text;

namespace Challenges
{
    public class Program143
    {
        public static string SpaceMeOut(string str)
        {
            StringBuilder result = new();
            foreach (char c in str)
            {
                    result.Append(c);
                    result.Append(' ');
            }
            result.Length--;
            return result.ToString();
        }
    }
}