//Create a function that takes an array of numbers and returns only the even values.
using System;

namespace Challenges
{
    public class Program133
    {
        public static int[] NoOdds(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 == 0) result[i] = arr[i];
                continue;
            }
            return result;
        }
    }
}