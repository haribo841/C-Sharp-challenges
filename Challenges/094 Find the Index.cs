//Create a function that takes an array and a string as arguments and returns the index of the string.
using System;
using System.Text;
namespace Challenges
{
    public class Program94
    {
        public static int FindIndex(string[] arr, string str)
        {
            foreach (string s in arr)
            {
                if (s == str) return Array.IndexOf(arr, str);
            }
            return -1;
        }
    }
}
