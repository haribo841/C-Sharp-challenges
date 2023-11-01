using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests157
    {
        [Test]
        [TestCase(27, false)]
        [TestCase(43, true)]
        [TestCase(14, false)]
        [TestCase(53, true)]
        [TestCase(99, true)]
        public void FixedTest(int num, bool expectedResult)
        {
            bool result = Program157.LargestSwap(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}