//Create a function that takes in an array of numbers and returns the sum of its cubes.
using System;
using System.Text;
namespace Challenges
{
    public class Program85
    {
        public static int CubesSum(int[] nums_arr) => nums_arr.Sum(num => num * num * num);
    }
}
