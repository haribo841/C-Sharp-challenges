//You will be implementing a basic case of the map-reduce pattern in programming.
//Given a vector stored as an array of numbers, find the magnitude of the vector.
//Use the standard distance formula for n-dimensional Cartesian coordinates.
using System;

namespace Challenges
{
    public class Program162
    {
        public static double Magnitude(int[] arr) => Math.Sqrt(arr.Sum(num => num * num));
    }
}