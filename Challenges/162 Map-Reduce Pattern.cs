//You will be implementing a basic case of the map-reduce pattern in programming.
//Given a vector stored as an array of numbers, find the magnitude of the vector.
//Use the standard distance formula for n-dimensional Cartesian coordinates.
using System;
using System.Numerics;
using System.Runtime.Intrinsics;

namespace Challenges
{
    public class Program162
    {
        public static double Magnitude(int[] arr)// => Math.Sqrt(arr.Sum(num => num * num));
                                                 //Math.Sqrt(arr.Select(num => num * num).Sum());
        {
            double squaredSum = arr
                .Select(x => Math.Pow(x, 2))
                .Sum();

            double magnitude = Math.Sqrt(squaredSum);
            return magnitude;
        }
    }
}
/*        {
            if (arr.Length == 0)
                return 0;

            Func<int, int> square = x => x * x;

            List<TResult> Map<T, TResult>(IEnumerable<T> source, Func<T, TResult> selector)
            {
                var result = new List<TResult>();
                foreach (var item in source)
                {
                    result.Add(selector(item));
                }
                return result;
            }

            TResult Reduce<T, TResult>(IEnumerable<T> source, Func<TResult, T, TResult> func, TResult seed)
            {
                TResult result = seed;

                foreach (var item in source)
                {
                    result = func(result, item);
                }

                return result;
            }

            var squaredValues = Map(arr, square);
            var sumOfSquaredValues = Reduce(squaredValues, (acc, val) => acc + val, 0);

            return Math.Sqrt(sumOfSquaredValues);
        }
 * 
 * {
            if (arr.Length == 0)
                return 0;

            Func<int, int> square = x => x * x;

            List<TResult> Map<T, TResult>(IEnumerable<T> source, Func<T, TResult> selector)
            {
                var result = new List<TResult>();
                foreach (var item in source)
                {
                    result.Add(selector(item));
                }
                return result;
            }

            TResult Reduce<T, TResult>(IEnumerable<T> source, Func<TResult, T, TResult> func, TResult seed)
            {
                TResult result = seed;

                foreach (var item in source)
                {
                    result = func(result, item);
                }

                return result;
            }

            var squaredValues = Map(arr, square);
            var sumOfSquaredValues = Reduce(squaredValues, (acc, val) => acc + val, 0);

            return Math.Sqrt(sumOfSquaredValues);
        }
 * 
 *         {
            double squaredSum = arr
                .Select(x => Math.Pow(x, 2))
                .Sum();

            double magnitude = Math.Sqrt(squaredSum);
            return magnitude;
        }
 * 
 *         {
            if (arr.Length == 0)
                return 0;

            double squaredSum = arr.AsParallel()
                                      .Select(x => x * x)
                                      .Sum();

            return Math.Sqrt(squaredSum);
        }
 * 
 *         {
            if (arr.Length == 0)
            {
                return 0;
            }

            double sumOfSquares = arr.Select(x => x * (double)x).Sum();
            double magnitude = Math.Sqrt(sumOfSquares);
            return magnitude;
        }
 */