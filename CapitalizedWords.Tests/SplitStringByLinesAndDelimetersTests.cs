using NUnit.Framework;

namespace CapitalizedWords.Tests
{
    public class SplitStringByLinesAndDelimetersTests
    {
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

        [TestCase("", ExpectedResult = 0)]
        [TestCase(null, ExpectedResult = 0)]
        [TestCase(" ", ExpectedResult = 0)]
        [TestCase(@"' ', ',', '.', ':', ';', '\r', '\n',
                        '\t', '!', '?', '/', '\'', '\',
                        '(', ')', '{', '}', '[', ']", ExpectedResult = 3)]
        [TestCase("154 cats Ččęėį", ExpectedResult = 3)]
        [TestCase(longStringWithLineBreaksCapitalized, ExpectedResult = 48)]
        [TestCase("My name is Frank", ExpectedResult = 4)]
        [TestCase("Keep it SImple stupid", ExpectedResult = 4)]
        [TestCase("The wORLD is mine", ExpectedResult = 4)]
        [TestCase("Provide two ways for accessing these functions!!!", ExpectedResult = 7)]
        [TestCase(" and indirectly via abstraction layer", ExpectedResult = 5)]
        [TestCase("test suites written with chosen xUnit framework for .NET [...]", ExpectedResult = 9)]
        public int SplitStringByLinesAndDelimetersTest(string testString)
        {
            string[] words = Utilities.SplitStringByLinesAndDelimeters(testString);
            if(words != null)
            {
                return words.Length;
            }
            return 0;
        }
    }
}
