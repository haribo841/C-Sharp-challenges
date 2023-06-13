//Write a function that returns true if all characters in a string are identical and false otherwise.
using System;

namespace Challenges
{
    public class Program112
    {
        public static bool IsIdentical(string str)
        {
            char first = str[0];
            foreach (char c in str) { 
                if (c != first) return false; }
            return true;
        }
    }
}