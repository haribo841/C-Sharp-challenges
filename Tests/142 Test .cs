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
        [TestCase( 20, 1256.63706, 125.66371)]
        [TestCase(2, 12.56637, 12.56637)]
        [TestCase(4.4, 60.82123, 27.64602)]
        [TestCaseSource(nameof(RandomTestCasesSource))]
        public static void TestCircle(double radius, double expectedArea, double expectedPerimeter)
        {
            // Arrange
            Circle circo = new(radius);
            // Act
            double resultArea = circo.GetArea();
            double resultPerimeter = circo.GetPerimeter();
            Assert.Multiple(() =>
            {
                // Assert
                Assert.That(Round(resultArea), Is.EqualTo(expectedArea));
                Assert.That(Round(resultPerimeter), Is.EqualTo(expectedPerimeter));
            });
        }
        // Define a method to provide the random test case
        private static IEnumerable<TestCaseData> RandomTestCasesSource()
        {
            int randomInt = (int)Round(TestContext.CurrentContext.Random.Next(200));
            double expectedArea = Round(Math.PI * Math.Pow(randomInt, 2));
            double expectedPerimeter = Round(2 * Math.PI * randomInt);
            yield return new TestCaseData(randomInt, expectedArea, expectedPerimeter);
        }
    }
}