using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SortingNumbers
{
    class sortingNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please enter n");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine("Please enter {0} numbers, after every one press enter", n);

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine();

            for (int x = 0; x < numbers.Length; x++)
            {
                Console.WriteLine(numbers[x]);
            }
            
        }
    }
}
