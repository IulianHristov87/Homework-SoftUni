using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunlight
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int rows = 3 * N;
            int cols = 3 * N;
            int leftRay = 0;
            int rightRay = cols - 1;
            //Upper
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col <cols; col++)
                {
                    if (cols / 2 == col)
                    {
                        Console.Write("*");
                    }
                    else if(row!=0 && (col == leftRay || col == rightRay))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    leftRay++;
                    rightRay--;
                    Console.WriteLine();
                }
            }
            //Middle part

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (cols / 2 == col || N / 2 == row)
                    {
                        Console.Write("*");
                    }
                    else if (col >= N && col < cols - N )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }
            }
            leftRay--;
            rightRay++;
            //Down
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (cols / 2 == col)
                    {
                        Console.Write("*");
                    }
                    else if ((row != N-1) && (col == leftRay || col == rightRay))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    leftRay--;
                    rightRay++;
                    Console.WriteLine();
                }
            }

        }
    }
}
