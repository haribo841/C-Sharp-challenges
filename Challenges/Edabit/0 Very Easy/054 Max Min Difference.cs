//Given an array of integers, return the difference between the largest and smallest integers in the array.
using System;
using System.Collections;
using System.Linq;
namespace Challenges
{
    public class Program54
    {
        public static int Diff(int[] arr)
        { 
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
            }

            return max - min;
        }
    }
}