//Create a function that takes a string and returns it as an integer.
using System;
namespace Challenges
{
    public class Program55
    {
        public static int StringInt(string txt)
        {
            if (string.IsNullOrEmpty(txt))
            {
                throw new ArgumentException("Input string is null or empty.");
            }

            int result = 0;
            int sign = 1;
            int index = 0;

            // Check for sign
            if (txt[0] == '-')
            {
                sign = -1;
                index++;
            }
            else if (txt[0] == '+')
            {
                index++;
            }

            // Convert characters to integer value
            while (index < txt.Length)
            {
                char currentChar = txt[index];
                if (currentChar is >= '0' and <= '9')
                {
                    result = result * 10 + (currentChar - '0');
                    index++;
                }
                else
                {
                    throw new ArgumentException("Invalid character in input string.");
                }
            }

            return result * sign;
        }
    }
}