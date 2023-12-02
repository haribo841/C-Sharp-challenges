//Create a function that takes a word and returns true if the word has two consecutive identical letters.
using System;

namespace Challenges
{
    public class Program130
    {
        public static bool DoubleLetters(string word)
        {
            bool result = false;
            char[] chars = word.ToCharArray();
            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == chars[i+1]) { result = true; break; }
            }
            return result;
        }
    }
}