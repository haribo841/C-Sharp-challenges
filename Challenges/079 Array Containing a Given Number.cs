//Write a method to check if an array contains a particular number.
using System;
using System.Text;

namespace Challenges
{
    public class Program79
    {
        public static bool Check(int[] arr, int el)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == el)
                    return true;
                else if (arr[mid] < el)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return false;
        }
    }
}
