//Create a function that returns the number of frames shown in a given number of minutes for a certain FPS.
using System;
public class Program32
{
    public static int Frames(int minutes, int fps) => minutes != 0 ? fps * minutes * 60:0;
}