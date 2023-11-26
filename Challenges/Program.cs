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
    [RankColumn]
    public class Method
    {
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string RegexR(string str) => Regex.Replace(str, "[aeiouAEIOU]", "");
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public string RegexBody(string str)
        {
            return Regex.Replace(str, "[aeiouAEIOU]", "");
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string FE(string str)
        {
            // Create a variable to store the result
            string result = "";

            foreach (char c in str)
            {
                // Check if the character is not a vowel
                if (!"aeiouAEIOU".Contains(c))
                {
                    // Append the character to the result string
                    result += c;
                }
            }

            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string L(string str)
        {
            // Create a variable to store the result
            string result = "";
            foreach (var c in from char c in str// Check if the character is not a vowel
                              where !"aeiouAEIOU".Contains(c)
                              select c)
            {
                // Append the character to the result string
                result += c;
            }

            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Le(string str)
        {
            // Create a variable to store the result
            string result = "";
            foreach (char c in from char c in str// Check if the character is not a vowel
                              where !"aeiouAEIOU".Contains(c)
                              select c)
            {
                // Append the character to the result string
                result += c;
            }

            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Lcall(string str)
        {
            // Create a variable to store the result
            string result = "";
            foreach (var c in str.Where(
            // Check if the character is not a vowel
            c => !"aeiouAEIOU".Contains(c)))
            {
                // Append the character to the result string
                result += c;
            }

            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Lecall(string str)
        {
            // Create a variable to store the result
            string result = "";
            foreach (char c in str.Where(
            // Check if the character is not a vowel
            c => !"aeiouAEIOU".Contains(c)))
            {
                // Append the character to the result string
                result += c;
            }

            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string FEi(string str)
        {
            // Create a variable to store the result
            string result = "";

            foreach (char c in str)
            {
                // Check if the character is not a vowel
                if ("aeiouAEIOU".Contains(c))
                {
                    continue;
                }
                // Append the character to the result string
                result += c;
            }

            return result;
        }
        //for
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string For(string str)
        {
            // Create a variable to store the result
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                // Check if the character is not a vowel
                if (!"aeiouAEIOU".Contains(c))
                {
                    // Append the character to the result string
                    result += c;
                }
            }

            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Fori(string str)
        {
            // Create a variable to store the result
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                // Check if the character is not a vowel
                if ("aeiouAEIOU".Contains(c))
                {
                    continue;
                }
                // Append the character to the result string
                result += c;
            }

            return result;
        }
        //for reversed
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string ForR(string str)
        {
            // Create a variable to store the result
            string result = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                // Check if the character is not a vowel
                if (!"aeiouAEIOU".Contains(c))
                {
                    // Append the character to the result string
                    result += c;
                }
            }

            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string ForRi(string str)
        {
            // Create a variable to store the result
            string result = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                // Check if the character is not a vowel
                if ("aeiouAEIOU".Contains(c))
                {
                    continue;
                }
                // Append the character to the result string
                result += c;
            }

            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string LINQbody(string str)
        {
            // Use LINQ to filter out vowels
            string result = new string(str.Where(c => !"aeiouAEIOU".Contains(c) || c == ' ').ToArray());
            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string LINQbn(string str)
        {
            // Use LINQ to filter out vowels
            string result = new(str.Where(c => !"aeiouAEIOU".Contains(c) || c == ' ').ToArray());
            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string LINQt(string str)
        {
            // Use LINQ to filter out vowels
            return new string(str.Where(c => !"aeiouAEIOU".Contains(c) || c == ' ').ToArray());
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string LINQ(string str) =>
            // Use LINQ to filter out vowels
            new string(str.Where(c => !"aeiouAEIOU".Contains(c) || c == ' ').ToArray());
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string LINQn(string str) =>
    // Use LINQ to filter out vowels
    new(str.Where(c => !"aeiouAEIOU".Contains(c) || c == ' ').ToArray());
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string LINQ2body(string str)
        {
            // Use LINQ to filter out vowels
            string result = new string(str.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string LINQ2nb(string str)
        {
            // Use LINQ to filter out vowels
            string result = new(str.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string LINQ2v(string str)
        {
            // Use LINQ to filter out vowels
            var result = new string(str.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
            return result;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string LINQ2t(string str)
        {
            // Use LINQ to filter out vowels
            return new string(str.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string LINQ2(string str) =>
            // Use LINQ to filter out vowels
            new string(str.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string LINQ2n(string str) =>
    // Use LINQ to filter out vowels
    new(str.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string JoinBody(string str)
        {
            // Use the Replace method to remove vowels
            return string.Join("", str.Split('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'));
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Join(string str) =>
            // Use the Replace method to remove vowels
            string.Join("", str.Split('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'));
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelS(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            StringBuilder sb = new();

            for (int i = 0; i < str.Length; i++)
            {
                if (!IsVowel(str[i]))
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            StringBuilder sb = new();

            for (int i = 0; i < str.Length; i++)
            {
                if (!IsVowel(str[i]))
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelT(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);

            for (int i = 0; i < str.Length; i++)
            {
                if (!IsVowel(str[i]))
                {
                    new StringBuilder().Append(str[i]);
                }
            }
            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVoweli(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            StringBuilder sb = new();

            for (int i = 0; i < str.Length; i++)
            {
                if (IsVowel(str[i]))
                {
                    continue;
                }
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelTi(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);

            for (int i = 0; i < str.Length; i++)
            {
                if (IsVowel(str[i]))
                {
                    continue;
                }
                new StringBuilder().Append(str[i]);
            }
            return new StringBuilder().ToString();
        }
        //for reversed
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelr(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            StringBuilder sb = new();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!IsVowel(str[i]))
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelTr(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!IsVowel(str[i]))
                {
                    new StringBuilder().Append(str[i]);
                }
            }
            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelir(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            StringBuilder sb = new();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (IsVowel(str[i]))
                {
                    continue;
                }
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelTir(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (IsVowel(str[i]))
                {
                    continue;
                }
                new StringBuilder().Append(str[i]);
            }
            return new StringBuilder().ToString();
        }
        //foreach
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelFE(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            StringBuilder sb = new();

            foreach (char v in str)
            {
                if (!IsVowel(v))
                {
                    sb.Append(v);
                }
            }
            return sb.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelFET(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);

            foreach (char v in str)
            {
                if (!IsVowel(v))
                {
                    new StringBuilder().Append(v);
                }
            }
            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelFEi(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            StringBuilder sb = new();

            foreach (char v in str)
            {
                if (IsVowel(v))
                {
                    continue;
                }
                sb.Append(v);
            }
            return sb.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelFEt(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);

            foreach (char v in str)
            {
                if (IsVowel(v))
                {
                    continue;
                }
                new StringBuilder().Append(v);
            }
            return new StringBuilder().ToString();
        }
        //fe to linq
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelL(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            StringBuilder sb = new();
            foreach (var v in from char v in str
                              where !IsVowel(v)
                              select v)
            {
                sb.Append(v);
            }

            return sb.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelLT(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            foreach (var v in from char v in str
                              where !IsVowel(v)
                              select v)
            {
                new StringBuilder().Append(v);
            }

            return new StringBuilder().ToString();
        }
        //fe to linq call
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelLc(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            StringBuilder sb = new();
            foreach (var v in str.Where(v => !IsVowel(v)))
            {
                sb.Append(v);
            }

            return sb.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowelLcT(string str)
        {
            static bool IsVowel(char c) => "AaEeIiOoUu".Contains(c);
            foreach (var v in str.Where(v => !IsVowel(v)))
            {
                new StringBuilder().Append(v);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2b(string str)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (!IsVowel(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2(string str)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (!IsVowel(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //temporary variable
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bt(string str)
        {

            foreach (char c in str)
            {
                if (!IsVowel(c))
                {
                    new StringBuilder().Append(c);
                }
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2t(string str)
        {

            foreach (char c in str)
            {
                if (!IsVowel(c))
                {
                    new StringBuilder().Append(c);
                }
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //inverted if
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bi(string str)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (IsVowel(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2i(string str)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (IsVowel(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //temporary variable
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bti(string str)
        {

            foreach (char c in str)
            {
                if (IsVowel(c))
                {
                    continue;
                }
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2ti(string str)
        {

            foreach (char c in str)
            {
                if (IsVowel(c))
                {
                    continue;
                }
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //foreach => for
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bf(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!IsVowel(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bL(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (var c in from char c in str
                              where !IsVowel(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bLc(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (var c in str.Where(c => !IsVowel(c)))
            {
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2f(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!IsVowel(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2L(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (var c in from char c in str
                              where !IsVowel(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2Lc(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (var c in str.Where(c => !IsVowel(c)))
            {
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //temporary variable
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2btf(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!IsVowel(c))
                {
                    new StringBuilder().Append(c);
                }
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2btL(string str)
        {
            foreach (var c in from char c in str
                              where !IsVowel(c)
                              select c)
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2btLc(string str)
        {
            foreach (var c in str.Where(c => !IsVowel(c)))
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2tf(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!IsVowel(c))
                {
                    new StringBuilder().Append(c);
                }
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2tL(string str)
        {
            foreach (var c in from char c in str
                              where !IsVowel(c)
                              select c)
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2tLc(string str)
        {
            foreach (var c in str.Where(c => !IsVowel(c)))
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //inverted if
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bif(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (IsVowel(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2if(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (IsVowel(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //temporary variable
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2btif(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (IsVowel(c))
                {
                    continue;
                }
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2tif(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (IsVowel(c))
                {
                    continue;
                }
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //reversed for
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bfr(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (!IsVowel(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bLi(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in from char c in str
                              where !IsVowel(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bLci(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in str.Where(c => !IsVowel(c)))
            {
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2fr(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (!IsVowel(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2Li(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in from char c in str
                              where !IsVowel(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2Lci(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in str.Where(c => !IsVowel(c)))
            {
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //temporary variable
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2btfr(string str)
        {

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (!IsVowel(c))
                {
                    new StringBuilder().Append(c);
                }
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2btLi(string str)
        {
            foreach (char c in from char c in str
                              where !IsVowel(c)
                              select c)
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2btLci(string str)
        {
            foreach (char c in str.Where(c => !IsVowel(c)))
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2tfr(string str)
        {

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (!IsVowel(c))
                {
                    new StringBuilder().Append(c);
                }
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2tLi(string str)
        {
            foreach (char c in from char c in str
                              where !IsVowel(c)
                              select c)
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2tLci(string str)
        {
            foreach (char c in str.Where(c => !IsVowel(c)))
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //inverted if
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bifr(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (IsVowel(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2ifr(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (IsVowel(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //temporary variable
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2btifr(string str)
        {

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (IsVowel(c))
                {
                    continue;
                }
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2tifr(string str)
        {

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (IsVowel(c))
                {
                    continue;
                }
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //temporary char
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bft(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (!IsVowel(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2ft(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (!IsVowel(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //temporary variable
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2btft(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (!IsVowel(str[i]))
                {
                    new StringBuilder().Append(str[i]);
                }
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2tft(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (!IsVowel(str[i]))
                {
                    new StringBuilder().Append(str[i]);
                }
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //inverted if
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bift(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (IsVowel(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2ift(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (IsVowel(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //temporary variable
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2btift(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (IsVowel(str[i]))
                {
                    continue;
                }
                new StringBuilder().Append(str[i]);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2tift(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (IsVowel(str[i]))
                {
                    continue;
                }
                new StringBuilder().Append(str[i]);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //reversed for
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bfrt(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!IsVowel(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2frt(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!IsVowel(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }

        //temporary variable
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2btfrt(string str)
        {

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!IsVowel(str[i]))
                {
                    new StringBuilder().Append(str[i]);
                }
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2tfrt(string str)
        {

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!IsVowel(str[i]))
                {
                    new StringBuilder().Append(str[i]);
                }
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //inverted if
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2bifrt(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (IsVowel(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2ifrt(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (IsVowel(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        //temporary variable
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2btifrt(string str)
        {

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (IsVowel(str[i]))
                {
                    continue;
                }
                new StringBuilder().Append(str[i]);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c)
            {
                return "aeiouAEIOU".IndexOf(c) != -1;
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string IsVowel2tifrt(string str)
        {

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (IsVowel(str[i]))
                {
                    continue;
                }
                new StringBuilder().Append(str[i]);
            }

            return new StringBuilder().ToString();


            bool IsVowel(char c) => "aeiouAEIOU".IndexOf(c) != -1;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S(string str)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (!"aeiouAEIOU".Contains(c))
                {
                    result.Append(c);
                }
}

return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string St(string str)
        {

            foreach (char c in str)
            {
                if (!"aeiouAEIOU".Contains(c))
                {
                    new StringBuilder().Append(c);
                }
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Si(string str)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if ("aeiouAEIOU".Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Sti(string str)
        {

            foreach (char c in str)
            {
                if ("aeiouAEIOU".Contains(c))
                {
                    continue;
                }
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        //for
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Sf(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!"aeiouAEIOU".Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string SL(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (var c in from char c in str
                              where !"aeiouAEIOU".Contains(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string SLc(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (var c in str.Where(c => !"aeiouAEIOU".Contains(c)))
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Stf(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!"aeiouAEIOU".Contains(c))
                {
                    new StringBuilder().Append(c);
                }
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string StL(string str)
        {
            foreach (var c in from char c in str
                              where !"aeiouAEIOU".Contains(c)
                              select c)
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string StLc(string str)
        {
            foreach (var c in str.Where(c => !"aeiouAEIOU".Contains(c)))
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Sif(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if ("aeiouAEIOU".Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Stif(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if ("aeiouAEIOU".Contains(c))
                {
                    continue;
                }
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        //for reversed
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Sfr(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (!"aeiouAEIOU".Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string SLi(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in from char c in str
                              where !"aeiouAEIOU".Contains(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string SLci(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in str.Where(c => !"aeiouAEIOU".Contains(c)))
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Stfr(string str)
        {

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (!"aeiouAEIOU".Contains(c))
                {
                    new StringBuilder().Append(c);
                }
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string StLi(string str)
        {
            foreach (char c in from char c in str
                              where !"aeiouAEIOU".Contains(c)
                              select c)
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string StLci(string str)
        {
            foreach (char c in str.Where(c => !"aeiouAEIOU".Contains(c)))
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Sifr(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if ("aeiouAEIOU".Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Stifr(string str)
        {

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if ("aeiouAEIOU".Contains(c))
                {
                    continue;
                }
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        //tomporary variable
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Sft(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (!"aeiouAEIOU".Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Stft(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (!"aeiouAEIOU".Contains(str[i]))
                {
                    new StringBuilder().Append(str[i]);
                }
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Sift(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if ("aeiouAEIOU".Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Stift(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if ("aeiouAEIOU".Contains(str[i]))
                {
                    continue;
                }
                new StringBuilder().Append(str[i]);
            }

            return new StringBuilder().ToString();
        }
        //for reversed
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Sfrt(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!"aeiouAEIOU".Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Stfrt(string str)
        {

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!"aeiouAEIOU".Contains(str[i]))
                {
                    new StringBuilder().Append(str[i]);
                }
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Sifrt(string str)
        {
            StringBuilder result = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if ("aeiouAEIOU".Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string Stifrt(string str)
        {

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if ("aeiouAEIOU".Contains(str[i]))
                {
                    continue;
                }
                new StringBuilder().Append(str[i]);
            }

            return new StringBuilder().ToString();
        }
        //last batch
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            foreach (char c in str)
            {
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2n(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels

            foreach (char c in str)
            {
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2v(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            foreach (char c in str)
            {
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        //t
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2t(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels

            foreach (char c in str)
            {
                if (!vowels.Contains(c))
                {
                    new StringBuilder().Append(c);
                }
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2c(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in str)
            {
                string vowels = "aeiouAEIOU"; // List of vowels
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2i(string str)
        {
            StringBuilder result = new();
            // List of vowels

            foreach (char c in str)
            {
                if (!"aeiouAEIOU".Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22v(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels

            foreach (char c in str)
            {
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        //if
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2r(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2nr(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2vr(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        //t
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2tr(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                {
                    continue;
                }
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2cr(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in str)
            {
                string vowels = "aeiouAEIOU"; // List of vowels
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2ir(string str)
        {
            StringBuilder result = new();
            // List of vowels

            foreach (char c in str)
            {
                if ("aeiouAEIOU".Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22vr(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        //for
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2f(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2L(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (var c in from char c in str
                              where !vowels.Contains(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2Lc(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (var c in str.Where(c => !vowels.Contains(c)))
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2nf(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2nL(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (var c in from char c in str
                              where !vowels.Contains(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2nLc(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (var c in str.Where(c => !vowels.Contains(c)))
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2vf(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2vL(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (var c in from char c in str
                              where !vowels.Contains(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2vLc(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (var c in str.Where(c => !vowels.Contains(c)))
            {
                result.Append(c);
            }

            return result.ToString();
        }
        //t
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2tf(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!vowels.Contains(c))
                {
                    new StringBuilder().Append(c);
                }
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2tL(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (var c in from char c in str
                              where !vowels.Contains(c)
                              select c)
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2tLc(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (var c in str.Where(c => !vowels.Contains(c)))
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2cf(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                string vowels = "aeiouAEIOU"; // List of vowels
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2cL(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (var c in from char c in str
                              let vowels = "aeiouAEIOU"// List of vowels
                              where !vowels.Contains(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2if(string str)
        {
            StringBuilder result = new();
            // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!"aeiouAEIOU".Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2iL(string str)
        {
            StringBuilder result = new();
            foreach (var c in
            // List of vowels
            from char c in str
            where !"aeiouAEIOU".Contains(c)
            select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2iLc(string str)
        {
            StringBuilder result = new();
            foreach (var c in str.Where(c => !"aeiouAEIOU".Contains(c))
            // List of vowels
            )
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22vf(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22vL(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels
            foreach (var c in from char c in str
                              where !vowels.Contains(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22vLc(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels
            foreach (var c in str.Where(c => !vowels.Contains(c)))
            {
                result.Append(c);
            }

            return result.ToString();
        }
        //if
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2rf(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2nrf(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2vrf(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        //t
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2trf(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (vowels.Contains(c))
                {
                    continue;
                }
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2crf(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                string vowels = "aeiouAEIOU"; // List of vowels
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2crL(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (var (c, vowels) in from char c in str
                                        let vowels = "aeiouAEIOU"// List of vowels
                                        select (c, vowels))
            {
                if (vowels.Contains(c))
                {
                    continue;
                }

                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2irf(string str)
        {
            StringBuilder result = new();
            // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if ("aeiouAEIOU".Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22vrf(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        //for reversed
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2fi(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2Li(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (char c in from char c in str
                              where !vowels.Contains(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2Lci(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (char c in str.Where(c => !vowels.Contains(c)))
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2nfr(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2nLi(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (char c in from char c in str
                              where !vowels.Contains(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2nLci(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (char c in str.Where(c => !vowels.Contains(c)))
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2vfr(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2vLi(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (char c in from char c in str
                              where !vowels.Contains(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2vLci(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (char c in str.Where(c => !vowels.Contains(c)))
            {
                result.Append(c);
            }

            return result.ToString();
        }
        //t
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2tfr(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (!vowels.Contains(c))
                {
                    new StringBuilder().Append(c);
                }
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2tLi(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (char c in from char c in str
                              where !vowels.Contains(c)
                              select c)
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2tLci(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels
            foreach (char c in str.Where(c => !vowels.Contains(c)))
            {
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2cfr(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                string vowels = "aeiouAEIOU"; // List of vowels
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2cLi(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in from char c in str
                              let vowels = "aeiouAEIOU"// List of vowels
                              where !vowels.Contains(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2ifr(string str)
        {
            StringBuilder result = new();
            // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (!"aeiouAEIOU".Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2iLi(string str)
        {
            StringBuilder result = new();
            foreach (char c in
            // List of vowels
            from char c in str
            where !"aeiouAEIOU".Contains(c)
            select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2iLci(string str)
        {
            StringBuilder result = new();
            foreach (char c in str.Where(c => !"aeiouAEIOU".Contains(c))
            // List of vowels
            )
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22vfr(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (!vowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22vLi(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels
            foreach (char c in from char c in str
                              where !vowels.Contains(c)
                              select c)
            {
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22vLci(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels
            foreach (char c in str.Where(c => !vowels.Contains(c)))
            {
                result.Append(c);
            }

            return result.ToString();
        }
        //if
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2rfr(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2nrfr(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2vrfr(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        //t
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2trfr(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (vowels.Contains(c))
                {
                    continue;
                }
                new StringBuilder().Append(c);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2crfr(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                string vowels = "aeiouAEIOU"; // List of vowels
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2crLi(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach ((char c, string vowels) in from char c in str
                                        let vowels = "aeiouAEIOU"// List of vowels
                                        select (c, vowels))
            {
                if (vowels.Contains(c))
                {
                    continue;
                }

                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2irfr(string str)
        {
            StringBuilder result = new();
            // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if ("aeiouAEIOU".Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22vrfr(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                if (vowels.Contains(c))
                {
                    continue;
                }
                result.Append(c);
            }

            return result.ToString();
        }
        //temporary char
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2ft(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                if (!vowels.Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2nft(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                if (!vowels.Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2vft(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                if (!vowels.Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        //t
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2tft(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                if (!vowels.Contains(str[i]))
                {
                    new StringBuilder().Append(str[i]);
                }
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2cft(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                string vowels = "aeiouAEIOU"; // List of vowels
                if (!vowels.Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        string S2cftt(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                // List of vowels
                if (!"aeiouAEIOU".Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2ift(string str)
        {
            StringBuilder result = new();
            // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                if (!"aeiouAEIOU".Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22vft(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                if (!vowels.Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        //if
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2rft(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2nrft(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2vrft(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        //t
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2trft(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    continue;
                }
                new StringBuilder().Append(str[i]);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2crft(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                string vowels = "aeiouAEIOU"; // List of vowels
                if (vowels.Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2crftt(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                // List of vowels
                if ("aeiouAEIOU".Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2irft(string str)
        {
            StringBuilder result = new();
            // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                if ("aeiouAEIOU".Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22vrft(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        //for reversed
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2fit(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!vowels.Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2nfrt(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!vowels.Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2vfrt(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!vowels.Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        //t
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2tfrt(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!vowels.Contains(str[i]))
                {
                    new StringBuilder().Append(str[i]);
                }
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2tfr2t(string str)
        {
            // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!"aeiouAEIOU".Contains(str[i]))
                {
                    new StringBuilder().Append(str[i]);
                }
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2cfrt(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                string vowels = "aeiouAEIOU"; // List of vowels
                if (!vowels.Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2cfr2t(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                // List of vowels
                if (!"aeiouAEIOU".Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2ifrt(string str)
        {
            StringBuilder result = new();
            // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!"aeiouAEIOU".Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22vfrt(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (!vowels.Contains(str[i]))
                {
                    result.Append(str[i]);
                }
            }

            return result.ToString();
        }
        //if
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2rfrt(string str)
        {
            StringBuilder result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (vowels.Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2nrfrt(string str)
        {
            StringBuilder result = new();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (vowels.Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2vrfrt(string str)
        {
            var result = new StringBuilder();
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (vowels.Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        //t
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2trfrt(string str)
        {
            string vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (vowels.Contains(str[i]))
                {
                    continue;
                }
                new StringBuilder().Append(str[i]);
            }

            return new StringBuilder().ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2crfrt(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                string vowels = "aeiouAEIOU"; // List of vowels
                if (vowels.Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2crfr2t(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                // List of vowels
                if ("aeiouAEIOU".Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S2irfrt(string str)
        {
            StringBuilder result = new();
            // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if ("aeiouAEIOU".Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        string S22vrfrt(string str)
        {
            var result = new StringBuilder();
            var vowels = "aeiouAEIOU"; // List of vowels

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (vowels.Contains(str[i]))
                {
                    continue;
                }
                result.Append(str[i]);
            }

            return result.ToString();
        }
        public IEnumerable<string> GetData()
        {
            yield return ("If Obama resigns from office NOW, thereby doing a great service to the country—I will give him free lifetime golf at any one of my courses!");
            yield return ("This election is a total sham and a travesty. We are not a democracy!");
            yield return ("I have never seen a thin person drinking Diet Coke.");
            yield return ("Everybody wants me to talk about Robert Pattinson and not Brian Williams—I guess people just don’t care about Brian!");
            yield return ("Katy, what the hell were you thinking when you married loser Russell Brand. There is a guy who has got nothing going, a waste!");
            yield return ("Windmills are the greatest threat in the US to both bald and golden eagles. Media claims fictional ‘global warming’ is worse.");
            yield return ("Sorry losers and haters, but my I.Q. is one of the highest -and you all know it! Please don’t feel so stupid or insecure,it’s not your fault");
            yield return ("Happy Thanksgiving to all--even the haters and losers!");
            yield return ("Watch Kasich squirm --- if he is not truthful in his negative ads I will sue him just for fun!");
            yield return ("Obama is, without question, the WORST EVER president. I predict he will now do something really bad and totally stupid to show manhood!");
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