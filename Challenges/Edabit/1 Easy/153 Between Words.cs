//Write a function that takes three string arguments (first, last, and word)
//returns true if word is found between first and last in the dictionary, otherwise false.
using System;

namespace Challenges
{
    public class Program153
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
/*
 *         {
            bool firstisfirst = false;
            bool lastislast = false;
            if (first.CompareTo(word) < 0) firstisfirst = true;
            if (word.CompareTo(last) <  0) lastislast = true;
            return lastislast == true && firstisfirst == true;
        }
*
*            bool firstIsFirst = first.CompareTo(word) < 0;
            bool lastIsLast = word.CompareTo(last) < 0;
            return firstIsFirst && lastIsLast;
*
*    {
        // Compare the strings and check if 'word' is between 'first' and 'last'
        int compareFirst = String.Compare(first, word);
        int compareLast = String.Compare(word, last);
        
        return compareFirst < 0 && compareLast < 0;
    }
*
*        {
            int firstComparison = word.CompareTo(first.Substring(0, Math.Min(first.Length, word.Length)));
            int lastComparison = word.CompareTo(last.Substring(0, Math.Min(last.Length, word.Length)));

            return firstComparison > 0 && lastComparison < 0;
        }
*
        {
            return String.Compare(first, word) < 0 && String.Compare(last, word) > 0;
        }
 *
         {
            string[] words = { first, last, word };
            Array.Sort(words);

            // Check if the word is in the middle position after sorting
            return words[1] == word;
        }
 */