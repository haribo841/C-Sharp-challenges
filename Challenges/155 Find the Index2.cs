//Create a function that searches for the index of a given item in an array using recursion.
//If the item is present, it should return the index, otherwise, it should return -1.
using System;
using System.Reflection;

namespace Challenges
{
    public class Program155
    {
        public static int Search(int[] arr, int item)
        {
            int index = 0;

            int Search(int[] arr, int item)
            {
                if (arr[index] == item)
                {
                    int currentIndex = index;
                    index = 0; // Reset index before returning
                    return currentIndex;
                }
                if (arr.Length == index + 1)
                {
                    index = 0; // Reset index before returning
                    return -1;
                }
                else
                {
                    index++;
                    return Search(arr, item);
                }

            }
            return Search(arr, item);
        }
    }
}
/*
 *         {
            if (arr[arr.Length - 1] == item) return arr.Length - 1;
            if(arr.Length == 0 ) return -1;
            int[] arr2 = arr.SkipLast(1).ToArray();
            return arr2.Length <= 0 ? -1 : Search(arr2, item);
        }
*
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if the target is at the middle
                if (arr[mid] == item)
                    return mid;

                // If the target is greater, ignore left half
                if (arr[mid] < item)
                    left = mid + 1;
                // If the target is smaller, ignore right half
                else
                    right = mid - 1;
            }

            // If the target is not present in the array
            return -1;
        }
*
*        {
            int RecursiveBinarySearch(int[] arr, int target, int left, int right)
            {
                if (left <= right)
                {
                    int mid = left + (right - left) / 2;

                    // If the target is at the middle
                    if (arr[mid] == target)
                        return mid;

                    // If the target is greater, search the right half
                    if (arr[mid] < target)
                        return RecursiveBinarySearch(arr, target, mid + 1, right);
                    // If the target is smaller, search the left half
                    else
                        return RecursiveBinarySearch(arr, target, left, mid - 1);
                }

                // If the target is not present in the array
                return -1;
            }
            return RecursiveBinarySearch(arr, item, 0, arr.Length - 1);
        }
*
        {
            if (arr.Length == 0)
                return -1;

            if (arr[0] == item)
                return 0;

            int[] resizedArray = new int[arr.Length - 1];
            Array.Copy(arr, 1, resizedArray, 0, arr.Length - 1);

            int index = Search(resizedArray, item);
            if (index == -1)
                return -1;
            else
                return index + 1;
        }
*
        {
            int RecursiveSearch(int[] arr, int item, int index)
            {
                if (arr[index] == item)
                    return index;
                if (arr.Length == index + 1)
                    return -1;
                else
                    return RecursiveSearch(arr, item, index + 1);
            }
            return RecursiveSearch(arr, item, 0);
        }
*
        public static int Search(int[] arr, int item)
        {
            return RecursiveSearch(arr, item, 0);
        }

        private static int RecursiveSearch(int[] arr, int item, int index)
        {
            if (index >= arr.Length)
                return -1;

            if (arr[index] == item)
                return index;

            return RecursiveSearch(arr, item, index + 1);
        }
 */