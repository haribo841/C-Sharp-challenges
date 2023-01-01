using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VeryEasy.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(6, 8)]
        [TestCase(19, 4181)]
        public void CalculateFibonacciNumberShouldReturnCorrectValue(int numberIndex, int expected)
        {
            var actual = Fibonacci.CalculateFibonacciNumber(numberIndex);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void CalculateFibonacciNumberShouldTrowArgumentExceptionForNegativeArgument()
        {
            var numberIndex = -1;
            TestDelegate actual = () => Fibonacci.CalculateFibonacciNumber(numberIndex);
            Assert.That(actual, Throws.ArgumentException);
        }
        [TestCaseSource(nameof(_getFibonacciSequenceShouldReturnCorrectSequenceData))]
        public void GetFibonacciSequenceShouldReturnCorrectSequence(int indexNumber, List<int> expected)
        {
            var actual = Fibonacci.GetFibonacciSequence(indexNumber);
            CollectionAssert.AreEqual(expected, actual);
        }
        static object[] _getFibonacciSequenceShouldReturnCorrectSequenceData =
        {
            new object[] { 0, new List<int> { 0 } },
            new object[] { 1, new List<int> { 0, 1 } },
            new object[] { 2, new List<int> { 0, 1, 1 } },
            new object[] { 3, new List<int> { 0, 1, 1, 2 } }
        };
    }
}