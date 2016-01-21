using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06.PureDivisor
{
    class PureDivisor
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool result = false;

            if ((n % 9) == 0 || (n % 11) == 0 || (n % 13) == 0)
            {
                result = true;
            }


            Console.WriteLine(result);
        }
    }
}
