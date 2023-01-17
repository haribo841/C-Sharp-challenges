using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Tests16
    {
        [Test]
        [TestCase("Mubashir", "MubashirEdabit")]
        [TestCase("Matt", "MattEdabit")]
        [TestCase("C#", "C#Edabit")]
        [TestCase("Airforce", "AirforceEdabit")]
        public void FixedTest(string a, string expectedResult) {
            Console.WriteLine($"Input: {a}");
            string result = Program16.nameString(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}