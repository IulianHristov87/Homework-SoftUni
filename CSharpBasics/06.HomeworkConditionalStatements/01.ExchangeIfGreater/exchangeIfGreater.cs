using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01.ExchangeIfGreater
{
    class exchangeIfGreater
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter number a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number b");
            double b = double.Parse(Console.ReadLine());
            double c;
            if (a < b)
            {
                Console.WriteLine("{0} {1}", a, b);
            }
            else if (b < a)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("{0} {1}", a, b);
            }
            else if (a == b)
            {
                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}
