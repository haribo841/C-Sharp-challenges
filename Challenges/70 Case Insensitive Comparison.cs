//Write a function that validates whether two strings are identical and make it case insensitive.
using System;
namespace Challenges
{
    public class Program70
    {
        public static bool match(string s1, string s2) => s1.ToLower() == s2.ToLower();
    }
}
