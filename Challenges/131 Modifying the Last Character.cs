//Create a function which makes the last character of a string repeat n number of times.
using System;

namespace Challenges
{
    public class Program131
    {
        public static string ModifyLast(string str, int n)
        {
            char[] chars = str.ToCharArray();
            char[] chars2 = new char[str.Length + n-1];
            for (int i = 0; i < str.Length; i++)
            {
                chars2[i] = chars[i];
            }
            for (int i = str.Length; i < chars2.Length; i++)
            {
                chars2[i] = chars[str.Length - 1];
            }
            return new string(chars2);
        }
    }
}