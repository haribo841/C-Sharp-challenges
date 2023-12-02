using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests145
    {
        [Test]
        [TestCase("https://www.reddit.com/r/relationships/", "relationships")]
        [TestCase("https://www.reddit.com/r/mildlyinteresting/", "mildlyinteresting")]
        [TestCase("https://www.reddit.com/r/funny/", "funny")]
        [TestCase("https://www.reddit.com/r/CrappyDesign/", "CrappyDesign")]
        [TestCase("https://www.reddit.com/r/confession/", "confession")]
        [TestCase("https://www.reddit.com/r/AskMen/", "AskMen")]
        [TestCase("https://www.reddit.com/r/comics/", "comics")]
        [TestCase("https://www.reddit.com/r/lifehacks/", "lifehacks")]
        [TestCase("https://www.reddit.com/r/wholesomememes/", "wholesomememes")]
        [TestCase("https://www.reddit.com/r/iamverysmart/", "iamverysmart")]
        [TestCase("https://www.reddit.com/r/starterpacks/", "starterpacks")]
        [TestCase("https://www.reddit.com/r/awww/", "awww")]
        public void FixedTest(string link, string expectedResult)
        {
            string result = Program145.SubReddit(link);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}