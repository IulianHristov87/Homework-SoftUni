using System;

class DailyCalorieIntake
{
    static void Main()
    {
        double w = double.Parse(Console.ReadLine())/2.2;

        double h = double.Parse(Console.ReadLine()) * 2.54;

        int age = int.Parse(Console.ReadLine());

        string gender = Console.ReadLine();

        int count = int.Parse(Console.ReadLine());
        double bmr = 0;
        if (gender == "m")
        {
            bmr = 66.5 + (13.75*w) + (5.003*h) - (6.755*age);
        }
        else
        {
            bmr = 655 + (9.563*w) + (1.850*h) - (4.676*age);
        }
        double result = 0;

        if (count <= 0)
        {
            result = bmr*1.2;
        }
        else if(count > 0 && count < 4)
        {
            result = bmr * 1.375;
        }
        else if (count >= 4 && count <= 6)
        {
            result = bmr * 1.55;
        }
        else if (count >= 7 && count <= 9)
        {
            result = bmr * 1.725;
        }
        else
        {
            result = bmr*1.9;
        }
        Console.WriteLine(Math.Floor(result));
    }
}
