using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
	public class Tests13
	{
		[Test]
		[TestCase(2, 7200, TestName = "2 hours are equal to 7200 seconds")]
		[TestCase(10, 36000, TestName = "10 hours are equal to 36000 seconds")]
		[TestCase(24, 86400, TestName = "24 hours are equal to 86400 seconds")]
		[TestCase(36, 129600, TestName = "36 hours are equal to 129600 seconds")]
		public void FixedTest(int hours, int expectedResult)
		{
            int result =  Program13.HowManySeconds(hours);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
	}
}