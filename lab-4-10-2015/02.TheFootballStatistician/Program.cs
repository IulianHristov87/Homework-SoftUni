using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.TheFootballStatistician
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            float payment = float.Parse(Console.ReadLine());
            
            int count = 0;
            int arsenalPoints = 0;
            int chelseaPoints = 0;
            int manCityPoints = 0;
            int manUnitedPoints = 0;
            int liverpoolPoints = 0;
            int evertonPoints = 0;
            int southamptonPoints = 0;
            int tottenhamPoints = 0;
            bool nextInput = true;

            while(nextInput)
            {
                string matchInput = Console.ReadLine();
                count++;
                string[] matchInfo = matchInput.Split(' ');
                string homeTeam = matchInfo[0];
                string result = matchInfo[1];
                string awayTeam = matchInfo[2];
                
                if (matchInput == "End of the league.")
                {
                    count--;
                    float paymentInLv = (float)(payment * 1.94);
                    float finalPayment = paymentInLv * count;
                    Console.WriteLine("{0:F2}lv.", finalPayment);
                    Console.WriteLine("Arsenal - {0} points.", arsenalPoints);
                    Console.WriteLine("Chelsea - {0} points.", chelseaPoints);
                    Console.WriteLine("Everton - {0} points.", evertonPoints);
                    Console.WriteLine("Liverpool - {0} points.", liverpoolPoints);
                    Console.WriteLine("Manchester City - {0} points.", manCityPoints);
                    Console.WriteLine("Manchester United - {0} points.", manUnitedPoints);
                    Console.WriteLine("Southampton - {0} points.", southamptonPoints);
                    Console.WriteLine("Tottenham - {0} points.", tottenhamPoints);
                    nextInput = false;
                }
                else
                {
                    switch (homeTeam)
                    {
                        case "Arsenal":
                            if (result == "1")
                            {
                                arsenalPoints += 3;
                            }
                            else if (result == "X")
                            {
                                arsenalPoints += 1;
                            }
                            break;
                        case "Chelsea":
                            if (result == "1")
                            {
                                chelseaPoints += 3;
                            }
                            else if (result == "X")
                            {
                                chelseaPoints += 1;
                            }
                            break;
                        case "ManchesterCity":
                            if (result == "1")
                            {
                                manCityPoints += 3;
                            }
                            else if (result == "X")
                            {
                                manCityPoints += 1;
                            }
                            break;
                        case "ManchesterUnited":
                            if (result == "1")
                            {
                                manUnitedPoints += 3;
                            }
                            else if (result == "X")
                            {
                                manUnitedPoints += 1;
                            }
                            break;
                        case "Liverpool":
                            if (result == "1")
                            {
                                liverpoolPoints += 3;
                            }
                            else if (result == "X")
                            {
                                liverpoolPoints += 1;
                            }
                            break;
                        case "Everton":
                            if (result == "1")
                            {
                                evertonPoints += 3;
                            }
                            else if (result == "X")
                            {
                                evertonPoints += 1;
                            }
                            break;
                        case "Southampton":
                            if (result == "1")
                            {
                                southamptonPoints += 3;
                            }
                            else if (result == "X")
                            {
                                southamptonPoints += 1;
                            }
                            break;
                        case "Tottenham":
                            if (result == "1")
                            {
                                manCityPoints += 3;
                            }
                            else if (result == "X")
                            {
                                manCityPoints += 1;
                            }
                            break;

                    }
                    switch (awayTeam)
                    {
                        case "Arsenal":
                            if (result == "2")
                            {
                                arsenalPoints += 3;
                            }
                            else if (result == "X")
                            {
                                arsenalPoints += 1;
                            }
                            break;
                        case "Chelsea":
                            if (result == "2")
                            {
                                chelseaPoints += 3;
                            }
                            else if (result == "X")
                            {
                                chelseaPoints += 1;
                            }
                            break;
                        case "ManchesterCity":
                            if (result == "2")
                            {
                                manCityPoints += 3;
                            }
                            else if (result == "X")
                            {
                                manCityPoints += 1;
                            }
                            break;
                        case "ManchesterUnited":
                            if (result == "2")
                            {
                                manUnitedPoints += 3;
                            }
                            else if (result == "X")
                            {
                                manUnitedPoints += 1;
                            }
                            break;
                        case "Liverpool":
                            if (result == "2")
                            {
                                liverpoolPoints += 3;
                            }
                            else if (result == "X")
                            {
                                liverpoolPoints += 1;
                            }
                            break;
                        case "Everton":
                            if (result == "2")
                            {
                                evertonPoints += 3;
                            }
                            else if (result == "X")
                            {
                                evertonPoints += 1;
                            }
                            break;
                        case "Southampton":
                            if (result == "2")
                            {
                                southamptonPoints += 3;
                            }
                            else if (result == "X")
                            {
                                southamptonPoints += 1;
                            }
                            break;
                        case "Tottenham":
                            if (result == "2")
                            {
                                tottenhamPoints += 3;
                            }
                            else if (result == "X")
                            {
                                tottenhamPoints += 1;
                            }
                            break;

                    }
                }
            }     
    }
  }
}
