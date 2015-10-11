using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04.Number_Comparer
{
    class numberComparer
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter number a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Biggest number is: " + Math.Max(a, b));
        }
    }
}
