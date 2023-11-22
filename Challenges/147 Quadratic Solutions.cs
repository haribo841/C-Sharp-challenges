//A quadratic equation a x^2 + b x + c = 0 has either 0, 1, or 2 distinct solutions for real values of x.
//Given a, b and c, you should return the number of solutions to the equation.
using System;

namespace Challenges
{
    public class Program147
    {
        public static int Solutions(int a, int b, int c) => b * b - 4 * a * c < 0 ? 0 : b * b - 4 * a * c == 0 ? 1 : 2;
    }
}
/*=> b * b - 4 * a * c < 0 ? 0 : b * b - 4 * a * c == 0 ? 1 : 2;
 * 
 *         {
            int delta = b * b - 4 * a * c;
            //double x1 = -b + Math.Sqrt(delta) / 2 * a;
            //double x2 = -b - Math.Sqrt(delta) / 2 * a;
            return delta < 0 ? 0 : delta == 0 ? 1 : 2;//|| x1 == x2 ? 1 : 2;
        } 
*
*    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            return 2; // Two real solutions
        }
        else if (discriminant == 0)
        {
            return 1; // One real solution
        }
        else
        {
            return 0; // No real solutions
        }
    }
*/