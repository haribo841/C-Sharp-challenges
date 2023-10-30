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

namespace Benchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Method
    {
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool F((int age, bool on_break)parameters) => !parameters.on_break && parameters.age >= 18;
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool Body((int age, bool on_break) parameters)
        {
            return !parameters.on_break && parameters.age >= 18;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool F2((int age, bool on_break) parameters) => !(parameters.on_break || parameters.age < 18);
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool Body2((int age, bool on_break) parameters)
        {
            return !(parameters.on_break || parameters.age < 18);
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool F3((int age, bool on_break) parameters) => parameters is { on_break: false, age: >= 18 };
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool Body3((int age, bool on_break) parameters)
        {
            return parameters is { on_break: false, age: >= 18 };
        }
        public IEnumerable<(int a, bool b)> GetData()
        {
            yield return (17, true);
            yield return (30, true);
            yield return (24, false);
            yield return (18, false);
            yield return (16, false);
            yield return (18, true);
            yield return (17, false);
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