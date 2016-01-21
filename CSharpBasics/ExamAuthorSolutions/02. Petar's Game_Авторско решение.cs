using System;
using System.Numerics;

public class PetarsGame
{
    public static void Main()
    {
        ulong startNumber = ulong.Parse(Console.ReadLine());
        ulong endNumber = ulong.Parse(Console.ReadLine());
        string replacement = Console.ReadLine();

        BigInteger sum = 0;

        for (ulong currentNumber = startNumber; currentNumber < endNumber; currentNumber++)
        {
            if (currentNumber % 5 == 0)
            {
                sum += currentNumber;
            }
            else
            {
                sum += currentNumber % 5;
            }
        }

        string sumAsString = sum.ToString();
        string digitToReplace;

        if (sum % 2 == 0)
        {
            digitToReplace = sumAsString[0].ToString();
        }
        else
        {
            digitToReplace = sumAsString[sumAsString.Length - 1].ToString();
        }

        sumAsString = sumAsString.Replace(digitToReplace, replacement);

        Console.WriteLine(sumAsString);
    }
}