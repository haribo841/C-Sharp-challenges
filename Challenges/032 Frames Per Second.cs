//Create a function that returns the number of frames shown in a given number of minutes for a certain FPS.
using System;

namespace Challenges
{
    public class Program32
    {
        public static int Frames(int minutes, int fps) => fps * minutes * 60;
    }
}