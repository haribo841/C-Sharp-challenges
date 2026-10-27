//Given an array of numbers, write a function that returns an array that...
//Has all duplicate elements removed.
//Is sorted from least value to greatest value.
using System;
using System.Linq;

namespace Challenges
{
    public static class Program158
    {
        public static double[] UniqueSort(double[] arr)
        {
            return arr.Distinct().OrderBy(number => number).ToArray();
        }
    }
}
