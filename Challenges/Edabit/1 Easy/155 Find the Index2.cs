//Create a function that searches for the index of a given item in an array using recursion.
//If the item is present, it should return the index, otherwise, it should return -1.
using System;
using System.Reflection;

namespace Challenges
{
    public static class Program155
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
