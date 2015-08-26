using System;

namespace PrintFullName
{
    class PrintFullName
    {
        static void Main()
        {
            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
