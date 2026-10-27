//Create a function that counts how many D's are in a sentence.
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Challenges
{
    public static class Program119
    {
        public static int CountDs(string str)
        {
            return str.Count(character => character is 'D' or 'd');
        }
    }
}
