using System;

namespace _15.AgeAfter10Years
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your birthday");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int age = today.Year - birthday.Year;
        if ((birthday.Month <= today.Month && birthday.Day <= today.Day) ^ (birthday.Month < today.Month && birthday.Day > today.Day))
        {
            Console.WriteLine("You are {0} years old.", age);
            Console.WriteLine("After 10 years you will be {0} years old", age + 10);
        }
        else
        {
            Console.WriteLine("You are {0} years old.", age - 1);
            Console.WriteLine("After 10 years you will be {0} years old", age + 9);
        }
        
    }
        }
    }

