using System;

namespace _07.QuotesInStrings
{
    class quotesInStrings
    {
        static void Main()
        {
            string one = "The \"use\" of quotations causes difficulties.";
            string two = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("{0}{1}{2}", one, Environment.NewLine, two);
        }
    }
}
