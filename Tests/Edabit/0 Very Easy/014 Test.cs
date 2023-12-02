using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests14
    {
        [Test]
        [TestCase(21, 3420, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(22, 3600, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(3, 180, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(4, 360, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(5, 540, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(6, 720, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(7, 900, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(8, 1080, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(9, 1260, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(10, 1440, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(11, 1620, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(12, 1800, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(13, 1980, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(14, 2160, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(15, 2340, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(16, 2520, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(17, 2700, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(18, 2880, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(19, 3060, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        [TestCase(20, 3240, TestName = "{0} sided polygon should have total sum of {1} degrees")]
        public void SumPolygon(int num, int expectedResult)
        {
            int result = Program14.SumPolygon(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
