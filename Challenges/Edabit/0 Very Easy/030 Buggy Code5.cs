//An int boolean is the same as a normal boolean, just 1 = true and 0 = false.
//Make a function that returns an int boolean opposite of an int boolean given (flip the int boolean).
using BenchmarkDotNet.Attributes;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Challenges
{
    public class Program30
    {
        public static List<int> PrintArray(int number)
        {
            List<int> array = new List<int>();

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