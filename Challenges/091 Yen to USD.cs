//Create a function that can turn JPY (Japanese yen) to USD (American dollar).
using System;
using System.Text;
namespace Challenges
{
    public class Program91
    {
        public static double YenToUsd(int yen) => (double)((int)(yen / 107.5 * 100 + 0.5)) / 100;
    }
}
// => Math.Round(yen * 0.00930232558, 2);
// => (yen * 100 / 10750.0);
// => yen * 0.00930232558;
// => (double)(yen * 0.00930232558);
/*
{
    const double ConversionFactor = 0.00930232558;
    return yen * ConversionFactor;
}
*/
