//Create a function that takes an array of numbers and returns only the even values.
using System;

namespace Challenges
{
    public class Program133
    {
        public static int[] NoOdds(int[] arr)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] & 1) == 0)
                {
                    result.Add(arr[i]);
                }
            }
            return result.ToArray();
        }
    }
}