using System;
using System.Globalization;
using System.Linq;

namespace CapitalizedWords
{
    public static class Utilities
    {
        public static bool BeginsCapitalized(this string inputString)
        {
            if (IsEmptyNullOrSpaces(inputString)) return false;
            string[] words = SplitStringByLinesAndDelimeters(inputString.Trim());
            if(words != null)
            {
                string firstLetter = words[0].Substring(0, 1);
                if (firstLetter == firstLetter.ToUpper(new CultureInfo("en-US"))) return true;
            }
            return false;
        }

        public static bool IsCapitalizedSentence(this string inputString)
        {
            if (IsEmptyNullOrSpaces(inputString)) return false;

            string[] words = SplitStringByLinesAndDelimeters(inputString.Trim());
            int wordsCount = words.Length;
            foreach (string word in words)
            {
                if (word.BeginsCapitalized()) wordsCount--;
            }
            if(wordsCount == 0) return true;
            return false;
        }

        public static bool IsEmptyNullOrSpaces(string inputString)
        {
            if(string.IsNullOrEmpty(inputString)) return true;
            if(string.IsNullOrEmpty(inputString.Trim())) return true;
            return false;
        }

        public static string[] SplitStringByLinesAndDelimeters(string inputString)
        {
            if (IsEmptyNullOrSpaces(inputString)) return null;
            string[] linesDelimeters = new[] { "\r\n", "\r", "\n" };
            string[] commonSymbols = new[] { "!", "?", "/", "\\", "\'", "\"", "(", ")", "{", "}", "[", "]", "<", ">" };
            string[] wordsDelimeters = { " ", ",", ".", ":", ";" };
            return inputString.Split(linesDelimeters.Union(commonSymbols).Union(wordsDelimeters).ToArray(), StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
