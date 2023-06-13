using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests123
    {
        [Test]
        public void Test1() => Assert.That(Program123.Sum(1), Is.EqualTo(1));

        [Test]
        public void Test2() => Assert.That(Program123.Sum(5), Is.EqualTo(15));

        [Test]
        public void Test3() => Assert.That(Program123.Sum(7), Is.EqualTo(28));

        [Test]
        public void Test4() => Assert.That(Program123.Sum(10), Is.EqualTo(55));

        [Test]
        public void Test5() => Assert.That(Program123.Sum(12), Is.EqualTo(78));

        [Test]
        public void Test6() => Assert.That(Program123.Sum(15), Is.EqualTo(120));

        [Test]
        public void Test7() => Assert.That(Program123.Sum(20), Is.EqualTo(210));

        [Test]
        public void Test8() => Assert.That(Program123.Sum(100), Is.EqualTo(5050));
    }
}