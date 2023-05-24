using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests12
    {
        [Test]
        [TestCase(false, true)]
        [TestCase(true, false)]
        public void FixedTest(bool boolean, bool expectedResult)
        {
            bool result = Program12.Reverse(boolean);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}