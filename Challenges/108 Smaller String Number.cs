//Create a function that returns the smaller number.
using System;

namespace Challenges
{
    public class Program108
    {
        public static string SmallerNum(string n1, string n2)
        {
            if (n1.Length < n2.Length) return n1;
            else if (n2.Length < n1.Length) return n2;
            else
            {
                for (int i = 0; i < n1.Length; i++)
                {
                    if (n1[i] < n2[i]) return n1;
                    else if (n2[i] < n1[i]) return n2;
                }
                return n1;  // They are equal
            }
        }
    }
}