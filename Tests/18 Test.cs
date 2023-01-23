using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
	[TestFixture]
	public class Tests18
	{
		[Test]
		[TestCase(1, 1, 5, TestName = "{0}*2+{1}*3 is equal to {2}")]
		[TestCase(1, 2, 8, TestName = "{0}*2+{1}*3 is equal to {2}")]
		[TestCase(2, 1, 7, TestName = "{0}*2+{1}*3 is equal to {2}")]
		[TestCase(2, 2, 10, TestName = "{0}*2+{1}*3 is equal to {2}")]
		[TestCase(69, 420, 1398, TestName = "{0}*2+{1}*3 is equal to {2}")]

		public void Points(int twoPointers, int threePointers, int expectedResult)
		{
			int result = Program18.Points(twoPointers, threePointers);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
	}
}