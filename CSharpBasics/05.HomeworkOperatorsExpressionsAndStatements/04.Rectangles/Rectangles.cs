using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter width");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter height");
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = (2 * width) + (2 * height);
            Console.WriteLine("Perimeter is: {0}. Area is : {1}", perimeter, area);
        }
    }
}
