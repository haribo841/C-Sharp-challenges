using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Tests1
    {
        [Test]
        [TestCase(2, 3, 5, TestName = "{0} plus {1} should be {2}")]
        [TestCase(-3, -6, -9, TestName = "{0} plus {1} should be {2}")]
        [TestCase(7, 3, 10, TestName = "{0} plus {1} should be {2}")]
        public void FixedTest(int a, int b, int expectedResult)
        {
            int result = Program1.Sum(a, b);// Act
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        /*         [Test]
        [TestCase(2, 3, 5, TestName = nameof(FormatTestName))]
        [TestCase(-3, -6, -9, TestName = nameof(FormatTestName))]
        [TestCase(7, 3, 10, TestName = nameof(FormatTestName))]
        public void FixedTest(int a, int b, int expectedResult)
        {
            int result = Program1.Sum(a, b);// Act
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [MethodImpl(MethodImplOptions.NoInlining)]  
        private string FormatTestName(int a, int b, int c)
        {
            return $"{a} plus {b} should be {c}";
        }
        NUnit3TestAdapter will not display the content of FormatTestName*/
    }
}