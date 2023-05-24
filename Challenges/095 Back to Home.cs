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
            bool result = false;
            int x = 0;
            int y = 0;
            foreach (char c in d)
            {
                switch (c)
                {
                    case 'N':
                        x++;
                        break;
                    case 'W':
                        y--;
                        break;
                    case 'S':
                        x--;
                        break;
                    case 'E':
                        y++;
                        break;
                }
            }
            if (x == 0 && y == 0) { result = true; }
            return result;
        }
    }
}
