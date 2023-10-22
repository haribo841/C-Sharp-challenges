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

namespace Benchmark
{


    [MemoryDiagnoser]
    [RankColumn]
    public class Method
    {
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string F(string str)
        {
            StringBuilder result = new();
            foreach (char c in str)
            {
                result.Append(c);
                result.Append(' ');
            }
            result.Length--;//TrimEnd()
            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string Dec(string str)
        {
            StringBuilder result = new();
            foreach (char c in str)
            {
                result.Append(c);
                result.Append(' ');
            }
            result.Length--;//TrimEnd()
            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string FSafe(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;
            StringBuilder result = new();
            foreach (char c in str)
            {
                result.Append(c);
                result.Append(' ');
            }
            result.Length--;//TrimEnd()
            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string DecS(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;
            StringBuilder result = new();
            foreach (char c in str)
            {
                result.Append(c);
                result.Append(' ');
            }
            result.Length--;//TrimEnd()
            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string Trim(string str)
        {
            StringBuilder result = new();
            foreach (char c in str)
            {
                result.Append(c);
                result.Append(' ');
            }
            return result.ToString().TrimEnd();
        }
        public IEnumerable<string> GetData()
        {
            yield return ("space");
            yield return ("far out");
            yield return ("elongated musk");
            yield return ("long");
            yield return ("123");
            yield return ("a1b2c3");
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