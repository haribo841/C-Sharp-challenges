//Given a string, return true if its length is even or false if the length is odd.
using BenchmarkDotNet.Attributes;

namespace Challenges
{
    public class Program46
    {
        public static bool OddOrEven(string word) => word.Length % 2 == 0;
    }
    public class BenchmarkProgram46
    {
        [Benchmark]
        [Arguments("apples")]
        [Arguments("banana")]
        [Arguments("cherry")]
        [Arguments("mango")]
        [Arguments("peach")]
        [Arguments("pears")]
        public bool OddOrEven(string word) => Program46.OddOrEven(word);
    }
}