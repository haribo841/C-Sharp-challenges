//Create a function that takes the age in years and returns the age in days.
using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
	[TestFixture]
	public class Tests5
	{
		[Test]
		[TestCase(10, 3650, TestName = "10 years should be converted to 3650 days")]
		[TestCase(0, 0, TestName = "0 years should be converted to 0 days")]
		[TestCase(73, 26645, TestName = "73 years should be converted to 26645 days")]
		public void CalcAge(int age, int expectedResult)
		{
            int result = Program5.CalcAge(age);
            Assert.That(result, Is.EqualTo(expectedResult));// Assert
        }
	}
}