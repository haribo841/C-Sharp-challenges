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
using Challenges;

namespace Benchmark
{
    public class Method
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine(A2401.DayOne("../../../../Challenges/Advent of Code/2024/input.txt"));
            }
        }
    }
}