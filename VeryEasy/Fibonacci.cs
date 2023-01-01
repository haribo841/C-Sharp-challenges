using System;
namespace VeryEasy
{
	public class Fibonacci
	{
        public static int CalculateFibonacciNumber(int numberIndex)
        {
            if (numberIndex < 0)
            {
                throw new ArgumentException("Index cannot be negative.");
            }

            if (numberIndex == 0 || numberIndex == 1)
            {
                return numberIndex;
            }

            return CalculateFibonacciNumber(numberIndex - 1) + CalculateFibonacciNumber(numberIndex - 2);
        }

        public static List<int> GetFibonacciSequence(int maxNumberIndexInclusive)
        {
            List<int> result = new List<int>();

            for (int i = 0; i <= maxNumberIndexInclusive; ++i)
            {
                result.Add(CalculateFibonacciNumber(i));
            }

            return result;
        }
    }
}