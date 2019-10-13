using NUnit.Framework;

namespace CapitalizedWords.Tests
{
    public class IsCapitalizedSentenceTests
    {
        const string longStringWithLineBreaksNotCapitalized = @"
String with some known special cases:

    Empty string
    Long string
    Unicode string (special characters)
    If limited to a specific set of characters, what happens when some are not in the range
    Odd/even length string
    Null (as argument)
    Non-null terminated
";

        const string longStringWithLineBreaksCapitalized = @"
Sort Algorithm That Could Fail In The Following Boundary Cases:

    [Empty] Input
    1 Element Input
    Very Long Input (Maybe Of Length Max(Data Type Used For Index))
    Garbage Inside The Collection That Will Be Sorted
    <Null> Input
    Duplicate Elements
    Collection With All Elements Equal
    Odd/Even Length Input
";

        [TestCase("")]
        [TestCase(null)]
        [TestCase(" ")]
        [TestCase(@"' ', ',', '.', ':', ';', '\r', '\n',
                        '\t', '!', '?', '/', '\'', '\',
                        '(', ')', '{', '}', '[', ']")]
        [TestCase("154 cats Ččęėį")]
        [TestCase(longStringWithLineBreaksNotCapitalized)]
        [TestCase("My name is Frank")]
        [TestCase("Keep it SImple stupid")]
        [TestCase("The wORLD is mine")]
        [TestCase("Provide two ways for accessing these functions!!!")]
        [TestCase(" and indirectly via abstraction layer")]
        [TestCase("test suites written with chosen xUnit framework for .NET [...]")]
        public void NonCapitalizedSentences(string testString)
        {
            Assert.IsFalse(testString.IsCapitalizedSentence());
        }

        [TestCase(longStringWithLineBreaksCapitalized)]
        [TestCase("My Name Is Frank!")]
        [TestCase("Keep IT Simple Stupid(KISS)")]
        [TestCase("Both Functions Should Also Have A Set Of Test Suites")]
        [TestCase("Capitalize The First Word In 'Quotations', Provided The \"Quoted Material\" Is A Complete Sentence.")]
        [TestCase(" Use Capitals For Proper Nouns. In Other Words, Capitalize The Names Of People, Specific Places, And Things.")]
        [TestCase("Capitalize Directions Only When They Refer To Specific Regions. ")]
        public void CapitalizedSentences(string testString)
        {
            Assert.IsTrue(testString.IsCapitalizedSentence());
        }
    }
}
