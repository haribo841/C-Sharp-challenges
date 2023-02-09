using System;
using System.Drawing;
using NUnit.Framework;
namespace VeryEasy.Tests
{
	[TestFixture]
	public class Tests27
	{
		[Test]
		[TestCase(12, 1, TestName = "{0} inches are {1} feet")]
		[TestCase(360, 30, TestName = "{0} inches are {1} feet")]
		[TestCase(3612, 301, TestName = "{0} inches are {1} feet")]
		[TestCase(324, 27, TestName = "{0} inches are {1} feet")]
		[TestCase(3012, 251, TestName = "{0} inches are {1} feet")]
		[TestCase(11, 0, TestName = "{0} inches are {1} feet")]

		public void FixedTest(int inches, int expectedResult)
		{
            int result = Program27.inchesToFeet(inches);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
	}
}