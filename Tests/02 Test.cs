using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
	[TestFixture]
	public class Tests2
	{
		[Test]
		[TestCase(6, 360, TestName = "6 minutes should be converted to 360 seconds")]
		[TestCase(4, 240, TestName = "4 minutes should be converted to 240 seconds")]
		[TestCase(8, 480, TestName = "8 minutes should be converted to 480 seconds")]
		[TestCase(60, 3600, TestName = "60 minutes should be converted to 3600 seconds")]
		public void FixedTest(int a, int expectedResult)
		{
            int minutes = a;// Arrange
            int result = Program2.convert(minutes);// Act
            Assert.That(result, Is.EqualTo(expectedResult));// Assert
        }
	}
}