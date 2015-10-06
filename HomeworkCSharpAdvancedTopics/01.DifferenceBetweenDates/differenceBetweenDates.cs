using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DifferenceBetweenDates
{
    class differenceBetweenDates
    {
        static void Main()
        {
            Console.WriteLine("Please enter first date in format dd.MM.yyyy");
            DateTime firstDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Please enter second date in format dd.MM.yyyy");
            DateTime secondDate = Convert.ToDateTime(Console.ReadLine());

            double difference = (secondDate - firstDate).TotalDays;
            Console.WriteLine("Difference between this two dates in days is: {0}", difference);
        }
    }
}
