//Create a function that takes a number (from 1 - 60) and returns a corresponding string of hyphens.
using System;
using System.Text;
namespace Challenges
{
    public class Program93
    {
        public static string Go(int num)
        {
            char[] chars = new char[num];
            for (int i = 0; i < num; i++)
            {
                chars[i] = '-';
            }
            string b = chars;
            return b;
        }
    }
}
