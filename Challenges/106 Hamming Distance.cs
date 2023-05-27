//Create a function that computes the hamming distance between two strings.
using System;
namespace Challenges
{
    public class Program106
    {
        public static int HammingDistance(string str1, string str2)
        {
            int j = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                char a = str1[i];
                char b = str2[i];
                if (a!=b)j++;
            }
            return j;
        }
    }
}