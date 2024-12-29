//Create a function that takes a string and returns it as an integer.
using System;
namespace Challenges
{
    public class Program55
    {
        public static int StringInt(string txt)
        {
            int result = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                // Convert the character to its integer value
                int digit = txt[i] - '0';
                result = result * 10 + digit;
            }
            return result;
        }
    }
}