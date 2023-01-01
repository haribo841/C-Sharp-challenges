using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
namespace VeryEasy.Tests
{
	[TestFixture]
	public class Tests4
	{
		[Test]
		[TestCase(110, 3, 330, TestName = "110 volts and 3 amperes should be 330 watts")]
		[TestCase(230, 10, 2300, TestName = "230 volts and 10 amperes should be 2300 watts")]
		[TestCase(480, 20, 9600, TestName = "480 volts and 20 amperes should be 9600 watts")]

		public void CircuitPower(int voltage, int current, int expectedResult)
		{
            int result = Program4.CircuitPower(voltage, current);
            Assert.That(result, Is.EqualTo(expectedResult));// Assert
        }
	}
}