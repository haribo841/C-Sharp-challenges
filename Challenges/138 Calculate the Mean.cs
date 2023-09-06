//Create a function that takes an array of numbers and returns the mean (average) of all those numbers.
using System;

namespace Challenges
{
    public class Program138
    {
        public static double Mean(int[] arr) => Math.Round(arr.Average(), 2);
    }
}