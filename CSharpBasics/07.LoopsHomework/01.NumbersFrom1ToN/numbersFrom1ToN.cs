using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace numbersFrom1ToN
{
    class numbersFrom1ToN
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter number n");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
