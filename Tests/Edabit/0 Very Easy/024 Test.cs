using System;
using Challenges.Edabit;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests24
    {
        [Test]
        [TestCase(2, 8)]
        [TestCase(3, 27)]
        [TestCase(4, 64)]
        [TestCase(5, 125)]
        [TestCase(10, 1000)]

        public void FixedTest(int a, int expectedResult)
        {
            int result = Program24.Cubes(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}