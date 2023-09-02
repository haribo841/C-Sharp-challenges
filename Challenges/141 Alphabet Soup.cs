//Create a function that takes a string and returns a string with its letters in alphabetical order.
using System;

namespace Challenges
{
    public class Program141
    {
        public static string AlphabetSoup(string str)
        {
            char[] x = str.ToCharArray();
            Array.Sort(x);
            return new string(x);
        }
    }
}