//Create a function that can turn JPY (Japanese yen) to USD (American dollar).
using System;
using System.Text;
namespace Challenges
{
    public static class Program91
    {
        public static double YenToUsd(int yen) => (double)(int)(yen / 107.5 * 100 + 0.5) / 100;
    }
}
