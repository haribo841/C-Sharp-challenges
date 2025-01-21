//Write a function that takes two numbers and returns if they should be added, subtracted, multiplied or divided to get 24.
//If none of the operations can give 24, return "none".
using BenchmarkDotNet.Attributes;

namespace Challenges
{
    public class Program63
    {
        public static string Operation(int num1, int num2) => 24 switch
        {
            int n when n == num1 + num2 => "added",
            int n when n == num1 - num2 => "subtracted",
            int n when n == num1 * num2 => "multiplied",
            int n when n == num1 / num2 => "divided",
            _ => "none"
        };
    }
    public class BenchmarkProgram63
    {
        [Benchmark]
        [Arguments(12, 12)]
        [Arguments(100, 76)]
        [Arguments(6, 4)]
        [Arguments(528, 22)]
        [Arguments(10, 12)]
        public string Operation(int A, int B) => Program63.Operation(A, B);
    }
}
