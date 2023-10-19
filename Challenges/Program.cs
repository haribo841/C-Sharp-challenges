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
        public bool CheckPalindrome(string str)
        {
            char[] arr1 = str.ToCharArray();
            char[] arr2 = arr1.Reverse().ToArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }
            return true;
        }
        public IEnumerable<string> GetData()
        {
            yield return "mom";
            yield return "scary";
            yield return "reviver";
            yield return "stressed";
            yield return "good";
            yield return "refer";
            yield return "something";
            yield return "redder";
            yield return "civic";
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