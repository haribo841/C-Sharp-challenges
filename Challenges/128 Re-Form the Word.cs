//A word has been split into a left part and a right part.
//Re-form the word by adding both halves together, changing the first character to an uppercase letter.
using System;
using System.Text;

namespace Challenges
{
    public class Program128
    {
        public static string GetWord(string left, string right)
        {
            StringBuilder result = new StringBuilder(left.Length + right.Length + 1);
            result.Append(char.ToUpper(left[0]));
            result.Append(left.Substring(1));
            result.Append(right);
            return result.ToString();
        }
    }
}