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
        [BenchmarkCategory("Regex"), Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(GetData))]
        public string R(string str) => Regex.Replace(str, "[^a-zA-Z]", "");
        [BenchmarkCategory("Regex"), Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string RBody(string str)
        {
            return Regex.Replace(str, "[\\W\\d_]", "");
        }

        [BenchmarkCategory("Regex"), Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string R2(string str) => Regex.Replace(str, "[\\W\\d_]", "");
        [BenchmarkCategory("Regex"), Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string R2Body(string str)
        {
            return Regex.Replace(str, "[\\W\\d_]", "");
        }
        [BenchmarkCategory("Where"), Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(GetData))]
        public string Where(string str)=>new string (str.Where(char.IsLetter).ToArray());
        [BenchmarkCategory("Where"), Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string WhereN(string str) => new(str.Where(char.IsLetter).ToArray());
        [BenchmarkCategory("StringBuilder"), Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(GetData))]
        public string S(string str)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [BenchmarkCategory("StringBuilder"), Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string Sn(string str)
        {
            StringBuilder result = new();

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [BenchmarkCategory("For"), Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(GetData))]
        public string F(string str)
        {
            int c = 0;
            char[] b = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i])) // Use char.IsLetter to check if it's a letter
                {
                    b[c] = str[i];
                    c++;
                }
            }
            Array.Resize(ref b, c);
            return new string(b);
        }
        [BenchmarkCategory("For"), Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string F2t(string str)
        {
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i])) // Use char.IsLetter to check if it's a letter
                {
                    (new char[str.Length])[c] = str[i];
                    c++;
                }
            }
            char[] b = new char[str.Length];
            Array.Resize(ref b, c);
            return new string(new char[str.Length]);
        }
        [BenchmarkCategory("N00b"), Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(GetData))]
        public string N(string str)
        {
            int c = 0;
            char[] b = new char[str.Length]; // Changed Char to char for consistency
            char[] a = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (char.ToLower(str[i]) == a[j] || char.ToUpper(str[i]) == a[j]) // Compare lower and upper case
                    {
                        b[c] = str[i]; // Assign directly to the array
                        c++;
                    }
                }
            }
            Array.Resize(ref b, c); // Resize the array to actual length
            return new string(b);
        }
        [BenchmarkCategory("N00b")]
        [ArgumentsSource(nameof(GetData))]
        public string NA(string str)
        {
            int c = 0;
            char[] b = new char[str.Length]; // Changed Char to char for consistency
            char[] a = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (!(char.ToLower(str[i]) != a[j] && char.ToUpper(str[i]) != a[j])) // Compare lower and upper case
                    {
                        b[c] = str[i]; // Assign directly to the array
                        c++;
                    }
                }
            }
            Array.Resize(ref b, c); // Resize the array to actual length
            return new string(b);
        }
        public IEnumerable<string> GetData()
        {
             yield return (",1|2)\")A^1<[_)?^\"]l[a`3+%!d@8-0_0d.*}i@&n?=");
            yield return ("^U)6$22>8p).");
            yield return ("I5n!449+c@e*}@@1]p{2@`,~t:i0o%n<3%8");
            yield return ("!)\"P[s9)\"69}yc3+?1]+33>3ho");
            yield return (":~;G{o}o{+524<df~:>}e24{l8:_l]a:?@]%s7");
            yield return ("&&S~]@8>1-0!h#r),80<_>!}|e>_k:");
            yield return (")^/|,!!09]=/1<G2?`=[l{a}d9]^i7a0|t6_o2*r");
            yield return ("]8;]V9e{=0r!.5t>i<^_g\"4o\"5~");
            yield return ("%%)?\"?B#>/_4a#,;t8|m8675a(n");
            yield return ("97H^)~a8567ll*o?\"6%)w63e37e<n?@=");
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