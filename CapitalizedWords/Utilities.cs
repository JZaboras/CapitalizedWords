using System;
using System.Collections.Generic;
using System.Text;

namespace CapitalizedWords
{
    public static class Utilities
    {
        public static bool BeginsCapitalized(this string str)
        {
            string firstLetter = str.Trim().Substring(0, 1);
            if (firstLetter == firstLetter.ToUpper()) return true;
            return false;
        }

        public static bool IsCapitalizedSentence(this string str)
        {
            string[] words = str.Trim().Split(" ");
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
