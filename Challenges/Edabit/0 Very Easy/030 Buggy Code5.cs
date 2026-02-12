//Fix the code in the code tab to pass this challenge (only syntax errors).
using BenchmarkDotNet.Attributes;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenges
{
    public class Program30
    {
        public static List<int> PrintArray(int number)
        {
#pragma warning disable IDE0090 // Use 'new(...)'
            List<int> array = new List<int>();
#pragma warning restore IDE0090 // Use 'new(...)'

            for (int counter = 1; counter <= number; counter++)
            {
                array.Add(counter);
            }

            return array;
        }
    }
    public class BenchmarkProgram30
    {
        [Benchmark]
        [Arguments(1)]
        [Arguments(2)]
        [Arguments(6)]
        public List<int> PrintArray(int number) => Program30.PrintArray(number);
    }
}