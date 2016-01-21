using System;

public class CompoundInterest
{
    public static void Main()
    {
        decimal priceOfTv = decimal.Parse(Console.ReadLine());
        int bankLoanTerm = int.Parse(Console.ReadLine());
        decimal bankInterestRate = decimal.Parse(Console.ReadLine());
        decimal friendInterest = decimal.Parse(Console.ReadLine());

        decimal bankPrice = CalculateFutureValue(priceOfTv, bankInterestRate, bankLoanTerm);
        decimal friendPrice = CalculateFutureValue(priceOfTv, friendInterest, 1);

        Console.WriteLine(
            "{0:F2} {1}", 
            Math.Min(bankPrice, friendPrice), 
            bankPrice < friendPrice ? "Bank" : "Friend");
    }

    private static decimal CalculateFutureValue(decimal presentValue, decimal interestRate, int term)
    {
        decimal interestBase = 1 + interestRate;
        decimal interestMultiplier = 1;

        for (int i = 0; i < term; i++)
        {
            interestMultiplier *= interestBase;
        }

        decimal futureValue = presentValue * interestMultiplier;

        return futureValue;
    }
}