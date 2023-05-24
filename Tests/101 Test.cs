using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests101
    {
        [Test]
        [TestCase(1, "January")]
        [TestCase(2,  "February")]
        [TestCase(3,  "March")]
        [TestCase(4,  "April")]
        [TestCase(5,  "May")]
        [TestCase(6,  "June")]
        [TestCase(7,  "July")]
        [TestCase(8,  "August")]
        [TestCase(9,  "September")]
        [TestCase(10, "October")]
        [TestCase(11, "November")]
        [TestCase(12, "December")]
        public void MonthName(int num, string expectedResult)
        {
            string result = Program101.MonthName(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
