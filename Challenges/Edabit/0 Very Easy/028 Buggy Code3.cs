//Create a function that returns true if an integer is evenly divisible by 5, and false otherwise.
using BenchmarkDotNet.Attributes;
using Challenges;
using System;

namespace Challenges
{
    public class Program28
    {
        public static string Sumarray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            return sum.ToString();
        }
    }
    public class BenchmarkProgram28
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        private int[] array1;
        private int[] array2;
        private int[] array3;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        [GlobalSetup]
        public void Setup()
        {
            array1 = new int[] { 1, 2, 3, 4, 5 };
            array2 = new int[] { -1, 0, 1 };
            array3 = new int[] { 0, 4, 8, 12 };
        }
        [Benchmark]
        public object GetLastItemArray1() => Program28.Sumarray(array1);
        [Benchmark]                                  
        public object GetLastItemArray2() => Program28.Sumarray(array2);
        [Benchmark]                                 
        public object GetLastItemArray3() => Program28.Sumarray(array3);
    }
}