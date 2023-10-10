using System;
using Challenges;
using NUnit.Framework;
using static Challenges.Program142;

namespace Tests
{
    [TestFixture]
    public class Test142
    {
        static double Round(double number)
        {
            double factor = Math.Pow(10, 5);
            return Math.Round(number * factor) / factor;
        }
        [Test]
        public void TestCircle()
        {
            var circo = new Circle(20);
            var circo1 = new Circle(2);
            var circo2 = new Circle(4.4);
            Random rand = new Random();
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