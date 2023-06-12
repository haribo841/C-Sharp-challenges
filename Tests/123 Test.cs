using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests123
    {
        [Test]
        public void Test1() => Assert.AreEqual(1, Program123.Sum(1));

        [Test]
        public void Test2() => Assert.AreEqual(15, Program123.Sum(5));

        [Test]
        public void Test3() => Assert.AreEqual(28, Program123.Sum(7));

        [Test]
        public void Test4() => Assert.AreEqual(55, Program123.Sum(10));

        [Test]
        public void Test5() => Assert.AreEqual(78, Program123.Sum(12));

        [Test]
        public void Test6() => Assert.AreEqual(120, Program123.Sum(15));

        [Test]
        public void Test7() => Assert.AreEqual(210, Program123.Sum(20));

        [Test]
        public void Test8() => Assert.AreEqual(5050, Program123 .Sum(100));
    }
}