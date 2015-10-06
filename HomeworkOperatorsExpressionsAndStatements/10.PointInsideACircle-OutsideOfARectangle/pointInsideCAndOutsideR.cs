using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10.PointInsideACircle_OutsideOfARectangle
{
    class pointInsideCAndOutsideR
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
            Console.WriteLine("Please enter rectangle left");
            double rectangleXL = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter rectangle top");
            double rectangleYL = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter rectangle width");
            double rectangleWidth = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter rectangle height");
            double rectangleHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter point x");
            double pointX = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter point y");
            double pointY = double.Parse(Console.ReadLine());

            double rectangleXR = rectangleXL + rectangleWidth;
            double rectangleYR = rectangleYL - rectangleHeight;

            if((((pointX - circleX) * (pointX - circleX)) + ((pointY - circleY) * (pointY - circleY))) <= (radius * radius) && circleX < rectangleXL || circleX < rectangleXR && circleY > rectangleYL || circleY < rectangleYR)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
