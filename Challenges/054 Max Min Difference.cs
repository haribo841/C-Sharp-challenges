//Given an array of integers, return the difference between the largest and smallest integers in the array.
using System;
using System.Linq;
namespace Challenges
{
	public class Program54
	{
        public static int Diff(int[] arr) => (arr.Max() >= 0 && arr.Min() >= 0)  ? Math.Abs(arr.Max()) - Math.Abs(arr.Min()) : Math.Abs(arr.Max()) + Math.Abs(arr.Min());
	}
}