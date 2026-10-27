//Given a string, create a function to reverse the case.
//All lower-cased letters should be upper-cased, and vice versa.
using System;
using System.Text;

namespace Challenges
{
    public static class Program164
    {
        public static string ReverseCase(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in str)
            {
                if (char.IsLetter(c) && c == char.ToLower(c)) result.Append(char.ToUpper(c));
                else if (char.IsLetter(c) && c == char.ToUpper(c)) result.Append(char.ToLower(c));
                else result.Append(c);
            }
            return result.ToString();
        }
    }
}
