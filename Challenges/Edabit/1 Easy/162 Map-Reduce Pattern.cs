//You will be implementing a basic case of the map-reduce pattern in programming.
//Given a vector stored as an array of numbers, find the magnitude of the vector.
//Use the standard distance formula for n-dimensional Cartesian coordinates.
using System;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace Challenges
{
    public static class Program162
    {
        public static double Magnitude(int[] arr)

        {
            double squaredSum = arr
                .Select(x => Math.Pow(x, 2))
                .Sum();

            double magnitude = Math.Sqrt(squaredSum);
            return magnitude;
        }
    }
}
