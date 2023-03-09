using Challenges;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Test
    {
        Power power = new Power();
        [Test]
        public void Test2to2is4()
        {
            var result = power.DoPower(2, 2);
            Assert.That(result, Is.EqualTo(4));//left - expected value, right - calculated one
        }
        [Test]
        public void Test2to3is8()
        {
            var result = power.DoPower(2, 3);
            Assert.That(result, Is.EqualTo(8));
        }
        [Test]
        public void Test2to0is1()
        {
            var result = power.DoPower(2, 0);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void TestMinus3to2isException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { power.DoPower(-3, 2); });
        }
        [Test]
        public void Test3toMinus2isException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { power.DoPower(3, -2); });
        }
    }
}