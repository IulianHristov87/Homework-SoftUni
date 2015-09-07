using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NewHouse
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int dashes = n - 1;
            int asterixs = n - dashes;
            Console.Write(new string('-', dashes / 2));
            Console.Write(new string('*', asterixs));
            Console.WriteLine(new string('-', dashes / 2));

            for (int i = 2; i < n ; i+=2)
            {
                int dash = n - i - 1;
                int asterix = n - dash;
                Console.Write(new string('-', dash/2));
                Console.Write(new string('*', asterix));
                Console.WriteLine(new string('-', dash/2));
            }
            for (int z = 0; z < n; z++)
            {
                int asterixMid = n - 2;

                Console.Write("|");
                Console.Write(new string('*', asterixMid));
                Console.WriteLine("|");
            }
        }
    }
}
