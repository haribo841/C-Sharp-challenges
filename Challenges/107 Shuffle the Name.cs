//Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.
using System;

namespace Challenges
{
    public class Program107
    {
        public static string NameShuffle(string str)
        {
            int found = 0;            
            foreach (char c in str)
            {
                found = str.IndexOf(" ");
            }
            string surname = str.Substring(++found);
            string name = str.Substring(0,--found);
            return surname+" "+name;
        }
    }
}