using Challenges;
using Challenges.Edabit;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class SonarRegressionTests
    {
        [Test]
        public void TruthAccessAndBenchmarkFormsRemainCompatible()
        {
            var benchmark = new BenchmarkProgram();
            Assert.That(Program.ReturnTrue(), Is.True);
            Assert.That(benchmark.MethodCall(), Is.True);
            Assert.That(benchmark.PropertyAccess(), Is.True);
            Assert.That(benchmark.FieldAccess(), Is.True);
            Assert.That(benchmark.ConstantAccess(), Is.True);
        }

        [Test]
        public void BenchmarkParametersCanStillBeAssignedThroughAProperty()
        {
            var benchmark = new BenchmarkProgram15 { Word = "abc" };
            Assert.That(benchmark.NewWord_Range(), Is.EqualTo("bc"));
        }

        [TestCase("", "")]
        [TestCase("0123456789", "")]
        [TestCase("A١２3B", "A١２B")]
        public void NumberRemovalStillFiltersOnlyAsciiDigits(string input, string expected)
        {
            Assert.That(Program31.RemoveNumbers(input), Is.EqualTo(expected));
        }

        [TestCase("", false)]
        [TestCase("##\t##", false)]
        [TestCase("## ##", true)]
        public void SpaceChecksStillUseTheLiteralSpaceCharacter(string input, bool hasSpaces)
        {
            Assert.That(Program169.HasSpaces(input), Is.EqualTo(hasSpaces));
            Assert.That(Program57.IsSafeBridge(input), Is.EqualTo(!hasSpaces));
        }

        [Test]
        public void EndingProjectionKeepsTheInputUnchanged()
        {
            string[] input = { "a", "b" };
            Assert.That(Program76.AddEnding(input, "!"), Is.EqualTo(new[] { "a!", "b!" }));
            Assert.That(input, Is.EqualTo(new[] { "a", "b" }));
            Assert.That(Program76.AddEnding(Array.Empty<string>(), "!"), Is.Empty);
        }

        [TestCase("123!", "lower")]
        [TestCase("Ąę", "mixed")]
        [TestCase("ĄĘ", "upper")]
        public void CaseClassificationStillIgnoresNonletters(string input, string expected)
        {
            Assert.That(Program92.GetCase(input), Is.EqualTo(expected));
        }

        [TestCase(new double[] { 2.0000000001 }, "2.0 ohms")]
        [TestCase(new double[] { 0.9999999999 }, "1 ohm")]
        [TestCase(new double[] { }, "0.0 ohm")]
        [SetCulture("pl-PL")]
        public void ResistanceFormattingRemainsInvariantAndPreservesWholeNumberRules(double[] values, string expected)
        {
            Assert.That(Program80.SeriesResistance(values), Is.EqualTo(expected));
        }

        [Test]
        public void SortingAcceptsNullAndReturnsANewSortedArray()
        {
            Assert.That(Program111.SortNumsAscending(null), Is.Empty);
            int[] input = { 3, 1, 2 };
            int[] sorted = Program111.SortNumsAscending(input);
            Assert.That(sorted, Is.EqualTo(new[] { 1, 2, 3 }));
            Assert.That(input, Is.EqualTo(new[] { 3, 1, 2 }));
            Assert.That(sorted, Is.Not.SameAs(input));
        }

        [TestCase(100000, 1, 100000, 0)]
        [TestCase(int.MaxValue, 0, -int.MaxValue, 2)]
        [TestCase(int.MaxValue, int.MaxValue, int.MaxValue, 0)]
        public void QuadraticDiscriminantsDoNotOverflowIntArithmetic(int a, int b, int c, int expected)
        {
            Assert.That(Program147.Solutions(a, b, c), Is.EqualTo(expected));
        }

        [Test]
        public void RegexReplacementKeepsReplacementTokenAndCaseSemantics()
        {
            Assert.That(Program152.ReplaceVowels("aey", "$&"), Is.EqualTo("aey"));
            Assert.That(Program152.ReplaceVowels("AEIOUY", "#"), Is.EqualTo("AEIOUY"));
            Assert.That(Program152.ReplaceVowels("rhythm", "*"), Is.EqualTo("rh*thm"));
        }

        [TestCase("١٢٣٤٥", true)]
        [TestCase("1234 ", false)]
        public void ZipValidationKeepsItsDigitClassification(string input, bool expected)
        {
            Assert.That(Program159.IsValid(input), Is.EqualTo(expected));
        }

        [TestCase("AEIOUaeiou", "")]
        [TestCase("ąĘy", "ąĘy")]
        [TestCase("", "")]
        public void VowelRemovalPreservesNonAsciiCharactersAndY(string input, string expected)
        {
            Assert.That(Program160.RemoveVowels(input), Is.EqualTo(expected));
        }

        [TestCase("abc", 0)]
        [TestCase("7", 77)]
        [TestCase("2\n9", 121)]
        [TestCase("ab12cd\nx5y", 67)]
        public void NumericCalibrationHandlesMissingAndRepeatedDigits(string text, int expected)
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, text);
                Assert.That(A2301.Trebuchet(path), Is.EqualTo(expected));
            }
            finally
            {
                File.Delete(path);
            }
        }

        [Test]
        public void SimilarityCountingRetainsDuplicateOccurrences()
        {
            string path = Path.GetTempFileName();
            try
            {
                File.WriteAllText(path, "3   3\n3   4\n4   3");
                Assert.That(A2401.DayOne(path), Is.Zero);
                Assert.That(A2401.DayOnePartTwo(path), Is.EqualTo(16));
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
