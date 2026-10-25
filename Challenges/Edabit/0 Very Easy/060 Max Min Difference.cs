using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    public class Program60
    {
        public static int Diff(int[] arr)
        {
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                if (num > max) max = num;
                if (num < min) min = num;
            }
            return max - min;
        }

        public static int DiffOptimized(int[] arr)
        {
            int len = arr.Length;
            int min = arr[0];
            int max = min;
            int i = 1;
            // process pairs
            for (; i + 1 < len; i += 2)
            {
                int v1 = arr[i];
                int v2 = arr[i + 1];

                if (v1 < min) min = v1;
                else if (v1 > max) max = v1;

                if (v2 < min) min = v2;
                else if (v2 > max) max = v2;
            }

            // handle leftover
            for (; i < len; i++)
            {
                int v = arr[i];
                if (v < min) min = v;
                else if (v > max) max = v;
            }
            return max - min;
        }

        // New compact optimized implementation (pairwise local min/max)
        public static int DiffOptimizedCompact(int[] arr)
        {
            int n = arr.Length;
            int min = arr[0], max = arr[0];
            int i = 1;
            for (; i + 1 < n; i += 2)
            {
                int a = arr[i], b = arr[i + 1];
                int localMin = a < b ? a : b;
                int localMax = a < b ? b : a;
                if (localMin < min) min = localMin;
                if (localMax > max) max = localMax;
            }

            if (i < n)
            {
                int v = arr[i];
                if (v < min) min = v;
                else if (v > max) max = v;
            }

            return max - min;
        }
    }

    [MemoryDiagnoser]
    public class BenchmarkProgram60
    {
        // Supply the same test inputs to both benchmarks.
        public static IEnumerable<int[]> TestInputs()
        {
            yield return new int[] { -9, -8, 6, -9, 15, 6 };
            yield return new int[] { -5, 6, 18, 4, 16, -2 };
            yield return new int[] { -2, 20, -9, -9, -2, -7 };
            yield return new int[] { 4, -2, 11, -9, 15, 2 };
            yield return new int[] { 15, 10, 3, -6, 6, 19 };
            yield return new int[] { 1, 7, 18, -1, -2, 9 };
            yield return new int[] { 5, 1, -9, 7, -8, -10 };
            yield return new int[] { 5, 1, -9, 7, -8, -10 };
            yield return new int[] { 4, 17, 12, 2, 10, 2 };
        }

        // Baseline: original implementation
        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(TestInputs))]
        public int DiffOptimized(int[] arr) => Program60.DiffOptimized(arr);

        // New benchmark: compact optimized implementation
        [Benchmark]
        [ArgumentsSource(nameof(TestInputs))]
        public int DiffOptimizedCompact(int[] arr) => Program60.DiffOptimizedCompact(arr);
        [Benchmark]
        [ArgumentsSource(nameof(TestInputs))]
        public int Diff(int[] arr) => Program60.Diff(arr);
    }
}
