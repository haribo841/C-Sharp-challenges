using NUnit.Framework;
using System;
namespace VeryEasy.Tests
{
    public class Tests
    {
        Power power = new Power();
        [Test]
        public void Test2to2is4()
        {
            var result = power.DoPower(2, 2);
            Assert.AreEqual(4, result);//left - expected value, right - calculated one

        }
        [Test]
        public void Test2to3is8()
        {
            var result = power.DoPower(2, 3);
            Assert.AreEqual(8, result);

        }
        [Test]
        public void Test2to0is1()
        {
            var result = power.DoPower(2, 0);
            Assert.AreEqual(1, result);

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