using System;

public class BookProblem
{
    public static void Main()
    {
        const int DaysInMonth = 30;
        const int MonthsInYear = 12;

        int bookPages = int.Parse(Console.ReadLine());
        int campingDays = int.Parse(Console.ReadLine());
        int pagesReadInNormalDay = int.Parse(Console.ReadLine());

        if (campingDays == 30 || pagesReadInNormalDay == 0)
        {
            Console.WriteLine("never");
            return;
        }

        int normalDaysInMonth = DaysInMonth - campingDays;
        int pagesReadPerMonth = pagesReadInNormalDay * normalDaysInMonth;

        int totalMonthNeeded = (int)Math.Ceiling((double)bookPages / pagesReadPerMonth);

        int yearsNeeded = totalMonthNeeded / MonthsInYear;
        int monthsNeeded = totalMonthNeeded % MonthsInYear;

        Console.WriteLine("{0} years {1} months", yearsNeeded, monthsNeeded);
    }
}