//Create a function that takes three arguments prob, prize, pay and returns true if prob * prize > pay; otherwise return false.
using System;
public class Program33
{
    public static bool ProfitableGamble(double prob, int prize, double pay) => prob * prize > pay?true:false;
}