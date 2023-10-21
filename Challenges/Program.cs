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
        public string F((string str, string ch) parameters)
        {
            foreach (char item in parameters.str)
            {
                if (item is 'a' or 'e' or 'i' or 'o' or 'u' or 'y') parameters.str = parameters.str.Replace(item, parameters.ch[0]);
            }
            return parameters.str;//new string(str);
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string C((string str, string ch) parameters)
        {
            string vowels = "aeiouy";
            foreach (char item in parameters.str)
            {
                if (parameters.str.Contains(vowels)) parameters.str = parameters.str.Replace(item, parameters.ch[0]);
            }
            return parameters.str;//new string(str);
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string Fnew((string str, string ch) parameters)
        {
            foreach (char item in parameters.str)
            {
                if (item is 'a' or 'e' or 'i' or 'o' or 'u' or 'y') parameters.str = parameters.str.Replace(item, parameters.ch[0]);
            }
            return new string(parameters.str);
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string Cnew((string str, string ch) parameters)
        {
            string vowels = "aeiouy";
            foreach (char item in parameters.str)
            {
                if (parameters.str.Contains(vowels)) parameters.str = parameters.str.Replace(item, parameters.ch[0]);
            }
            return new string(parameters.str);
        }
        public IEnumerable<(string str, string ch)> GetData()
        {
            yield return ("the aardvark", "#");
            yield return ("minnie mouse", "?");
            yield return ("shakespeare", "*");
            yield return ("all is fair in love and war", "<");
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