using System;
using System.Collections;
using System.Collections.Generic;

namespace _16.HalfSum
{
    class halfSum
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int x = 0; x < 2*n; x++)
            {
                numbers.Add(Int32.Parse(Console.ReadLine()));
            }
            int group1 = 0;
            int group2 = 0;
            for (int z = 0; z < 2*n / 2; z++)
            {
                group1 = group1 + numbers[z];
            }
            for (int y = 2*n/2; y < 2*n ; y++)
            {
                group2 = group2 + numbers[y];
            }
            if (group1 == group2)
            {
                Console.WriteLine("Yes, sum=" + group1);
            }
            else
            {
                int diff = Math.Abs(group1 - group2);
                Console.WriteLine("No, diff=" + diff);
            }
        }
    }
}
