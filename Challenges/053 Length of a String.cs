//Write a function that returns the length of a string.
//Make your function recursive.
using System;
namespace Challenges
{
    public class Program53
    {
        public static int Length(string str) => string.IsNullOrEmpty(str) ? 0 : 1 + Length(str.Substring(1));
    }
}
