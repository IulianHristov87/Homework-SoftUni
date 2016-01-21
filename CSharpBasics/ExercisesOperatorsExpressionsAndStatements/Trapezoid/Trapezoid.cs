using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Trapezoid
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = ((a + b) / 2.00)*h;
            Console.WriteLine(area);
        }
    }
}
