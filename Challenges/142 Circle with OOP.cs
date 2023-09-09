//Create a function that takes two integers and checks if they are equal.
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
            //put code here
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