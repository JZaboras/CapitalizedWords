using NUnit.Framework;

namespace CapitalizedWords.Tests
{
    public class IsCapitalizedSentenceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("My name is Frank")]
        [TestCase("Keep it SImple stupid")]
        [TestCase("The wORLD is mine")]
        [TestCase("Provide two ways for accessing these functions")]
        [TestCase(" and indirectly via abstraction layer")]
        [TestCase("test suites written with chosen xUnit framework for .NET []")]
        public void NonCapitalizedSentences(string testString)
        {
            Assert.IsFalse(testString.IsCapitalizedSentence());
        }


        [TestCase("My Name Is Frank!")]
        [TestCase("Keep IT Simple Stupid(KISS)")]
        [TestCase("Both Functions Should Also Have A Set Of Test Suites")]
        [TestCase("Capitalize The First Word In Quotations, Provided The Quoted Material Is A Complete Sentence.")]
        [TestCase(" Use Capitals For Proper Nouns. In Other Words, Capitalize The Names Of People, Specific Places, And Things.")]
        [TestCase("Capitalize Directions Only When They Refer To Specific Regions. ")]
        public void CapitalizedSentences(string testString)
        {
            Assert.IsTrue(testString.IsCapitalizedSentence());
        }
    }
}
