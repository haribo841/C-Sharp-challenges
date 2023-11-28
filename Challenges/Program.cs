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
        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(GetData))]
        string F(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in str)
            {
                if (char.IsLetter(c) && c == char.ToLower(c)) result.Append(char.ToUpper(c));
                else if (char.IsLetter(c) && c == char.ToUpper(c)) result.Append(char.ToLower(c));
                else result.Append(c);
            }
            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string F2(string str)
        {
            StringBuilder reversed = new StringBuilder(str.Length);

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                        reversed.Append(char.ToLower(c));
                    }
                    else
                    {
                        reversed.Append(char.ToUpper(c));
                    }
                }
                else
                {
                    reversed.Append(c);
                }
            }

            return reversed.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string F3(string str)
        {
            string result = string.Empty;
            char[] inputArray = str.ToCharArray();

            foreach (char c in inputArray)
            {
                if (char.IsLower(c))
                    result += c.ToString().ToUpper();
                else if (char.IsUpper(c))
                    result += c.ToString().ToLower();
                else
                    result += c.ToString();
            }

            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string F4(string str)
        {
            string result = string.Empty;
            char[] inputArray = str.ToCharArray();
            foreach (char c in inputArray)
            {
                if (char.IsLower(c))
                    result += Char.ToUpper(c);
                else
                    result += Char.ToLower(c);
            }
            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string F5(string str)
        {
            char[] charArray = str.ToCharArray();// new char[str.Length];

            for (int i = 0; i < charArray.Length; i++)//str.Length
            {
                if (char.IsLetter(charArray[i]))
                {
                    if (char.IsLower(charArray[i]))
                        charArray[i] = char.ToUpper(charArray[i]);
                    else
                        charArray[i] = char.ToLower(charArray[i]);
                }
            }

            return new string(charArray);
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string F6(string str)
        {
            string[] reversedCharacters = new string[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    reversedCharacters[i] = Char.ToLower(str[i]).ToString();
                }
                else if (Char.IsLower(str[i]))
                {
                    reversedCharacters[i] = Char.ToUpper(str[i]).ToString();
                }
                else
                {
                    reversedCharacters[i] = str[i].ToString(); // Keep non-letter characters as they are
                }
            }

            return string.Concat(reversedCharacters);
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string F7(string str)
        {
            char[] charArray = str.ToCharArray();
            char[] newCharArray = new char[charArray.Length];

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsUpper(charArray[i]))
                    newCharArray[i] = Char.ToLower(charArray[i]);

                else if (char.IsLower(charArray[i]))
                    newCharArray[i] = Char.ToUpper(charArray[i]);

                else
                    newCharArray[i] = charArray[i];
            }

            string s = new string(newCharArray);
            return s;
        }
        public IEnumerable<string> GetData()
        {
            yield return ("Happy Birthday");
            yield return ("MANY THANKS");
            yield return ("sPoNtAnEoUs");
            yield return ("eXCELLENT, yOuR mAJESTY");
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