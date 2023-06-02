//Create a function that takes an array of hurdle heights and a jumper's jump height, and determine whether or not the hurdler can clear all the hurdles.
//A hurdler can clear a hurdle if their jump height is greater than or equal to the hurdle height.
using System;
namespace Challenges
{
    public class Program99
    {
        public static bool HurdleJump(int[] hurdles, int jumpHeight)
        {
            foreach (int i in hurdles)
            {
                if (i > jumpHeight) return false;
            }
            return true;
        }
    }
}
