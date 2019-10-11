using System;

namespace CapitalizedWords
{
    public class StringCheker : ICapitalized
    {
        public string InputString { get; set; }

        public void Check()
        {
            if (string.IsNullOrEmpty(InputString))
            {
                Console.WriteLine("Given string is empty!!");
                return;
            }
            else
            {
                if (StartsWithCapitalLetter())
                {
                    Console.WriteLine("Given string starts with capital letter.");
                }
                else
                {
                    Console.WriteLine("Given string starts with not capital letter.");
                }
                if (EveryWordStartsWithCapitalLetter())
                {
                    Console.WriteLine("Given sentence has all words capitalized.");
                }
                else
                {
                    Console.WriteLine("Given sentence has not all words capitalized.");
                }
            }
        }

        public bool EveryWordStartsWithCapitalLetter()
        {
            return InputString.IsCapitalizedSentence();
        }

        public bool StartsWithCapitalLetter()
        {
            return InputString.BeginsCapitalized();
        }
    }
}
