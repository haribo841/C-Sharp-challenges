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
    }//BenchmarkConfig

    public static class EntryPoint
    {
        public static void Main(string[] args)
        {
            // BenchmarkRunner.Run<BenchmarkProgramNumber>(new CustomConfig());
            BenchmarkRunner.Run<BenchmarkProgram21>(new CustomConfig());
        }
    }
}