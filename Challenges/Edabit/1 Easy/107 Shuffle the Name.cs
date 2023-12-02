//Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.
using System;

namespace Challenges
{
    public class Program107
    {
        public static string NameShuffle(string str)
        {
            int spaceIndex = str.IndexOf(' ');
            if (spaceIndex != -1)
            {
                string firstName = str[..spaceIndex];
                string lastName = str[(spaceIndex + 1)..];
                return lastName + " " + firstName;
            }
            return str; // If there's no space, return the original string
        }
    }
}