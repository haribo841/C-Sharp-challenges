//Create a function that takes a string and returns a new string with all vowels removed.
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Challenges
{
    public class Program160
    {
        public static string RemoveVowels(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (!IsVowel(str[i]))
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
        }
    }
}