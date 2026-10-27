//Write a function that removes any non-letters from a string, returning a well-known film title.
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Challenges
{
    public static class Program161
    {
        public static string LettersOnly(string str)

        {
            int c = 0;
            char[] b = new char[str.Length]; // Changed Char to char for consistency
            char[] a = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (char.ToLower(str[i]) == a[j] || char.ToUpper(str[i]) == a[j]) // Compare lower and upper case
                    {
                        b[c] = str[i]; // Assign directly to the array
                        c++;
                    }
                }
            }
            Array.Resize(ref b, c); // Resize the array to actual length
            return new string(b);
        }
    }
}
