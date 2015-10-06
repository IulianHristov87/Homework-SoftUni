using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter h");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;
            Console.WriteLine("Area is: {0}", area);
        }
    }
}
