using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class fibonacciNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            Console.WriteLine("Please enter number n");
            int n = int.Parse(Console.ReadLine());

            List<long> FibonacciNumbers = new List<long>();

            FibonacciNumbers.Add  (0);
            FibonacciNumbers.Add  (1);
            FibonacciNumbers.Add  (1);

            for (int x = 3; x < n; x++) // Generate Fibonacci numbers
            {
                FibonacciNumbers.Add(FibonacciNumbers[x - 1] + FibonacciNumbers[x - 2]);
               
            }

            Console.Write(FibonacciNumbers[0]); // Print first number

            for (int y = 1; y < n; y++) // Print all other number to n
            {
                Console.Write(" "+FibonacciNumbers[y]);
            }
            Console.WriteLine();
        }
    }
}
