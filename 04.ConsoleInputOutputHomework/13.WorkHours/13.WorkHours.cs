using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12.WorkHours
{
    class workHours
    {
        static void Main()
        {
            
            int h = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double bikingTime = (double)(d * 0.1);
            double workDays = d - bikingTime;
            double workHours = workDays * 12;
            double efficientWorkHours = workHours * p / 100;

            int complete = (int)efficientWorkHours - h;

            if (complete >= 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(complete);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine(complete);
            }
        }
    }
}