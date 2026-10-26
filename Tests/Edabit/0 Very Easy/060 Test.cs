//Given an array of integers, return the difference between the largest and smallest integers in the array.
using NUnit.Framework;
using System;
using Challenges.Edabit;

namespace Tests
{
    [TestFixture]
    public class Tests60
    {
        [Test]
        [TestCase(new int[] { -9, -8, 6, -9, 15, 6 }, 24)]
        [TestCase(new int[] { -5, 6, 18, 4, 16, -2 }, 23)]
        [TestCase(new int[] { -2, 20, -9, -9, -2, -7 }, 29)]
        [TestCase(new int[] { 4, -2, 11, -9, 15, 2 }, 24)]
        [TestCase(new int[] { 15, 10, 3, -6, 6, 19 }, 25)]
        [TestCase(new int[] { 1, 7, 18, -1, -2, 9 }, 20)]
        [TestCase(new int[] { 5, 1, -9, 7, -8, -10 }, 17)]
        [TestCase(new int[] { 5, 1, -9, 7, -8, -10 }, 17)]
        [TestCase(new int[] { 4, 17, 12, 2, 10, 2 }, 15)]
        [TestCase(new int[] { 7 }, 0)]
        [TestCase(new int[] { -3, -3, -3 }, 0)]
        [TestCase(new int[] { -10, 2, 5, 1, -4 }, 15)]
        [TestCase(new int[] { int.MinValue }, 0)]
        [TestCase(new int[] { int.MaxValue, int.MaxValue }, 0)]
        [TestCase(new int[] { int.MinValue, -1 }, int.MaxValue)]
        [TestCase(new int[] { 0, int.MaxValue }, int.MaxValue)]
        public void Diff(int[] arr, int expectedResult)
        {
            int result = Program60.Diff(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
            Assert.That(Program60.DiffOptimized(arr), Is.EqualTo(expectedResult));
            Assert.That(Program60.DiffOptimizedCompact(arr), Is.EqualTo(expectedResult));
        }

        [Test]
        public void ImplementationsAgreeForReproducibleRandomArrays()
        {
            var random = new Random(0);
            for (int sample = 0; sample < 1000; sample++)
            {
                int[] values = Enumerable.Range(0, random.Next(1, 129))
                    .Select(_ => random.Next(-10000, 10001)).ToArray();
                int expected = values.Max() - values.Min();
                Assert.That(Program60.Diff(values), Is.EqualTo(expected));
                Assert.That(Program60.DiffOptimized(values), Is.EqualTo(expected));
                Assert.That(Program60.DiffOptimizedCompact(values), Is.EqualTo(expected));
            }
        }

        [Test]
        public void EmptyArraysAreRejected()
        {
            int[] values = Array.Empty<int>();
            Assert.Throws<ArgumentException>(() => Program60.Diff(values));
            Assert.Throws<ArgumentException>(() => Program60.DiffOptimized(values));
            Assert.Throws<ArgumentException>(() => Program60.DiffOptimizedCompact(values));
        }

        [Test]
        public void NullArraysAreRejected()
        {
            Assert.Throws<ArgumentNullException>(() => Program60.Diff(null!));
            Assert.Throws<ArgumentNullException>(() => Program60.DiffOptimized(null!));
            Assert.Throws<ArgumentNullException>(() => Program60.DiffOptimizedCompact(null!));
        }

        [TestCase(new int[] { int.MinValue, 0 })]
        [TestCase(new int[] { int.MinValue, int.MaxValue })]
        [TestCase(new int[] { int.MaxValue, -1, 0 })]
        public void UnrepresentableDifferencesAreRejected(int[] values)
        {
            Assert.Throws<OverflowException>(() => Program60.Diff(values));
            Assert.Throws<OverflowException>(() => Program60.DiffOptimized(values));
            Assert.Throws<OverflowException>(() => Program60.DiffOptimizedCompact(values));
        }
    }
}
