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
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Benchmark
{
    [MemoryDiagnoser]
    //[DisassemblyDiagnoser]
    [ThreadingDiagnoser]
    [RankColumn]
    public class Method
    {
        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(GetData))]
        public int[] F(int num, int length)
        {
            List<int> list = new List<int>(length);
            for (int i = 1; i <= length; i++)
            {
                list.Add(num * i);
            }
            return list.ToArray();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int[] F2(int num, int length)
        {
            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = num * (i + 1);
            }
            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int[] F3(int num, int length)
        {
            return Enumerable.Range(1, length).Select(x => x * num).ToArray();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int[] F4(int num, int length)
        {
            return Enumerable.Repeat(num, length).Select((x, index) => x * (index + 1)).ToArray();
        }

        public IEnumerable<object[]> GetData()
        {
            yield return new object[] {7, 5};
            yield return new object[] { 12, 10};
            yield return new object[] { 17, 7};
            yield return new object[] { 630, 14};
            yield return new object[] { 140, 3};
            yield return new object[] { 7, 8};
            yield return new object[] { 11, 21};
            yield return new object[] { 7, 5};
            yield return new object[] { 12, 10};
            yield return new object[] { 17, 7};
            yield return new object[] { 630, 14};
            yield return new object[] { 140, 3};
            yield return new object[] { 7, 8};
            yield return new object[] { 11, 21};
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