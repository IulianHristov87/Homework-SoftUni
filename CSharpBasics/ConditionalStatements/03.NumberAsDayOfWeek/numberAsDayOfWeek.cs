using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.NumberAsDayOfWeek
{
    class numberAsDayOfWeek
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter number a");
            double n = double.Parse(Console.ReadLine());
            int nInt = (int)n;

            switch (nInt)
            {
                case 1: 
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("not valid");
                    break;
            }
        }
    }
}
