using System;
using Challenges.Edabit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests4
    {
        [Test]
        [TestCase(110, 3, 330, TestName = "{0} volts and 3 amperes should be {1} watts")]
        [TestCase(230, 10, 2300, TestName = "{0} volts and 3 amperes should be {1} watts")]
        [TestCase(480, 20, 9600, TestName = "{0} volts and 3 amperes should be {1} watts")]

        public void CircuitPower(int voltage, int current, int expectedResult)
        {
            int result = Program4.CircuitPower(voltage, current);
            Assert.That(result, Is.EqualTo(expectedResult));// Assert
        }
    }
}