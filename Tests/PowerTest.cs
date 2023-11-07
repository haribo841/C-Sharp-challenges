using Challenges;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Test
    {
        [Test]
        public void Test2to2is4()
        {
            int result = Power.DoPower(2, 2);
            Assert.That(result, Is.EqualTo(4));//left - expected value, right - calculated one
        }
        [Test]
        public void Test2to3is8()
        {
            int result = Power.DoPower(2, 3);
            Assert.That(result, Is.EqualTo(8));
        }
        [Test]
        public void Test2to0is1()
        {
            int result = Power.DoPower(2, 0);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void TestMinus3to2isException() => Assert.Throws<ArgumentOutOfRangeException>(() => Power.DoPower(-3, 2));
        [Test]
        public void Test3toMinus2isException() => Assert.Throws<ArgumentOutOfRangeException>(() => Power.DoPower(3, -2));
    }
}