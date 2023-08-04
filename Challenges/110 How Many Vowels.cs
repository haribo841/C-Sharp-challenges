//Create a function that takes a string and returns the number (count) of vowels contained within it.
using System;

namespace Challenges
{
    public class Program110
    {
        public static int CountVowels(string str)
        {
            string vowels = "aeiou";
            return str.Count(c => vowels.Contains(c));
        }
    }
}