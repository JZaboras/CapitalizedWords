using System;

namespace CapitalizedWords
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                var stringCheker = new StringCheker();
                stringCheker.InputString = args[0];
                stringCheker.Check();
            }
            else
            {
                Console.WriteLine("No arguments was provided!! Usage>:CapitalizedWords.exe <input string>");
            }
            Console.ReadKey();
        }
    }
}
