//Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.
using System;
namespace Challenges
{
    public class Program102
    {
        public static double[] FindMinMax(double[] values)
        {
            double minValue = values.Min();
            double maxValue = values.Max();
            values = new double[2];
            values[0] = minValue;
            values[1] = maxValue;
            return values;
        }
    }
}