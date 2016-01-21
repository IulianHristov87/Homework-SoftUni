using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.bonusScore
{
    class bonusScore
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter number a");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine(a * 10);
                    break;
                case 2:
                    Console.WriteLine(a * 10);
                    break;
                case 3:
                    Console.WriteLine(a * 10);
                    break;
                case 4:
                    Console.WriteLine(a * 100);
                    break;
                case 5:
                    Console.WriteLine(a * 100);
                    break;
                case 6:
                    Console.WriteLine(a * 100);
                    break;
                case 7:
                    Console.WriteLine(a * 1000);
                    break;
                case 8:
                    Console.WriteLine(a * 1000);
                    break;
                case 9:
                    Console.WriteLine(a * 1000);
                    break;
                default:
                    Console.WriteLine("invalid score");
                    break;
            }
        }
    }
}
