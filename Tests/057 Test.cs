using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests57
    {
        [Test]
        [TestCase(6, 2, true)]
        [TestCase(-6, -9, true)]
        [TestCase(6, -2, false)]
        [TestCase(0, 0, true)]
        [TestCase(100, 1, true)]
        [TestCase(-0, 0, true)]
        [TestCase(-80, -5000, true)]
        [TestCase(6, -999, false)]
        [TestCase(-1, 2, false)]
        [TestCase(0, 2, false)]
        public void FixedTest(int n, int k, bool expectedResult)
        {
            bool result = Program57.Both(n, k);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}