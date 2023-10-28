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
        public int MissingNum(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr.Contains(i)) continue;
                return i;
            }
            return 10;
        }
        public IEnumerable<int[]> GetData()
        {
            yield return (new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 });
            yield return (new int[] { 7, 2, 3, 6, 5, 9, 1, 4, 8 });
            yield return (new int[] { 7, 2, 3, 9, 4, 5, 6, 8, 10 });
            yield return (new int[] { 10, 5, 1, 2, 4, 6, 8, 3, 9 });
            yield return (new int[] { 1, 7, 2, 4, 8, 10, 5, 6, 9 });
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