using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05.BigAndOdd
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            int n = int.Parse(Console.ReadLine());
            bool result = false;

            if (n > 20 && (n % 2) != 0)
            {
                result = true;
            }


            Console.WriteLine(result);
        }
    }
}
