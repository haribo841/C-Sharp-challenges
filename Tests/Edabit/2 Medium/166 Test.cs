using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests166
    {
        [TestCase(1, 1, true)]
        [TestCase(1, 1.0, false)]
        [TestCase(0, false, false)]
        [TestCase("1", 1, false)]
        [TestCase("same", "same", true)]
        [TestCase("same", "Same", false)]
        [TestCase(true, true, true)]
        [TestCase(true, false, false)]
        [TestCase(null, null, true)]
        [TestCase(null, "", false)]
        public void CheckEqualityRequiresMatchingTypesAndValues(object? first, object? second, bool expected)
        {
            Assert.That(Program166.CheckEquality(first, second), Is.EqualTo(expected));
        }
    }
}
