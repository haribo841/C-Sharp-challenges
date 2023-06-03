//Create a function that takes an array of parallel resistance values, and calculates the total resistance of the circuit.
using System;
namespace Challenges
{
    public class Program115
    {
        public static double ParallelResistance(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                 sum += 1 / arr[i];
            }
            double Resistance_Total = 1/sum;
            return Math.Round(Resistance_Total, 1);
        }
    }
}
