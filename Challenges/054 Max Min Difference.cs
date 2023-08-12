//Given an array of integers, return the difference between the largest and smallest integers in the array.
using System;
using System.Collections;
using System.Linq;
namespace Challenges
{
    public class Program54
    {
        public static int Diff(int[] arr)//=>arr.Max()-arr.Min();
        {
            double[] doubleArray = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                doubleArray[i] = (double)arr[i]; }

            return Program67.FindLargestNum(arr) - (int)Program66.FindSmallestNum(doubleArray);
        }
    }
}