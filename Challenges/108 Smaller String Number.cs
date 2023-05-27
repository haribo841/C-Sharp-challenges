//Create a function that returns the smaller number.
using System;

namespace Challenges
{
    public class Program108
    {
        public static string smallerNum(string n1, string n2) => int.Parse(n1) < int.Parse(n2) ? n1 : n2;
    }
}