//Create a function that takes a character and a string as arguments and returns the number of times the character is found in the string.
using System;
namespace Challenges
{
    public class Program100
    {
        public static int CharCount(char myChar, string str) => str.Count(c => c == myChar);
    }
}
