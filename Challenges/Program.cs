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
        public int F1((int a, int b, int c) parameters)
        {
            if (parameters.a == parameters.b && parameters.b == parameters.c) return 3;
            if (parameters.a == parameters.b || parameters.b == parameters.c || parameters.a == parameters.c) return 2;
            return 0;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int F2((int a, int b, int c) parameters)
        {
            if (parameters.a == parameters.b && parameters.b == parameters.c) return 3;
            return parameters.a == parameters.b || parameters.b == parameters.c || parameters.a == parameters.c ? 2 : 0;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int F3((int a, int b, int c) parameters)
        {
            return parameters.a == parameters.b && parameters.b == parameters.c
                ? 3
                : parameters.a == parameters.b || parameters.b == parameters.c || parameters.a == parameters.c ? 2 : 0;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int F4((int a, int b, int c) parameters) => parameters.a == parameters.b && parameters.b == parameters.c
                ? 3
                : parameters.a == parameters.b || parameters.b == parameters.c || parameters.a == parameters.c ? 2 : 0;
        public IEnumerable<(int a, int b, int c)> GetData()
        {
            yield return (2, 3, 4);
            yield return (7, 3, 7);
            yield return (4, 4, 4);
            yield return (7, 3, 4);
            yield return (3, 3, 6);
            yield return (1, 1, 1);
            yield return (1, 7, 6);
            yield return (7, 7, 7);
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