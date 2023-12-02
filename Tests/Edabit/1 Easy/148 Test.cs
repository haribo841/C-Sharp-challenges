using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests148
    {
        [Test]
        [TestCase(1, 9, "11%")]
        [TestCase(2, 10, "20%")]
        [TestCase(3, 7, "43%")]
        public void FixedTest(int i, int p, string expectedResult)
        {
            string result = Program148.ImposterFormula(i, p);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}