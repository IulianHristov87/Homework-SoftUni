using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FirstBit
{
    class FirstBit
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long nShiftedR = n >> n - 1 ;

            Console.WriteLine(nShiftedR);

            long bitAtPosition1 = nShiftedR & 1;

            Console.WriteLine(bitAtPosition1);

        }
    }
}
