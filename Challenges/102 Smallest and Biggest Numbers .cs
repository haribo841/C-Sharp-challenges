//Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.
using System;
using System.Linq;
namespace Challenges
{
    public class Program102
    {
        public static double[] FindMinMax(double[] values)
        {
            if (values.Length == 0)
            {
                // Handle the case of an empty array
                return new double[] { double.NaN, double.NaN };
            }
            double minValue = values[0];
            double maxValue = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < minValue) minValue = values[i];
                else if (values[i] > maxValue) maxValue = values[i];
            }

            return new double[] { minValue, maxValue };
        }
    }
}