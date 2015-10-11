using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace _05.FormattingNumbers
{
    class formatingNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Please enter number a(int, between 0 ad 500)");
            int a = int.Parse(Console.ReadLine());
            if (0 > a || a > 500)
            {
                Console.WriteLine("Please enter number a between 0 and 500");
            }
            else
            {
                Console.WriteLine("Please enter number b(float-point)");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter number c(float-point)");
                double c = double.Parse(Console.ReadLine());

                char aTxt = 'a';
                char bTxt = 'b';
                char cTxt = 'c';
                string resultTxt = "result";
                string aBin = Convert.ToString(a, 2); // convert number "a" into binary

                if (aBin.Length < 10)
                {
                    int zero = 10 - aBin.Length; // Number of zeros to padding binary number "a"

                    string zeros = new string('0', zero); // creating string with required amount zeros
                    string aBinFormated = zeros + aBin; // concatenate strings 

                    Console.WriteLine("|{0, -10}|{1, -10}|{2, -10}|{3, -43}|", aTxt, bTxt, cTxt, resultTxt);
                    Console.WriteLine("|{0, -10}|{1, -10}|{2, -10}|{0, -10:X}|{3, 10}|{1, 10:F2}|{2, -10:F3}|", a, b, c, aBinFormated); 
                }
                else
                {
                    Console.WriteLine("|{0, -10}|{1, -10}|{2, -10}|{3, -43}|", aTxt, bTxt, cTxt, resultTxt);
                    Console.WriteLine("|{0, -10}|{1, -10}|{2, -10}|{0, -10:X}|{3, 10}|{1, 10:F2}|{2, -10:F3}|", a, b, c, aBin); 
                }
   
            }
        }
    }
}
