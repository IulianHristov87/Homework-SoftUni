using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter first number");
            int firstNumb = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int secondNumb = int.Parse(Console.ReadLine());
            int count = 0;
            List<long> numbersDividable = new List<long>();

            for (int i = firstNumb; i <= secondNumb; i++)
            {
                if (i % 5 == 0)
                {
                    count += 1;
                    numbersDividable.Add(i);

                }
                
            }
            Console.WriteLine(count);
            if (count != 0)
            {
                Console.Write("Numbers dividable to 5 with reminder 0 are: ");

                for (int x = 0; x < count; x++)
                {
                    Console.Write(numbersDividable[x] + " ");
                }
            }
            else
            {
                Console.WriteLine("There isnt numbers dividable by 5 with reminder 0");
            }
            
            
        }
    }
}
