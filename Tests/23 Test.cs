using System;
using NUnit.Framework;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class Tests23
    {
        [Test]
        [TestCase(new object[] { 5, 6, 7 }, 5)]
        [TestCase(new object[] { "Semiramis", "Gaia", "Hypatia" }, "Semiramis")]
        [TestCase(new object[] { -500, 0, 500 }, -500)]
        [TestCase(new object[] { 'n', 'm', 'v' }, 'n')]
        [TestCase(new object[] { 3.3, 4.4, 5.5 }, 3.3)]
        [TestCase(new object[] { true, false, true }, true)]
        public void FixedTest(object[] arr, object expectedResult)
        {
            object result = Program23.GetFirstValue(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}