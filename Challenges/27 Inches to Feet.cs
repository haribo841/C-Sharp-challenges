//Create a function that accepts a measurement value in inches and returns the equivalent of the measurement value in feet.
using System;
public class Program27
{
    public static int inchesToFeet(int inches) => inches < 12 ? 0 : inches / 12;
}
