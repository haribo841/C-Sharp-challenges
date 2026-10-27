//Create a function to concatenate two integer arrays.
using System;
using System.Text;
namespace Challenges
{
    public static class Program86
    {
        public static int[] ConcatArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            Array.Copy(arr1, result, arr1.Length);
            Array.Copy(arr2, 0, result, arr1.Length, arr2.Length);
            return result;
        }
    }
}
