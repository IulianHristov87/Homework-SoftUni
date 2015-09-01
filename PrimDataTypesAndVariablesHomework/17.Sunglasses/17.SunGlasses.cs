using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Sunglasses
{
    class sunglasses
    {
        static void Main()
        {
            int N = Int32.Parse(Console.ReadLine());
            int width = N * 2;

            Console.Write(new string('*', width));
            Console.Write(new string(' ', N));
            Console.WriteLine(new string('*', width));

            for (int i = 1; i < N - 1; i++)
            {
                int lenses = (N * 2) - 2;
                
                Console.Write("*");
                Console.Write(new string('/', lenses));
                Console.Write("*");
                if (i == N / 2)
                {
                    Console.Write(new string('|', N));
                }
                else
                {
                    Console.Write(new string(' ', N));
                }
                Console.Write("*");            
                Console.Write(new string('/', lenses));
                Console.WriteLine("*");

            }
            Console.Write(new string('*', width));
            Console.Write(new string(' ', N));
            Console.WriteLine(new string('*', width));

            
        }
    }
}
