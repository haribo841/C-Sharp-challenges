//Create a function that returns how many possible arrangements can come from a certain number of switches (on / off).
//In other words, for a given number of switches, how many different patterns of on and off can we have?
using System;
namespace Challenges
{
    public class Program75
    {
        public static int PosCom(int n) => (int)Math.Pow(2, n);
    }
}