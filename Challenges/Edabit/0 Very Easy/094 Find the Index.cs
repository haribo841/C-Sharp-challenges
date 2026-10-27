//Create a function that takes an array and a string as arguments and returns the index of the string.
using System;
using System.Text;
namespace Challenges
{
    public static class Program94
    {
        public static int FindIndex(string[] arr, string str)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (string.Compare(arr[mid], str) == 0) return mid; // Found the string at index 'mid'
                else if (string.Compare(arr[mid], str) < 0)  left = mid + 1; // Search the right half
                else right = mid - 1; // Search the left half
            }
            return -1; // String not found in the array
        }
    }
}
