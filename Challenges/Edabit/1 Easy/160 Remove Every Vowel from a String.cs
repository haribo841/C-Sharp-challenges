//Create a function that takes a string and returns a new string with all vowels removed.
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Challenges
{
    public static class Program160
    {
        public static string RemoveVowels(string str)
        {
            var result = new StringBuilder();
            foreach (char c in str.Where(character => !"aeiouAEIOU".Contains(character)))
            {
                result.Append(c);
            }
            return result.ToString();
        }
    }
}
