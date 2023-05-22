//When resistors are connected together in series, the same current passes through each resistor in the chain and the total resistance, RT, of the circuit must be equal to the sum of all the individual resistors added together.
//That is: RT = R1 + R2 + R3 ...
//Create a function that takes an array of values resistance that are connected in series, and calculates the total resistance of the circuit in ohms.
//The ohm is the standard unit of electrical resistance in the International System of Units ( SI ).
using System;
using System.Text;
using System.Linq;
namespace Challenges
{
    public class Program80
    {
        public static string SeriesResistance(double[] arr) => arr.Sum()<= 1 ? Math.Round(arr.Sum() , 1).ToString() + " ohm": Math.Round(arr.Sum(), 1).ToString()+" ohms";
    }
}
