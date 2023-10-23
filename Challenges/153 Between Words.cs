//Write a function that takes three string arguments (first, last, and word)
//returns true if word is found between first and last in the dictionary, otherwise false.
using System;

namespace Challenges
{
    public class Program153
    {
        public static bool isBetween(string first, string last, string word)
        {
            bool firstisfirst = false;
            bool lastislast = false;
            /*for (int i = 0; i < (word.Length - first.Length < 0?word.Length: first.Length); i++)
            {
                var x = first[i].CompareTo(word[i]);
                if (x > 0)  break;
                firstisfirst = true;
            }
            for (int i = 0; i < word.Length; i++)
            {
                var x = word[i].CompareTo(last[i]);
                if (x > 0) break;
                lastislast = true;
            }
            */
            if (first.CompareTo(word) < 0) firstisfirst = true;
            if (word.CompareTo(last) <  0) lastislast = true;
            return lastislast == true && firstisfirst == true;
        }
    }
}