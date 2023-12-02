using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests78
    {
        [Test]
        [TestCase(27, 59, "obtuse")]
        [TestCase(135, 11, "acute")]
        [TestCase(45, 45, "right")]
        [TestCase(45, 15, "obtuse")]
        [TestCase(31, 100, "acute")]
        [TestCase(35, 55, "right")]
        public void MissingAngle(int angle1, int angle2, string expectedResult)
        {
            string result = Program78.MissingAngle(angle1, angle2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}