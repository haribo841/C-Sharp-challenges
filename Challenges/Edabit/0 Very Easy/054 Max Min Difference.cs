//Given an array of integers, return the difference between the largest and smallest integers in the array.
using BenchmarkDotNet.Attributes;
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
                if (num > max) max = num;
                if (num < min) min = num;
            }
            return max - min;
        }
    }
    public class BenchmarkProgram54
    {
        [Benchmark]
        [Arguments(new int[] { -9, -8, 6, -9, 15, 6 })]
        [Arguments(new int[] { -5, 6, 18, 4, 16, -2 })]
        [Arguments(new int[] { -2, 20, -9, -9, -2, -7 })]
        [Arguments(new int[] { 4, -2, 11, -9, 15, 2 })]
        [Arguments(new int[] { 15, 10, 3, -6, 6, 19 })]
        [Arguments(new int[] { 1, 7, 18, -1, -2, 9 })]
        [Arguments(new int[] { 5, 1, -9, 7, -8, -10 })]
        [Arguments(new int[] { 5, 1, -9, 7, -8, -10 })]
        [Arguments(new int[] { 4, 17, 12, 2, 10, 2 })]
        public int Diff(int[] arr) => Program54.Diff(arr);
    }
}