using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
	[TestFixture]
	public class Tests10
	{
		[Test]
		[TestCase(2, 2, true, TestName = "2 is equal to 2")]
		[TestCase(88, 88, true, TestName = "88 is equal to 88")]
		[TestCase(36, 35, false, TestName = "36 is not equal to 35")]
		[TestCase(1, 1, true, TestName = "1 is equal to 1")]
		[TestCase(5, 6, false, TestName = "5 is not equal to 6")]
		public void FixedTest(int num1, int num2, bool expectedResult)
		{
			bool result = Program10.IsEqual(num1, num2);
			Assert.That(result, Is.EqualTo(expectedResult));
		}
	}
}