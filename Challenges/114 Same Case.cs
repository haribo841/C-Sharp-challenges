//Create a function that returns true if an input string contains only uppercase or only lowercase letters.
using System;

namespace Challenges
{
    public class Program114
    {
        public static bool SameCase(string str) => str.Length == str.Count(char.IsUpper) || str.Length == str.Count(char.IsLower);
    }
}