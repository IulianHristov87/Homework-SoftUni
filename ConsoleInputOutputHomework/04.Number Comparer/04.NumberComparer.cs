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
            string greaterTxt = "greater";
            char aTxt = 'a';
            char bTxt = 'b';

            if (a > b)
            {
                double greater = a;
                Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}|", aTxt, bTxt, greaterTxt);
                Console.WriteLine("|{0,-10}|{1,-10:F2}|{2,-10:F2}|", a, b, greater);
            }
            else if (b > a)
            {
                double greater = b;
                Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}|", aTxt, bTxt, greaterTxt);
                Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}|", a, b, greater);
            }
            else
            {
                Console.WriteLine("Numbers are equal");
            }
        }
    }
}
