using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09.SumOfNNumbers
{
    class sumOfNNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            Console.WriteLine("Please enter number n");
            int n = int.Parse(Console.ReadLine());

            List<double> numbers = new List<double>();

            for (int x = 0; x < n; x++)
            {
                numbers.Add(double.Parse(Console.ReadLine()));
            }

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}

