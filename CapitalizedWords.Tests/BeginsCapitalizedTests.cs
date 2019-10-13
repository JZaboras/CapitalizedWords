using NUnit.Framework;

namespace CapitalizedWords.Tests
{
    public class BeginsCapitalizedTests
    {
        [TestCase("name", ExpectedResult = false)]
        [TestCase("    ", ExpectedResult = false)]
        [TestCase("wORD", ExpectedResult = false)]
        [TestCase("functioN", ExpectedResult = false)]
        [TestCase(" meTHOD", ExpectedResult = false)]
        [TestCase("sentencE ", ExpectedResult = false)]
        [TestCase("Name ", ExpectedResult = true)]
        [TestCase("WORD ", ExpectedResult = true)]
        [TestCase("MeTHOD ", ExpectedResult = true)]
        [TestCase("SentencE  ", ExpectedResult = true)]
        [TestCase("/SentencE  ", ExpectedResult = true)]
        [TestCase("  [SentencE  ", ExpectedResult = true)]
        [TestCase("(SentencE???)  ", ExpectedResult = true)]
        [TestCase("<SentencE>  ", ExpectedResult = true)]
        [TestCase("<SentencE>  MeTHOD srs 15", ExpectedResult = true)]
        public bool CapitalizedWords(string testString)
        {
            return testString.BeginsCapitalized();
        }
    }
}