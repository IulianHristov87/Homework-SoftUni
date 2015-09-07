using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07.SumOfFiveNumbers
{
    class sumOfFiveNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter numbers");
            string userInput = Console.ReadLine();
            string[] numbers = userInput.Split(' ');
            double sum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += double.Parse(numbers[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
