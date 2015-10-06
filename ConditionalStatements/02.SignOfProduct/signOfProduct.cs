using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.SignOfProduct
{
    class signOfProduct
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

            int product = 0;

            if (a < 0)
            {
                product += 1;
            }
            if (b < 0)
            {
                product += 1;
            }
            if (c < 0)
            {
                product += 1;
            }

            if (product  ==  1)
            {
                Console.WriteLine("Negative");
            }
            else if (product == 3)
            {
                Console.WriteLine("Negative");
            }
            else if (product == 0)
            {
                Console.WriteLine("Positive");
            }
            else if (product == 2)
            {
                Console.WriteLine("Positive");
            }
        }
    }
}
