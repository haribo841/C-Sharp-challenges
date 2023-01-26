using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
	[TestFixture]
	public class Tests21
	{
		[Test]
		[TestCase(5, 2, 8, 50, TestName = "{0} chickens, {1} cows and {2} pigs have {3} legs together")]
		[TestCase(3, 4, 7, 50, TestName = "{0} chickens, {1} cows and {2} pigs have {3} legs together")]
		[TestCase(1, 2, 3, 22, TestName = "{0} chickens, {1} cows and {2} pigs have {3} legs together")]
		[TestCase(3, 5, 2, 34, TestName = "{0} chickens, {1} cows and {2} pigs have {3} legs together")]
		public void animals(int a, int b, int c, int expectedResult)
		{
            // Arrange
            int chickens = a;
            int cows = b;
            int pigs = c;
			int result = Program21.animals(chickens, cows, pigs);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
	}
}