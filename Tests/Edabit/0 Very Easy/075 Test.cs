using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests75
    {
        [Test]
        [TestCase(5, 32)]
        [TestCase(4, 16)]
        [TestCase(3, 8)]
        [TestCase(2, 4)]
        [TestCase(1, 2)]
        [TestCase(6, 64)]
        [TestCase(7, 128)]
        [TestCase(8, 256)]
        [TestCase(9, 512)]
        [TestCase(10, 1024)]
        [TestCase(25, 33554432)]
        public void FixedTest(int n, int expectedResult)
        {
            int result = Program75.PosCom(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}