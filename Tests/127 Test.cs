using Challenges;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests127
    {
        [Test]
        [TestCase("C:/Projects/pil_tests/ascii/edabit.txt", "edabit.txt")]
        [TestCase("C:/Users/johnsmith/Music/Beethoven_5.mp3", "Beethoven_5.mp3")]
        [TestCase("ffprobe.exe", "ffprobe.exe")]
        [TestCase("Music/Drafts/unfinished2.midi", "unfinished2.midi")]
        [TestCase("C:/Users/chad/OneDrive/Desktop/Atom.lnk", "Atom.lnk")]
        [TestCase("senoron/OneDrive/Desktop/DDLC-1.1.1-pc/lib/windows-i686/DDLC.exe", "DDLC.exe")]
        public void FixedTest(string n, string expectedResult)
        {
            string result = Program127.GetFilename(n);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}