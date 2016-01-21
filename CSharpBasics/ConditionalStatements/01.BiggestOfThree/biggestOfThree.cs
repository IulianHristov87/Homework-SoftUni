using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01.BiggestOfThree
{
    class biggestOfThree
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter number a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number c");
            double c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Biggest number is: {0}", a);
                }
                else if (a < c)
                {
                    Console.WriteLine("Biggest number is: {0}", c);
                }
            }
            else if (b > a)
            {
                if (b > c)
                {
                    Console.WriteLine("Biggest number is: {0}", b);
                }
                else if (b < c)
                {
                    Console.WriteLine("Biggest number is: {0}", c);
                }
            }
            else if (c > a)
            {
                if (c > b)
                {
                    Console.WriteLine("Biggest number is: {0}", c);
                }
                else if (c < b)
                {
                    Console.WriteLine("Biggest number is: {0}", b);
                }

            }
            if (a == b)
            {
                if (b == c)
                {
                    Console.WriteLine("Numbers are equal");
                }

            }
        }
    }
}

