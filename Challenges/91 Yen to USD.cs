//Create a function that can turn JPY (Japanese yen) to USD (American dollar).
using System;
using System.Text;
namespace Challenges
{
    public class Program91
    {
        public static double YenToUsd(int yen)=> Math.Round(yen / 107.5, 2);
    }
}
