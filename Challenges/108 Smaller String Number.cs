//Create a function that returns the smaller number.
using System;

namespace Challenges
{
    public class Program108
    {
        public static string SmallerNum(string n1, string n2)
        {
            int comparison = n1.CompareTo(n2);
            if (comparison <= 0)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }
    }
}