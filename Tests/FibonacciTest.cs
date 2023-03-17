using Challenges;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tests
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
            int actual = Fibonacci.CalculateFibonacciNumber(numberIndex);
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void CalculateFibonacciNumberShouldTrowArgumentExceptionForNegativeArgument()
        {
            int numberIndex = -1;
            void actual() => Fibonacci.CalculateFibonacciNumber(numberIndex);
            Assert.That(actual, Throws.ArgumentException);
        }
        [TestCaseSource(nameof(_getFibonacciSequenceShouldReturnCorrectSequenceData))]
        public void GetFibonacciSequenceShouldReturnCorrectSequence(int indexNumber, List<int> expected)
        {
            List<int> actual = Fibonacci.GetFibonacciSequence(indexNumber);
            CollectionAssert.AreEqual(expected, actual);
        }
        static readonly object[] _getFibonacciSequenceShouldReturnCorrectSequenceData =
        {
            new object[] { 0, new List<int> { 0 } },
            new object[] { 1, new List<int> { 0, 1 } },
            new object[] { 2, new List<int> { 0, 1, 1 } },
            new object[] { 3, new List<int> { 0, 1, 1, 2 } }
        };
    }
}