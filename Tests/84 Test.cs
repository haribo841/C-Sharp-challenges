//Create a function that takes a number as an argument.
//Add up all the numbers from 1 to the number you passed to the function.
//For example, if the input is 4 then your function should return 10 because 1 + 2 + 3 + 4 = 10.
using Challenges;
using NUnit.Framework;
namespace Tests
{
    [TestFixture]
    public class Tests84
    {
        [Test]
        [TestCase(4, 10)]
        [TestCase(13, 91)]
        [TestCase(600, 180300)]
        [TestCase(392, 77028)]
        [TestCase(53, 1431)]
        [TestCase(897, 402753)]
        [TestCase(23, 276)]
        [TestCase(1000, 500500)]
        [TestCase(738, 272691)]
        [TestCase(100, 5050)]
        [TestCase(925, 428275)]
        [TestCase(1, 1)]
        [TestCase(999, 499500)]
        [TestCase(175, 15400)]
        [TestCase(111, 6216)]
        public void FixedTest(int num, int expectedResult)
        {
            int result = Program84.AddUp(num);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}