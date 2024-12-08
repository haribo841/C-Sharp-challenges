//Create a function that takes a number n and returns its length.
using System;
namespace Challenges
{
    public class Program59
    {
        public static int Length(int n) => (int)Math.Floor(Math.Log10(n)) + 1;
    }
}