using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
	[TestFixture]
	public class Tests19
	{
		[Test]
		[TestCase(6, 7, 26, TestName = "length of {0} and width {1} will give perimeter of {2}")]
		[TestCase(20, 10, 60, TestName = "length of {0} and width {1} will give perimeter of {2}")]
		[TestCase(2, 9, 22, TestName = "length of {0} and width {1} will give perimeter of {2}")]

		public void FixedTest(int length, int width, int expectedResult)
		{
            int result = Program19.FindPerimeter(length, width);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
	}
}