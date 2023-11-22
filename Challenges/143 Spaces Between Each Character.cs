//Create a function that takes a string and returns a string with spaces in between all of the characters.
using System;
using System.Text;

namespace Challenges
{
    public class Program143
    {
        public static string SpaceMeOut(string str)
        {
            StringBuilder result = new();
            foreach (char c in str)
            {
                    result.Append(c);
                    result.Append(' ');
            }
            result.Length--;
            return result.ToString();
        }
    }
}
/*
 *     {
        StringBuilder spacedString = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            // Append the character
            spacedString.Append(input[i]);

            // Append a space if it's not the last character or a space
            if (i < input.Length - 1 && input[i] != ' ')
            {
                spacedString.Append(' ');
            }
        }

        return spacedString.ToString();
    } */