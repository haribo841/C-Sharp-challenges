using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
	public class Tests9
	{
		[Test]
		[TestCase(5, 57, true, TestName = "5 plus 57 is less than hundred")]
		[TestCase(77, 30, false, TestName = "77 plus 30 is not less than hundred")]
		[TestCase(0, 59, true, TestName = "0 plus 59 is less than hundred")]
		[TestCase(78, 35, false, TestName = "78 plus 35 is not less than hundred")]
		[TestCase(63, 11, true, TestName = "63 plus 11 is less than hundred")]
		[TestCase(37, 99, false, TestName = "37 plus 57 is not less than hundred")]
		[TestCase(52, 11, true, TestName = "5 plus 99 is less than hundred")]
		[TestCase(82, 95, false, TestName = "82 plus 95 is not less than hundred")]
		[TestCase(17, 44, true, TestName = "17 plus 44 is less than hundred")]
		[TestCase(74, 53, false, TestName = "74 plus 53 is not less than hundred")]
		[TestCase(3, 77, true, TestName = "3 plus 77 is less than hundred")]
		[TestCase(25, 80, false, TestName = "25 plus 80 is not less than hundred")]
		[TestCase(59, 28, true, TestName = "59 plus 28 is less than hundred")]
		[TestCase(69, 87, false, TestName = "69 plus 87 is not less than hundred")]
		[TestCase(10, 45, true, TestName = "10 plus 45 is less than hundred")]
		[TestCase(43, 58, false, TestName = "43 plus 58 is not less than hundred")]
		[TestCase(50, 44, true, TestName = "50 plus 44 is less than hundred")]
		[TestCase(74, 89, false, TestName = "74 plus 89 is not less than hundred")]
		[TestCase(3, 27, true, TestName = "3 plus 27 is less than hundred")]
		[TestCase(21, 79, false, TestName = "21 plus 79 is not less than hundred")]

		public void FixedTest(int a, int b, bool expectedResult)
        {
            bool result = Program9.lessThan100(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
	}
}