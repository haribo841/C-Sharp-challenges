using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    public class Tests9
    {
        [Test]
        [TestCase(5, 57, true, TestName = "{0} plus {1} is less than hundred")]
        [TestCase(77, 30, false, TestName = "{0} plus {1} is not less than hundred")]
        [TestCase(0, 59, true, TestName = "{0} plus {1} is less than hundred")]
        [TestCase(78, 35, false, TestName = "{0} plus {1} is not less than hundred")]
        [TestCase(63, 11, true, TestName = "{0} plus {1} is less than hundred")]
        [TestCase(37, 99, false, TestName = "{0} plus {1} is not less than hundred")]
        [TestCase(52, 11, true, TestName = "{0} plus {1} is less than hundred")]
        [TestCase(82, 95, false, TestName = "{0} plus {1} is not less than hundred")]
        [TestCase(17, 44, true, TestName = "{0} plus {1} is less than hundred")]
        [TestCase(74, 53, false, TestName = "{0} plus {1} is not less than hundred")]
        [TestCase(3, 77, true, TestName = "{0} plus {1} is less than hundred")]
        [TestCase(25, 80, false, TestName = "{0} plus {1} is not less than hundred")]
        [TestCase(59, 28, true, TestName = "{0} plus {1} is less than hundred")]
        [TestCase(69, 87, false, TestName = "{0} plus {1} is not less than hundred")]
        [TestCase(10, 45, true, TestName = "{0} plus {1} is less than hundred")]
        [TestCase(43, 58, false, TestName = "{0} plus {1} is not less than hundred")]
        [TestCase(50, 44, true, TestName = "{0} plus {1} is less than hundred")]
        [TestCase(74, 89, false, TestName = "{0} plus {1} is not less than hundred")]
        [TestCase(3, 27, true, TestName = "{0} plus {1} is less than hundred")]
        [TestCase(21, 79, false, TestName = "{0} plus {1} is not less than hundred")]

        public void FixedTest(int a, int b, bool expectedResult)
        {
            bool result = Program9.LessThan100(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}