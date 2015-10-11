using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number");
            int Numb = Int32.Parse(Console.ReadLine());

            double SquareRoot = Math.Sqrt(Numb);
            Console.WriteLine("Square root is " + SquareRoot);
        }
    }
}
