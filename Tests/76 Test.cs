using System;
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests76
    {
        [Test]
        [TestCase(new string[] { "clever", "meek", "hurried", "nice" }, "ly", new string[] { "cleverly", "meekly", "hurriedly", "nicely" })]
        [TestCase(new string[] { "new", "pander", "scoop" }, "er", new string[] { "newer", "panderer", "scooper" })]
        [TestCase(new string[] { "bend", "sharpen", "mean" }, "ing", new string[] { "bending", "sharpening", "meaning" })]
        [TestCase(new string[] { "bend", "tooth", "mint" }, "y", new string[] { "bendy", "toothy", "minty" })]
        [TestCase(new string[] { "bend", "tooth", "mint" }, "ier", new string[] { "bendier", "toothier", "mintier" })]
        public void FixedTest(string[] arr, string ending, object expectedResult)
        {
            object result = Program76.AddEnding(arr, ending);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}