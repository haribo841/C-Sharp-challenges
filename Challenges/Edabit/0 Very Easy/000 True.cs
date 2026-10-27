using BenchmarkDotNet.Attributes;
using System;
using System.Runtime.CompilerServices;
namespace Challenges
{
    public static class Program
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ReturnTrue() => AlwaysTrue;
        public static bool AlwaysTrue => true;
        public static readonly bool trueField = true;
        public const bool TrueConst = true;
    }
    public class BenchmarkProgram
    {
        [Benchmark]
        public bool MethodCall() => Program.ReturnTrue();

        [Benchmark]
        public bool PropertyAccess() => Program.AlwaysTrue;

        [Benchmark]
        public bool FieldAccess() => Program.trueField;

        [Benchmark]
        public bool ConstantAccess() => Program.TrueConst;
    }
}
