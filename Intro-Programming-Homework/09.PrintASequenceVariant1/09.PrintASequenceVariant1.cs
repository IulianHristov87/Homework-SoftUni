using System;

namespace PrintASequence
{
    class PrintASequence
    {
        static void Main()
        {
            for (int i = 2; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(i * (-1) + ", ");
                }

            }
        }
    }
}
