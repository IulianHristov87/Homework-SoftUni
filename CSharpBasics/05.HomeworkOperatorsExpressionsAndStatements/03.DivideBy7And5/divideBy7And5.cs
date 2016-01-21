using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DivideBy7And5
{
    class divideBy7And5
    {
        static void Main()
        {
            Console.WriteLine("Please enter your weight");
            int number = int.Parse(Console.ReadLine());
            bool divideBy7And5 = false;
            if (number % 7 == 0 && number % 5 == 0)
            {
                divideBy7And5 = true;
            }
            Console.WriteLine("{0} is divide by 7 and 5 without remainder: " + divideBy7And5 , number);
        }
    }
}
