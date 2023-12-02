//Create a function that counts how many D's are in a sentence.
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Challenges
{
    public class Program119
    {
        public static int CountDs(string str)
        {
            int count = 0;
            foreach (char c in str) { if (c is 'D' or 'd') count++; }
            return count;
        }
    }
}