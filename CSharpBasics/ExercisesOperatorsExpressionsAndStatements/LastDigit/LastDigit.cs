using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LastDigit
{
    class LastDigit
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            int n = int.Parse(Console.ReadLine());
            int lastDigit = n % 10;
            
            Console.WriteLine(lastDigit);
            
        }
    }
}
