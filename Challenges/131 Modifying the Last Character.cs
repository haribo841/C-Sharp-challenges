//Create a function which makes the last character of a string repeat n number of times.
using System;
using System.Text;

namespace Challenges
{
    public class Program131
    {
        public static string ModifyLast(string str, int n)
        {
            if (str.Length == 0 || n <= 0)
            {
                return str; // No modification needed
            }

            char lastChar = str[str.Length - 1];
            StringBuilder modified = new(str.Length + n - 1);

            // Append the initial characters
            modified.Append(str);

            // Append the repeated last character
            for (int i = 1; i < n; i++)
            {
                modified.Append(lastChar);
            }

            return modified.ToString();
        }
    }
}