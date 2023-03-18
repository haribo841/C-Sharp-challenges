using System;

namespace Challenges
{
    public class Fibonacci
    {
        public static int CalculateFibonacciNumber(int numberIndex) => numberIndex < 0
                ? throw new ArgumentException("Index cannot be negative.")
                : numberIndex is 0 or 1
                ? numberIndex
                : CalculateFibonacciNumber(numberIndex - 1) + CalculateFibonacciNumber(numberIndex - 2);

        public static List<int> GetFibonacciSequence(int maxNumberIndexInclusive)
        {
            List<int> result = new();

            for (int i = 0; i <= maxNumberIndexInclusive; ++i)
                result.Add(CalculateFibonacciNumber(i));

            return result;
        }
    }
}