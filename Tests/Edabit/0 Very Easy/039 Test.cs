using System;
using Challenges.Edabit;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests39
    {
        [TestCase(-5, true)]
        [TestCase(-50, false)]
        [TestCase(0, false)]
        [TestCase(25, true)]
        [TestCase(-19, true)]
        [TestCase(12, false)]
        [TestCase(23, true)]
        [TestCase(-71, true)]

        public void IsOdd(int num, bool expectedResult)
        {
            bool result = Program39.IsOdd(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}