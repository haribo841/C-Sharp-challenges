using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using System.Text.Json.Serialization;
using Microsoft.CodeAnalysis;
using Microsoft.Diagnostics.Runtime.Utilities;

namespace Benchmark
{


    [MemoryDiagnoser]
    [RankColumn]
    public class Method
    {
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int F((int side1, int side2) parameters) => parameters.side1 + parameters.side2 - 1;
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int Body((int side1, int side2) parameters)
        {
            return parameters.side1 + parameters.side2 -1;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int OneDec((int side1, int side2) parameters) => --parameters.side1 + parameters.side2;
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int ODBody((int side1, int side2) parameters)
        {
            return --parameters.side1 + parameters.side2;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int TwoDec((int side1, int side2) parameters) => parameters.side1 + --parameters.side2;
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public int TDBody((int side1, int side2) parameters)
        {
            return parameters.side1 + --parameters.side2;
        }
        public IEnumerable<(int side1, int side2)> GetData()
        {
            yield return (5, 4);
            yield return (8, 3);
            yield return (7, 9);
            yield return (10, 4);
            yield return (7, 2);
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