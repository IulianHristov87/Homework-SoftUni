using System;

class TheFootballStatistician
{
    private static void Main()
    {
        decimal moneyEuro = decimal.Parse(Console.ReadLine());

        string inputLine = Console.ReadLine();
        string[] teams = { "Arsenal", "Chelsea", "Everton","Liverpool",
            "ManchesterCity", "ManchesterUnited",  "Southampton", "Tottenham" };
        int[] point = new int[8];

        int counter = 0;

        while (inputLine != "End of the league.")
        {
            counter++;
            string[] info = inputLine.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            string homeTeam = info[0];
            string awayTeam = info[2];
            string result = info[1];
            int index = 0;

            
            switch (result)
            {
                case "1":
                    index = Array.IndexOf(teams, homeTeam);
                    point[index] += 3;
                    break;
                case "2":
                    index = Array.IndexOf(teams, awayTeam);
                    point[index] += 3;
                    break;
                case "X":
                    index = Array.IndexOf(teams, homeTeam);
                    point[index] += 1;
                    index = Array.IndexOf(teams, awayTeam);
                    point[index] += 1;
                    break;
            }

            inputLine = Console.ReadLine();
        }
        decimal moneyLv = 1.94m * moneyEuro * counter;
        Console.WriteLine("{0:F2}lv.", moneyLv);
        Console.WriteLine("Arsenal - {0} points.", point[0]);
        Console.WriteLine("Chelsea - {0} points.", point[1]);
        Console.WriteLine("Everton - {0} points.", point[2]);
        Console.WriteLine("Liverpool - {0} points.", point[3]);
        Console.WriteLine("Manchester City - {0} points.", point[4]);
        Console.WriteLine("Manchester United - {0} points.", point[5]);
        Console.WriteLine("Southampton - {0} points.", point[6]);
        Console.WriteLine("Tottenham - {0} points.", point[7]);
    }
}

