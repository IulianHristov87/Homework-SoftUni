using System;

namespace PrintASequence
{
    class PrintASequence
    {
        static void Main()
        {
            Console.WriteLine("Please enter first number from sequence");
             string a =  Console.ReadLine();
             int b = Int32.Parse(a);
             Console.WriteLine("Please enter a number for end of the sequence");
             string c = Console.ReadLine();
            int d = Int32.Parse(c);
            
             for (int i = b; i < d; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(i * (-1)+ ", ");
                }
                
            }
        }
    }
}
