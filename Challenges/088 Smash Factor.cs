//Smash factor is a term in golf that relates to the amount of energy transferred from the club head to the golf ball.
//The formula for calculating smash factor is ball speed divided by club speed.
//Create a function that takes ball speed a and club speed b as arguments and returns the smash factor to the nearest hundredth.
using System;
using System.Text;
namespace Challenges
{
    public class Program88
    {
        public static double SmashFactor(double a, double b) => Math.Round(a / b, 2);
    }
}
