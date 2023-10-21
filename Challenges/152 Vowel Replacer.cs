//Create a function that replaces all the vowels in a string with a specified character.
using System;

namespace Challenges
{
    public class Program152
    {
        public static string ReplaceVowels(string str, string ch)
        {
            foreach (char item in str)
            {
                if (item is 'a' or 'e' or 'i' or 'o' or 'u' or 'y') str=str.Replace(item, ch[0]);
            }
            return str;
        }
    }
}