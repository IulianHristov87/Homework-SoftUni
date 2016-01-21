using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MatrixOfPalindromes
{
    class matrixOfPanidromes
    {
        static void Main()
        {
            Console.WriteLine("Please enter r");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter c");
            int c = int.Parse(Console.ReadLine());
            string[,] matrix = new string[r, c];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char firstLetter = 'a';
                    char secondLetter = (char)(firstLetter + col);
                    if (row > 0 && col == 0)
                    {
                     firstLetter = (char)(97+row);
                     secondLetter = (char)(firstLetter + col);
                    }
                    if (row > 0 && col > 0)
                     {
                        firstLetter = (char)(97 + row);
                        secondLetter = (char)(firstLetter + col);
                    }
                     string result = firstLetter+""+secondLetter +""+firstLetter+" ";
                     matrix[row, col] = result;
                     
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
                    