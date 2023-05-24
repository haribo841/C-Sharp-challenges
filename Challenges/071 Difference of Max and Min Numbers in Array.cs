//Create a function that takes an array and returns the difference between the biggest and smallest numbers.
using System;
namespace Challenges
{
    public class Program71
    {
        public static int DifferenceMaxMin(int[] arr) => arr.Min() < 0 ? Math.Abs(arr.Min()) + arr.Max() : Math.Abs(arr.Min() - arr.Max());
    }
}
