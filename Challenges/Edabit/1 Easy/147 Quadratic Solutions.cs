//A quadratic equation a x^2 + b x + c = 0 has either 0, 1, or 2 distinct solutions for real values of x.
//Given a, b and c, you should return the number of solutions to the equation.
using System;

namespace Challenges
{
    public static class Program147
    {
        public static int Solutions(int a, int b, int c)
        {
            decimal discriminant = (decimal)b * b - 4m * a * c;
            if (discriminant < 0)
                return 0;
            return discriminant == 0 ? 1 : 2;
        }
    }
}
