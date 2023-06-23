using System;
using Challenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests132
    {
        [Test]
        [TestCase("Think different.", ".tnereffid knihT")]
        [TestCase("It doesn’t make sense to hire smart people and tell them what to do; we hire smart people so they can tell us what to do.", ".od ot tahw su llet nac yeht os elpoep trams erih ew ;od ot tahw meht llet dna elpoep trams erih ot esnes ekam t’nseod tI")]
        [TestCase("Innovation is the ability to see change as an opportunity - not a threat", "taerht a ton - ytinutroppo na sa egnahc ees ot ytiliba eht si noitavonnI")]
        [TestCase("Everything is based on a simple rule: Quality is the best business plan.", ".nalp ssenisub tseb eht si ytilauQ :elur elpmis a no desab si gnihtyrevE")]
        [TestCase("The people who are crazy enough to think they can change the world are the ones who do.", ".od ohw seno eht era dlrow eht egnahc nac yeht kniht ot hguone yzarc era ohw elpoep ehT")]
        [TestCase("Don’t let the noise of others’ opinions drown out your own inner voice.", ".eciov renni nwo ruoy tuo nword snoinipo ’srehto fo esion eht tel t’noD")]
        [TestCase("Learn continually; There's always one more thing to learn.", ".nrael ot gniht erom eno syawla s'erehT ;yllaunitnoc nraeL")]
        [TestCase("Quality is more important than quantity. One home run is much better than two doubles.", ".selbuod owt naht retteb hcum si nur emoh enO .ytitnauq naht tnatropmi erom si ytilauQ")]
        [TestCase("Your time is limited so don't waste it living someone else's life.", ".efil s'esle enoemos gnivil ti etsaw t'nod os detimil si emit ruoY")]
        [TestCase("The only way to be truly satisfied is to do what you believe is great work.", ".krow taerg si eveileb uoy tahw od ot si deifsitas ylurt eb ot yaw ylno ehT")]
        public void FixedTest(string str, string expectedResult)
        {
            string result = Program132.Reverse(str);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}