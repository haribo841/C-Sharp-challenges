//A quadratic equation a x^2 + b x + c = 0 has either 0, 1, or 2 distinct solutions for real values of x.
//Given a, b and c, you should return the number of solutions to the equation.
using System;

namespace Challenges
{
    public class Program147
    {
        public static int Solutions(int a, int b, int c)
        {
            double delta = b * b - 4 * a * c;
            double x1 = -b + Math.Sqrt(delta) / 2 * a;
            double x2 = -b - Math.Sqrt(delta) / 2 * a;
            return delta < 0 ? 0 : delta == 0 || x1 == x2 ? 1 : 2;
        }
    }
}