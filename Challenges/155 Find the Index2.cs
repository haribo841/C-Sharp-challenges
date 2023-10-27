//Create a function that searches for the index of a given item in an array using recursion.
//If the item is present, it should return the index, otherwise, it should return -1.
using System;

namespace Challenges
{
    public class Program155
    {
        public static int Search(int[] arr, int item)
        {
            if (arr[arr.Length - 1] == item) return arr.Length - 1;
            if(arr.Length == 0 ) return -1;
            int[] arr2 = arr.SkipLast(1).ToArray();
            if (arr2.Length <= 0) return -1;
            return Search( arr2, item);
        }
    }
}