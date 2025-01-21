//Create a function that returns the number of frames shown in a given number of minutes for a certain FPS.
using BenchmarkDotNet.Attributes;
using System;

namespace Challenges
{
    public class Program32
    {
        public static int Frames(int minutes, int fps) => fps * minutes * 60;
    }
    public class BenchmarkProgram32
    {
        [Benchmark]
        [Arguments(1, 1)]
        [Arguments(10, 1)]
        [Arguments(10, 25)]
        [Arguments(500, 60)]
        [Arguments(0, 60)]
        [Arguments(99, 1)]
        [Arguments(419, 70)]
        [Arguments(52, 33)]
        public int Frames(int minutes, int fps) => Program32.Frames(minutes, fps);
    }
}