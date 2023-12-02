using System;
using Challenges.Edabit;
using Microsoft.Diagnostics.Runtime.Utilities;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests161
    {
        [Test]
        [TestCase(",1|2)\")A^1<[_)?^\"]l[a`3+%!d@8-0_0d.*}i@&n?=", "Aladdin")]
        [TestCase("^U)6$22>8p).", "Up")]
        [TestCase("I5n!449+c@e*}@@1]p{2@`,~t:i0o%n<3%8", "Inception")]
        [TestCase("!)\"P[s9)\"69}yc3+?1]+33>3ho", "Psycho")]
        [TestCase(":~;G{o}o{+524<df~:>}e24{l8:_l]a:?@]%s7", "Goodfellas")]
        [TestCase("&&S~]@8>1-0!h#r),80<_>!}|e>_k:", "Shrek")]
        [TestCase(")^/|,!!09]=/1<G2?`=[l{a}d9]^i7a0|t6_o2*r", "Gladiator")]
        [TestCase("]8;]V9e{=0r!.5t>i<^_g\"4o\"5~", "Vertigo")]
        [TestCase("%%)?\"?B#>/_4a#,;t8|m8675a(n", "Batman")]
        [TestCase("97H^)~a8567ll*o?\"6%)w63e37e<n?@=", "Halloween")]
        public void FixedTest(string a, string expectedResult)
        {
            string result = Program161.LettersOnly(a);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}