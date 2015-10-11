using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.PointInCircle
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter circle point x");
            double circleX = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter circle point y");
            double circleY = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter circle radius");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter point x");
            double pointX = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter point y");
            double pointY = double.Parse(Console.ReadLine());
            bool inCircle = false;

            if ((((pointX - circleX) * (pointX - circleX)) + ((pointY - circleY) * (pointY - circleY))) <= (radius * radius))
            {
                inCircle = true;
            }
            Console.WriteLine("Point({0} , {1}) is in circle: {2}", pointX, pointY, inCircle);
        }
    }
}
