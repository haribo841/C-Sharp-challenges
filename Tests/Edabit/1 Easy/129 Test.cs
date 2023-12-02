using System;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    public class Tests129
    {
        [Test]
        [TestCase("String", "SSttrriinngg")]
        [TestCase("Hello World!", "HHeelllloo  WWoorrlldd!!")]
        [TestCase("1234!_ ", "11223344!!__  ")]
        [TestCase("##^&%%*&%%$#@@!", "####^^&&%%%%**&&%%%%$$##@@@@!!")]
        [TestCase("scandal", "ssccaannddaall")]
        [TestCase("economics", "eeccoonnoommiiccss")]
        [TestCase(" ", "  ")]
        [TestCase("_______", "______________")]
        [TestCase("equip gallon read", "eeqquuiipp  ggaalllloonn  rreeaadd")]
        [TestCase("baby increase", "bbaabbyy  iinnccrreeaassee")]
        public void FixedTest(string str, string expectedResult)
        {
            string result = Program129.DoubleChar(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}