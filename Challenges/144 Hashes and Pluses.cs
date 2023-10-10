//Create a function that returns the number of hashes and pluses in a string.
using System;

namespace Challenges
{
    public class Program144
    {
        public static int[] HashPlusCount(string s)
        {
            int[] result = { 0, 0 };
            foreach (char c in s)
            {
                if (c == '#') result[0]++;
                if (c == '+') result[1]++;
            }
            return result;
        }
    }
}