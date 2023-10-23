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
        public bool isBetween((string first, string last, string word) parameters)
        {
            bool firstisfirst = false;
            bool lastislast = false;
            if (parameters.first.CompareTo(parameters.word) < 0) firstisfirst = true;
            if (parameters.word.CompareTo(parameters.last) < 0) lastislast = true;
            return lastislast == true && firstisfirst == true;
        }
        public IEnumerable<(string first, string last, string word)> GetData()
        {
            yield return ("apple", "banana", "azure");
            yield return ("bookcase", "zebra", "squid");
            yield return ("shrapnel", "tapenade", "tally");
            yield return ("monk", "monument", "monkey");
            yield return ("oath", "ostrich", "osteoporosis");
            yield return ("ostracize", "ostrich", "open");
            yield return ("bookend", "boolean", "boost");
            yield return ("tamer", "tanner", "timid");
            yield return ("rhino", "sorcerer", "quote");
            yield return ("body", "lung", "ace");
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