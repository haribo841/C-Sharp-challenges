using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
	[TestFixture]
	public class Tests6
	{
		[Test]
		[TestCase(3, 2, 3, TestName = "base 3 with height 2 should give an area of 3")]
		[TestCase(5, 4, 10, TestName = "base 5 with height 4 should give an area of 10")]
		[TestCase(10, 10, 50, TestName = "base 10 with height 10 should give an area of 50")]
		[TestCase(0, 60, 0, TestName = "base 0 with height 60 should give an area of 0")]
		[TestCase(12, 11, 66, TestName = "base 12 with height 11 should give an area of 66")]
		public void triArea(int b, int h, int expectedResult)
		{
			// Arrange
            int triangleBase = b;
            int triangleHeight = h;
			// Act
            int result = Program6.triArea(triangleBase, triangleHeight);
			// Assert
            Assert.That(result, Is.EqualTo(expectedResult));
		}
	}
}