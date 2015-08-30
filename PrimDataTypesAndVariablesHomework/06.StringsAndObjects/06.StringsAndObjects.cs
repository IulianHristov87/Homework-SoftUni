using System;

namespace _06.StringsAndObjects
{
    class stringsAndObjects
    {
        static void Main()
        {
            string one = "Hello";
            string two = "World";
            object greetings = one + " " + two;
            string greetingsConcat = (string) greetings;
            Console.WriteLine(greetingsConcat);
        }
    }
}
