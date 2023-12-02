//Given a word, create a function that checks whether it is a palindrome.
using System;
using System.Text;

namespace Challenges
{
    public class Program151
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
/*
 *         public static bool CheckPalindrome(string str)
        {
            char[] arr1  = str.ToCharArray();
            char[] arr2 = arr1.Reverse().ToArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }
            return true;
        }
*
         {
            if (string.IsNullOrEmpty(str))
                return false;

            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                    return false;

                left++;
                right--;
            }
*
            return true;
        }

        {
            if (string.IsNullOrEmpty(str))
                return false;

            StringBuilder reversed = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }

            return str.Equals(reversed.ToString());
        }
 */