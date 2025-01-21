//Create a function that takes an array of numbers and returns the smallest number in the set.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public class Program66
    {
        public static double FindSmallestNum(double[] arr)
        {
            if (arr.Length == 0)
            {
                throw new InvalidOperationException("Array is empty.");
            }

            double smallest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            return smallest;
        }
    }
    public class BenchmarkProgram66
    {
        private double[] array1;
        private double[] array2;
        private double[] array3;
        private double[] array4;
        private double[] array5;
        private double[] array6;
        private double[] array7;
        private double[] array8;
        private double[] array9;
        private double[] array10;

        [GlobalSetup]
        public void Setup()
        {
            array1 = new double[] { 34, 15, 88, 2 };
            array2 = new double[] { 34, -345, -1, 100 };
            array3 = new double[]{ -76, 1.345, 1, 0};
            array4 = new double[]{ 0.4356, 0.8795, 0.5435, -0.9999};
            array5 = new double[] { 7, 7, 7 };
            array6 = new double[] { 4, 6, 1, 3, 4, 5, 5, 1 };
            array7 = new double[] { -4, -6, -8, -1 };
            array8 = new double[] { 54, 76, 23, 54 };
            array9 = new double[] { 100 };
            array10 = new double[] { 0, 1, 2, 3, 4, 5 };
        }

        [Benchmark]
        public object GetLastItemArray1() => Program66.FindSmallestNum(array1);

        [Benchmark]
        public object GetLastItemArray2() => Program66.FindSmallestNum(array2);

        [Benchmark]
        public object GetLastItemArray3() => Program66.FindSmallestNum(array3);

        [Benchmark]
        public object GetLastItemArray4() => Program66.FindSmallestNum(array4);

        [Benchmark]
        public object GetLastItemArray5() => Program66.FindSmallestNum(array5);

        [Benchmark]
        public object GetLastItemArray6() => Program66.FindSmallestNum(array6);

        [Benchmark]
        public object GetLastItemArray7() => Program66.FindSmallestNum(array7);

        [Benchmark]
        public object GetLastItemArray8() => Program66.FindSmallestNum(array8);

        [Benchmark]
        public object GetLastItemArray9() => Program66.FindSmallestNum(array9);

        [Benchmark]
        public object GetLastItemArray10() => Program66.FindSmallestNum(array10);
    }
}