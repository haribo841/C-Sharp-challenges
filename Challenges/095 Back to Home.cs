//You have started your journey from home.
//Given a string of directions (N=North, W=West, S=South, E=East), you will walk for one minute in each direction.
//Determine whether a set of directions will lead you back to the starting position or not.
using System;
using System.Linq.Expressions;
using System.Text;
namespace Challenges
{
    public class Program95
    {
        public static bool BackToHome(string d)
        {
            int x = 0;
            int y = 0;

            foreach (char direction in d)
            {
                (int dx, int dy) = direction switch
                {
                    'N' => (0, 1),
                    'S' => (0, -1),
                    'E' => (1, 0),
                    'W' => (-1, 0),
                    _ => (0, 0) // Handle invalid directions
                };

                x += dx;
                y += dy;
            }

            return x == 0 && y == 0;
        }
    }
}
