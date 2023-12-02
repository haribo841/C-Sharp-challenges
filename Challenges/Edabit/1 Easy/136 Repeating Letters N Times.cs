//Create a function that repeats each character in a string n times.
using System;
using System.Text;

namespace Challenges
{
    public class Program136
    {
        public static string Repeat(string str, int num)
        {
            StringBuilder result = new();
            foreach (char c in str)
            {
                for (int i = 0; i < num; i++)
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
    }
}