//Create a function that takes an array as an argument and returns true or false
//depending on whether the average of all elements in the array is a whole number or not.
using System;
using System.Text;

namespace Challenges
{
    public class Program137
    {
        public static bool IsAvgWhole(int[] arr) => (arr.Sum() % arr.Length) == 0;
    }
}