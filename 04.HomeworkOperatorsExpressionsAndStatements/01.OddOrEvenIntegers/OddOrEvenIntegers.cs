using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Please enter number");
            int number = int.Parse(Console.ReadLine());
            bool oddOrEven = false;
            if (number % 2 != 0)
            {
                oddOrEven = true;
            }
            Console.WriteLine();
            Console.WriteLine("Number is odd: " + oddOrEven);
        }
    }
}
