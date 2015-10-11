using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter your weight");
            double weight = double.Parse(Console.ReadLine());

            double weightOnTheMoon = weight * 0.17;

            Console.WriteLine("Your weight on the moon will be: {0}", weightOnTheMoon);

        }
    }
}
