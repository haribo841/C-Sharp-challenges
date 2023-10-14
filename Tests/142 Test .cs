using System;
using Challenges;
using NUnit.Framework;
using static Challenges.Program142;

namespace Tests
{
    [TestFixture]
    public class Test142
    {
        Random rand = new();

        static double Round(double number)
        {
            double factor = Math.Pow(10, 5);
            return Math.Round(number * factor) / factor;
        }
        [Test]
        [TestCase(20, 1256.63706, 125.66371)]
        [TestCase(2, 12.56637, 12.56637)]
        [TestCase(4.4, 60.82123, 27.64602)]
        [TestCase((int)Round(rand.Next(200)), 60.82123, 27.64602)]
        public static void TestIsFourLetters(double radius, double expectedArea, double expectedPerimeter)
        {
            // Arrange
            Circle circo = new Circle(radius);
            Random rand = new();
            int randomInt = (int)Round(rand.Next(200));
            // Act
            double resultArea = circo.GetArea(); // Use the GetArea method of the Circle class
            double resultPerimeter = circo.GetPerimeter(); // Use the GetArea method of the Circle class
            Assert.That(Round(resultArea), Is.EqualTo(expectedArea));
            Assert.That(Round(resultPerimeter), Is.EqualTo(expectedPerimeter));
        }
        public void TestCircle()
        {
            Circle circo = new Circle(20);
            var circo1 = new Circle(2);
            var circo2 = new Circle(4.4);
            Random rand = new();
            int randomInt = (int)Round(rand.Next(200));
            var circo3 = new Circle(randomInt);
            Assert.Multiple(() =>
            {
                Assert.That(Round(circo.GetArea()), Is.EqualTo(1256.63706));
                Assert.That(Round(circo.GetPerimeter()), Is.EqualTo(125.66371));
                Assert.That(Round(circo1.GetArea()), Is.EqualTo(12.56637));
                Assert.That(Round(circo1.GetPerimeter()), Is.EqualTo(12.56637));
                Assert.That(Round(circo2.GetArea()), Is.EqualTo(60.82123));
                Assert.That(Round(circo2.GetPerimeter()), Is.EqualTo(27.64602));
                Assert.That(Round(Math.PI * Math.Pow(randomInt, 2)), Is.EqualTo(Round(circo3.GetArea())));
                Assert.That(Round(2 * Math.PI * randomInt), Is.EqualTo(Round(circo3.GetPerimeter())));
            });
        }
    }
}