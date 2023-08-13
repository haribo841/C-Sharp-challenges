//When resistors are connected together in series, the same current passes through each resistor in the chain and the total resistance, RT, of the circuit must be equal to the sum of all the individual resistors added together.
//That is: RT = R1 + R2 + R3 ...
//Create a function that takes an array of values resistance that are connected in series, and calculates the total resistance of the circuit in ohms.
//The ohm is the standard unit of electrical resistance in the International System of Units ( SI ).
using System;
using System.Text;
using System.Linq;
using System.Globalization;

namespace Challenges
{
    public class Program80
    {
        public static string SeriesResistance(double[] arr)
        {
            double totalResistance = 0;
            foreach (double resistance in arr)
            {
                totalResistance += resistance;
            }

            if (Math.Abs(totalResistance - 1.0) < 1e-9)
            {
                return "1 ohm";
            }
            else
            {
                return totalResistance < 1.0
                    ? totalResistance.ToString("F1", CultureInfo.InvariantCulture) + " ohm"
                    : totalResistance == Math.Floor(totalResistance)
                                    ? totalResistance.ToString("F0", CultureInfo.InvariantCulture) + " ohms"
                                    : totalResistance.ToString("F1", CultureInfo.InvariantCulture) + " ohms";
            }
        }
    }
}