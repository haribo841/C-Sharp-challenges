//Your task is to create a Circle constructor that creates a circle with a radius provided by an argument.
//The circles constructed must have two getters GetArea() (PI*r^2) and GetPerimeter() (2*PI*r)
//which give both respective areas and perimeter (circumference).
using System;

namespace Challenges
{
    public class Program142
    {
        class Rectangle
        {
            public double SideA;
            public double SideB;
            public Rectangle(double sideA, double sideB)
            {
                SideA = sideA;
                SideB = sideB;
            }
            public double GetArea()
            {
                return SideA * SideB;
            }
            public double GetPerimeter()
            {
                return (SideA + SideB) * 2;
            }
        }


        public class Circle
        {
            public double Radius;

            // Constructor to initialize the radius
            public Circle(double radius)
            {
                Radius = radius;
            }

            // Getter for calculating the area of the circle (PI * r^2)
            public double GetArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }

            // Getter for calculating the perimeter (circumference) of the circle (2 * PI * r)
            public double GetPerimeter()
            {
                return 2 * Math.PI * Radius;
            }
        }

        //unquote and use run to test these cases
        //public class Program{
        //  public static void Main(int[] args){
        //    var q = new Circle(4.44);
        //    Console.WriteLine(q.GetArea());
        //    Console.WriteLine(q.GetPerimeter());
        //  }
        //}
    }
}