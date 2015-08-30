using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.JoroTheFootballPlayer
{
    class JoroTheFootbalPlayer
    {
        static void Main()
        {
            string t = Console.ReadLine(); // The string “t” for leap year or “f” for year that is not leap.
            int p = Int32.Parse(Console.ReadLine()); //The number p – number of holidays in the year (which are not Saturday or Sunday).
            int h = Int32.Parse(Console.ReadLine()); //The number h – number of weekends that Joro spends in his hometown.

            if(t == "t"){
                double hometownPlays = h;
                double weekends = (52 - h) * 2 / 3;
                double holliday = (p / 2);
                int addForLeapYear = 3;
                int howManyPlays = (int)hometownPlays + (int)weekends+ (int)holliday + addForLeapYear; //sum of played games from Joro
                Console.WriteLine(howManyPlays);
            }
            else
            {
                double hometownPlays = h;
                double weekends = (52 - h) * 2 / 3;
                double holliday = (p / 2);
                int howManyPlays = (int)hometownPlays + (int)weekends + (int)holliday; //sum of played games from Joro
                Console.WriteLine(howManyPlays);
            }
        }
    }
}
