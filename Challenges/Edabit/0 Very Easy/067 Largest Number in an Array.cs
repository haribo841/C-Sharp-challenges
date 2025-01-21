//Create a function that takes an array of numbers. Return the largest number in the array.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public class Program67
    {
        public static int FindLargestNum(int[] arr)
        {
            if (arr.Length == 0)
            {
                throw new InvalidOperationException("Array is empty.");
            }

            int largest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            return largest;
        }
    }
    public class BenchmarkProgram67
    {
        private int[] array1;
        private int[] array2;
        private int[] array3;
        private int[] array4;
        private int[] array5;
        private int[] array6;
        private int[] array7;

        [GlobalSetup]
        public void Setup()
        {
            array1 = new int[] { 4, 5, 1, 3 };
            array2 = new int[] { 13, 27, 18, 26 };
            array3 = new int[] { 32, 35, 37, 39 };
            array4 = new int[] { 1000, 1001, 857, 1 };
            array5 = new int[] { 27364, 837363, 736736, 73635 };
            array6 = new int[] { 30, 2, 40, 3 };
            array7 = new int[] { 0, 1, 0, 0, 1 };
        }

        [Benchmark]
        public object GetLastItemArray1() => Program67.FindLargestNum(array1);
        [Benchmark]
        public object GetLastItemArray2() => Program67.FindLargestNum(array2);
        [Benchmark]
        public object GetLastItemArray3() => Program67.FindLargestNum(array3);
        [Benchmark]
        public object GetLastItemArray4() => Program67.FindLargestNum(array4);
        [Benchmark]
        public object GetLastItemArray5() => Program67.FindLargestNum(array5);
        [Benchmark]
        public object GetLastItemArray6() => Program67.FindLargestNum(array6);
        [Benchmark]
        public object GetLastItemArray7() => Program67.FindLargestNum(array7);
    }
}
