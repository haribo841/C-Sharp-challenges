using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Tests33
    {
        [Test]
        [TestCase(0.2, 50, 9,  true)]
        [TestCase(0.9, 1, 2, false)]
        [TestCase(0.9, 3, 2, true)]
        [TestCase(0.33, 10, 3.30, true)]
        [TestCase(0, 1000, 0.01, false)]
        [TestCase(0.1, 1000, 7, true)]
        [TestCase(0, 0, 0, false)]
        public void ProfitableGamble(double prob, int prize, double pay, bool expectedResult)
        {
            bool result = Program33.ProfitableGamble(prob, prize, pay);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}