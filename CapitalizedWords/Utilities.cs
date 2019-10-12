using System;
using System.Globalization;

namespace CapitalizedWords
{
    public static class Utilities
    {
        public static bool BeginsCapitalized(this string inputString)
        {
            if (IsEmptyNullOrSpaces(inputString)) return false;
            string firstLetter = inputString.Trim().Substring(0, 1);
            if (firstLetter == firstLetter.ToUpper(new CultureInfo("en-US"))) return true;
            return false;
        }

        public static bool IsCapitalizedSentence(this string inputString)
        {
            if (IsEmptyNullOrSpaces(inputString)) return false;
            char[] delimiterChars = { ' ', ',', '.', ':', ';', '\t', '!', '?', '/', '\'', '\"', '(', ')', '{', '}', '[', ']' };
            string[] words = inputString.Trim().Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
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
    }
}
