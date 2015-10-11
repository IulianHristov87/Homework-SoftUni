using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DailyCalorieIntake
{
    class Program
    {
        static void Main()
        {
            int W = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            int A = int.Parse(Console.ReadLine());
            string G = Console.ReadLine();
            int E = int.Parse(Console.ReadLine());
            double DCI = 0;
            double BMR = 0;
            double weightInKg = (W / 2.2);
            double heightInCm = (2.54 * H);

            if (G == "m")
            {
                BMR = ((66.5 + (13.75 * weightInKg)) + ((5.003 * heightInCm) - (6.755 * A)));
                
            }
            else
            {
                BMR = ((655 + (9.563 * weightInKg)) + ((1.850 * heightInCm) - (4.676 * A)));
            }
            if (E <= 0)
            {
                DCI = Math.Floor(BMR * 1.2);
            }
            else if(E <= 3)
            {
                DCI = Math.Floor(BMR * 1.375);
            }
            else if(E <= 6)
            {
                DCI = Math.Floor(BMR * 1.55);
            }
            else if(E<=9)
            {
                DCI = Math.Floor(BMR * 1.725);
            }
            else if(E>9)
            {
                 DCI = Math.Floor(BMR * 1.9);
            } 
            Console.WriteLine(DCI);

        }
    }
}
