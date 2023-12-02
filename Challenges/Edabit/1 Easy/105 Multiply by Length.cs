//Create a function to multiply all of the values in an array by the amount of values in the given array.
using System;
namespace Challenges
{
    public class Program105
    {
        public static int[] MultiplyByLength(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= arr.Length;
            }
            return arr;
        }
    }
}