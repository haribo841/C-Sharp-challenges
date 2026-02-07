using System;
using System.Collections.Generic;
using System.Linq;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests30
    {
        [TestCaseSource(nameof(TestData))]
        public void FixedTest(int a, List<int> expectedResult)
        {
            List<int> result = Program30.PrintArray(a);    // PrintArray returns List<int>
            CollectionAssert.AreEqual(expectedResult, result);
        }

        private static IEnumerable<TestCaseData> TestData()
        {
            yield return new TestCaseData(1, new List<int> { 1 });
            yield return new TestCaseData(2, new List<int> { 1, 2 });
            yield return new TestCaseData(6, new List<int> { 1, 2, 3, 4, 5, 6 });
        }
    }
}
