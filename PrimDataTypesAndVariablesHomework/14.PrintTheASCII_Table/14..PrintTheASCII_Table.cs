using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintTheASCII_Table
{
    class printTheASCII
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < 256; i++)
            {
                char symbolFromASCII = (char)i;
                Console.WriteLine("Decimal code {0} is this symbol {1} from ASCII table", i, symbolFromASCII);
            }
        }
    }
}
