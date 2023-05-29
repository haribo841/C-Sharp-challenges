//Create a function that takes a string and returns the number (count) of vowels contained within it.
using System;

namespace Challenges
{
    public class Program110
    {
        public static int CountVowels(string str)
        {
            int count = 0;
            foreach (char c in str) { if (c is 'a' or 'e' or 'i' or 'o' or 'u' or 'y' ) count++; }
            return count;
        }
    }
}