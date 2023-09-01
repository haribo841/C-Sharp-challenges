//Create a function that repeats each character in a string n times.
using System;
using System.Text;

namespace Challenges
{
    public class Program136
    {
        public static string Repeat(string str, int num)
        {
            char[] chars = new char[str.Length * num];
            char[] chars2 = str.ToCharArray();
            for (int i = 0; i < chars2.Length; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    chars[i * num + j] = chars2[i];
                }
            }
            return new string(chars);
        }
    }
}