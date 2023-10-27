using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Microsoft.CodeAnalysis;
using Microsoft.Diagnostics.Runtime.Utilities;
using System.Text;
using System.Reflection.Metadata;

namespace Benchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Method
    {
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int Search((int[] arr, int item) parameters)
        {
            if (parameters.arr[parameters.arr.Length - 1] == parameters.item) return parameters.arr.Length - 1;
            if (parameters.arr.Length == 0) return -1;
            int[] arr2 = parameters.arr.SkipLast(1).ToArray();
            if (arr2.Length <= 0) return -1;
            return Search((arr2, parameters.item));
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int Search2((int[] arr, int item) parameters)
        {
            if (parameters.arr[parameters.arr.Length - 1] == parameters.item) return parameters.arr.Length - 1;
            if (parameters.arr.Length == 0) return -1;
            int[] arr2 = parameters.arr.SkipLast(1).ToArray();
            return arr2.Length <= 0 ? -1 : Search2((arr2, parameters.item));
        }
        public IEnumerable<(int[] a, int b)> GetData()
        {
            yield return (new int[] { 1, 2, 3, 4 }, 3);
            yield return (new int[] { 2, 4, 6, 8, 10 }, 8);
            yield return (new int[] { 1, 3, 5, 7, 9 }, 11);
            yield return (new int[] { 1, 5, 7, 11, 25, 100, 200, 350 }, 5);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                var summary = BenchmarkRunner.Run<Method>();
            }
        }
    }
}