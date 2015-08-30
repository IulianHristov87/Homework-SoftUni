using System;

namespace _09.ExchangeVariableValues
{
    class exchangeVariableValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c;

            Console.WriteLine("a = {0} and b= {1}", a, b);
            if (b > a)
            {
                c = b;
                b = a;
                a = c;
                Console.WriteLine("After exchange (if b > a) a = {0} and b = {1}", a, b);
            }
            else
            {
                Console.WriteLine("a = {0} and b = {1}", a, b);
            }
        }
    }
}
