using System;
using NUnit.Framework;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tests
{
    [TestFixture]
    public class Tests35
    {
        [Test]
        [TestCase(2013, 12, 24, true)]
        [TestCase(2013, 0, 23, false)]
        [TestCase(3000, 12, 24, true)]
        public void FixedTest(int year, int month, int day, bool expectedResult)
        {
            bool result = Program35.TimeForMilkAndCookies(year, month, day);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}