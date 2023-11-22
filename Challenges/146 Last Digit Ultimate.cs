//Create a function that takes 3 numbers: a, b, c and returns true if the last digit of a * b = the last digit of c.
using System;

namespace Challenges
{
    public class Program146
    {
        public static bool LastDig(int a, int b, int c) => a % 10 * b % 10 % 10 == c % 10;
    }
}
/*
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
        public bool F((int a, int b, int c) parameters) => parameters.a % 10 * parameters.b % 10 % 10 == parameters.c % 10;
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool FBody((int a, int b, int c) parameters)
        {
            return parameters.a % 10 * parameters.b % 10 % 10 == parameters.c % 10;
        }
        //Attempt 1
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool A((int a, int b, int c) parameters)
        {
            // Get the last digits as integers
            int A = int.Parse(parameters.a.ToString()[^1].ToString());
            int B = int.Parse(parameters.b.ToString()[^1].ToString());
            int C = int.Parse(parameters.c.ToString()[^1].ToString());

            // Check if the last digit of a * b equals the last digit of c
            return A * B % 10 == C;
        }
        //Attempt 2
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool B((int a, int b, int c) parameters)
        {
            int lastDigitA = parameters.a % 10;
            int lastDigitB = parameters.b % 10;
            int lastDigitC = parameters.c % 10;

            return lastDigitA * lastDigitB % 10 == lastDigitC;
        }
        //Attempt 3
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool Cbody((int a, int b, int c) parameters)
        {
            // Get the last digit of each number by converting to string
            char[] A = parameters.a.ToString().ToCharArray();
            char[] B = parameters.b.ToString().ToCharArray();
            char[] C = parameters.c.ToString().ToCharArray();
            // Convert the characters to integers before multiplication
            int lastDigitA = A[A.Length - 1] - '0';
            int lastDigitB = B[B.Length - 1] - '0';
            int lastDigitC = C[C.Length - 1] - '0';
            return lastDigitA * lastDigitB % 10 == lastDigitC;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool CbodyI((int a, int b, int c) parameters)
        {
            // Get the last digit of each number by converting to string
            char[] A = parameters.a.ToString().ToCharArray();
            char[] B = parameters.b.ToString().ToCharArray();
            char[] C = parameters.c.ToString().ToCharArray();
            // Convert the characters to integers before multiplication
            int lastDigitA = A[^1] - '0';
            int lastDigitB = B[^1] - '0';
            int lastDigitC = C[^1] - '0';
            return lastDigitA * lastDigitB % 10 == lastDigitC;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool Cbodys((int a, int b, int c) parameters)
        {
            // Get the last digit of each number by converting to string
            string A = parameters.a.ToString();
            string B = parameters.b.ToString();
            string C = parameters.c.ToString();
            // Convert the characters to integers before multiplication
            int lastDigitA = A[A.Length - 1] - '0';
            int lastDigitB = B[B.Length - 1] - '0';
            int lastDigitC = C[C.Length - 1] - '0';
            return lastDigitA * lastDigitB % 10 == lastDigitC;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool CbodysI((int a, int b, int c) parameters)
        {
            // Get the last digit of each number by converting to string
            string A = parameters.a.ToString();
            string B = parameters.b.ToString();
            string C = parameters.c.ToString();
            // Convert the characters to integers before multiplication
            int lastDigitA = A[^1] - '0';
            int lastDigitB = B[^1] - '0';
            int lastDigitC = C[^1] - '0';
            return lastDigitA * lastDigitB % 10 == lastDigitC;
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool C((int a, int b, int c) parameters) =>
            (parameters.a.ToString().ToCharArray()[^1] - '0') * (parameters.b.ToString().ToCharArray()[^1] - '0') % 10 == (parameters.c.ToString().ToCharArray()[^1] - '0');
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool CS((int a, int b, int c) parameters) =>
    (parameters.a.ToString()[^1] - '0') * (parameters.b.ToString()[^1] - '0') % 10 == (parameters.c.ToString()[^1] - '0');
        //Attempt 4
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool DBody((int a, int b, int c) parameters)
        {
            {
                // Get the last digit of each number without using modulo
                int lastDigitA = GetLastDigit(parameters.a);
                int lastDigitB = GetLastDigit(parameters.b);
                int lastDigitC = GetLastDigit(parameters.c);

                // Compare the last digits
                return (lastDigitA * lastDigitB) % 10 == lastDigitC;
            }

            static int GetLastDigit(int number)
            {
                return Math.Abs(number % 10);
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool DNested((int a, int b, int c) parameters)
        {
            {
                // Get the last digit of each number without using modulo
                int lastDigitA = GetLastDigit(parameters.a);
                int lastDigitB = GetLastDigit(parameters.b);
                int lastDigitC = GetLastDigit(parameters.c);

                // Compare the last digits
                return (lastDigitA * lastDigitB) % 10 == lastDigitC;
            }

            static int GetLastDigit(int number)=>Math.Abs(number % 10);
            
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool DTBody((int a, int b, int c) parameters)
        {
            {
                // Get the last digit of each number without using modulo

                // Compare the last digits
                return (GetLastDigit(parameters.a) * GetLastDigit(parameters.b)) % 10 == GetLastDigit(parameters.c);
            }

            static int GetLastDigit(int number)
            {
                return Math.Abs(number % 10);
            }
        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool DTemp((int a, int b, int c) parameters)
        {
            {
                // Get the last digit of each number without using modulo
                return GetLastDigit(parameters.a) * GetLastDigit(parameters.b) % 10 == GetLastDigit(parameters.c);
            }

            static int GetLastDigit(int number) => Math.Abs(number % 10);

        }
        [Benchmark]
        [ArgumentsSource(nameof(GetData))]
        public bool D((int a, int b, int c) parameters) => Math.Abs(parameters.a % 10) * Math.Abs(parameters.b % 10) % 10 == Math.Abs(parameters.c % 10);
        public IEnumerable<(int a, int b, int c)> GetData()
        {
            yield return (1, 1, 1);
            yield return (12, 15, 10);
            yield return (15228, 9209, 72162);
            yield return (15, 1, 1);
            yield return (123, 15, 10);
            yield return (5213, 99219, 6165);
            yield return (1523, 513, 512);
            yield return (-15, 1, 1);
            yield return (123, -15, 10);
            yield return (-12, 15, -10);
            yield return (15228, -9209, -72162);
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
 */