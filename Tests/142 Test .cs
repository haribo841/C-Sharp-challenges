using System;
using Challenges;
using NUnit.Framework;
using static Challenges.Program142;

namespace Tests
{
    [TestFixture]
    public class Test1142
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

            Assert.AreEqual(1256.63706, Round(circo.GetArea()));
            Assert.AreEqual(125.66371, Round(circo.GetPerimeter()));
            Assert.AreEqual(12.56637, Round(circo1.GetArea()));
            Assert.AreEqual(12.56637, Round(circo1.GetPerimeter()));
            Assert.AreEqual(60.82123, Round(circo2.GetArea()));
            Assert.AreEqual(27.64602, Round(circo2.GetPerimeter()));
            Assert.AreEqual(Round(circo3.GetArea()), Round(Math.PI * Math.Pow(randomInt, 2)));
            Assert.AreEqual(Round(circo3.GetPerimeter()), Round(2 * Math.PI * randomInt));
        }
    }
}