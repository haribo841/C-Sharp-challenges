//Create a function that accepts an array and returns the last item in the array.
//The array can contain any of C#'s primitive data types.
using BenchmarkDotNet.Attributes;
namespace Challenges
{
    public class Program61
    {
        public static object GetLastItem(object[] arr) => arr[^1];
    }
    public class BenchmarkProgram61
    {
        private object[] array1;
        private object[] array2;
        private object[] array3;
        private object[] array4;
        private object[] array5;
        private object[] array6;
        private object[] array7;
        private object[] array8;
        private object[] array9;
        private object[] array10;
        private object[] array11;
        private object[] array12;

        [GlobalSetup]
        public void Setup()
        {
            array1 = new object[] { "Cat", "Dog", "Duck" };
            array2 = new object[] { 1, 2, 3 };
            array3 = new object[] { null };
            array4 = new object[] { true, false, false, true };
            array5 = new object[] { 7, "String", false, null, null };
            array6 = new object[] { null };
            array7 = new object[] { false };
            array8 = new object[] { null, null, null };
            array9 = new object[] { 1, 2, 3, 56, 87, 23, 65, 45 };
            array10 = new object[] { "Apple", "Orange", null };
            array11 = new object[] { true, false, "Apple" };
            array12 = new object[] { 1 };
        }

        [Benchmark]
        public object GetLastItemArray1() => Program61.GetLastItem(array1);

        [Benchmark]
        public object GetLastItemArray2() => Program61.GetLastItem(array2);

        [Benchmark]
        public object GetLastItemArray3() => Program61.GetLastItem(array3);

        [Benchmark]
        public object GetLastItemArray4() => Program61.GetLastItem(array4);

        [Benchmark]
        public object GetLastItemArray5() => Program61.GetLastItem(array5);

        [Benchmark]
        public object GetLastItemArray6() => Program61.GetLastItem(array6);

        [Benchmark]
        public object GetLastItemArray7() => Program61.GetLastItem(array7);

        [Benchmark]
        public object GetLastItemArray8() => Program61.GetLastItem(array8);

        [Benchmark]
        public object GetLastItemArray9() => Program61.GetLastItem(array9);

        [Benchmark]
        public object GetLastItemArray10() => Program61.GetLastItem(array10);
        [Benchmark]
        public object GetLastItemArray11() => Program61.GetLastItem(array11);
        [Benchmark]
        public object GetLastItemArray12() => Program61.GetLastItem(array12);
    }
}
