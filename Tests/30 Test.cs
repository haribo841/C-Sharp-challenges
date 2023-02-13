using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Tests30
    {
        [Test]
        [TestCase(1, 0)]
        [TestCase(0, 1)]
        public void FlipIntBool(int ib, int expectedResult)
        {
            int result = Program30.FlipIntBool(ib);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}