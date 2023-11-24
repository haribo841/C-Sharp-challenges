//Write a function that removes any non-letters from a string, returning a well-known film title.
using System;
using System.Text.RegularExpressions;

namespace Challenges
{
    public class Program161
    {
        public static string LettersOnly(string str) => Regex.Replace(str, "[\\W\\d_]", "");
    }
}