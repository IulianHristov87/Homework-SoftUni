using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class quadraticEquation
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter number a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number c");
            double c = double.Parse(Console.ReadLine());

            double Discriminant = Math.Pow(b, 2) - (4 * a * c);

            if (Discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(Discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(Discriminant)) / (2 * a);
                Console.WriteLine("The real roots are: x1 = {0:F2} and x2 = {1:F2}", x1,x2);
            }
            else if (Discriminant == 0)
            {
                double x = -(b / (2 * a));
                Console.WriteLine("Discriminant is 0, there is only one real root: x = {0:F2}", x);
            }
            else
            {
                Console.WriteLine("Discriminant is under 0 and there isnt real roots");
            }
        }
    }
}
