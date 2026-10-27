//Create a function that replaces all the vowels in a string with a specified character.
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Challenges
{
    public static class Program152
    {
        public static string ReplaceVowels(string str, string ch)
        {
            string pattern = "[aeiouy]";
            Regex regex = new Regex(pattern, RegexOptions.None, TimeSpan.FromSeconds(1));
            return regex.Replace(str, ch);
        }
    }
}
