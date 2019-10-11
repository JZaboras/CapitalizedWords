using System;

namespace CapitalizedWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!".BeginsCapitalized());
            Console.WriteLine("noncapitalized".BeginsCapitalized());
            Console.WriteLine("Hello World!".IsCapitalizedSentence());
            Console.WriteLine("My name is Frank".IsCapitalizedSentence());
            Console.ReadKey();
        }
    }
}
