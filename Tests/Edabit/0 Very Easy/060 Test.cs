using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Test60
    {
        [Test]
        [TestCase(8, 3, 2, true)]
        [TestCase(8, 3, 3, false)]
        [TestCase(24, 12, 2, true)]
        [TestCase(5, 6, 1, false)]
        [TestCase(5, 0, 100, true)]
        [TestCase(15, 2, 7, true)]
        [TestCase(15, 2, 8, false)]
        public void EqualSlices(int total, int people, int each, bool expectedResult)
        {
            bool result = Program60.EqualSlices(total, people, each);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

