//Create a function that takes a whole number as input and returns the shape with that number's amount of sides.
//Here are the expected outputs to get from these inputs.
using System;

namespace Challenges
{
    public class Program118
    {
        public static string NSidedShape(int n) => n switch
        {
            int i when i == 1 => "circle",
            int i when i == 2 => "semi-circle",
            int i when i == 3 => "triangle",
            int i when i == 4 => "square",
            int i when i == 5 => "pentagon",
            int i when i == 6 => "hexagon",
            int i when i == 7 => "heptagon",
            int i when i == 8 => "octagon",
            int i when i == 9 => "nonagon",
            int i when i == 10 => "decagon",
            _ => "none"
        };
    }
}