//Create a function that takes a string and returns a new string with all vowels removed.
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Challenges
{
    public class Program160
    {
        public static string RemoveVowels(string str)// => Regex.Replace(str, "[aeiouAEIOU]", "");
        {
            // Create a variable to store the result
            string result = "";

            foreach (char c in str)
            {
                // Check if the character is not a vowel
                if (!"aeiouAEIOU".Contains(c))
                {
                    // Append the character to the result string
                    result += c;
                }
            }

            return result;
        }
    }
}
/*                {
            // Use LINQ to filter out vowels
            string result = new string(str.Where(c => !"aeiouAEIOU".Contains(c) || c == ' ').ToArray());
            return result;
        }
 *        
 *        {
            // Use LINQ to filter out vowels
            string result = new string(str.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
            return result;
        }
 * 
 *         {
            // Use the Replace method to remove vowels
            return string.Join("", str.Split('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'));
        }
 * 
 *         {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            StringBuilder sb = new();

            for (int i = 0; i < str.Length; i++)
            {
                if (!IsVowel(str[i]))
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
        }
*
*        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (!IsVowel(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
*
*        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (!"aeiouAEIOU".Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
*
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            foreach (char c in str)
            {
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
 */