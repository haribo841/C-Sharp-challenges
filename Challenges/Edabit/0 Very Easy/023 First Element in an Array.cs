//Create a function that takes an array containing only values of the same type and return the first element.
using System;

namespace Challenges
{
    public class Program23
    {
        public static object GetFirstValue(object[] arr) => arr[0];
    }
}
/*
          public object F(object[] arr) => arr[0];
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public object Body(object[] arr)
        {
            return arr[0];
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public object First(object[] arr) => arr.First();
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public object BodyFirst(object[] arr)
        {
            return arr.First();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public object FOD(object[] arr) => arr.FirstOrDefault();
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public object BodyFOD(object[] arr)
        {
            return arr.FirstOrDefault();
        }
 */