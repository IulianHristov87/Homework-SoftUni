using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.CirclePerimeterAndArea
{
    class circlePerimeterAndArea
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter number r");
            double r = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            char rTxt = 'r';
            string perimeterTxt = "perimeter";
            string areaTxt = "area";

            Console.WriteLine("|{0,-10}|{1,-10}|{2,-10}|", rTxt, perimeterTxt, areaTxt);
            Console.WriteLine("|{0,-10}|{1,-10:F2}|{2,-10:F2}|", r, perimeter, area);
        }
    }
}
