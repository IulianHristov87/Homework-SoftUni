using System;

class StripedTowel
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int height = (int)(width*1.5);

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if ((row + col) % 3 == 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}