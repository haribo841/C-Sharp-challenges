//Write a function to reverse an array.
using System;
using System.Text;
namespace Challenges
{
    public class Program81
    {
        public static int[] Reverse(int[] arr) => Enumerable.Range(0, arr.Length).Select(index => arr[arr.Length - index-1]).ToArray();
    }
}
