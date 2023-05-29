//Create a function that takes an array and a string as arguments and returns the index of the string.
using System;
using System.Text;
namespace Challenges
{
    public class Program94
    {
        public static int FindIndex(string[] arr, string str)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == str)
                    return i;
            }
            return -1;
        }
    }
}
