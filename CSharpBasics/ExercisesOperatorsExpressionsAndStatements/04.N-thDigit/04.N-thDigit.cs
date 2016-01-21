using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04.N_thDigit
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int nDigit = (number / (int)(Math.Pow(10, n - 1))) % 10;
           
                if (nDigit < 1)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine(nDigit);
                }
        }
    }
}
