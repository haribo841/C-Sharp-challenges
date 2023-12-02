//Write a function that stutters a word as if someone is struggling to read it.
//The first two letters are repeated twice with an ellipsis ...
//and space after each, and then the word is pronounced with a question mark ?.
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenges
{
    public class Program126
    {
        public static string Stutter(string word)
        {
            string a = word[..2];
            string b = "... ";
            return a + b + a + b + word + "?";
        }
    }
}