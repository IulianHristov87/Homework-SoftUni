using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01.SumOfThreeNumbers
{
    class sumOfThreeNumbers
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

            double sum = a + b + c;
            Console.WriteLine("Sum of a,b and c is: {0}", sum);
        }
    }
}
