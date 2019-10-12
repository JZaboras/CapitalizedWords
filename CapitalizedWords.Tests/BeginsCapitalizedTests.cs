using NUnit.Framework;

namespace CapitalizedWords.Tests
{
    public class BeginsCapitalizedTests
    {
        [SetUp]
        public void Setup()
        {
        }

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
        public bool CapitalizedWords(string testString)
        {
            return testString.BeginsCapitalized();
        }
    }
}