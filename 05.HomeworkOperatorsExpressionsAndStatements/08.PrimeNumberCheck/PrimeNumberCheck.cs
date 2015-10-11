using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number to be check");
            int numberForCheck = int.Parse(Console.ReadLine());
            bool primeOrNot = false;
            if (numberForCheck > 100)
            {
                Console.WriteLine("Please enter number less than 100");
            }
            else
            {
                if (numberForCheck == 0 || numberForCheck == 1 || numberForCheck < 0)
                {
                    Console.WriteLine("{0} is prime: {1}", numberForCheck, primeOrNot);
                }
                else if(numberForCheck == 2 || numberForCheck == 3 || numberForCheck == 5 || numberForCheck == 7)
                {
                    primeOrNot = true;
                    Console.WriteLine("{0} is prime: {1}", numberForCheck, primeOrNot);
                }
                else if (numberForCheck % numberForCheck == 0 && numberForCheck % 4 != 0 && numberForCheck % 2 != 0 && numberForCheck % 3 != 0 && numberForCheck % 5 !=0 && numberForCheck % 6 != 0 && numberForCheck %7 != 0 && numberForCheck % 8 != 0 && numberForCheck % 9 != 0)
                {
                    primeOrNot = true;
                    Console.WriteLine("{0} is prime: {1}", numberForCheck, primeOrNot);
                }
                else
                {
                    Console.WriteLine("{0} is prime: {1}", numberForCheck, primeOrNot);
                }
                
            }
            
        }
    }
}
