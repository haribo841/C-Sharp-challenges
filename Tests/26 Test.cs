using System;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
namespace VeryEasy.Tests
{
	[TestFixture]
	public class Tests26
	{
		[Test]
		[TestCase(5, 4, 8)]
		[TestCase(8, 3, 10)]
		[TestCase(7, 9, 15)]
		[TestCase(10, 4, 13)]
		[TestCase(7, 2, 8)]

		public void FixedTest(int side1, int side2, int expectedResult)
		{
			int result = Program26.NextEdge(side1, side2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
	}
}