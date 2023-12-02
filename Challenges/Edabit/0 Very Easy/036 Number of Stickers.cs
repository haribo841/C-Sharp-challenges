//Given a Rubik's Cube with a side length of n, return the number of individual stickers that are needed to cover the whole cube.
using System;

namespace Challenges
{
    public class Program36
    {
        public static int HowManyStickers(int n) => 6 * n * n;
    }
}