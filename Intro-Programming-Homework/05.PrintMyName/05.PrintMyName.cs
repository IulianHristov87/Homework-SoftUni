using System;

namespace PrintMyName
{
    class PrintMyName
    {
        static void Main()
        {
            Console.WriteLine("What is name that you want to print");
            string name = Console.ReadLine();
            Console.WriteLine("My name is {0}", name);
        }
    }
}
