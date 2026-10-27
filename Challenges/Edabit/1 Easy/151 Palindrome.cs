//Given a word, create a function that checks whether it is a palindrome.
using System;
using System.Text;

namespace Challenges
{
    public static class Program151
    {
        public static bool CheckPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;

            string reversed = new string(str.Reverse().ToArray());
            return str.Equals(reversed);
        }
    }
}//check first n last character, go to middle, dont create 2nd arr
 //120
