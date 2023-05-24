using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests92
    {
        [TestCase("whisper...", "lower")]
        [TestCase("SHOUT!", "upper")]
        [TestCase("Indoor Voice", "mixed")]
        [TestCase("324324Indoor66453546Voice434", "mixed")]
        [TestCase("!!!!SHOUT!!!!", "upper")]
        [TestCase("......313whisper2131232...", "lower")]
        public void FixedTest(string n, string expectedResult)
        {
            string result = Program92.GetCase(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
