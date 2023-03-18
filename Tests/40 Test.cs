using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests40
    {
        [TestCase(1, 0)]
        [TestCase(2, 2)]
        [TestCase(3, 4)]
        [TestCase(100, 198)]
        [TestCase(1298734, 2597466)]

        public void Points(int n, int expectedResult)
        {
            int result = Program40.NthEven(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}