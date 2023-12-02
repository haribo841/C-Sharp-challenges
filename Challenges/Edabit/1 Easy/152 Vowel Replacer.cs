//Create a function that replaces all the vowels in a string with a specified character.
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Challenges
{
    public class Program152
    {
        public static string ReplaceVowels(string str, string ch)
        {
            string pattern = "[aeiouy]";
            Regex regex = new Regex(pattern);
            return regex.Replace(str, ch);
        }
    }
}
/*
 *         {
            foreach (char item in str)
            {
                if (item is 'a' or 'e' or 'i' or 'o' or 'u' or 'y') str=str.Replace(item, ch[0]);
            }
            return str;
        }
*
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

            foreach (char item in vowels)
            {
                str = str.Replace(item, ch[0]);
            }

            return str;
        }
*
*        {
            string vowels = "aeiouy";
            foreach (char item in str)
            {
                if (vowels.Contains(item))
                {
                    str = str.Replace(item, ch[0]);
                }
            }
            return str;
        }
*
*        {
            static bool IsVowel(char c) => "aeiou".Contains(c);
            StringBuilder sb = new StringBuilder(str);

            for (int i = 0; i < sb.Length; i++)
            {
                char currentChar = sb[i];
                if (IsVowel(currentChar))
                {
                    sb[i] = ch[0];
                }
            }
            return sb.ToString();
        }
 */