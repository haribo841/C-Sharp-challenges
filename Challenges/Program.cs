using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Loggers;
using Challenges;
namespace Benchmark
{
    public class SingleParameterBenchmark<T>
    {
        [ParamsSource(nameof(SingleParams))]
        public T Input1 { get; set; }
        public static IEnumerable<T> SingleParams => typeof(T) switch
        {
            var t when t == typeof(int) => (IEnumerable<T>)(object)new[]
            { 3, 0, 7, 12, 6474, 563, 3, 301, -3, -0, -7, -12, -563, -6474, -301 },
            var t when t == typeof(string) => (IEnumerable<T>)(object)new[]
            {
                "dudes",
                "flowers",
                "checks",
                "varies",
                "efforts",
                "mood",
                "whiteboard",
                "cow",
                "word",
                "love"
            },
            var t when t == typeof(double) => (IEnumerable<T>)(object)new[] { -4.5, 212.1, -125.2, 932123.4 },
            var t when t == typeof(char) => (IEnumerable<T>)(object)new[]
            { 'E', 'd', 'a', 'b', 'i', 't', '.', ' ', '1' },
            var t when t == typeof(object) => (IEnumerable<T>)(object)new[]
            {
                new object[] { "Cat", "Dog", "Duck" },
                new object[] { 1, 2, 3 },
                new object[] { null },
                new object[] { true, false, false, true },
                new object[] { 7, "String", false, null, null },
                new object[] { null },
                new object[] { false },
                new object[] { null, null, null },
                new object[] { 1, 2, 3, 56, 87, 23, 65, 45 },
                new object[] { "Apple", "Orange", null },
                new object[] { true, false, "Apple" },
                new object[] { 1 }
            },
            _ => throw new NotSupportedException($"Type {typeof(T)} is not supported for parameters.")
        };

        [Benchmark]
        public T Base()//Output type => parameter type
        {
            return typeof(T) switch
            {
                var t when t == typeof(int) => (T)(object)Program58.CharToASCII((char)(object)Input1),
                var t when t == typeof(bool) => (T)(object)Program62.IsPlural((string)(object)Input1),
                var t when t == typeof(string) => (T)(object)(Input1),//useless
                var t when t == typeof(double) => (T)(object)(-(double)(object)Input1),
                var t when t == typeof(char) => (T)(object)(char)Program58.CharToASCII((char)(object)Input1),
                var t when t == typeof(object) => (T)(object)Program61.GetLastItem((object[])(object)Input1),
                _ => throw new NotSupportedException($"Type {typeof(T)} is not supported for output.")
            };
        }
    }
    public class PairParameterBenchmark<T>//Both parameters are the same type
    {
        [ParamsSource(nameof(PairParams))]
        public (T Input1, T Input2) Parameters { get; set; }

        public T Input1 => Parameters.Input1;
        public T Input2 => Parameters.Input2;

        public static IEnumerable<(T, T)> PairParams => typeof(T) switch
        {
            var t when t == typeof(int) => (IEnumerable<(T, T)>)(object)new[]
            { (6, 2), (-6, -9), (6, -2), (0, 0), (100, 1), (-0, 0), (0, 0), (-80, -5000), (6, -999), (-1, 2), (0, 2) },
            var t when t == typeof(bool) => (IEnumerable<(T, T)>)(object)new[] { (true, false), (false, true), (true, true), (false, false) },
            var t when t == typeof(string) => (IEnumerable<(T, T)>)(object)new[] { ("apple", "banana"), ("cherry", "date") },
            _ => throw new NotSupportedException($"Type {typeof(T)} is not supported.")
        };

        [Benchmark]//Output type => parameters type
        public T Base() => typeof(T) switch
        {
            var t when t == typeof(int) => (T)(object)((int)(object)Input1 + (int)(object)Input2),
            var t when t == typeof(bool) => (T)(object)Program48.ShouldServeDrinks((int)(object)Input1, (bool)(object)Input2),
            var t when t == typeof(string) => (T)(object)((string)(object)Input1 + (string)(object)Input2),
            _ => throw new NotSupportedException($"Type {typeof(T)} is not supported.")
        };
    }
    public class PairParameterBenchmarkWithMixedTypes
    {
        [ParamsSource(nameof(PairParams))]
        public (int Input1, bool Input2) Parameters { get; set; }

        public int Input1 => Parameters.Input1;
        public bool Input2 => Parameters.Input2;

        public static IEnumerable<(int, bool)> PairParams => new[]
        {
            (17, true),
            (30, true),
            (24, false),
            (18, false),
            (16, false),
            (18, true),
            (17, false)
        };

        [Benchmark]
        public bool Base()
        {
            return Program48.ShouldServeDrinks(Input1, Input2);
        }
    }
    public class ThreeParameterBenchmark<T>
    {

        [ParamsSource(nameof(TripleParams))]
        public (T Input1, T Input2, T Input3) Parameters { get; set; }

        public T Input1 => Parameters.Input1;
        public T Input2 => Parameters.Input2;

        public T Input3 => Parameters.Input3;
        public static IEnumerable<(T, T, T)> TripleParams => typeof(T) switch
        {
            var t when t == typeof(int) => (IEnumerable<(T, T, T)>)(object)new[]
        {
            (8, 3, 2),
            (8, 3, 3),
            (24, 12, 2),
            (5, 6, 1),
            (5, 0, 100),
            (15, 2, 7),
            (15, 2, 8) },
            _ => throw new NotSupportedException($"Input type {typeof(T)} is not supported.")
        };

        [Benchmark]//Output type => parameters type
        public T Base() => typeof(T) switch
        {
            var t when t == typeof(bool) => (T)(object)Program60.EqualSlices((int)(object)Input1, (int)(object)Input2, (int)(object)Input3),
            var t when t == typeof(int) => (T)(object)((int)(object)Input1 + (int)(object)Input2 + (int)(object)Input3), // Example logic for int
            _ => throw new NotSupportedException($"Output type {typeof(T)} is not supported.")
        };
    }
    public class CustomConfig : ManualConfig
    {
        public CustomConfig()
        {
            AddColumnProvider(DefaultColumnProviders.Instance);
            AddDiagnoser(MemoryDiagnoser.Default);
            AddColumn(RankColumn.Arabic);
            AddColumn(StatisticColumn.Median);
            AddLogger(ConsoleLogger.Default);
            AddExporter(MarkdownExporter.Default);
            AddExporter(HtmlExporter.Default);
        }
    }

    public static class EntryPoint
    {
        public static void Main(string[] args)
        {
            //insert input type in <>
            //BenchmarkRunner.Run<SingleParameterBenchmark<string>>(new CustomConfig());
            //BenchmarkRunner.Run<PairParameterBenchmark<string>>(new CustomConfig());
            // Running a mixed-type benchmark (int, bool)
            //BenchmarkRunner.Run<PairParameterBenchmarkWithMixedTypes>(new CustomConfig());
            //BenchmarkRunner.Run<ThreeParameterBenchmark<int>>(new CustomConfig());
            Console.WriteLine(A2401.DayOnePartTwo("../../../../Challenges/Advent of Code/2024/test.txt"));
            Console.WriteLine(A2401.DayOnePartTwo("../../../../Challenges/Advent of Code/2024/input.txt"));
        }
    }
}

