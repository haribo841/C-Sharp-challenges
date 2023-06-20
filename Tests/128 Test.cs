using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests128
    {
        [Test]
        [TestCase("maga", "zine", "Magazine")]
        [TestCase("reli", "able", "Reliable")]
        [TestCase("impl", "icit", "Implicit")]
        [TestCase("docu", "ment", "Document")]
        [TestCase("oppo", "site", "Opposite")]
        [TestCase("offi", "cial", "Official")]
        [TestCase("disa", "gree", "Disagree")]
        [TestCase("acci", "dent", "Accident")]
        [TestCase("omis", "sion", "Omission")]
        [TestCase("vigo", "rous", "Vigorous")]
        [TestCase("pred", "ator", "Predator")]
        [TestCase("prog", "ress", "Progress")]
        [TestCase("inva", "sion", "Invasion")]
        [TestCase("fare", "well", "Farewell")]
        [TestCase("majo", "rity", "Majority")]
        [TestCase("pers", "onal", "Personal")]
        [TestCase("sequ", "ence", "Sequence")]
        [TestCase("gove", "rnor", "Governor")]
        [TestCase("igno", "rant", "Ignorant")]
        [TestCase("fini", "shed", "Finished")]
        public void FixedTest(string a, string b, string expectedResult)
        {
            string result = Program128.GetWord(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}