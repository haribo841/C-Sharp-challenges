//Write a function that recursively finds the sum of the first n natural numbers.
using System;

namespace Challenges
{
    public class Program123
    {
        public static int Sum(int n) => n == 0 ? 0 : n + Sum(--n);
    }
}