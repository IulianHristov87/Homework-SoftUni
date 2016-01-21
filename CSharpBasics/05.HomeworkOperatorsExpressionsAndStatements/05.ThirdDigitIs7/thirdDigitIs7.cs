using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigitIs7
{
    class thirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("Please enter number");
            int number = int.Parse(Console.ReadLine());
            bool thirdDigitIs7 = false;

            double thirdDigit = (number / Math.Pow(10, 2)) % 10;
            int thirdDigitInt = (int)thirdDigit;
            if (thirdDigitInt == 7)
            {
                thirdDigitIs7 = true;
            }
            Console.WriteLine(thirdDigitIs7);
        }
    }
}
