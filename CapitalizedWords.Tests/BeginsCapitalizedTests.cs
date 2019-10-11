using NUnit.Framework;

namespace CapitalizedWords.Tests
{
    public class BeginsCapitalizedTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("name")]
        [TestCase("word")]
        [TestCase("wORD")]
        [TestCase("functioN")]
        [TestCase(" meTHOD")]
        [TestCase("sentencE ")]
        public void NonCapitalizedWords(string testString)
        {
            Assert.IsFalse(testString.BeginsCapitalized());
        }


        [TestCase("Name")]
        [TestCase("Word")]
        [TestCase("WORD")]
        [TestCase("FunctioN")]
        [TestCase(" MeTHOD")]
        [TestCase("SentencE ")]
        public void CapitalizedWords(string testString)
        {
            Assert.IsTrue(testString.BeginsCapitalized());
        }
    }
}