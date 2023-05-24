using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests88
    {
        [Test]
        [TestCase(139.4, 93.8, 1.49)]
        [TestCase(181.2, 124.5, 1.46)]
        [TestCase(154.7, 104.3, 1.48)]
        [TestCase(218.1, 278.3, 0.78)]
        [TestCase(171.4, 171.6, 1.0)]
        [TestCase(218.0, 162.2, 1.34)]
        [TestCase(263.2, 272.7, 0.97)]
        [TestCase(199.4, 166.0, 1.2)]
        [TestCase(279.3, 103.9, 2.69)]
        [TestCase(192.8, 162.6, 1.19)]
        [TestCase(155.4, 272.2, 0.57)]
        [TestCase(285.8, 232.5, 1.23)]
        [TestCase(128.0, 136.1, 0.94)]
        [TestCase(153.8, 129.7, 1.19)]
        [TestCase(209.7, 164.3, 1.28)]
        [TestCase(287.4, 193.6, 1.48)]
        [TestCase(178.1, 202.2, 0.88)]
        [TestCase(111.8, 101.5, 1.1)]
        [TestCase(130.7, 284.2, 0.46)]
        [TestCase(139.3, 148.0, 0.94)]
        [TestCase(183.7, 198.0, 0.93)]
        [TestCase(106.5, 250.2, 0.43)]
        [TestCase(170.7, 274.8, 0.62)]
        public void FixedTest(double a, double b, double expectedResult)
        {
            double result = Program88.SmashFactor(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}