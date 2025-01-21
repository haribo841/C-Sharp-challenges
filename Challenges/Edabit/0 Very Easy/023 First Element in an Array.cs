//Create a function that takes an array containing only values of the same type and return the first element.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program23
    {
        public static object GetFirstValue(object[] arr) => arr[0];
    }
    public class BenchmarkProgram23
    {
        private object[] array1;
        private object[] array2;
        private object[] array3;
        private object[] array4;
        private object[] array5;
        private object[] array6;

        [GlobalSetup]
        public void Setup()
        {
            array1 = new object[] { 5, 6, 7 };
            array2 = new object[] { "Semiramis", "Gaia", "Hypatia" };
            array3 = new object[] { -500, 0, 500 };
            array4 = new object[] { 'n', 'm', 'v' };
            array5 = new object[] { 3.3, 4.4, 5.5 };
            array6 = new object[] { true, false, true };
        }

        [Benchmark]
        public object GetLastItemArray1() => Program23.GetFirstValue(array1);
        [Benchmark]
        public object GetLastItemArray2() => Program23.GetFirstValue(array2);
        [Benchmark]
        public object GetLastItemArray3() => Program23.GetFirstValue(array3);
        [Benchmark]
        public object GetLastItemArray4() => Program23.GetFirstValue(array4);
        [Benchmark]
        public object GetLastItemArray5() => Program23.GetFirstValue(array5);
        [Benchmark]
        public object GetLastItemArray6() => Program23.GetFirstValue(array6);
    }
}