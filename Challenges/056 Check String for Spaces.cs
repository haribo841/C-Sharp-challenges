//Create a function that returns true if a string contains any spaces.
using System;
namespace Challenges
{
    public class Program56
    {
        public static bool HasSpaces(string str)
        {
            foreach (char c in str)
            {
                if (c == ' ')
                {
                    return true;
                }
            }
            return false;
        }
    }
}