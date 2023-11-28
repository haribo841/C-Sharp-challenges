//Create a function that takes an array of numbers and returns an array where each number is the sum of itself + all previous numbers in the array.
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Challenges
{
    public class Program163
    {
        public static double[] CumulativeSum(double[] arr)
        {
            if (arr.Length == 0)
            {
                return new double[0];
            }

            double[] cumulative = new double[arr.Length];
            cumulative[0] = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                cumulative[i] = cumulative[i - 1] + arr[i];
            }

            return cumulative;
        }
    }
}
/*          {
            if (arr == null || arr.Length == 0)
            {
                return new double[0];
            }

            double[] runningTotal = arr.Aggregate(
                new List<double>(),
                (a, i) =>
                {
                    if (a.Count == 0)
                    {
                        a.Add(i);
                    }
                    else
                    {
                        double sum = a.Last() + i;
                        a.Add(sum);
                    }
                    return a;
                }
            ).ToArray();

            return runningTotal;
        }
 *  
 *          => (arr.Aggregate(
                new {sum=Enumerable.Empty<double>(), last = 0.0d},
                (a, c) => new {
                    sum = a.sum.Concat(Enumerable.Repeat(a.last+c,1)),
                    last = a.last + c
},
                a => a.sum
            ).ToArray());
    }
 *  
 *  {
            if (arr.Length == 0)
            {
                return new double[0]; // Return an empty array if the input is empty
            }

            return arr.Select((x, i) => arr.Take(i + 1).Sum()).ToArray();
        }
 * 
 *         {
            double[] cumulativeSums = new double[arr.Length];
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                cumulativeSums[i] = sum;
            }

            return cumulativeSums;
        }
 * 
 *         {
            if (arr.Length == 0 ) return arr;
            for (int i = 1; i <= arr.Length - 1; i++) {
                arr[i] += arr[i-1];
            }
            return arr;
        }
*
        {
            var cumulative = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                cumulative[i] = arr[i] + (i == 0 ? 0 : cumulative[i - 1]);

            return cumulative;
        }
 */