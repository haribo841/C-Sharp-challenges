//Create a function that takes a number n and returns its length.
using BenchmarkDotNet.Attributes;
using System;
namespace Challenges
{
    public class Program59
    {
        public static int Length(int n)
        {
            int count = 0;
            do
            {
                count++;
                n /= 10; // Divide n by 10 to remove the last digit
            } while (n != 0);

            return count;
        }
    }
    public class BenchmarkProgram59
    {
        [Benchmark]
        [Arguments(12)]
        [Arguments(6000)]
        [Arguments(314)]
        public int Length(int n) => Program59.Length(n);
    }
}