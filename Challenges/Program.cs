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
        public bool LargestSwap(int num)
        {
            string a = num.ToString();
            if (a[0] == a[1]) return true;
            else if (a[0] < a[1]) return false;
            return true;
        }
        public IEnumerable<int> GetData()
        {
            yield return (27);
            yield return (43);
            yield return (14);
            yield return (53);
            yield return (99);
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