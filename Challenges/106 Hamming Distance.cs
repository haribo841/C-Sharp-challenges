//Create a function that computes the hamming distance between two strings.
using System;
namespace Challenges
{
    public class Program106
    {
        public static int HammingDistance(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                throw new ArgumentException("Input strings must have the same length.");
            }
            int distance = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    distance++;
                }
            }
            return distance;
        }
    }
}