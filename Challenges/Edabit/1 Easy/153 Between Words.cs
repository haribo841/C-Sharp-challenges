//Write a function that takes three string arguments (first, last, and word)
//returns true if word is found between first and last in the dictionary, otherwise false.
using System;

namespace Challenges
{
    public static class Program153
    {
        public static bool IsBetween(string first, string last, string word)
        {
            string[] words = { first, last, word };
            Array.Sort(words); // Sort the array lexicographically

            int firstIndex = Array.IndexOf(words, first);
            int lastIndex = Array.IndexOf(words, last);
            int wordIndex = Array.IndexOf(words, word);

            return firstIndex < wordIndex && wordIndex < lastIndex;
        }
    }
}
