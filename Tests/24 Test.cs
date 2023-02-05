using System;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Tests24
    {
        [Test]
        [TestCase(1, 0, 3600, TestName = "{0} hour and {1} minutes makes {2} seconds")]
        [TestCase(1, 3, 3780, TestName = "{0} hour and {1} minutes makes {2} seconds")]
        [TestCase(0, 30, 1800, TestName = "{0} hour and {1} minutes makes {2} seconds")]

        public void FixedTest(int hours, int minutes, int expectedResult)
        {
            int result = Program24.Convert(hours, minutes);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}