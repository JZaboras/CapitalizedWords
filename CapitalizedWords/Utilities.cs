using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CapitalizedWords
{
    public static class Utilities
    {
        public static bool BeginsCapitalized(this string inputString)
        {
            if (string.IsNullOrEmpty(inputString)) return false;
            string firstLetter = inputString.Trim().Substring(0, 1);
            if (firstLetter == firstLetter.ToUpper(new CultureInfo("en-US"))) return true;
            return false;
        }

        public static bool IsCapitalizedSentence(this string inputString)
        {
            if (string.IsNullOrEmpty(inputString)) return false;
            string[] words = inputString.Trim().Split(" ");
            int wordsCount = words.Length;
            foreach (string word in words)
            {
                if (word.BeginsCapitalized()) wordsCount--;
            }
            if(wordsCount == 0) return true;
            return false;
        }
    }
}
