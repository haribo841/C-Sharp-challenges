//Given a word, create a function that checks whether it is a palindrome.
using System;

namespace Challenges
{
    public class Program151
    {
        public static bool CheckPalindrome(string str)
        {
            char[] arr1  = str.ToCharArray();
            char[] arr2 = arr1.Reverse().ToArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }
            return true;
        }
    }
}//check first n last character, go to middle, dont create 2nd arr