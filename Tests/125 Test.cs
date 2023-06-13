using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests125
    {
        [Test]
        [TestCase("11/12/2019", "20191211")]
        [TestCase("12/31/2019", "20193112")]
        [TestCase("01/15/2019", "20191501")]
        public void FormatDate(string date, string expectedResult)
        {
            string result = Program125.FormatDate(date);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}