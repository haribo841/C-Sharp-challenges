//Write a function that returns true if all characters in a string are identical and false otherwise.
using System;

namespace Challenges
{
    public static class Program112
    {
        public static bool IsIdentical(string str)
        {
            char first = str[0];
            return str.All(character => character == first);
        }
    }
}
